# ⚡ EVChargeFinder

**Find EV charging stations, explore connectors, and manage your charging history.**

EVChargeFinder is a web application built with **ASP.NET Core MVC (.NET 10)** and **SQL Server**. It combines a public charging-station directory and an interactive map with a personal charging-session dashboard for registered users.

The project was developed as part of the **SoftUni ASP.NET Core MVC Fundamentals** learning path. It demonstrates MVC architecture, Entity Framework Core, relational data modeling, application services, input validation, ASP.NET Core Identity, and role-based authorization.

![EVChargeFinder home page artwork](EVChargeFinder/wwwroot/images/ev-home-hero.webp)

> The image above is the background artwork used on the Home page. Station and session data are stored locally in SQL Server; the application is **not** connected to a live charging-network availability API.

## Features

### 🔎 Charging Stations — public access

Visitors can browse stations without creating an account or signing in.

- Explore charging stations on an interactive **Leaflet** map and in a paginated list.
- Search by station name, city, address, or operator.
- Filter by **charging type (AC, DC, AC/DC)**, station status, operator, and connector type.
- See station counts, active-station counts, operator counts, and connector counts.
- View station details, location, operator, status, connector types, charging power, and prices.
- Display the filtered station set on the map, independently of the current list page.

### 🔋 Charging Sessions — signed-in users

Registered users can manage their own charging history.

- **Create, view, edit, and delete** charging-session records.
- Select a station and then a connector from a dependent dropdown.
- Record charging start/end times, consumed energy (kWh), and the applied price per kWh.
- Calculate total charging cost on the server.
- Search sessions by charging-station name and filter by a date range.
- Browse results with pagination.
- View dashboard metrics: **total sessions, total energy, total cost, and average charging duration**.
- Explore **daily energy consumption** and the **five most-used connectors** through dashboard components and charts.

Editing is currently restricted to completed sessions.

### 🔐 Authentication and access control

- Registration, login, logout, and account management with **ASP.NET Core Identity**.
- New accounts receive the **User** role upon successful registration.
- **User** role: access to the user's own charging sessions.
- **Admin** role: access to all charging sessions.
- Ownership checks are applied in the service layer to session read and write operations, not only to visible UI links.
- Charging-station browsing, searching, and details are available anonymously.
- Account deletion removes the related charging-session records through an EF Core / SQL Server **cascade-delete** relationship.

### ✅ Validation and data integrity

Charging-session input is checked with Data Annotations, cross-field validation, and service-level rules. The current rules include:

- End time must be later than start time.
- Charging duration must not exceed **96 hours**.
- The selected station must exist, and the connector must belong to that station.
- Entered energy cannot exceed the theoretical maximum based on connector power and duration.
- The applied price cannot exceed the selected connector's configured price.
- Energy and applied price accept at most **two decimal places** in the create/edit input models.
- Total cost is calculated from energy and price, rounded to two decimal places.

## Technology stack

**Backend**
- C# / **.NET 10**
- **ASP.NET Core MVC** and Razor Views
- **ASP.NET Core Identity** for authentication and roles
- **Entity Framework Core 10**, migrations, and LINQ
- **Microsoft SQL Server**
- Dependency injection and asynchronous service methods

**Frontend**
- HTML, CSS, JavaScript, and **Bootstrap 5**
- **Leaflet 1.9.4** for interactive maps
- **Tom Select 2.4.3** for searchable select controls
- **Chart.js 4.4.8** for charging-session analytics
- **Bootstrap Icons 1.11.3**
- Responsive dark-themed UI

## Solution architecture

The solution is organized into seven projects, with responsibilities separated between presentation, services, data, and shared definitions.

```text
EVChargeFinder.slnx
│
├── EVChargeFinder/                 ASP.NET Core MVC web app
│   ├── Areas/Identity/            Account pages
│   ├── Controllers/               MVC actions and authorization
│   ├── Views/                     Razor views and partial views
│   └── wwwroot/                   CSS, JavaScript, images and libraries
│
├── EVChargeFinder.InputModels/     Input models and request validation
├── EVChargeFinder.ViewModels/      Models used by Razor views
├── EVChargeFinder.Services.Core/   Business logic and service interfaces
├── EVChargeFinder.Data/            DbContext, EF configurations,
│                                   migrations and database seeding
├── EVChargeFinder.Data.DbModels/   Entity models and enumerations
└── EVChargeFinder.GCommon/         Shared constants and validation values
```

**Application flow**

```text
Browser / Razor Views
        │
        ▼
MVC Controllers ───── ASP.NET Core Identity / Authorization
        │
        ▼
Service interfaces and implementations
        │
        ▼
Entity Framework Core / ApplicationDbContext
        │
        ▼
SQL Server
```

