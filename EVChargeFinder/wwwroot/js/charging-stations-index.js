const stations = JSON.parse(
    document.getElementById('stationsData').textContent
);

const mapElement = document.getElementById('stationsMap');

const mapboxToken = mapElement.dataset.mapboxToken;

const map = L.map('stationsMap')
    .setView(
        [
            42.7339,
            25.4858
        ],
        7
    );

L.tileLayer(
    `https://api.mapbox.com/styles/v1/mapbox/streets-v12/tiles/512/{z}/{x}/{y}?access_token=${mapboxToken}`,
    {
        tileSize: 512,
        zoomOffset: -1,
        maxZoom: 22,
        attribution: '© Mapbox © OpenStreetMap'
    })
    .addTo(map);


const locateButton = document.getElementById('locateUserButton');

let userLocationMarker = null;

locateButton.addEventListener('click', function () {

    navigator.geolocation.getCurrentPosition(
        function (position) {

            const userLatitude = position.coords.latitude;
            const userLongitude = position.coords.longitude;

            if (userLocationMarker === null) {

                userLocationMarker = L.marker([
                    userLatitude,
                    userLongitude
                ])
                .addTo(map)
                .bindPopup('Your location');
            }
            else {

                userLocationMarker.setLatLng([
                    userLatitude,
                    userLongitude
                ]);
            }

            map.flyTo(
                [
                    userLatitude,
                    userLongitude
                ],
                14
            );

            userLocationMarker.openPopup();
        },
        function (error) {

            console.log(error);
        }
    );
});


                stations.forEach(station => {

    let pinColor = "#6c757d";

    if (station.ChargingType === "AC") {
        pinColor = "#2ecc71";
    }
    else if (station.ChargingType === "DC") {
        pinColor = "#f59e0b";
    }
    else if (station.ChargingType === "AC/DC") {
        pinColor = "#0d6efd";
    }

    const powerValue = Number(station.MaxPowerKw);

    const displayPower =
        Number.isInteger(powerValue)
            ? powerValue.toString()
            : powerValue.toFixed(1);

    const typeFontSize =
        station.ChargingType === "AC/DC"
            ? 11
            : 13;

    const chargingTypeText =
        station.ChargingType === "AC/DC"
            ? `
                <tspan x="30" y="50">AC</tspan>
                <tspan x="30" y="61">DC</tspan>
              `
            : `
                <tspan x="30" y="56">
                    ${station.ChargingType}
                </tspan>
              `;

    const stationIcon = L.divIcon({
        className: 'charging-station-marker',

        html: `
            <svg
                width="60"
                height="82"
                viewBox="0 0 60 82"
                xmlns="http://www.w3.org/2000/svg">

                <defs>
                    <filter
                        id="pinShadow-${station.Id}"
                        x="-40%"
                        y="-30%"
                        width="180%"
                        height="190%">

                        <feDropShadow
                            dx="2"
                            dy="3"
                            stdDeviation="2"
                            flood-color="#000"
                            flood-opacity="0.45"/>
                    </filter>
                </defs>

                <path
                    d="
                        M 30 2
                        C 14 2, 4 13, 4 28
                        C 4 40, 10 48, 16 56
                        L 30 79
                        L 44 56
                        C 50 48, 56 40, 56 28
                        C 56 13, 46 2, 30 2
                        Z
                    "
                    fill="#171717"
                    filter="url(#pinShadow-${station.Id})"
                />

                <circle
                    cx="30"
                    cy="27"
                    r="21"
                    fill="${pinColor}"
                />

                <circle
                    cx="30"
                    cy="27"
                    r="17"
                    fill="#eeeeea"
                />

                <text
                    x="30"
                    y="24"
                    text-anchor="middle"
                    dominant-baseline="middle"
                    font-size="12"
                    font-weight="900"
                    fill="#202020">

                    ${displayPower}

                </text>

                <text
                    x="30"
                    y="35"
                    text-anchor="middle"
                    dominant-baseline="middle"
                    font-size="7"
                    font-weight="800"
                    fill="#333333">

                    kW

                </text>

                <text
                    x="30"
                    text-anchor="middle"
                    dominant-baseline="middle"
                    font-size="${typeFontSize}"
                    font-weight="900"
                    fill="#ffffff">

                    ${chargingTypeText}

                </text>

            </svg>
        `,

        iconSize: [60, 82],
        iconAnchor: [30, 79],
        popupAnchor: [0, -76]
    });

    const marker = L.marker(
        [
            station.Latitude,
            station.Longitude
        ],
        {
            icon: stationIcon
        }
    );

    marker.addTo(map);

    marker.bindPopup(`
        <div style="min-width: 210px;">

            <strong
                style="
                    font-size: 14px;
                    color: #172033;
                ">
                ${station.Name}
            </strong>

            <br>

            <span
                style="
                    color: #64748b;
                    font-size: 12px;
                ">
                ${station.Operator}
            </span>

            <br><br>

            ${station.City ?? ""}

            <br>

            ${station.Address}

            <br><br>

            <strong>
                ${station.ChargingType}
                ·
                ${displayPower} kW
            </strong>

            <br><br>

            <a href="/ChargingStations/Details/${station.Id}">
                View details
            </a>

        </div>
    `);
});