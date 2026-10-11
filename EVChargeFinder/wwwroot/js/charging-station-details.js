const mapElement = document.getElementById('stationMap');

const stationLatitude = parseFloat(mapElement.dataset.latitude);
const stationLongitude = parseFloat(mapElement.dataset.longitude);

const stationName = mapElement.dataset.name;
const stationAddress = mapElement.dataset.address;

const mapboxToken = mapElement.dataset.mapboxToken;


const map = L.map('stationMap')
    .setView(
        [
            stationLatitude,
            stationLongitude
        ],
        15
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


const marker = L.marker(
    [
        stationLatitude,
        stationLongitude
    ])
    .addTo(map);


marker.bindPopup(`
    <strong>${stationName}</strong>
    <br>
    ${stationAddress}
`);


requestAnimationFrame(() => {
    map.invalidateSize();
});


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
                15
            );


            userLocationMarker.openPopup();

        },

        function (error) {

            console.log(error);

        }

    );

});