Controller actions delegate the main station and session operations to `IChargingStationService` and `IChargingSessionService`. The service layer is responsible for querying, validation, and ownership restrictions.

## Database model

The core domain contains four entities:

- **Operator**: charging-network operator information.
- **ChargingStation**: name, address, city, geographic coordinates, status, source metadata, and operator.
- **Connector**: connector number, type, power, price, status, and parent station.
- **ChargingSession**: selected connector, session times, energy, price, cost, and owning Identity user.

```text
Operator
  └── ChargingStation
        └── Connector
              └── ChargingSession
                    └── IdentityUser (owner)
```

A station belongs to an operator, connectors belong to a station, and each session references a connector. Personal sessions reference an ASP.NET Core Identity user. The `UserId` association is optional in the data model to accommodate existing/seeded records.

## Getting started

### Requirements

- **.NET 10 SDK**
- **SQL Server**, SQL Server Express, or SQL Server LocalDB
- A version of Visual Studio compatible with .NET 10, or another editor with the .NET CLI
- EF Core command-line tools if using the CLI for migrations

### 1. Clone the repository

```bash
git clone https://github.com/Atanas-Valkov/EV-Charge-Finder.git
cd EV-Charge-Finder
```

### 2. Restore and build

```bash
dotnet restore EVChargeFinder.slnx
dotnet build EVChargeFinder.slnx
```

### 3. Configure the database connection

The web project reads the connection string named **`DevConnectionString`** in `Program.cs`.

For a local SQL Server LocalDB installation, configure it with **.NET User Secrets** rather than committing a password:

```bash
dotnet user-secrets set "ConnectionStrings:DevConnectionString" "Server=(localdb)\MSSQLLocalDB;Database=EVChargeFinder;Trusted_Connection=True;TrustServerCertificate=True;" --project EVChargeFinder
```

Adapt the server name and authentication settings for your own SQL Server instance. Do not commit production credentials, personal secrets, or private connection strings.

### 4. Create/update the database

From the repository root:

```bash
dotnet ef database update --project EVChargeFinder.Data --startup-project EVChargeFinder
```

The repository includes EF Core migrations. Its database-seeding configuration populates operators, stations, connectors, and demonstration charging sessions.

**Fresh-installation caveat:** The current development `IdentityRoleSeeder` also expects three pre-existing accounts (`user1@test.test`, `user2@test.test`, and `admin@test.test`) when the application starts in Development. It throws an exception if they do not exist. For a clean installation, this development seeder needs to be made tolerant of missing accounts, or those accounts must be provisioned beforehand. No sample passwords are included in this README. This is a remaining setup issue, not an automatic first-run feature.

### 5. Run the application

```bash
dotnet run --project EVChargeFinder --launch-profile https
```

The checked-in HTTPS launch profile uses **`https://localhost:7174`**. The HTTP profile uses **`http://localhost:5021`**. You can also launch the `EVChargeFinder` startup project from Visual Studio.

If prompted to trust a local HTTPS development certificate, follow the .NET development-certificate setup for your operating system.

## How to explore the application

1. Open **Charging Stations** as a guest to try search, filters, station details, and the map.
2. Register a new account and sign in to access **Charging Sessions**.
3. Create a session by choosing a station and a valid connector, then enter its time range and energy usage.
4. Review the calculated cost, edit or remove a completed record, and inspect the dashboard metrics and charts.
5. Use the account-management pages to review account options and personal-data deletion.

**Permissions:** Guests can browse station data. Regular users can manage their own sessions. Admin access to other users' session data requires an explicitly assigned Admin role; registration does not create an admin account.

## Demo data and project scope

Charging operators, station records, connectors, and demonstration sessions are supplied through the repository's local database seeders. They are intended to demonstrate the application; station/connector status and pricing should **not** be treated as verified live information. The app does not initiate real vehicle charging, reserve a charger, or process payments.

Account confirmation in development can use the standard Identity development confirmation-link flow. **A production email sender is not configured** in this project.

## Verification

The following flows have been exercised during development:

- Registration, login, logout, and User/Admin role behavior.
- Anonymous station navigation, search, and details.
- Charging-session ownership restrictions, including protection against opening another user's session by ID.
- Account deletion and related charging-session cascade deletion.
- Session creation and input validation during manual testing.

These are manual development checks, **not a claim of automated test coverage**.

## Author

Developed by [Atanas Valkov](https://github.com/Atanas-Valkov) as an ASP.NET Core MVC educational project.

Repository: [github.com/Atanas-Valkov/EV-Charge-Finder](https://github.com/Atanas-Valkov/EV-Charge-Finder)
