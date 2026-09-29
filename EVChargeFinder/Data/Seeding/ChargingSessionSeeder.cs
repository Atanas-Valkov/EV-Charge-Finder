namespace EVChargeFinder.Data.Seeding
{
    using System.Globalization;
    using EVChargeFinder.DbModels;
    using Microsoft.EntityFrameworkCore;

    public static class ChargingSessionSeeder
    {
        public static void Seed(ApplicationDbContext context)
        {
            if (context.ChargingSessions.Any())
            {
                return;
            }

            List<Connector> connectors = context.Connectors
                .AsNoTracking()
                .OrderBy(c => c.Id)
                .ToList();

            if (connectors.Count < 778)
            {
                throw new InvalidOperationException("ChargingSessionSeeder requires at least 778 connectors.");
            }

            ChargingSession[] chargingSessions =
            [
                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-01-05T07:03:33.753Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-01-05T08:52:42.753Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 14.14m,
                    AppliedPricePerKWh = connectors[0].PricePerKWh,
                    TotalCost = Math.Round(14.14m * connectors[0].PricePerKWh, 2),
                    ConnectorId = connectors[0].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-01-06T00:55:15.614Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-01-06T01:53:47.614Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 16.25m,
                    AppliedPricePerKWh = connectors[2].PricePerKWh,
                    TotalCost = Math.Round(16.25m * connectors[2].PricePerKWh, 2),
                    ConnectorId = connectors[2].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-01-06T02:22:19.513Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-01-06T04:07:16.513Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 22.32m,
                    AppliedPricePerKWh = connectors[4].PricePerKWh,
                    TotalCost = Math.Round(22.32m * connectors[4].PricePerKWh, 2),
                    ConnectorId = connectors[4].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-01-07T09:46:28.512Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-01-07T10:53:27.512Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 18.54m,
                    AppliedPricePerKWh = connectors[6].PricePerKWh,
                    TotalCost = Math.Round(18.54m * connectors[6].PricePerKWh, 2),
                    ConnectorId = connectors[6].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-01-08T09:56:49.056Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-01-08T11:49:16.056Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 31.83m,
                    AppliedPricePerKWh = connectors[8].PricePerKWh,
                    TotalCost = Math.Round(31.83m * connectors[8].PricePerKWh, 2),
                    ConnectorId = connectors[8].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-01-08T06:26:11.260Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-01-08T08:20:08.260Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 23.81m,
                    AppliedPricePerKWh = connectors[10].PricePerKWh,
                    TotalCost = Math.Round(23.81m * connectors[10].PricePerKWh, 2),
                    ConnectorId = connectors[10].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-01-08T23:09:52.009Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-01-09T01:09:20.009Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 9.66m,
                    AppliedPricePerKWh = connectors[12].PricePerKWh,
                    TotalCost = Math.Round(9.66m * connectors[12].PricePerKWh, 2),
                    ConnectorId = connectors[12].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-01-10T01:48:44.720Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-01-10T04:13:02.720Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 24.84m,
                    AppliedPricePerKWh = connectors[14].PricePerKWh,
                    TotalCost = Math.Round(24.84m * connectors[14].PricePerKWh, 2),
                    ConnectorId = connectors[14].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-01-10T09:11:27.450Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-01-10T10:07:03.450Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 11.29m,
                    AppliedPricePerKWh = connectors[16].PricePerKWh,
                    TotalCost = Math.Round(11.29m * connectors[16].PricePerKWh, 2),
                    ConnectorId = connectors[16].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-01-11T07:05:01.427Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-01-11T09:01:57.427Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 13.20m,
                    AppliedPricePerKWh = connectors[18].PricePerKWh,
                    TotalCost = Math.Round(13.20m * connectors[18].PricePerKWh, 2),
                    ConnectorId = connectors[18].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-01-12T05:59:15.341Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-01-12T08:09:46.341Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 18.19m,
                    AppliedPricePerKWh = connectors[19].PricePerKWh,
                    TotalCost = Math.Round(18.19m * connectors[19].PricePerKWh, 2),
                    ConnectorId = connectors[19].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-01-13T01:55:31.205Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-01-13T03:47:42.205Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 33.41m,
                    AppliedPricePerKWh = connectors[21].PricePerKWh,
                    TotalCost = Math.Round(33.41m * connectors[21].PricePerKWh, 2),
                    ConnectorId = connectors[21].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-01-12T23:57:08.727Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-01-13T01:10:13.727Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 21.76m,
                    AppliedPricePerKWh = connectors[23].PricePerKWh,
                    TotalCost = Math.Round(21.76m * connectors[23].PricePerKWh, 2),
                    ConnectorId = connectors[23].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-01-13T14:34:39.929Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-01-13T15:36:49.929Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 18.36m,
                    AppliedPricePerKWh = connectors[25].PricePerKWh,
                    TotalCost = Math.Round(18.36m * connectors[25].PricePerKWh, 2),
                    ConnectorId = connectors[25].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-01-14T11:05:21.233Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-01-14T12:25:31.233Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 23.83m,
                    AppliedPricePerKWh = connectors[27].PricePerKWh,
                    TotalCost = Math.Round(23.83m * connectors[27].PricePerKWh, 2),
                    ConnectorId = connectors[27].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-01-14T23:00:19.647Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-01-15T00:56:53.647Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 28.92m,
                    AppliedPricePerKWh = connectors[29].PricePerKWh,
                    TotalCost = Math.Round(28.92m * connectors[29].PricePerKWh, 2),
                    ConnectorId = connectors[29].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-01-15T20:55:52.827Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-01-15T23:05:01.827Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 23.04m,
                    AppliedPricePerKWh = connectors[31].PricePerKWh,
                    TotalCost = Math.Round(23.04m * connectors[31].PricePerKWh, 2),
                    ConnectorId = connectors[31].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-01-16T23:26:01.098Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-01-17T01:28:52.098Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 33.57m,
                    AppliedPricePerKWh = connectors[33].PricePerKWh,
                    TotalCost = Math.Round(33.57m * connectors[33].PricePerKWh, 2),
                    ConnectorId = connectors[33].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-01-17T09:12:57.146Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-01-17T11:40:56.146Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 31.07m,
                    AppliedPricePerKWh = connectors[35].PricePerKWh,
                    TotalCost = Math.Round(31.07m * connectors[35].PricePerKWh, 2),
                    ConnectorId = connectors[35].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-01-17T20:56:57.566Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-01-17T22:57:30.566Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 19.67m,
                    AppliedPricePerKWh = connectors[37].PricePerKWh,
                    TotalCost = Math.Round(19.67m * connectors[37].PricePerKWh, 2),
                    ConnectorId = connectors[37].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-01-18T06:17:37.060Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-01-18T07:14:54.060Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 10.19m,
                    AppliedPricePerKWh = connectors[39].PricePerKWh,
                    TotalCost = Math.Round(10.19m * connectors[39].PricePerKWh, 2),
                    ConnectorId = connectors[39].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-01-19T12:37:59.241Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-01-19T14:58:29.241Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 9.49m,
                    AppliedPricePerKWh = connectors[41].PricePerKWh,
                    TotalCost = Math.Round(9.49m * connectors[41].PricePerKWh, 2),
                    ConnectorId = connectors[41].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-01-19T19:46:16.430Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-01-19T21:08:24.430Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 24.41m,
                    AppliedPricePerKWh = connectors[43].PricePerKWh,
                    TotalCost = Math.Round(24.41m * connectors[43].PricePerKWh, 2),
                    ConnectorId = connectors[43].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-01-20T13:55:52.136Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-01-20T16:21:49.136Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 19.72m,
                    AppliedPricePerKWh = connectors[45].PricePerKWh,
                    TotalCost = Math.Round(19.72m * connectors[45].PricePerKWh, 2),
                    ConnectorId = connectors[45].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-01-21T09:11:49.084Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-01-21T10:05:38.084Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 8.44m,
                    AppliedPricePerKWh = connectors[47].PricePerKWh,
                    TotalCost = Math.Round(8.44m * connectors[47].PricePerKWh, 2),
                    ConnectorId = connectors[47].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-01-21T19:12:34.335Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-01-21T21:13:26.335Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 7.99m,
                    AppliedPricePerKWh = connectors[49].PricePerKWh,
                    TotalCost = Math.Round(7.99m * connectors[49].PricePerKWh, 2),
                    ConnectorId = connectors[49].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-01-22T17:22:04.651Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-01-22T19:13:13.651Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 15.73m,
                    AppliedPricePerKWh = connectors[51].PricePerKWh,
                    TotalCost = Math.Round(15.73m * connectors[51].PricePerKWh, 2),
                    ConnectorId = connectors[51].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-01-23T09:20:55.295Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-01-23T10:37:43.295Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 18.03m,
                    AppliedPricePerKWh = connectors[53].PricePerKWh,
                    TotalCost = Math.Round(18.03m * connectors[53].PricePerKWh, 2),
                    ConnectorId = connectors[53].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-01-23T21:11:09.332Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-01-23T23:14:10.332Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 10.50m,
                    AppliedPricePerKWh = connectors[55].PricePerKWh,
                    TotalCost = Math.Round(10.50m * connectors[55].PricePerKWh, 2),
                    ConnectorId = connectors[55].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-01-24T03:03:26.829Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-01-24T04:21:01.829Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 16.12m,
                    AppliedPricePerKWh = connectors[56].PricePerKWh,
                    TotalCost = Math.Round(16.12m * connectors[56].PricePerKWh, 2),
                    ConnectorId = connectors[56].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-01-25T15:14:41.180Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-01-25T16:27:04.180Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 14.30m,
                    AppliedPricePerKWh = connectors[58].PricePerKWh,
                    TotalCost = Math.Round(14.30m * connectors[58].PricePerKWh, 2),
                    ConnectorId = connectors[58].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-01-26T10:02:20.567Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-01-26T12:16:24.567Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 22.27m,
                    AppliedPricePerKWh = connectors[60].PricePerKWh,
                    TotalCost = Math.Round(22.27m * connectors[60].PricePerKWh, 2),
                    ConnectorId = connectors[60].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-01-26T08:20:15.748Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-01-26T09:15:03.748Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 13.57m,
                    AppliedPricePerKWh = connectors[62].PricePerKWh,
                    TotalCost = Math.Round(13.57m * connectors[62].PricePerKWh, 2),
                    ConnectorId = connectors[62].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-01-26T21:25:14.958Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-01-26T23:13:18.958Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 28.79m,
                    AppliedPricePerKWh = connectors[64].PricePerKWh,
                    TotalCost = Math.Round(28.79m * connectors[64].PricePerKWh, 2),
                    ConnectorId = connectors[64].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-01-27T16:17:43.489Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-01-27T17:21:34.489Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 9.82m,
                    AppliedPricePerKWh = connectors[66].PricePerKWh,
                    TotalCost = Math.Round(9.82m * connectors[66].PricePerKWh, 2),
                    ConnectorId = connectors[66].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-01-28T07:03:30.560Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-01-28T08:12:36.560Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 12.00m,
                    AppliedPricePerKWh = connectors[68].PricePerKWh,
                    TotalCost = Math.Round(12.00m * connectors[68].PricePerKWh, 2),
                    ConnectorId = connectors[68].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-01-29T11:42:45.311Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-01-29T13:13:07.311Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 12.46m,
                    AppliedPricePerKWh = connectors[70].PricePerKWh,
                    TotalCost = Math.Round(12.46m * connectors[70].PricePerKWh, 2),
                    ConnectorId = connectors[70].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-01-30T06:37:23.500Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-01-30T07:40:16.500Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 6.81m,
                    AppliedPricePerKWh = connectors[72].PricePerKWh,
                    TotalCost = Math.Round(6.81m * connectors[72].PricePerKWh, 2),
                    ConnectorId = connectors[72].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-01-31T03:10:27.007Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-01-31T04:35:38.007Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 8.05m,
                    AppliedPricePerKWh = connectors[74].PricePerKWh,
                    TotalCost = Math.Round(8.05m * connectors[74].PricePerKWh, 2),
                    ConnectorId = connectors[74].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-01-30T22:01:33.727Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-01-31T00:02:59.727Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 7.16m,
                    AppliedPricePerKWh = connectors[76].PricePerKWh,
                    TotalCost = Math.Round(7.16m * connectors[76].PricePerKWh, 2),
                    ConnectorId = connectors[76].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-01-31T12:49:48.234Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-01-31T14:32:57.234Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 30.64m,
                    AppliedPricePerKWh = connectors[78].PricePerKWh,
                    TotalCost = Math.Round(30.64m * connectors[78].PricePerKWh, 2),
                    ConnectorId = connectors[78].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-02-01T11:48:30.557Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-02-01T13:56:58.557Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 22.13m,
                    AppliedPricePerKWh = connectors[80].PricePerKWh,
                    TotalCost = Math.Round(22.13m * connectors[80].PricePerKWh, 2),
                    ConnectorId = connectors[80].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-02-02T11:27:54.534Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-02-02T12:47:33.534Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 21.43m,
                    AppliedPricePerKWh = connectors[82].PricePerKWh,
                    TotalCost = Math.Round(21.43m * connectors[82].PricePerKWh, 2),
                    ConnectorId = connectors[82].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-02-02T18:03:30.336Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-02-02T19:47:40.336Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 10.27m,
                    AppliedPricePerKWh = connectors[84].PricePerKWh,
                    TotalCost = Math.Round(10.27m * connectors[84].PricePerKWh, 2),
                    ConnectorId = connectors[84].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-02-04T02:06:08.345Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-02-04T03:26:13.345Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 23.90m,
                    AppliedPricePerKWh = connectors[86].PricePerKWh,
                    TotalCost = Math.Round(23.90m * connectors[86].PricePerKWh, 2),
                    ConnectorId = connectors[86].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-02-03T21:26:18.586Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-02-03T22:51:47.586Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 25.30m,
                    AppliedPricePerKWh = connectors[88].PricePerKWh,
                    TotalCost = Math.Round(25.30m * connectors[88].PricePerKWh, 2),
                    ConnectorId = connectors[88].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-02-04T20:27:22.625Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-02-04T22:10:22.625Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 22.07m,
                    AppliedPricePerKWh = connectors[90].PricePerKWh,
                    TotalCost = Math.Round(22.07m * connectors[90].PricePerKWh, 2),
                    ConnectorId = connectors[90].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-02-05T11:27:27.817Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-02-05T13:53:52.817Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 6.42m,
                    AppliedPricePerKWh = connectors[92].PricePerKWh,
                    TotalCost = Math.Round(6.42m * connectors[92].PricePerKWh, 2),
                    ConnectorId = connectors[92].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-02-05T22:59:45.404Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-02-06T00:32:07.404Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 23.14m,
                    AppliedPricePerKWh = connectors[93].PricePerKWh,
                    TotalCost = Math.Round(23.14m * connectors[93].PricePerKWh, 2),
                    ConnectorId = connectors[93].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-02-06T21:28:15.821Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-02-06T22:54:13.821Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 17.09m,
                    AppliedPricePerKWh = connectors[95].PricePerKWh,
                    TotalCost = Math.Round(17.09m * connectors[95].PricePerKWh, 2),
                    ConnectorId = connectors[95].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-02-07T04:26:17.229Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-02-07T06:08:37.229Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 6.89m,
                    AppliedPricePerKWh = connectors[97].PricePerKWh,
                    TotalCost = Math.Round(6.89m * connectors[97].PricePerKWh, 2),
                    ConnectorId = connectors[97].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-02-08T18:43:23.076Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-02-08T19:43:14.076Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 17.59m,
                    AppliedPricePerKWh = connectors[99].PricePerKWh,
                    TotalCost = Math.Round(17.59m * connectors[99].PricePerKWh, 2),
                    ConnectorId = connectors[99].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-02-09T04:45:39.876Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-02-09T06:13:34.876Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 11.47m,
                    AppliedPricePerKWh = connectors[101].PricePerKWh,
                    TotalCost = Math.Round(11.47m * connectors[101].PricePerKWh, 2),
                    ConnectorId = connectors[101].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-02-09T19:31:07.893Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-02-09T20:53:23.893Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 24.31m,
                    AppliedPricePerKWh = connectors[103].PricePerKWh,
                    TotalCost = Math.Round(24.31m * connectors[103].PricePerKWh, 2),
                    ConnectorId = connectors[103].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-02-10T12:28:53.889Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-02-10T13:58:03.889Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 11.06m,
                    AppliedPricePerKWh = connectors[105].PricePerKWh,
                    TotalCost = Math.Round(11.06m * connectors[105].PricePerKWh, 2),
                    ConnectorId = connectors[105].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-02-11T06:56:58.855Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-02-11T09:23:27.855Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 26.69m,
                    AppliedPricePerKWh = connectors[107].PricePerKWh,
                    TotalCost = Math.Round(26.69m * connectors[107].PricePerKWh, 2),
                    ConnectorId = connectors[107].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-02-11T21:05:23.479Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-02-11T22:45:34.479Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 7.67m,
                    AppliedPricePerKWh = connectors[109].PricePerKWh,
                    TotalCost = Math.Round(7.67m * connectors[109].PricePerKWh, 2),
                    ConnectorId = connectors[109].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-02-12T17:56:37.566Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-02-12T20:00:54.566Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 23.73m,
                    AppliedPricePerKWh = connectors[111].PricePerKWh,
                    TotalCost = Math.Round(23.73m * connectors[111].PricePerKWh, 2),
                    ConnectorId = connectors[111].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-02-13T04:42:08.001Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-02-13T06:45:32.001Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 28.78m,
                    AppliedPricePerKWh = connectors[113].PricePerKWh,
                    TotalCost = Math.Round(28.78m * connectors[113].PricePerKWh, 2),
                    ConnectorId = connectors[113].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-02-13T16:19:20.543Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-02-13T18:38:24.543Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 6.85m,
                    AppliedPricePerKWh = connectors[115].PricePerKWh,
                    TotalCost = Math.Round(6.85m * connectors[115].PricePerKWh, 2),
                    ConnectorId = connectors[115].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-02-13T21:01:03.970Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-02-13T23:05:16.970Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 17.68m,
                    AppliedPricePerKWh = connectors[117].PricePerKWh,
                    TotalCost = Math.Round(17.68m * connectors[117].PricePerKWh, 2),
                    ConnectorId = connectors[117].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-02-15T11:12:38.606Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-02-15T13:20:00.606Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 30.25m,
                    AppliedPricePerKWh = connectors[119].PricePerKWh,
                    TotalCost = Math.Round(30.25m * connectors[119].PricePerKWh, 2),
                    ConnectorId = connectors[119].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-02-15T08:59:23.755Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-02-15T10:40:15.755Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 29.74m,
                    AppliedPricePerKWh = connectors[121].PricePerKWh,
                    TotalCost = Math.Round(29.74m * connectors[121].PricePerKWh, 2),
                    ConnectorId = connectors[121].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-02-15T22:35:39.182Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-02-15T23:29:24.182Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 15.31m,
                    AppliedPricePerKWh = connectors[123].PricePerKWh,
                    TotalCost = Math.Round(15.31m * connectors[123].PricePerKWh, 2),
                    ConnectorId = connectors[123].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-02-16T18:33:57.198Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-02-16T20:45:06.198Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 10.31m,
                    AppliedPricePerKWh = connectors[125].PricePerKWh,
                    TotalCost = Math.Round(10.31m * connectors[125].PricePerKWh, 2),
                    ConnectorId = connectors[125].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-02-17T23:59:42.956Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-02-18T02:16:20.956Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 21.01m,
                    AppliedPricePerKWh = connectors[127].PricePerKWh,
                    TotalCost = Math.Round(21.01m * connectors[127].PricePerKWh, 2),
                    ConnectorId = connectors[127].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-02-18T17:18:03.641Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-02-18T19:26:16.641Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 30.95m,
                    AppliedPricePerKWh = connectors[129].PricePerKWh,
                    TotalCost = Math.Round(30.95m * connectors[129].PricePerKWh, 2),
                    ConnectorId = connectors[129].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-02-19T06:55:12.529Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-02-19T08:36:52.529Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 24.32m,
                    AppliedPricePerKWh = connectors[130].PricePerKWh,
                    TotalCost = Math.Round(24.32m * connectors[130].PricePerKWh, 2),
                    ConnectorId = connectors[130].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-02-19T19:44:04.366Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-02-19T21:59:42.366Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 32.91m,
                    AppliedPricePerKWh = connectors[132].PricePerKWh,
                    TotalCost = Math.Round(32.91m * connectors[132].PricePerKWh, 2),
                    ConnectorId = connectors[132].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-02-20T11:01:55.131Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-02-20T12:07:48.131Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 19.42m,
                    AppliedPricePerKWh = connectors[134].PricePerKWh,
                    TotalCost = Math.Round(19.42m * connectors[134].PricePerKWh, 2),
                    ConnectorId = connectors[134].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-02-20T20:52:07.204Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-02-20T22:39:58.204Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 31.95m,
                    AppliedPricePerKWh = connectors[136].PricePerKWh,
                    TotalCost = Math.Round(31.95m * connectors[136].PricePerKWh, 2),
                    ConnectorId = connectors[136].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-02-21T19:56:02.803Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-02-21T22:16:42.803Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 19.78m,
                    AppliedPricePerKWh = connectors[138].PricePerKWh,
                    TotalCost = Math.Round(19.78m * connectors[138].PricePerKWh, 2),
                    ConnectorId = connectors[138].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-02-22T11:23:27.392Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-02-22T13:23:36.392Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 27.70m,
                    AppliedPricePerKWh = connectors[140].PricePerKWh,
                    TotalCost = Math.Round(27.70m * connectors[140].PricePerKWh, 2),
                    ConnectorId = connectors[140].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-02-23T03:14:53.769Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-02-23T05:41:26.769Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 8.07m,
                    AppliedPricePerKWh = connectors[142].PricePerKWh,
                    TotalCost = Math.Round(8.07m * connectors[142].PricePerKWh, 2),
                    ConnectorId = connectors[142].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-02-24T02:03:49.656Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-02-24T03:43:43.656Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 25.35m,
                    AppliedPricePerKWh = connectors[144].PricePerKWh,
                    TotalCost = Math.Round(25.35m * connectors[144].PricePerKWh, 2),
                    ConnectorId = connectors[144].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-02-23T23:43:55.911Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-02-24T02:11:56.911Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 8.95m,
                    AppliedPricePerKWh = connectors[146].PricePerKWh,
                    TotalCost = Math.Round(8.95m * connectors[146].PricePerKWh, 2),
                    ConnectorId = connectors[146].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-02-24T18:18:05.701Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-02-24T20:32:39.701Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 33.32m,
                    AppliedPricePerKWh = connectors[148].PricePerKWh,
                    TotalCost = Math.Round(33.32m * connectors[148].PricePerKWh, 2),
                    ConnectorId = connectors[148].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-02-25T04:50:19.187Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-02-25T06:45:56.187Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 23.55m,
                    AppliedPricePerKWh = connectors[150].PricePerKWh,
                    TotalCost = Math.Round(23.55m * connectors[150].PricePerKWh, 2),
                    ConnectorId = connectors[150].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-02-26T07:03:41.407Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-02-26T08:23:24.407Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 23.48m,
                    AppliedPricePerKWh = connectors[152].PricePerKWh,
                    TotalCost = Math.Round(23.48m * connectors[152].PricePerKWh, 2),
                    ConnectorId = connectors[152].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-02-27T00:19:52.526Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-02-27T01:57:10.526Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 28.99m,
                    AppliedPricePerKWh = connectors[154].PricePerKWh,
                    TotalCost = Math.Round(28.99m * connectors[154].PricePerKWh, 2),
                    ConnectorId = connectors[154].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-02-27T12:33:14.519Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-02-27T13:44:52.519Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 21.18m,
                    AppliedPricePerKWh = connectors[156].PricePerKWh,
                    TotalCost = Math.Round(21.18m * connectors[156].PricePerKWh, 2),
                    ConnectorId = connectors[156].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-02-28T18:50:39.782Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-02-28T20:02:41.782Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 12.41m,
                    AppliedPricePerKWh = connectors[158].PricePerKWh,
                    TotalCost = Math.Round(12.41m * connectors[158].PricePerKWh, 2),
                    ConnectorId = connectors[158].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-02-28T23:27:21.697Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-03-01T01:54:08.697Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 29.02m,
                    AppliedPricePerKWh = connectors[160].PricePerKWh,
                    TotalCost = Math.Round(29.02m * connectors[160].PricePerKWh, 2),
                    ConnectorId = connectors[160].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-03-01T19:53:01.386Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-03-01T21:27:08.386Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 19.66m,
                    AppliedPricePerKWh = connectors[162].PricePerKWh,
                    TotalCost = Math.Round(19.66m * connectors[162].PricePerKWh, 2),
                    ConnectorId = connectors[162].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-03-02T12:01:59.814Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-03-02T13:43:36.814Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 30.05m,
                    AppliedPricePerKWh = connectors[164].PricePerKWh,
                    TotalCost = Math.Round(30.05m * connectors[164].PricePerKWh, 2),
                    ConnectorId = connectors[164].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-03-02T16:23:20.032Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-03-02T18:07:48.032Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 20.57m,
                    AppliedPricePerKWh = connectors[166].PricePerKWh,
                    TotalCost = Math.Round(20.57m * connectors[166].PricePerKWh, 2),
                    ConnectorId = connectors[166].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-03-03T21:53:41.809Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-03-03T23:41:49.809Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 32.15m,
                    AppliedPricePerKWh = connectors[167].PricePerKWh,
                    TotalCost = Math.Round(32.15m * connectors[167].PricePerKWh, 2),
                    ConnectorId = connectors[167].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-03-04T00:50:08.947Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-03-04T02:44:18.947Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 12.05m,
                    AppliedPricePerKWh = connectors[169].PricePerKWh,
                    TotalCost = Math.Round(12.05m * connectors[169].PricePerKWh, 2),
                    ConnectorId = connectors[169].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-03-04T17:16:25.460Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-03-04T19:25:24.460Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 13.75m,
                    AppliedPricePerKWh = connectors[171].PricePerKWh,
                    TotalCost = Math.Round(13.75m * connectors[171].PricePerKWh, 2),
                    ConnectorId = connectors[171].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-03-05T22:34:32.455Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-03-06T00:10:02.455Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 15.93m,
                    AppliedPricePerKWh = connectors[173].PricePerKWh,
                    TotalCost = Math.Round(15.93m * connectors[173].PricePerKWh, 2),
                    ConnectorId = connectors[173].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-03-06T11:39:44.157Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-03-06T14:03:23.157Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 25.51m,
                    AppliedPricePerKWh = connectors[175].PricePerKWh,
                    TotalCost = Math.Round(25.51m * connectors[175].PricePerKWh, 2),
                    ConnectorId = connectors[175].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-03-07T02:11:11.546Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-03-07T03:34:34.546Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 11.21m,
                    AppliedPricePerKWh = connectors[177].PricePerKWh,
                    TotalCost = Math.Round(11.21m * connectors[177].PricePerKWh, 2),
                    ConnectorId = connectors[177].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-03-08T03:53:52.722Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-03-08T05:30:38.722Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 21.31m,
                    AppliedPricePerKWh = connectors[179].PricePerKWh,
                    TotalCost = Math.Round(21.31m * connectors[179].PricePerKWh, 2),
                    ConnectorId = connectors[179].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-03-08T14:19:19.946Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-03-08T16:12:35.946Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 33.70m,
                    AppliedPricePerKWh = connectors[181].PricePerKWh,
                    TotalCost = Math.Round(33.70m * connectors[181].PricePerKWh, 2),
                    ConnectorId = connectors[181].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-03-08T23:27:18.901Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-03-09T00:35:47.901Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 14.62m,
                    AppliedPricePerKWh = connectors[183].PricePerKWh,
                    TotalCost = Math.Round(14.62m * connectors[183].PricePerKWh, 2),
                    ConnectorId = connectors[183].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-03-09T12:41:43.033Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-03-09T14:12:09.033Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 16.83m,
                    AppliedPricePerKWh = connectors[185].PricePerKWh,
                    TotalCost = Math.Round(16.83m * connectors[185].PricePerKWh, 2),
                    ConnectorId = connectors[185].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-03-10T16:10:08.135Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-03-10T17:54:21.135Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 26.96m,
                    AppliedPricePerKWh = connectors[187].PricePerKWh,
                    TotalCost = Math.Round(26.96m * connectors[187].PricePerKWh, 2),
                    ConnectorId = connectors[187].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-03-10T19:03:23.837Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-03-10T21:28:19.837Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 26.67m,
                    AppliedPricePerKWh = connectors[189].PricePerKWh,
                    TotalCost = Math.Round(26.67m * connectors[189].PricePerKWh, 2),
                    ConnectorId = connectors[189].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-03-11T22:26:10.167Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-03-11T23:32:16.167Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 19.77m,
                    AppliedPricePerKWh = connectors[191].PricePerKWh,
                    TotalCost = Math.Round(19.77m * connectors[191].PricePerKWh, 2),
                    ConnectorId = connectors[191].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-03-12T17:26:51.576Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-03-12T19:18:23.576Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 27.14m,
                    AppliedPricePerKWh = connectors[193].PricePerKWh,
                    TotalCost = Math.Round(27.14m * connectors[193].PricePerKWh, 2),
                    ConnectorId = connectors[193].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-03-13T05:21:40.228Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-03-13T07:52:09.228Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 31.73m,
                    AppliedPricePerKWh = connectors[195].PricePerKWh,
                    TotalCost = Math.Round(31.73m * connectors[195].PricePerKWh, 2),
                    ConnectorId = connectors[195].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-03-14T01:23:13.994Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-03-14T03:11:46.994Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 32.25m,
                    AppliedPricePerKWh = connectors[197].PricePerKWh,
                    TotalCost = Math.Round(32.25m * connectors[197].PricePerKWh, 2),
                    ConnectorId = connectors[197].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-03-13T23:23:57.808Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-03-14T01:28:37.808Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 28.87m,
                    AppliedPricePerKWh = connectors[199].PricePerKWh,
                    TotalCost = Math.Round(28.87m * connectors[199].PricePerKWh, 2),
                    ConnectorId = connectors[199].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-03-15T11:15:20.311Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-03-15T13:04:44.311Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 30.54m,
                    AppliedPricePerKWh = connectors[201].PricePerKWh,
                    TotalCost = Math.Round(30.54m * connectors[201].PricePerKWh, 2),
                    ConnectorId = connectors[201].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-03-15T08:21:58.735Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-03-15T09:52:03.735Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 12.80m,
                    AppliedPricePerKWh = connectors[203].PricePerKWh,
                    TotalCost = Math.Round(12.80m * connectors[203].PricePerKWh, 2),
                    ConnectorId = connectors[203].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-03-16T21:18:31.447Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-03-16T23:13:41.447Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 11.97m,
                    AppliedPricePerKWh = connectors[204].PricePerKWh,
                    TotalCost = Math.Round(11.97m * connectors[204].PricePerKWh, 2),
                    ConnectorId = connectors[204].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-03-17T06:34:56.514Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-03-17T08:00:19.514Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 25.34m,
                    AppliedPricePerKWh = connectors[206].PricePerKWh,
                    TotalCost = Math.Round(25.34m * connectors[206].PricePerKWh, 2),
                    ConnectorId = connectors[206].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-03-18T02:09:39.554Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-03-18T04:09:27.554Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 30.90m,
                    AppliedPricePerKWh = connectors[208].PricePerKWh,
                    TotalCost = Math.Round(30.90m * connectors[208].PricePerKWh, 2),
                    ConnectorId = connectors[208].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-03-18T00:12:40.472Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-03-18T01:51:27.472Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 12.75m,
                    AppliedPricePerKWh = connectors[210].PricePerKWh,
                    TotalCost = Math.Round(12.75m * connectors[210].PricePerKWh, 2),
                    ConnectorId = connectors[210].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-03-18T18:49:40.372Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-03-18T20:31:59.372Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 30.43m,
                    AppliedPricePerKWh = connectors[212].PricePerKWh,
                    TotalCost = Math.Round(30.43m * connectors[212].PricePerKWh, 2),
                    ConnectorId = connectors[212].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-03-19T12:40:33.125Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-03-19T14:27:24.125Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 13.42m,
                    AppliedPricePerKWh = connectors[214].PricePerKWh,
                    TotalCost = Math.Round(13.42m * connectors[214].PricePerKWh, 2),
                    ConnectorId = connectors[214].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-03-20T01:35:44.766Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-03-20T03:41:42.766Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 8.42m,
                    AppliedPricePerKWh = connectors[216].PricePerKWh,
                    TotalCost = Math.Round(8.42m * connectors[216].PricePerKWh, 2),
                    ConnectorId = connectors[216].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-03-21T07:27:01.089Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-03-21T09:40:22.089Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 20.50m,
                    AppliedPricePerKWh = connectors[218].PricePerKWh,
                    TotalCost = Math.Round(20.50m * connectors[218].PricePerKWh, 2),
                    ConnectorId = connectors[218].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-03-21T18:01:29.310Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-03-21T19:27:50.310Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 9.33m,
                    AppliedPricePerKWh = connectors[220].PricePerKWh,
                    TotalCost = Math.Round(9.33m * connectors[220].PricePerKWh, 2),
                    ConnectorId = connectors[220].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-03-22T05:39:04.393Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-03-22T06:56:55.393Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 17.96m,
                    AppliedPricePerKWh = connectors[222].PricePerKWh,
                    TotalCost = Math.Round(17.96m * connectors[222].PricePerKWh, 2),
                    ConnectorId = connectors[222].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-03-22T21:12:05.801Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-03-22T22:23:28.801Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 11.08m,
                    AppliedPricePerKWh = connectors[224].PricePerKWh,
                    TotalCost = Math.Round(11.08m * connectors[224].PricePerKWh, 2),
                    ConnectorId = connectors[224].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-03-23T06:39:09.675Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-03-23T08:53:48.675Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 14.04m,
                    AppliedPricePerKWh = connectors[226].PricePerKWh,
                    TotalCost = Math.Round(14.04m * connectors[226].PricePerKWh, 2),
                    ConnectorId = connectors[226].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-03-24T01:31:26.189Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-03-24T03:19:08.189Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 13.22m,
                    AppliedPricePerKWh = connectors[228].PricePerKWh,
                    TotalCost = Math.Round(13.22m * connectors[228].PricePerKWh, 2),
                    ConnectorId = connectors[228].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-03-24T19:21:42.521Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-03-24T21:01:51.521Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 19.60m,
                    AppliedPricePerKWh = connectors[230].PricePerKWh,
                    TotalCost = Math.Round(19.60m * connectors[230].PricePerKWh, 2),
                    ConnectorId = connectors[230].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-03-25T21:35:32.117Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-03-25T23:44:37.117Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 29.68m,
                    AppliedPricePerKWh = connectors[232].PricePerKWh,
                    TotalCost = Math.Round(29.68m * connectors[232].PricePerKWh, 2),
                    ConnectorId = connectors[232].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-03-26T10:56:38.993Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-03-26T13:15:02.993Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 19.98m,
                    AppliedPricePerKWh = connectors[234].PricePerKWh,
                    TotalCost = Math.Round(19.98m * connectors[234].PricePerKWh, 2),
                    ConnectorId = connectors[234].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-03-27T08:36:52.129Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-03-27T10:31:40.129Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 33.96m,
                    AppliedPricePerKWh = connectors[236].PricePerKWh,
                    TotalCost = Math.Round(33.96m * connectors[236].PricePerKWh, 2),
                    ConnectorId = connectors[236].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-03-27T08:39:23.236Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-03-27T09:46:12.236Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 19.67m,
                    AppliedPricePerKWh = connectors[238].PricePerKWh,
                    TotalCost = Math.Round(19.67m * connectors[238].PricePerKWh, 2),
                    ConnectorId = connectors[238].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-03-28T03:39:56.021Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-03-28T05:11:09.021Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 9.16m,
                    AppliedPricePerKWh = connectors[240].PricePerKWh,
                    TotalCost = Math.Round(9.16m * connectors[240].PricePerKWh, 2),
                    ConnectorId = connectors[240].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-03-29T02:53:43.082Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-03-29T04:40:26.082Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 13.91m,
                    AppliedPricePerKWh = connectors[241].PricePerKWh,
                    TotalCost = Math.Round(13.91m * connectors[241].PricePerKWh, 2),
                    ConnectorId = connectors[241].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-03-30T04:47:08.830Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-03-30T06:37:15.830Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 12.95m,
                    AppliedPricePerKWh = connectors[243].PricePerKWh,
                    TotalCost = Math.Round(12.95m * connectors[243].PricePerKWh, 2),
                    ConnectorId = connectors[243].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-03-30T09:35:15.005Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-03-30T11:00:10.005Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 25.19m,
                    AppliedPricePerKWh = connectors[245].PricePerKWh,
                    TotalCost = Math.Round(25.19m * connectors[245].PricePerKWh, 2),
                    ConnectorId = connectors[245].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-03-31T06:38:41.712Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-03-31T09:09:17.712Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 7.27m,
                    AppliedPricePerKWh = connectors[247].PricePerKWh,
                    TotalCost = Math.Round(7.27m * connectors[247].PricePerKWh, 2),
                    ConnectorId = connectors[247].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-03-31T17:31:32.551Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-03-31T19:17:45.551Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 30.18m,
                    AppliedPricePerKWh = connectors[249].PricePerKWh,
                    TotalCost = Math.Round(30.18m * connectors[249].PricePerKWh, 2),
                    ConnectorId = connectors[249].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-04-01T06:04:44.431Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-04-01T07:21:07.431Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 22.58m,
                    AppliedPricePerKWh = connectors[251].PricePerKWh,
                    TotalCost = Math.Round(22.58m * connectors[251].PricePerKWh, 2),
                    ConnectorId = connectors[251].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-04-02T09:40:53.233Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-04-02T11:41:24.233Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 14.23m,
                    AppliedPricePerKWh = connectors[253].PricePerKWh,
                    TotalCost = Math.Round(14.23m * connectors[253].PricePerKWh, 2),
                    ConnectorId = connectors[253].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-04-02T23:01:27.151Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-04-03T01:19:06.151Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 28.37m,
                    AppliedPricePerKWh = connectors[255].PricePerKWh,
                    TotalCost = Math.Round(28.37m * connectors[255].PricePerKWh, 2),
                    ConnectorId = connectors[255].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-04-03T11:04:19.615Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-04-03T12:35:34.615Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 25.18m,
                    AppliedPricePerKWh = connectors[257].PricePerKWh,
                    TotalCost = Math.Round(25.18m * connectors[257].PricePerKWh, 2),
                    ConnectorId = connectors[257].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-04-04T06:16:28.076Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-04-04T07:37:07.076Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 23.50m,
                    AppliedPricePerKWh = connectors[259].PricePerKWh,
                    TotalCost = Math.Round(23.50m * connectors[259].PricePerKWh, 2),
                    ConnectorId = connectors[259].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-04-04T10:30:53.706Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-04-04T13:00:59.706Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 33.15m,
                    AppliedPricePerKWh = connectors[261].PricePerKWh,
                    TotalCost = Math.Round(33.15m * connectors[261].PricePerKWh, 2),
                    ConnectorId = connectors[261].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-04-05T07:38:21.613Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-04-05T09:14:48.613Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 28.53m,
                    AppliedPricePerKWh = connectors[263].PricePerKWh,
                    TotalCost = Math.Round(28.53m * connectors[263].PricePerKWh, 2),
                    ConnectorId = connectors[263].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-04-06T12:02:16.387Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-04-06T13:22:58.387Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 7.85m,
                    AppliedPricePerKWh = connectors[265].PricePerKWh,
                    TotalCost = Math.Round(7.85m * connectors[265].PricePerKWh, 2),
                    ConnectorId = connectors[265].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-04-06T09:00:28.979Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-04-06T10:48:57.979Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 32.35m,
                    AppliedPricePerKWh = connectors[267].PricePerKWh,
                    TotalCost = Math.Round(32.35m * connectors[267].PricePerKWh, 2),
                    ConnectorId = connectors[267].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-04-07T00:00:14.138Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-04-07T00:56:51.138Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 10.01m,
                    AppliedPricePerKWh = connectors[269].PricePerKWh,
                    TotalCost = Math.Round(10.01m * connectors[269].PricePerKWh, 2),
                    ConnectorId = connectors[269].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-04-07T23:17:56.417Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-04-08T01:04:55.417Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 6.19m,
                    AppliedPricePerKWh = connectors[271].PricePerKWh,
                    TotalCost = Math.Round(6.19m * connectors[271].PricePerKWh, 2),
                    ConnectorId = connectors[271].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-04-08T08:16:16.021Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-04-08T09:55:04.021Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 29.15m,
                    AppliedPricePerKWh = connectors[273].PricePerKWh,
                    TotalCost = Math.Round(29.15m * connectors[273].PricePerKWh, 2),
                    ConnectorId = connectors[273].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-04-09T18:00:08.872Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-04-09T19:57:46.872Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 28.05m,
                    AppliedPricePerKWh = connectors[275].PricePerKWh,
                    TotalCost = Math.Round(28.05m * connectors[275].PricePerKWh, 2),
                    ConnectorId = connectors[275].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-04-09T19:14:39.219Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-04-09T20:53:18.219Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 7.63m,
                    AppliedPricePerKWh = connectors[277].PricePerKWh,
                    TotalCost = Math.Round(7.63m * connectors[277].PricePerKWh, 2),
                    ConnectorId = connectors[277].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-04-10T08:19:05.525Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-04-10T09:57:21.525Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 18.61m,
                    AppliedPricePerKWh = connectors[278].PricePerKWh,
                    TotalCost = Math.Round(18.61m * connectors[278].PricePerKWh, 2),
                    ConnectorId = connectors[278].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-04-11T08:22:15.725Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-04-11T09:57:10.725Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 28.01m,
                    AppliedPricePerKWh = connectors[280].PricePerKWh,
                    TotalCost = Math.Round(28.01m * connectors[280].PricePerKWh, 2),
                    ConnectorId = connectors[280].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-04-11T22:40:52.180Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-04-11T23:50:22.180Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 12.67m,
                    AppliedPricePerKWh = connectors[282].PricePerKWh,
                    TotalCost = Math.Round(12.67m * connectors[282].PricePerKWh, 2),
                    ConnectorId = connectors[282].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-04-13T06:06:47.683Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-04-13T08:29:55.683Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 25.31m,
                    AppliedPricePerKWh = connectors[284].PricePerKWh,
                    TotalCost = Math.Round(25.31m * connectors[284].PricePerKWh, 2),
                    ConnectorId = connectors[284].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-04-13T22:44:31.500Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-04-14T00:18:47.500Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 27.52m,
                    AppliedPricePerKWh = connectors[286].PricePerKWh,
                    TotalCost = Math.Round(27.52m * connectors[286].PricePerKWh, 2),
                    ConnectorId = connectors[286].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-04-13T15:42:32.283Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-04-13T17:22:20.283Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 13.04m,
                    AppliedPricePerKWh = connectors[288].PricePerKWh,
                    TotalCost = Math.Round(13.04m * connectors[288].PricePerKWh, 2),
                    ConnectorId = connectors[288].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-04-15T07:00:53.830Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-04-15T08:21:43.830Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 23.93m,
                    AppliedPricePerKWh = connectors[290].PricePerKWh,
                    TotalCost = Math.Round(23.93m * connectors[290].PricePerKWh, 2),
                    ConnectorId = connectors[290].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-04-15T14:45:56.545Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-04-15T16:55:42.545Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 15.42m,
                    AppliedPricePerKWh = connectors[292].PricePerKWh,
                    TotalCost = Math.Round(15.42m * connectors[292].PricePerKWh, 2),
                    ConnectorId = connectors[292].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-04-15T23:03:26.876Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-04-16T01:11:17.876Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 23.95m,
                    AppliedPricePerKWh = connectors[294].PricePerKWh,
                    TotalCost = Math.Round(23.95m * connectors[294].PricePerKWh, 2),
                    ConnectorId = connectors[294].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-04-16T14:20:17.604Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-04-16T16:30:21.604Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 8.66m,
                    AppliedPricePerKWh = connectors[296].PricePerKWh,
                    TotalCost = Math.Round(8.66m * connectors[296].PricePerKWh, 2),
                    ConnectorId = connectors[296].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-04-17T00:46:34.170Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-04-17T02:59:03.170Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 29.67m,
                    AppliedPricePerKWh = connectors[298].PricePerKWh,
                    TotalCost = Math.Round(29.67m * connectors[298].PricePerKWh, 2),
                    ConnectorId = connectors[298].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-04-17T21:20:37.100Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-04-17T23:29:28.100Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 19.92m,
                    AppliedPricePerKWh = connectors[300].PricePerKWh,
                    TotalCost = Math.Round(19.92m * connectors[300].PricePerKWh, 2),
                    ConnectorId = connectors[300].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-04-18T17:53:27.859Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-04-18T20:15:10.859Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 33.61m,
                    AppliedPricePerKWh = connectors[302].PricePerKWh,
                    TotalCost = Math.Round(33.61m * connectors[302].PricePerKWh, 2),
                    ConnectorId = connectors[302].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-04-19T03:47:17.251Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-04-19T05:49:42.251Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 13.69m,
                    AppliedPricePerKWh = connectors[304].PricePerKWh,
                    TotalCost = Math.Round(13.69m * connectors[304].PricePerKWh, 2),
                    ConnectorId = connectors[304].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-04-20T03:32:54.780Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-04-20T05:09:46.780Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 28.65m,
                    AppliedPricePerKWh = connectors[306].PricePerKWh,
                    TotalCost = Math.Round(28.65m * connectors[306].PricePerKWh, 2),
                    ConnectorId = connectors[306].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-04-20T09:20:06.811Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-04-20T11:12:00.811Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 19.51m,
                    AppliedPricePerKWh = connectors[308].PricePerKWh,
                    TotalCost = Math.Round(19.51m * connectors[308].PricePerKWh, 2),
                    ConnectorId = connectors[308].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-04-21T19:40:10.242Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-04-21T21:32:13.242Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 33.43m,
                    AppliedPricePerKWh = connectors[310].PricePerKWh,
                    TotalCost = Math.Round(33.43m * connectors[310].PricePerKWh, 2),
                    ConnectorId = connectors[310].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-04-21T20:48:54.586Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-04-21T21:43:11.586Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 15.29m,
                    AppliedPricePerKWh = connectors[312].PricePerKWh,
                    TotalCost = Math.Round(15.29m * connectors[312].PricePerKWh, 2),
                    ConnectorId = connectors[312].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-04-22T12:23:28.554Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-04-22T13:57:24.554Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 20.02m,
                    AppliedPricePerKWh = connectors[314].PricePerKWh,
                    TotalCost = Math.Round(20.02m * connectors[314].PricePerKWh, 2),
                    ConnectorId = connectors[314].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-04-23T01:09:13.544Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-04-23T02:39:18.544Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 16.85m,
                    AppliedPricePerKWh = connectors[315].PricePerKWh,
                    TotalCost = Math.Round(16.85m * connectors[315].PricePerKWh, 2),
                    ConnectorId = connectors[315].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-04-24T11:01:33.874Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-04-24T12:33:46.874Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 27.34m,
                    AppliedPricePerKWh = connectors[317].PricePerKWh,
                    TotalCost = Math.Round(27.34m * connectors[317].PricePerKWh, 2),
                    ConnectorId = connectors[317].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-04-24T11:17:15.832Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-04-24T12:51:29.832Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 28.02m,
                    AppliedPricePerKWh = connectors[319].PricePerKWh,
                    TotalCost = Math.Round(28.02m * connectors[319].PricePerKWh, 2),
                    ConnectorId = connectors[319].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-04-25T10:03:13.141Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-04-25T11:44:13.141Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 29.15m,
                    AppliedPricePerKWh = connectors[321].PricePerKWh,
                    TotalCost = Math.Round(29.15m * connectors[321].PricePerKWh, 2),
                    ConnectorId = connectors[321].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-04-25T21:45:44.008Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-04-25T23:21:06.008Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 18.23m,
                    AppliedPricePerKWh = connectors[323].PricePerKWh,
                    TotalCost = Math.Round(18.23m * connectors[323].PricePerKWh, 2),
                    ConnectorId = connectors[323].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-04-26T12:22:29.139Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-04-26T14:01:21.139Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 29.26m,
                    AppliedPricePerKWh = connectors[325].PricePerKWh,
                    TotalCost = Math.Round(29.26m * connectors[325].PricePerKWh, 2),
                    ConnectorId = connectors[325].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-04-27T11:27:15.454Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-04-27T13:02:46.454Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 14.29m,
                    AppliedPricePerKWh = connectors[327].PricePerKWh,
                    TotalCost = Math.Round(14.29m * connectors[327].PricePerKWh, 2),
                    ConnectorId = connectors[327].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-04-28T07:42:00.204Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-04-28T09:02:38.204Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 12.71m,
                    AppliedPricePerKWh = connectors[329].PricePerKWh,
                    TotalCost = Math.Round(12.71m * connectors[329].PricePerKWh, 2),
                    ConnectorId = connectors[329].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-04-28T22:47:22.443Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-04-29T00:11:58.443Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 21.07m,
                    AppliedPricePerKWh = connectors[331].PricePerKWh,
                    TotalCost = Math.Round(21.07m * connectors[331].PricePerKWh, 2),
                    ConnectorId = connectors[331].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-04-29T08:40:03.674Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-04-29T11:03:01.674Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 31.75m,
                    AppliedPricePerKWh = connectors[333].PricePerKWh,
                    TotalCost = Math.Round(31.75m * connectors[333].PricePerKWh, 2),
                    ConnectorId = connectors[333].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-04-29T19:29:26.635Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-04-29T21:30:08.635Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 9.77m,
                    AppliedPricePerKWh = connectors[335].PricePerKWh,
                    TotalCost = Math.Round(9.77m * connectors[335].PricePerKWh, 2),
                    ConnectorId = connectors[335].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-05-01T04:41:08.524Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-05-01T06:22:21.524Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 8.58m,
                    AppliedPricePerKWh = connectors[337].PricePerKWh,
                    TotalCost = Math.Round(8.58m * connectors[337].PricePerKWh, 2),
                    ConnectorId = connectors[337].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-05-01T18:19:49.498Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-05-01T20:40:17.498Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 12.19m,
                    AppliedPricePerKWh = connectors[339].PricePerKWh,
                    TotalCost = Math.Round(12.19m * connectors[339].PricePerKWh, 2),
                    ConnectorId = connectors[339].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-05-02T05:12:41.810Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-05-02T07:37:29.810Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 24.12m,
                    AppliedPricePerKWh = connectors[341].PricePerKWh,
                    TotalCost = Math.Round(24.12m * connectors[341].PricePerKWh, 2),
                    ConnectorId = connectors[341].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-05-03T01:28:46.541Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-05-03T02:28:47.541Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 10.52m,
                    AppliedPricePerKWh = connectors[343].PricePerKWh,
                    TotalCost = Math.Round(10.52m * connectors[343].PricePerKWh, 2),
                    ConnectorId = connectors[343].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-05-03T03:05:21.526Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-05-03T04:50:20.526Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 30.66m,
                    AppliedPricePerKWh = connectors[345].PricePerKWh,
                    TotalCost = Math.Round(30.66m * connectors[345].PricePerKWh, 2),
                    ConnectorId = connectors[345].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-05-04T13:02:43.221Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-05-04T14:47:04.221Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 31.13m,
                    AppliedPricePerKWh = connectors[347].PricePerKWh,
                    TotalCost = Math.Round(31.13m * connectors[347].PricePerKWh, 2),
                    ConnectorId = connectors[347].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-05-05T05:48:37.469Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-05-05T07:38:56.469Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 29.87m,
                    AppliedPricePerKWh = connectors[349].PricePerKWh,
                    TotalCost = Math.Round(29.87m * connectors[349].PricePerKWh, 2),
                    ConnectorId = connectors[349].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-05-05T13:15:51.021Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-05-05T15:45:48.021Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 16.65m,
                    AppliedPricePerKWh = connectors[351].PricePerKWh,
                    TotalCost = Math.Round(16.65m * connectors[351].PricePerKWh, 2),
                    ConnectorId = connectors[351].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-05-06T15:43:10.850Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-05-06T17:06:38.850Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 8.96m,
                    AppliedPricePerKWh = connectors[352].PricePerKWh,
                    TotalCost = Math.Round(8.96m * connectors[352].PricePerKWh, 2),
                    ConnectorId = connectors[352].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-05-06T20:02:49.407Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-05-06T20:52:52.407Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 7.36m,
                    AppliedPricePerKWh = connectors[354].PricePerKWh,
                    TotalCost = Math.Round(7.36m * connectors[354].PricePerKWh, 2),
                    ConnectorId = connectors[354].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-05-07T16:15:52.118Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-05-07T17:53:46.118Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 20.05m,
                    AppliedPricePerKWh = connectors[356].PricePerKWh,
                    TotalCost = Math.Round(20.05m * connectors[356].PricePerKWh, 2),
                    ConnectorId = connectors[356].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-05-08T03:57:08.936Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-05-08T05:09:16.936Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 10.94m,
                    AppliedPricePerKWh = connectors[358].PricePerKWh,
                    TotalCost = Math.Round(10.94m * connectors[358].PricePerKWh, 2),
                    ConnectorId = connectors[358].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-05-09T07:20:22.384Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-05-09T09:24:30.384Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 7.07m,
                    AppliedPricePerKWh = connectors[360].PricePerKWh,
                    TotalCost = Math.Round(7.07m * connectors[360].PricePerKWh, 2),
                    ConnectorId = connectors[360].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-05-09T21:51:38.425Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-05-09T23:17:39.425Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 25.80m,
                    AppliedPricePerKWh = connectors[362].PricePerKWh,
                    TotalCost = Math.Round(25.80m * connectors[362].PricePerKWh, 2),
                    ConnectorId = connectors[362].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-05-09T22:58:29.419Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-05-10T00:47:26.419Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 27.33m,
                    AppliedPricePerKWh = connectors[364].PricePerKWh,
                    TotalCost = Math.Round(27.33m * connectors[364].PricePerKWh, 2),
                    ConnectorId = connectors[364].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-05-10T22:52:49.822Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-05-11T01:04:03.822Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 19.44m,
                    AppliedPricePerKWh = connectors[366].PricePerKWh,
                    TotalCost = Math.Round(19.44m * connectors[366].PricePerKWh, 2),
                    ConnectorId = connectors[366].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-05-11T15:27:12.845Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-05-11T17:30:39.845Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 19.71m,
                    AppliedPricePerKWh = connectors[368].PricePerKWh,
                    TotalCost = Math.Round(19.71m * connectors[368].PricePerKWh, 2),
                    ConnectorId = connectors[368].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-05-12T00:17:34.276Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-05-12T01:25:56.276Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 12.46m,
                    AppliedPricePerKWh = connectors[370].PricePerKWh,
                    TotalCost = Math.Round(12.46m * connectors[370].PricePerKWh, 2),
                    ConnectorId = connectors[370].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-05-13T07:39:29.728Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-05-13T09:41:05.728Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 9.20m,
                    AppliedPricePerKWh = connectors[372].PricePerKWh,
                    TotalCost = Math.Round(9.20m * connectors[372].PricePerKWh, 2),
                    ConnectorId = connectors[372].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-05-13T23:26:57.036Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-05-14T00:59:48.036Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 27.43m,
                    AppliedPricePerKWh = connectors[374].PricePerKWh,
                    TotalCost = Math.Round(27.43m * connectors[374].PricePerKWh, 2),
                    ConnectorId = connectors[374].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-05-13T19:56:48.064Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-05-13T21:54:59.064Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 31.09m,
                    AppliedPricePerKWh = connectors[376].PricePerKWh,
                    TotalCost = Math.Round(31.09m * connectors[376].PricePerKWh, 2),
                    ConnectorId = connectors[376].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-05-15T00:05:10.700Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-05-15T01:24:14.700Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 23.55m,
                    AppliedPricePerKWh = connectors[378].PricePerKWh,
                    TotalCost = Math.Round(23.55m * connectors[378].PricePerKWh, 2),
                    ConnectorId = connectors[378].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-05-15T05:39:51.591Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-05-15T07:40:35.591Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 13.51m,
                    AppliedPricePerKWh = connectors[380].PricePerKWh,
                    TotalCost = Math.Round(13.51m * connectors[380].PricePerKWh, 2),
                    ConnectorId = connectors[380].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-05-16T05:53:34.669Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-05-16T06:58:44.669Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 7.22m,
                    AppliedPricePerKWh = connectors[382].PricePerKWh,
                    TotalCost = Math.Round(7.22m * connectors[382].PricePerKWh, 2),
                    ConnectorId = connectors[382].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-05-16T15:56:06.606Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-05-16T17:16:31.606Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 23.97m,
                    AppliedPricePerKWh = connectors[384].PricePerKWh,
                    TotalCost = Math.Round(23.97m * connectors[384].PricePerKWh, 2),
                    ConnectorId = connectors[384].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-05-17T11:23:20.184Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-05-17T12:40:14.184Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 18.75m,
                    AppliedPricePerKWh = connectors[386].PricePerKWh,
                    TotalCost = Math.Round(18.75m * connectors[386].PricePerKWh, 2),
                    ConnectorId = connectors[386].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-05-17T21:29:55.994Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-05-17T22:25:19.994Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 14.76m,
                    AppliedPricePerKWh = connectors[388].PricePerKWh,
                    TotalCost = Math.Round(14.76m * connectors[388].PricePerKWh, 2),
                    ConnectorId = connectors[388].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-05-19T01:11:49.589Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-05-19T03:12:14.589Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 31.47m,
                    AppliedPricePerKWh = connectors[389].PricePerKWh,
                    TotalCost = Math.Round(31.47m * connectors[389].PricePerKWh, 2),
                    ConnectorId = connectors[389].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-05-19T15:17:03.043Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-05-19T16:52:21.043Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 13.91m,
                    AppliedPricePerKWh = connectors[391].PricePerKWh,
                    TotalCost = Math.Round(13.91m * connectors[391].PricePerKWh, 2),
                    ConnectorId = connectors[391].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-05-20T04:56:32.116Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-05-20T05:58:46.116Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 12.17m,
                    AppliedPricePerKWh = connectors[393].PricePerKWh,
                    TotalCost = Math.Round(12.17m * connectors[393].PricePerKWh, 2),
                    ConnectorId = connectors[393].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-05-20T15:00:59.073Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-05-20T16:38:09.073Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 11.40m,
                    AppliedPricePerKWh = connectors[395].PricePerKWh,
                    TotalCost = Math.Round(11.40m * connectors[395].PricePerKWh, 2),
                    ConnectorId = connectors[395].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-05-21T07:10:08.731Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-05-21T08:59:54.731Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 7.62m,
                    AppliedPricePerKWh = connectors[397].PricePerKWh,
                    TotalCost = Math.Round(7.62m * connectors[397].PricePerKWh, 2),
                    ConnectorId = connectors[397].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-05-22T05:00:04.307Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-05-22T06:42:10.307Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 6.40m,
                    AppliedPricePerKWh = connectors[399].PricePerKWh,
                    TotalCost = Math.Round(6.40m * connectors[399].PricePerKWh, 2),
                    ConnectorId = connectors[399].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-05-22T12:45:06.172Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-05-22T15:00:52.172Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 11.70m,
                    AppliedPricePerKWh = connectors[401].PricePerKWh,
                    TotalCost = Math.Round(11.70m * connectors[401].PricePerKWh, 2),
                    ConnectorId = connectors[401].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-05-23T14:52:39.740Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-05-23T16:46:40.740Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 33.92m,
                    AppliedPricePerKWh = connectors[403].PricePerKWh,
                    TotalCost = Math.Round(33.92m * connectors[403].PricePerKWh, 2),
                    ConnectorId = connectors[403].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-05-23T18:26:57.600Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-05-23T19:53:01.600Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 25.63m,
                    AppliedPricePerKWh = connectors[405].PricePerKWh,
                    TotalCost = Math.Round(25.63m * connectors[405].PricePerKWh, 2),
                    ConnectorId = connectors[405].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-05-24T18:34:25.939Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-05-24T20:29:55.939Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 22.35m,
                    AppliedPricePerKWh = connectors[407].PricePerKWh,
                    TotalCost = Math.Round(22.35m * connectors[407].PricePerKWh, 2),
                    ConnectorId = connectors[407].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-05-25T18:01:14.161Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-05-25T20:20:14.161Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 25.19m,
                    AppliedPricePerKWh = connectors[409].PricePerKWh,
                    TotalCost = Math.Round(25.19m * connectors[409].PricePerKWh, 2),
                    ConnectorId = connectors[409].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-05-26T12:53:04.987Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-05-26T15:14:32.987Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 14.42m,
                    AppliedPricePerKWh = connectors[411].PricePerKWh,
                    TotalCost = Math.Round(14.42m * connectors[411].PricePerKWh, 2),
                    ConnectorId = connectors[411].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-05-27T08:40:27.541Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-05-27T10:31:48.541Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 7.90m,
                    AppliedPricePerKWh = connectors[413].PricePerKWh,
                    TotalCost = Math.Round(7.90m * connectors[413].PricePerKWh, 2),
                    ConnectorId = connectors[413].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-05-27T14:55:30.504Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-05-27T16:22:41.504Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 15.85m,
                    AppliedPricePerKWh = connectors[415].PricePerKWh,
                    TotalCost = Math.Round(15.85m * connectors[415].PricePerKWh, 2),
                    ConnectorId = connectors[415].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-05-28T14:40:12.112Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-05-28T16:06:08.112Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 9.74m,
                    AppliedPricePerKWh = connectors[417].PricePerKWh,
                    TotalCost = Math.Round(9.74m * connectors[417].PricePerKWh, 2),
                    ConnectorId = connectors[417].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-05-29T02:51:59.009Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-05-29T04:49:02.009Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 22.92m,
                    AppliedPricePerKWh = connectors[419].PricePerKWh,
                    TotalCost = Math.Round(22.92m * connectors[419].PricePerKWh, 2),
                    ConnectorId = connectors[419].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-05-29T10:30:39.982Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-05-29T12:11:34.982Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 24.22m,
                    AppliedPricePerKWh = connectors[421].PricePerKWh,
                    TotalCost = Math.Round(24.22m * connectors[421].PricePerKWh, 2),
                    ConnectorId = connectors[421].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-05-30T15:21:52.235Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-05-30T17:30:16.235Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 18.85m,
                    AppliedPricePerKWh = connectors[423].PricePerKWh,
                    TotalCost = Math.Round(18.85m * connectors[423].PricePerKWh, 2),
                    ConnectorId = connectors[423].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-05-31T07:43:21.945Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-05-31T09:54:58.945Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 18.95m,
                    AppliedPricePerKWh = connectors[425].PricePerKWh,
                    TotalCost = Math.Round(18.95m * connectors[425].PricePerKWh, 2),
                    ConnectorId = connectors[425].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-05-31T17:27:38.205Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-05-31T18:52:19.205Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 25.18m,
                    AppliedPricePerKWh = connectors[426].PricePerKWh,
                    TotalCost = Math.Round(25.18m * connectors[426].PricePerKWh, 2),
                    ConnectorId = connectors[426].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-06-01T17:20:07.991Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-06-01T19:46:47.991Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 27.35m,
                    AppliedPricePerKWh = connectors[428].PricePerKWh,
                    TotalCost = Math.Round(27.35m * connectors[428].PricePerKWh, 2),
                    ConnectorId = connectors[428].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-06-01T12:43:08.577Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-06-01T14:23:28.577Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 14.96m,
                    AppliedPricePerKWh = connectors[430].PricePerKWh,
                    TotalCost = Math.Round(14.96m * connectors[430].PricePerKWh, 2),
                    ConnectorId = connectors[430].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-06-02T11:10:49.412Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-06-02T12:51:11.412Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 29.92m,
                    AppliedPricePerKWh = connectors[432].PricePerKWh,
                    TotalCost = Math.Round(29.92m * connectors[432].PricePerKWh, 2),
                    ConnectorId = connectors[432].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-06-03T03:19:13.739Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-06-03T05:01:29.739Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 10.76m,
                    AppliedPricePerKWh = connectors[434].PricePerKWh,
                    TotalCost = Math.Round(10.76m * connectors[434].PricePerKWh, 2),
                    ConnectorId = connectors[434].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-06-03T10:26:22.390Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-06-03T12:32:40.390Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 14.88m,
                    AppliedPricePerKWh = connectors[436].PricePerKWh,
                    TotalCost = Math.Round(14.88m * connectors[436].PricePerKWh, 2),
                    ConnectorId = connectors[436].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-06-04T07:13:54.217Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-06-04T08:29:26.217Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 15.58m,
                    AppliedPricePerKWh = connectors[438].PricePerKWh,
                    TotalCost = Math.Round(15.58m * connectors[438].PricePerKWh, 2),
                    ConnectorId = connectors[438].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-06-04T19:26:44.164Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-06-04T20:58:05.164Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 27.13m,
                    AppliedPricePerKWh = connectors[440].PricePerKWh,
                    TotalCost = Math.Round(27.13m * connectors[440].PricePerKWh, 2),
                    ConnectorId = connectors[440].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-06-06T01:39:40.719Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-06-06T03:02:26.719Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 24.35m,
                    AppliedPricePerKWh = connectors[442].PricePerKWh,
                    TotalCost = Math.Round(24.35m * connectors[442].PricePerKWh, 2),
                    ConnectorId = connectors[442].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-06-06T17:23:25.502Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-06-06T19:07:19.502Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 16.86m,
                    AppliedPricePerKWh = connectors[444].PricePerKWh,
                    TotalCost = Math.Round(16.86m * connectors[444].PricePerKWh, 2),
                    ConnectorId = connectors[444].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-06-07T09:15:00.311Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-06-07T11:04:48.311Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 32.66m,
                    AppliedPricePerKWh = connectors[446].PricePerKWh,
                    TotalCost = Math.Round(32.66m * connectors[446].PricePerKWh, 2),
                    ConnectorId = connectors[446].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-06-08T01:42:09.630Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-06-08T03:08:19.630Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 20.75m,
                    AppliedPricePerKWh = connectors[448].PricePerKWh,
                    TotalCost = Math.Round(20.75m * connectors[448].PricePerKWh, 2),
                    ConnectorId = connectors[448].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-06-09T01:23:56.596Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-06-09T03:07:24.596Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 30.64m,
                    AppliedPricePerKWh = connectors[450].PricePerKWh,
                    TotalCost = Math.Round(30.64m * connectors[450].PricePerKWh, 2),
                    ConnectorId = connectors[450].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-06-08T21:18:39.491Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-06-08T23:08:21.491Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 32.50m,
                    AppliedPricePerKWh = connectors[452].PricePerKWh,
                    TotalCost = Math.Round(32.50m * connectors[452].PricePerKWh, 2),
                    ConnectorId = connectors[452].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-06-09T18:07:24.191Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-06-09T20:35:55.191Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 30.15m,
                    AppliedPricePerKWh = connectors[454].PricePerKWh,
                    TotalCost = Math.Round(30.15m * connectors[454].PricePerKWh, 2),
                    ConnectorId = connectors[454].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-06-10T02:47:38.225Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-06-10T04:17:28.225Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 11.58m,
                    AppliedPricePerKWh = connectors[456].PricePerKWh,
                    TotalCost = Math.Round(11.58m * connectors[456].PricePerKWh, 2),
                    ConnectorId = connectors[456].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-06-10T21:03:08.342Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-06-10T22:10:01.342Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 15.58m,
                    AppliedPricePerKWh = connectors[458].PricePerKWh,
                    TotalCost = Math.Round(15.58m * connectors[458].PricePerKWh, 2),
                    ConnectorId = connectors[458].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-06-11T22:56:36.306Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-06-12T01:19:08.306Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 16.58m,
                    AppliedPricePerKWh = connectors[460].PricePerKWh,
                    TotalCost = Math.Round(16.58m * connectors[460].PricePerKWh, 2),
                    ConnectorId = connectors[460].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-06-12T15:54:13.605Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-06-12T16:56:13.605Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 18.45m,
                    AppliedPricePerKWh = connectors[462].PricePerKWh,
                    TotalCost = Math.Round(18.45m * connectors[462].PricePerKWh, 2),
                    ConnectorId = connectors[462].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-06-13T15:08:29.137Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-06-13T17:13:34.137Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 28.39m,
                    AppliedPricePerKWh = connectors[463].PricePerKWh,
                    TotalCost = Math.Round(28.39m * connectors[463].PricePerKWh, 2),
                    ConnectorId = connectors[463].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-06-14T02:11:26.554Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-06-14T04:20:55.554Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 23.13m,
                    AppliedPricePerKWh = connectors[465].PricePerKWh,
                    TotalCost = Math.Round(23.13m * connectors[465].PricePerKWh, 2),
                    ConnectorId = connectors[465].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-06-14T05:31:54.490Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-06-14T07:16:24.490Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 24.08m,
                    AppliedPricePerKWh = connectors[467].PricePerKWh,
                    TotalCost = Math.Round(24.08m * connectors[467].PricePerKWh, 2),
                    ConnectorId = connectors[467].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-06-15T05:15:23.037Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-06-15T06:26:12.037Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 10.49m,
                    AppliedPricePerKWh = connectors[469].PricePerKWh,
                    TotalCost = Math.Round(10.49m * connectors[469].PricePerKWh, 2),
                    ConnectorId = connectors[469].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-06-15T15:50:24.381Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-06-15T17:47:04.381Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 30.02m,
                    AppliedPricePerKWh = connectors[471].PricePerKWh,
                    TotalCost = Math.Round(30.02m * connectors[471].PricePerKWh, 2),
                    ConnectorId = connectors[471].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-06-16T09:37:39.519Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-06-16T11:21:28.519Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 30.62m,
                    AppliedPricePerKWh = connectors[473].PricePerKWh,
                    TotalCost = Math.Round(30.62m * connectors[473].PricePerKWh, 2),
                    ConnectorId = connectors[473].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-06-17T07:54:26.692Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-06-17T09:28:13.692Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 10.57m,
                    AppliedPricePerKWh = connectors[475].PricePerKWh,
                    TotalCost = Math.Round(10.57m * connectors[475].PricePerKWh, 2),
                    ConnectorId = connectors[475].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-06-17T22:24:34.899Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-06-18T00:39:46.899Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 26.54m,
                    AppliedPricePerKWh = connectors[477].PricePerKWh,
                    TotalCost = Math.Round(26.54m * connectors[477].PricePerKWh, 2),
                    ConnectorId = connectors[477].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-06-18T10:47:36.549Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-06-18T11:58:34.549Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 12.82m,
                    AppliedPricePerKWh = connectors[479].PricePerKWh,
                    TotalCost = Math.Round(12.82m * connectors[479].PricePerKWh, 2),
                    ConnectorId = connectors[479].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-06-19T05:18:15.314Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-06-19T06:52:49.314Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 10.51m,
                    AppliedPricePerKWh = connectors[481].PricePerKWh,
                    TotalCost = Math.Round(10.51m * connectors[481].PricePerKWh, 2),
                    ConnectorId = connectors[481].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-06-19T22:11:37.505Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-06-19T23:23:36.505Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 12.14m,
                    AppliedPricePerKWh = connectors[483].PricePerKWh,
                    TotalCost = Math.Round(12.14m * connectors[483].PricePerKWh, 2),
                    ConnectorId = connectors[483].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-06-21T02:22:02.943Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-06-21T03:50:58.943Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 6.81m,
                    AppliedPricePerKWh = connectors[485].PricePerKWh,
                    TotalCost = Math.Round(6.81m * connectors[485].PricePerKWh, 2),
                    ConnectorId = connectors[485].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-06-21T05:06:23.828Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-06-21T07:03:29.828Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 17.98m,
                    AppliedPricePerKWh = connectors[487].PricePerKWh,
                    TotalCost = Math.Round(17.98m * connectors[487].PricePerKWh, 2),
                    ConnectorId = connectors[487].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-06-21T23:30:31.845Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-06-22T01:08:11.845Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 28.85m,
                    AppliedPricePerKWh = connectors[489].PricePerKWh,
                    TotalCost = Math.Round(28.85m * connectors[489].PricePerKWh, 2),
                    ConnectorId = connectors[489].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-06-23T00:27:00.249Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-06-23T02:30:14.249Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 28.76m,
                    AppliedPricePerKWh = connectors[491].PricePerKWh,
                    TotalCost = Math.Round(28.76m * connectors[491].PricePerKWh, 2),
                    ConnectorId = connectors[491].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-06-23T17:53:15.530Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-06-23T18:55:52.530Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 17.93m,
                    AppliedPricePerKWh = connectors[493].PricePerKWh,
                    TotalCost = Math.Round(17.93m * connectors[493].PricePerKWh, 2),
                    ConnectorId = connectors[493].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-06-24T02:11:08.373Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-06-24T03:56:10.373Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 31.39m,
                    AppliedPricePerKWh = connectors[495].PricePerKWh,
                    TotalCost = Math.Round(31.39m * connectors[495].PricePerKWh, 2),
                    ConnectorId = connectors[495].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-06-24T15:00:45.639Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-06-24T17:22:38.639Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 19.25m,
                    AppliedPricePerKWh = connectors[497].PricePerKWh,
                    TotalCost = Math.Round(19.25m * connectors[497].PricePerKWh, 2),
                    ConnectorId = connectors[497].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-06-25T03:38:38.358Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-06-25T04:46:23.358Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 11.30m,
                    AppliedPricePerKWh = connectors[499].PricePerKWh,
                    TotalCost = Math.Round(11.30m * connectors[499].PricePerKWh, 2),
                    ConnectorId = connectors[499].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-06-26T02:17:27.878Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-06-26T04:05:40.878Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 32.30m,
                    AppliedPricePerKWh = connectors[500].PricePerKWh,
                    TotalCost = Math.Round(32.30m * connectors[500].PricePerKWh, 2),
                    ConnectorId = connectors[500].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-06-27T02:38:09.223Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-06-27T04:22:56.223Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 31.18m,
                    AppliedPricePerKWh = connectors[502].PricePerKWh,
                    TotalCost = Math.Round(31.18m * connectors[502].PricePerKWh, 2),
                    ConnectorId = connectors[502].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-06-27T07:10:31.077Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-06-27T08:52:28.077Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 30.10m,
                    AppliedPricePerKWh = connectors[504].PricePerKWh,
                    TotalCost = Math.Round(30.10m * connectors[504].PricePerKWh, 2),
                    ConnectorId = connectors[504].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-06-28T07:10:40.525Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-06-28T08:26:48.525Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 8.22m,
                    AppliedPricePerKWh = connectors[506].PricePerKWh,
                    TotalCost = Math.Round(8.22m * connectors[506].PricePerKWh, 2),
                    ConnectorId = connectors[506].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-06-28T04:06:14.769Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-06-28T06:18:34.769Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 17.34m,
                    AppliedPricePerKWh = connectors[508].PricePerKWh,
                    TotalCost = Math.Round(17.34m * connectors[508].PricePerKWh, 2),
                    ConnectorId = connectors[508].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-06-29T08:13:35.429Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-06-29T10:37:16.429Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 8.16m,
                    AppliedPricePerKWh = connectors[510].PricePerKWh,
                    TotalCost = Math.Round(8.16m * connectors[510].PricePerKWh, 2),
                    ConnectorId = connectors[510].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-06-29T12:56:03.018Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-06-29T14:28:46.018Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 14.35m,
                    AppliedPricePerKWh = connectors[512].PricePerKWh,
                    TotalCost = Math.Round(14.35m * connectors[512].PricePerKWh, 2),
                    ConnectorId = connectors[512].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-06-30T15:25:26.285Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-06-30T17:33:06.285Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 15.83m,
                    AppliedPricePerKWh = connectors[514].PricePerKWh,
                    TotalCost = Math.Round(15.83m * connectors[514].PricePerKWh, 2),
                    ConnectorId = connectors[514].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-07-01T13:27:33.376Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-07-01T15:26:41.376Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 12.09m,
                    AppliedPricePerKWh = connectors[516].PricePerKWh,
                    TotalCost = Math.Round(12.09m * connectors[516].PricePerKWh, 2),
                    ConnectorId = connectors[516].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-07-01T16:26:11.511Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-07-01T18:29:02.511Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 12.77m,
                    AppliedPricePerKWh = connectors[518].PricePerKWh,
                    TotalCost = Math.Round(12.77m * connectors[518].PricePerKWh, 2),
                    ConnectorId = connectors[518].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-07-02T09:18:01.970Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-07-02T11:42:37.970Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 16.63m,
                    AppliedPricePerKWh = connectors[520].PricePerKWh,
                    TotalCost = Math.Round(16.63m * connectors[520].PricePerKWh, 2),
                    ConnectorId = connectors[520].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-07-03T08:45:46.210Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-07-03T10:13:03.210Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 17.30m,
                    AppliedPricePerKWh = connectors[522].PricePerKWh,
                    TotalCost = Math.Round(17.30m * connectors[522].PricePerKWh, 2),
                    ConnectorId = connectors[522].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-07-04T02:04:34.968Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-07-04T03:32:21.968Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 25.86m,
                    AppliedPricePerKWh = connectors[524].PricePerKWh,
                    TotalCost = Math.Round(25.86m * connectors[524].PricePerKWh, 2),
                    ConnectorId = connectors[524].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-07-04T21:08:51.823Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-07-04T22:08:33.823Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 16.12m,
                    AppliedPricePerKWh = connectors[526].PricePerKWh,
                    TotalCost = Math.Round(16.12m * connectors[526].PricePerKWh, 2),
                    ConnectorId = connectors[526].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-07-05T18:50:38.990Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-07-05T20:45:16.990Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 33.95m,
                    AppliedPricePerKWh = connectors[528].PricePerKWh,
                    TotalCost = Math.Round(33.95m * connectors[528].PricePerKWh, 2),
                    ConnectorId = connectors[528].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-07-05T21:59:28.948Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-07-05T23:38:37.948Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 26.60m,
                    AppliedPricePerKWh = connectors[530].PricePerKWh,
                    TotalCost = Math.Round(26.60m * connectors[530].PricePerKWh, 2),
                    ConnectorId = connectors[530].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-07-06T04:37:20.988Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-07-06T05:49:56.988Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 21.36m,
                    AppliedPricePerKWh = connectors[532].PricePerKWh,
                    TotalCost = Math.Round(21.36m * connectors[532].PricePerKWh, 2),
                    ConnectorId = connectors[532].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-07-07T10:09:22.135Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-07-07T12:11:02.135Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 33.32m,
                    AppliedPricePerKWh = connectors[534].PricePerKWh,
                    TotalCost = Math.Round(33.32m * connectors[534].PricePerKWh, 2),
                    ConnectorId = connectors[534].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-07-07T19:02:45.295Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-07-07T20:49:04.295Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 15.86m,
                    AppliedPricePerKWh = connectors[536].PricePerKWh,
                    TotalCost = Math.Round(15.86m * connectors[536].PricePerKWh, 2),
                    ConnectorId = connectors[536].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-07-08T16:03:15.677Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-07-08T17:00:16.677Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 8.28m,
                    AppliedPricePerKWh = connectors[537].PricePerKWh,
                    TotalCost = Math.Round(8.28m * connectors[537].PricePerKWh, 2),
                    ConnectorId = connectors[537].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-07-09T00:58:51.895Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-07-09T01:48:52.895Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 10.79m,
                    AppliedPricePerKWh = connectors[539].PricePerKWh,
                    TotalCost = Math.Round(10.79m * connectors[539].PricePerKWh, 2),
                    ConnectorId = connectors[539].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-07-09T17:50:18.918Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-07-09T19:54:47.918Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 20.38m,
                    AppliedPricePerKWh = connectors[541].PricePerKWh,
                    TotalCost = Math.Round(20.38m * connectors[541].PricePerKWh, 2),
                    ConnectorId = connectors[541].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-07-10T05:06:06.612Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-07-10T06:31:48.612Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 25.24m,
                    AppliedPricePerKWh = connectors[543].PricePerKWh,
                    TotalCost = Math.Round(25.24m * connectors[543].PricePerKWh, 2),
                    ConnectorId = connectors[543].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-07-11T11:10:10.537Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-07-11T12:26:35.537Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 18.63m,
                    AppliedPricePerKWh = connectors[545].PricePerKWh,
                    TotalCost = Math.Round(18.63m * connectors[545].PricePerKWh, 2),
                    ConnectorId = connectors[545].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-07-11T13:30:27.303Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-07-11T15:15:27.303Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 19.79m,
                    AppliedPricePerKWh = connectors[547].PricePerKWh,
                    TotalCost = Math.Round(19.79m * connectors[547].PricePerKWh, 2),
                    ConnectorId = connectors[547].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-07-12T14:29:50.117Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-07-12T16:18:44.117Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 32.30m,
                    AppliedPricePerKWh = connectors[549].PricePerKWh,
                    TotalCost = Math.Round(32.30m * connectors[549].PricePerKWh, 2),
                    ConnectorId = connectors[549].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-07-13T02:52:37.274Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-07-13T03:43:09.274Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 10.22m,
                    AppliedPricePerKWh = connectors[551].PricePerKWh,
                    TotalCost = Math.Round(10.22m * connectors[551].PricePerKWh, 2),
                    ConnectorId = connectors[551].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-07-13T20:14:23.997Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-07-13T22:09:30.997Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 18.59m,
                    AppliedPricePerKWh = connectors[553].PricePerKWh,
                    TotalCost = Math.Round(18.59m * connectors[553].PricePerKWh, 2),
                    ConnectorId = connectors[553].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-07-14T17:10:38.542Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-07-14T19:07:16.542Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 25.43m,
                    AppliedPricePerKWh = connectors[555].PricePerKWh,
                    TotalCost = Math.Round(25.43m * connectors[555].PricePerKWh, 2),
                    ConnectorId = connectors[555].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-07-15T17:45:32.808Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-07-15T19:33:12.808Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 20.17m,
                    AppliedPricePerKWh = connectors[557].PricePerKWh,
                    TotalCost = Math.Round(20.17m * connectors[557].PricePerKWh, 2),
                    ConnectorId = connectors[557].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-07-15T14:46:13.909Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-07-15T16:40:59.909Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 24.95m,
                    AppliedPricePerKWh = connectors[559].PricePerKWh,
                    TotalCost = Math.Round(24.95m * connectors[559].PricePerKWh, 2),
                    ConnectorId = connectors[559].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-07-17T01:11:45.177Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-07-17T03:11:06.177Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 9.15m,
                    AppliedPricePerKWh = connectors[561].PricePerKWh,
                    TotalCost = Math.Round(9.15m * connectors[561].PricePerKWh, 2),
                    ConnectorId = connectors[561].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-07-17T13:36:42.832Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-07-17T15:37:48.832Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 11.69m,
                    AppliedPricePerKWh = connectors[563].PricePerKWh,
                    TotalCost = Math.Round(11.69m * connectors[563].PricePerKWh, 2),
                    ConnectorId = connectors[563].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-07-18T03:31:43.460Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-07-18T04:41:07.460Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 20.63m,
                    AppliedPricePerKWh = connectors[565].PricePerKWh,
                    TotalCost = Math.Round(20.63m * connectors[565].PricePerKWh, 2),
                    ConnectorId = connectors[565].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-07-19T03:22:42.589Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-07-19T04:52:14.589Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 10.09m,
                    AppliedPricePerKWh = connectors[567].PricePerKWh,
                    TotalCost = Math.Round(10.09m * connectors[567].PricePerKWh, 2),
                    ConnectorId = connectors[567].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-07-19T09:02:02.411Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-07-19T10:33:39.411Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 15.15m,
                    AppliedPricePerKWh = connectors[569].PricePerKWh,
                    TotalCost = Math.Round(15.15m * connectors[569].PricePerKWh, 2),
                    ConnectorId = connectors[569].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-07-19T16:05:27.554Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-07-19T17:23:34.554Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 23.21m,
                    AppliedPricePerKWh = connectors[571].PricePerKWh,
                    TotalCost = Math.Round(23.21m * connectors[571].PricePerKWh, 2),
                    ConnectorId = connectors[571].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-07-20T11:28:32.264Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-07-20T12:48:24.264Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 23.28m,
                    AppliedPricePerKWh = connectors[573].PricePerKWh,
                    TotalCost = Math.Round(23.28m * connectors[573].PricePerKWh, 2),
                    ConnectorId = connectors[573].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-07-21T07:47:36.516Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-07-21T09:00:06.516Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 8.73m,
                    AppliedPricePerKWh = connectors[574].PricePerKWh,
                    TotalCost = Math.Round(8.73m * connectors[574].PricePerKWh, 2),
                    ConnectorId = connectors[574].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-07-21T23:29:30.537Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-07-22T01:44:54.537Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 12.64m,
                    AppliedPricePerKWh = connectors[576].PricePerKWh,
                    TotalCost = Math.Round(12.64m * connectors[576].PricePerKWh, 2),
                    ConnectorId = connectors[576].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-07-22T08:18:36.704Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-07-22T09:38:50.704Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 6.99m,
                    AppliedPricePerKWh = connectors[578].PricePerKWh,
                    TotalCost = Math.Round(6.99m * connectors[578].PricePerKWh, 2),
                    ConnectorId = connectors[578].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-07-23T13:44:28.157Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-07-23T14:56:15.157Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 19.37m,
                    AppliedPricePerKWh = connectors[580].PricePerKWh,
                    TotalCost = Math.Round(19.37m * connectors[580].PricePerKWh, 2),
                    ConnectorId = connectors[580].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-07-24T10:35:09.698Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-07-24T13:02:04.698Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 33.95m,
                    AppliedPricePerKWh = connectors[582].PricePerKWh,
                    TotalCost = Math.Round(33.95m * connectors[582].PricePerKWh, 2),
                    ConnectorId = connectors[582].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-07-24T18:48:50.818Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-07-24T21:18:36.818Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 32.99m,
                    AppliedPricePerKWh = connectors[584].PricePerKWh,
                    TotalCost = Math.Round(32.99m * connectors[584].PricePerKWh, 2),
                    ConnectorId = connectors[584].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-07-25T15:33:52.802Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-07-25T17:00:01.802Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 15.51m,
                    AppliedPricePerKWh = connectors[586].PricePerKWh,
                    TotalCost = Math.Round(15.51m * connectors[586].PricePerKWh, 2),
                    ConnectorId = connectors[586].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-07-25T17:39:55.969Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-07-25T19:11:35.969Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 27.01m,
                    AppliedPricePerKWh = connectors[588].PricePerKWh,
                    TotalCost = Math.Round(27.01m * connectors[588].PricePerKWh, 2),
                    ConnectorId = connectors[588].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-07-26T12:33:07.254Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-07-26T13:38:39.254Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 19.06m,
                    AppliedPricePerKWh = connectors[590].PricePerKWh,
                    TotalCost = Math.Round(19.06m * connectors[590].PricePerKWh, 2),
                    ConnectorId = connectors[590].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-07-27T08:27:24.925Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-07-27T10:53:02.925Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 11.62m,
                    AppliedPricePerKWh = connectors[592].PricePerKWh,
                    TotalCost = Math.Round(11.62m * connectors[592].PricePerKWh, 2),
                    ConnectorId = connectors[592].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-07-27T18:17:05.085Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-07-27T20:18:28.085Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 30.60m,
                    AppliedPricePerKWh = connectors[594].PricePerKWh,
                    TotalCost = Math.Round(30.60m * connectors[594].PricePerKWh, 2),
                    ConnectorId = connectors[594].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-07-28T23:21:11.830Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-07-29T00:37:21.830Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 22.77m,
                    AppliedPricePerKWh = connectors[596].PricePerKWh,
                    TotalCost = Math.Round(22.77m * connectors[596].PricePerKWh, 2),
                    ConnectorId = connectors[596].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-07-29T00:57:09.361Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-07-29T03:14:05.361Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 7.89m,
                    AppliedPricePerKWh = connectors[598].PricePerKWh,
                    TotalCost = Math.Round(7.89m * connectors[598].PricePerKWh, 2),
                    ConnectorId = connectors[598].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-07-30T08:05:25.243Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-07-30T09:07:37.243Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 15.50m,
                    AppliedPricePerKWh = connectors[600].PricePerKWh,
                    TotalCost = Math.Round(15.50m * connectors[600].PricePerKWh, 2),
                    ConnectorId = connectors[600].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-07-30T07:47:57.086Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-07-30T09:20:13.086Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 16.13m,
                    AppliedPricePerKWh = connectors[602].PricePerKWh,
                    TotalCost = Math.Round(16.13m * connectors[602].PricePerKWh, 2),
                    ConnectorId = connectors[602].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-07-31T17:29:34.296Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-07-31T18:22:32.296Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 14.80m,
                    AppliedPricePerKWh = connectors[604].PricePerKWh,
                    TotalCost = Math.Round(14.80m * connectors[604].PricePerKWh, 2),
                    ConnectorId = connectors[604].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-07-31T21:41:36.634Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-07-31T22:59:12.634Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 22.90m,
                    AppliedPricePerKWh = connectors[606].PricePerKWh,
                    TotalCost = Math.Round(22.90m * connectors[606].PricePerKWh, 2),
                    ConnectorId = connectors[606].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-08-01T23:00:51.643Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-08-02T00:47:44.643Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 17.53m,
                    AppliedPricePerKWh = connectors[608].PricePerKWh,
                    TotalCost = Math.Round(17.53m * connectors[608].PricePerKWh, 2),
                    ConnectorId = connectors[608].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-08-02T11:06:25.864Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-08-02T12:27:52.864Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 24.19m,
                    AppliedPricePerKWh = connectors[610].PricePerKWh,
                    TotalCost = Math.Round(24.19m * connectors[610].PricePerKWh, 2),
                    ConnectorId = connectors[610].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-08-02T17:07:20.790Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-08-02T18:03:20.790Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 12.78m,
                    AppliedPricePerKWh = connectors[611].PricePerKWh,
                    TotalCost = Math.Round(12.78m * connectors[611].PricePerKWh, 2),
                    ConnectorId = connectors[611].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-08-03T22:09:53.691Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-08-04T00:08:30.691Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 19.31m,
                    AppliedPricePerKWh = connectors[613].PricePerKWh,
                    TotalCost = Math.Round(19.31m * connectors[613].PricePerKWh, 2),
                    ConnectorId = connectors[613].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-08-03T23:57:27.442Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-08-04T01:13:36.442Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 11.88m,
                    AppliedPricePerKWh = connectors[615].PricePerKWh,
                    TotalCost = Math.Round(11.88m * connectors[615].PricePerKWh, 2),
                    ConnectorId = connectors[615].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-08-05T07:58:17.550Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-08-05T10:12:18.550Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 8.30m,
                    AppliedPricePerKWh = connectors[617].PricePerKWh,
                    TotalCost = Math.Round(8.30m * connectors[617].PricePerKWh, 2),
                    ConnectorId = connectors[617].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-08-06T04:12:20.165Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-08-06T05:54:00.165Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 15.38m,
                    AppliedPricePerKWh = connectors[619].PricePerKWh,
                    TotalCost = Math.Round(15.38m * connectors[619].PricePerKWh, 2),
                    ConnectorId = connectors[619].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-08-05T22:39:40.904Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-08-06T00:16:13.904Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 19.09m,
                    AppliedPricePerKWh = connectors[621].PricePerKWh,
                    TotalCost = Math.Round(19.09m * connectors[621].PricePerKWh, 2),
                    ConnectorId = connectors[621].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-08-06T20:47:04.833Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-08-06T21:57:02.833Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 20.60m,
                    AppliedPricePerKWh = connectors[623].PricePerKWh,
                    TotalCost = Math.Round(20.60m * connectors[623].PricePerKWh, 2),
                    ConnectorId = connectors[623].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-08-07T20:20:55.201Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-08-07T22:12:08.201Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 33.19m,
                    AppliedPricePerKWh = connectors[625].PricePerKWh,
                    TotalCost = Math.Round(33.19m * connectors[625].PricePerKWh, 2),
                    ConnectorId = connectors[625].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-08-07T23:42:08.482Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-08-08T01:24:14.482Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 8.55m,
                    AppliedPricePerKWh = connectors[627].PricePerKWh,
                    TotalCost = Math.Round(8.55m * connectors[627].PricePerKWh, 2),
                    ConnectorId = connectors[627].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-08-09T05:48:30.552Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-08-09T07:56:08.552Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 21.41m,
                    AppliedPricePerKWh = connectors[629].PricePerKWh,
                    TotalCost = Math.Round(21.41m * connectors[629].PricePerKWh, 2),
                    ConnectorId = connectors[629].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-08-10T00:04:29.459Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-08-10T01:22:50.459Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 13.52m,
                    AppliedPricePerKWh = connectors[631].PricePerKWh,
                    TotalCost = Math.Round(13.52m * connectors[631].PricePerKWh, 2),
                    ConnectorId = connectors[631].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-08-10T16:39:46.056Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-08-10T18:25:31.056Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 10.79m,
                    AppliedPricePerKWh = connectors[633].PricePerKWh,
                    TotalCost = Math.Round(10.79m * connectors[633].PricePerKWh, 2),
                    ConnectorId = connectors[633].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-08-11T10:00:10.827Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-08-11T11:53:14.827Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 33.85m,
                    AppliedPricePerKWh = connectors[635].PricePerKWh,
                    TotalCost = Math.Round(33.85m * connectors[635].PricePerKWh, 2),
                    ConnectorId = connectors[635].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-08-12T00:23:08.066Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-08-12T01:27:01.066Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 8.67m,
                    AppliedPricePerKWh = connectors[637].PricePerKWh,
                    TotalCost = Math.Round(8.67m * connectors[637].PricePerKWh, 2),
                    ConnectorId = connectors[637].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-08-12T08:03:07.589Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-08-12T09:16:43.589Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 8.78m,
                    AppliedPricePerKWh = connectors[639].PricePerKWh,
                    TotalCost = Math.Round(8.78m * connectors[639].PricePerKWh, 2),
                    ConnectorId = connectors[639].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-08-12T21:40:58.549Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-08-12T23:49:15.549Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 18.06m,
                    AppliedPricePerKWh = connectors[641].PricePerKWh,
                    TotalCost = Math.Round(18.06m * connectors[641].PricePerKWh, 2),
                    ConnectorId = connectors[641].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-08-13T17:50:21.728Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-08-13T19:36:15.728Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 31.36m,
                    AppliedPricePerKWh = connectors[643].PricePerKWh,
                    TotalCost = Math.Round(31.36m * connectors[643].PricePerKWh, 2),
                    ConnectorId = connectors[643].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-08-13T22:13:42.141Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-08-14T00:22:00.141Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 31.85m,
                    AppliedPricePerKWh = connectors[645].PricePerKWh,
                    TotalCost = Math.Round(31.85m * connectors[645].PricePerKWh, 2),
                    ConnectorId = connectors[645].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-08-14T14:21:15.539Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-08-14T16:13:58.539Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 28.57m,
                    AppliedPricePerKWh = connectors[647].PricePerKWh,
                    TotalCost = Math.Round(28.57m * connectors[647].PricePerKWh, 2),
                    ConnectorId = connectors[647].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-08-15T12:01:03.167Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-08-15T14:05:15.167Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 25.60m,
                    AppliedPricePerKWh = connectors[648].PricePerKWh,
                    TotalCost = Math.Round(25.60m * connectors[648].PricePerKWh, 2),
                    ConnectorId = connectors[648].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-08-15T23:27:54.768Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-08-16T01:41:19.768Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 13.23m,
                    AppliedPricePerKWh = connectors[650].PricePerKWh,
                    TotalCost = Math.Round(13.23m * connectors[650].PricePerKWh, 2),
                    ConnectorId = connectors[650].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-08-17T00:32:32.744Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-08-17T01:29:41.744Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 9.15m,
                    AppliedPricePerKWh = connectors[652].PricePerKWh,
                    TotalCost = Math.Round(9.15m * connectors[652].PricePerKWh, 2),
                    ConnectorId = connectors[652].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-08-18T01:27:17.979Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-08-18T02:51:46.979Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 24.94m,
                    AppliedPricePerKWh = connectors[654].PricePerKWh,
                    TotalCost = Math.Round(24.94m * connectors[654].PricePerKWh, 2),
                    ConnectorId = connectors[654].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-08-18T20:39:19.554Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-08-18T22:49:14.554Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 18.41m,
                    AppliedPricePerKWh = connectors[656].PricePerKWh,
                    TotalCost = Math.Round(18.41m * connectors[656].PricePerKWh, 2),
                    ConnectorId = connectors[656].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-08-18T17:07:30.792Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-08-18T18:47:47.792Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 28.70m,
                    AppliedPricePerKWh = connectors[658].PricePerKWh,
                    TotalCost = Math.Round(28.70m * connectors[658].PricePerKWh, 2),
                    ConnectorId = connectors[658].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-08-19T21:55:42.536Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-08-19T23:28:19.536Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 13.78m,
                    AppliedPricePerKWh = connectors[660].PricePerKWh,
                    TotalCost = Math.Round(13.78m * connectors[660].PricePerKWh, 2),
                    ConnectorId = connectors[660].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-08-19T21:57:34.648Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-08-19T23:47:43.648Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 20.98m,
                    AppliedPricePerKWh = connectors[662].PricePerKWh,
                    TotalCost = Math.Round(20.98m * connectors[662].PricePerKWh, 2),
                    ConnectorId = connectors[662].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-08-20T16:28:30.515Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-08-20T18:05:38.515Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 19.11m,
                    AppliedPricePerKWh = connectors[664].PricePerKWh,
                    TotalCost = Math.Round(19.11m * connectors[664].PricePerKWh, 2),
                    ConnectorId = connectors[664].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-08-21T21:54:24.589Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-08-21T22:51:21.589Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 7.03m,
                    AppliedPricePerKWh = connectors[666].PricePerKWh,
                    TotalCost = Math.Round(7.03m * connectors[666].PricePerKWh, 2),
                    ConnectorId = connectors[666].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-08-22T03:10:24.806Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-08-22T05:34:43.806Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 27.82m,
                    AppliedPricePerKWh = connectors[668].PricePerKWh,
                    TotalCost = Math.Round(27.82m * connectors[668].PricePerKWh, 2),
                    ConnectorId = connectors[668].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-08-23T00:21:25.266Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-08-23T02:09:14.266Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 31.93m,
                    AppliedPricePerKWh = connectors[670].PricePerKWh,
                    TotalCost = Math.Round(31.93m * connectors[670].PricePerKWh, 2),
                    ConnectorId = connectors[670].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-08-23T08:27:23.728Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-08-23T09:25:40.728Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 16.21m,
                    AppliedPricePerKWh = connectors[672].PricePerKWh,
                    TotalCost = Math.Round(16.21m * connectors[672].PricePerKWh, 2),
                    ConnectorId = connectors[672].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-08-24T14:03:06.252Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-08-24T14:53:41.252Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 11.08m,
                    AppliedPricePerKWh = connectors[674].PricePerKWh,
                    TotalCost = Math.Round(11.08m * connectors[674].PricePerKWh, 2),
                    ConnectorId = connectors[674].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-08-24T21:04:50.945Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-08-24T22:34:12.945Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 26.58m,
                    AppliedPricePerKWh = connectors[676].PricePerKWh,
                    TotalCost = Math.Round(26.58m * connectors[676].PricePerKWh, 2),
                    ConnectorId = connectors[676].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-08-25T20:05:59.214Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-08-25T22:29:30.214Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 17.94m,
                    AppliedPricePerKWh = connectors[678].PricePerKWh,
                    TotalCost = Math.Round(17.94m * connectors[678].PricePerKWh, 2),
                    ConnectorId = connectors[678].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-08-26T10:24:31.285Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-08-26T12:48:24.285Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 16.18m,
                    AppliedPricePerKWh = connectors[680].PricePerKWh,
                    TotalCost = Math.Round(16.18m * connectors[680].PricePerKWh, 2),
                    ConnectorId = connectors[680].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-08-27T10:43:18.670Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-08-27T12:30:26.670Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 22.11m,
                    AppliedPricePerKWh = connectors[682].PricePerKWh,
                    TotalCost = Math.Round(22.11m * connectors[682].PricePerKWh, 2),
                    ConnectorId = connectors[682].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-08-27T21:40:18.621Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-08-27T23:59:59.621Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 24.55m,
                    AppliedPricePerKWh = connectors[684].PricePerKWh,
                    TotalCost = Math.Round(24.55m * connectors[684].PricePerKWh, 2),
                    ConnectorId = connectors[684].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-08-28T12:31:32.984Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-08-28T14:21:25.984Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 7.36m,
                    AppliedPricePerKWh = connectors[685].PricePerKWh,
                    TotalCost = Math.Round(7.36m * connectors[685].PricePerKWh, 2),
                    ConnectorId = connectors[685].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-08-28T22:42:39.946Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-08-29T00:48:55.946Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 10.47m,
                    AppliedPricePerKWh = connectors[687].PricePerKWh,
                    TotalCost = Math.Round(10.47m * connectors[687].PricePerKWh, 2),
                    ConnectorId = connectors[687].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-08-29T08:42:52.877Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-08-29T10:43:43.877Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 33.75m,
                    AppliedPricePerKWh = connectors[689].PricePerKWh,
                    TotalCost = Math.Round(33.75m * connectors[689].PricePerKWh, 2),
                    ConnectorId = connectors[689].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-08-30T05:12:24.793Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-08-30T06:58:06.793Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 31.36m,
                    AppliedPricePerKWh = connectors[691].PricePerKWh,
                    TotalCost = Math.Round(31.36m * connectors[691].PricePerKWh, 2),
                    ConnectorId = connectors[691].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-08-31T07:30:39.056Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-08-31T09:22:44.056Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 20.94m,
                    AppliedPricePerKWh = connectors[693].PricePerKWh,
                    TotalCost = Math.Round(20.94m * connectors[693].PricePerKWh, 2),
                    ConnectorId = connectors[693].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-08-31T22:37:45.167Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-09-01T00:35:11.167Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 26.22m,
                    AppliedPricePerKWh = connectors[695].PricePerKWh,
                    TotalCost = Math.Round(26.22m * connectors[695].PricePerKWh, 2),
                    ConnectorId = connectors[695].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-09-01T13:47:08.616Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-09-01T15:03:44.616Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 15.28m,
                    AppliedPricePerKWh = connectors[697].PricePerKWh,
                    TotalCost = Math.Round(15.28m * connectors[697].PricePerKWh, 2),
                    ConnectorId = connectors[697].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-09-02T03:17:28.100Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-09-02T05:07:25.100Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 32.43m,
                    AppliedPricePerKWh = connectors[699].PricePerKWh,
                    TotalCost = Math.Round(32.43m * connectors[699].PricePerKWh, 2),
                    ConnectorId = connectors[699].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-09-02T13:07:18.984Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-09-02T15:10:53.984Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 11.98m,
                    AppliedPricePerKWh = connectors[701].PricePerKWh,
                    TotalCost = Math.Round(11.98m * connectors[701].PricePerKWh, 2),
                    ConnectorId = connectors[701].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-09-03T13:03:34.612Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-09-03T15:02:48.612Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 15.02m,
                    AppliedPricePerKWh = connectors[703].PricePerKWh,
                    TotalCost = Math.Round(15.02m * connectors[703].PricePerKWh, 2),
                    ConnectorId = connectors[703].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-09-03T23:20:26.141Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-09-04T01:00:22.141Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 25.17m,
                    AppliedPricePerKWh = connectors[705].PricePerKWh,
                    TotalCost = Math.Round(25.17m * connectors[705].PricePerKWh, 2),
                    ConnectorId = connectors[705].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-09-04T17:49:02.053Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-09-04T19:51:30.053Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 10.87m,
                    AppliedPricePerKWh = connectors[707].PricePerKWh,
                    TotalCost = Math.Round(10.87m * connectors[707].PricePerKWh, 2),
                    ConnectorId = connectors[707].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-09-04T22:49:38.020Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-09-05T00:25:53.020Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 22.73m,
                    AppliedPricePerKWh = connectors[709].PricePerKWh,
                    TotalCost = Math.Round(22.73m * connectors[709].PricePerKWh, 2),
                    ConnectorId = connectors[709].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-09-06T09:57:55.414Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-09-06T11:55:53.414Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 16.52m,
                    AppliedPricePerKWh = connectors[711].PricePerKWh,
                    TotalCost = Math.Round(16.52m * connectors[711].PricePerKWh, 2),
                    ConnectorId = connectors[711].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-09-06T18:01:08.342Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-09-06T19:58:58.342Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 24.33m,
                    AppliedPricePerKWh = connectors[713].PricePerKWh,
                    TotalCost = Math.Round(24.33m * connectors[713].PricePerKWh, 2),
                    ConnectorId = connectors[713].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-09-07T07:02:22.913Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-09-07T09:17:45.913Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 25.27m,
                    AppliedPricePerKWh = connectors[715].PricePerKWh,
                    TotalCost = Math.Round(25.27m * connectors[715].PricePerKWh, 2),
                    ConnectorId = connectors[715].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-09-07T23:04:41.911Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-09-08T01:28:43.911Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 6.45m,
                    AppliedPricePerKWh = connectors[717].PricePerKWh,
                    TotalCost = Math.Round(6.45m * connectors[717].PricePerKWh, 2),
                    ConnectorId = connectors[717].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-09-09T06:04:14.011Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-09-09T07:26:06.011Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 19.77m,
                    AppliedPricePerKWh = connectors[719].PricePerKWh,
                    TotalCost = Math.Round(19.77m * connectors[719].PricePerKWh, 2),
                    ConnectorId = connectors[719].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-09-09T13:19:45.634Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-09-09T15:17:45.634Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 24.28m,
                    AppliedPricePerKWh = connectors[721].PricePerKWh,
                    TotalCost = Math.Round(24.28m * connectors[721].PricePerKWh, 2),
                    ConnectorId = connectors[721].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-09-10T08:24:31.119Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-09-10T10:14:57.119Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 32.70m,
                    AppliedPricePerKWh = connectors[722].PricePerKWh,
                    TotalCost = Math.Round(32.70m * connectors[722].PricePerKWh, 2),
                    ConnectorId = connectors[722].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-09-11T03:48:13.259Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-09-11T06:00:26.259Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 27.16m,
                    AppliedPricePerKWh = connectors[724].PricePerKWh,
                    TotalCost = Math.Round(27.16m * connectors[724].PricePerKWh, 2),
                    ConnectorId = connectors[724].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-09-11T15:19:20.992Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-09-11T17:18:14.992Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 31.67m,
                    AppliedPricePerKWh = connectors[726].PricePerKWh,
                    TotalCost = Math.Round(31.67m * connectors[726].PricePerKWh, 2),
                    ConnectorId = connectors[726].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-09-12T06:53:45.224Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-09-12T08:22:23.224Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 26.18m,
                    AppliedPricePerKWh = connectors[728].PricePerKWh,
                    TotalCost = Math.Round(26.18m * connectors[728].PricePerKWh, 2),
                    ConnectorId = connectors[728].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-09-12T14:04:44.663Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-09-12T16:11:16.663Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 32.26m,
                    AppliedPricePerKWh = connectors[730].PricePerKWh,
                    TotalCost = Math.Round(32.26m * connectors[730].PricePerKWh, 2),
                    ConnectorId = connectors[730].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-09-13T03:07:32.777Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-09-13T05:30:07.777Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 9.15m,
                    AppliedPricePerKWh = connectors[732].PricePerKWh,
                    TotalCost = Math.Round(9.15m * connectors[732].PricePerKWh, 2),
                    ConnectorId = connectors[732].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-09-13T22:21:21.503Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-09-14T00:31:15.503Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 12.29m,
                    AppliedPricePerKWh = connectors[734].PricePerKWh,
                    TotalCost = Math.Round(12.29m * connectors[734].PricePerKWh, 2),
                    ConnectorId = connectors[734].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-09-14T23:49:41.254Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-09-15T01:40:51.254Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 28.24m,
                    AppliedPricePerKWh = connectors[736].PricePerKWh,
                    TotalCost = Math.Round(28.24m * connectors[736].PricePerKWh, 2),
                    ConnectorId = connectors[736].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-09-15T20:49:50.125Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-09-15T23:00:10.125Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 11.01m,
                    AppliedPricePerKWh = connectors[738].PricePerKWh,
                    TotalCost = Math.Round(11.01m * connectors[738].PricePerKWh, 2),
                    ConnectorId = connectors[738].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-09-16T14:43:38.513Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-09-16T16:21:19.513Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 21.08m,
                    AppliedPricePerKWh = connectors[740].PricePerKWh,
                    TotalCost = Math.Round(21.08m * connectors[740].PricePerKWh, 2),
                    ConnectorId = connectors[740].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-09-16T21:02:14.637Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-09-16T23:05:29.637Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 29.31m,
                    AppliedPricePerKWh = connectors[742].PricePerKWh,
                    TotalCost = Math.Round(29.31m * connectors[742].PricePerKWh, 2),
                    ConnectorId = connectors[742].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-09-17T06:02:42.223Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-09-17T07:41:26.223Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 20.43m,
                    AppliedPricePerKWh = connectors[744].PricePerKWh,
                    TotalCost = Math.Round(20.43m * connectors[744].PricePerKWh, 2),
                    ConnectorId = connectors[744].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-09-17T17:17:36.471Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-09-17T19:29:36.471Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 18.22m,
                    AppliedPricePerKWh = connectors[746].PricePerKWh,
                    TotalCost = Math.Round(18.22m * connectors[746].PricePerKWh, 2),
                    ConnectorId = connectors[746].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-09-19T06:00:33.828Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-09-19T08:16:12.828Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 8.45m,
                    AppliedPricePerKWh = connectors[748].PricePerKWh,
                    TotalCost = Math.Round(8.45m * connectors[748].PricePerKWh, 2),
                    ConnectorId = connectors[748].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-09-19T20:00:25.250Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-09-19T21:23:31.250Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 20.74m,
                    AppliedPricePerKWh = connectors[750].PricePerKWh,
                    TotalCost = Math.Round(20.74m * connectors[750].PricePerKWh, 2),
                    ConnectorId = connectors[750].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-09-20T01:18:05.229Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-09-20T03:16:19.229Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 29.82m,
                    AppliedPricePerKWh = connectors[752].PricePerKWh,
                    TotalCost = Math.Round(29.82m * connectors[752].PricePerKWh, 2),
                    ConnectorId = connectors[752].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-09-21T02:35:32.346Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-09-21T04:34:51.346Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 22.16m,
                    AppliedPricePerKWh = connectors[754].PricePerKWh,
                    TotalCost = Math.Round(22.16m * connectors[754].PricePerKWh, 2),
                    ConnectorId = connectors[754].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-09-21T22:46:04.387Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-09-22T01:16:24.387Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 18.02m,
                    AppliedPricePerKWh = connectors[756].PricePerKWh,
                    TotalCost = Math.Round(18.02m * connectors[756].PricePerKWh, 2),
                    ConnectorId = connectors[756].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-09-22T08:39:37.805Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-09-22T10:16:21.805Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 24.11m,
                    AppliedPricePerKWh = connectors[758].PricePerKWh,
                    TotalCost = Math.Round(24.11m * connectors[758].PricePerKWh, 2),
                    ConnectorId = connectors[758].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-09-22T13:26:17.462Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-09-22T15:18:20.462Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 31.40m,
                    AppliedPricePerKWh = connectors[759].PricePerKWh,
                    TotalCost = Math.Round(31.40m * connectors[759].PricePerKWh, 2),
                    ConnectorId = connectors[759].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-09-23T17:40:43.094Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-09-23T19:04:56.094Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 11.68m,
                    AppliedPricePerKWh = connectors[761].PricePerKWh,
                    TotalCost = Math.Round(11.68m * connectors[761].PricePerKWh, 2),
                    ConnectorId = connectors[761].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-09-24T10:14:38.318Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-09-24T11:43:07.318Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 13.46m,
                    AppliedPricePerKWh = connectors[763].PricePerKWh,
                    TotalCost = Math.Round(13.46m * connectors[763].PricePerKWh, 2),
                    ConnectorId = connectors[763].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-09-24T13:25:25.522Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-09-24T14:56:27.522Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 27.02m,
                    AppliedPricePerKWh = connectors[765].PricePerKWh,
                    TotalCost = Math.Round(27.02m * connectors[765].PricePerKWh, 2),
                    ConnectorId = connectors[765].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-09-25T17:02:08.434Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-09-25T18:48:30.434Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 7.27m,
                    AppliedPricePerKWh = connectors[767].PricePerKWh,
                    TotalCost = Math.Round(7.27m * connectors[767].PricePerKWh, 2),
                    ConnectorId = connectors[767].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-09-26T15:38:17.611Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-09-26T17:28:56.611Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 32.89m,
                    AppliedPricePerKWh = connectors[769].PricePerKWh,
                    TotalCost = Math.Round(32.89m * connectors[769].PricePerKWh, 2),
                    ConnectorId = connectors[769].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-09-27T00:32:08.648Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-09-27T02:24:14.648Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 15.61m,
                    AppliedPricePerKWh = connectors[771].PricePerKWh,
                    TotalCost = Math.Round(15.61m * connectors[771].PricePerKWh, 2),
                    ConnectorId = connectors[771].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-09-27T01:35:36.656Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-09-27T04:02:51.656Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 22.56m,
                    AppliedPricePerKWh = connectors[773].PricePerKWh,
                    TotalCost = Math.Round(22.56m * connectors[773].PricePerKWh, 2),
                    ConnectorId = connectors[773].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-09-28T06:55:30.710Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-09-28T08:20:58.710Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 11.02m,
                    AppliedPricePerKWh = connectors[775].PricePerKWh,
                    TotalCost = Math.Round(11.02m * connectors[775].PricePerKWh, 2),
                    ConnectorId = connectors[775].Id
                },

                new ChargingSession
                {
                    StartedAt = DateTime.Parse("2026-09-28T14:14:35.844Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EndedAt = DateTime.Parse("2026-09-28T16:24:15.844Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    EnergyKWh = 31.28m,
                    AppliedPricePerKWh = connectors[777].PricePerKWh,
                    TotalCost = Math.Round(31.28m * connectors[777].PricePerKWh, 2),
                    ConnectorId = connectors[777].Id
                }

            ];

            context.ChargingSessions.AddRange(chargingSessions);
            context.SaveChanges();
        }
    }
}