//Geting elements from page
const elems = document.querySelectorAll(".carousel-images img");
const but_next = document.querySelector(".carousel-next");
const but_prev = document.querySelector(".carousel-prev");
const frame = document.querySelector(".frame");

const step = elems[0].clientWidth;
const count = elems.length;

var position = 0;

animate();

but_next.addEventListener('click', () => {
    if (position < step * (count - 2)) position += step;
    animateFrame()
    animate();
});

but_prev.addEventListener('click', () => {
    if (position > -step) position -= step;
    animateFrame()
    animate();
});

function animate() {
    elems.forEach((item) => { item.style.transform = `translateX(${-position}px) scale(0)` })
    var index = position / step;
    //If you are at the beginning of a carousel, disable animation left
    if (index === -1) {
        elems[0].style.transform = `translateX(${-position}px) scale(1)`;
        elems[1].style.transform = `translateX(${-position}px) scale(0.65)`;
    } else {
        elems[index].style.transform = `translateX(${-position}px) scale(0.65)`;
        elems[index + 1].style.transform = `translateX(${-position}px) scale(1)`;
        //If you are at the end of a carousel, disable animation right
        if (index < count - 2)
        elems[index + 2].style.transform = `translateX(${-position}px) scale(0.65)`;
    }
}

//Animate frame after button click
function animateFrame()
{
    frame.style.transform = `scale(1.08)`;
    frame.style.opacity = `0.5`;
    setTimeout(() => { frame.style.transform = `scale(1)`; frame.style.opacity = `1`; }, 500)
}

google.maps.event.addDomListener(window, 'load', init);

function init() {
    // Basic options for a simple Google Map
    // For more options see: https://developers.google.com/maps/documentation/javascript/reference#MapOptions
    var mapOptions = {
        // How zoomed in you want the map to start at (always required)
        zoom: 17,

        // The latitude and longitude to center the map (always required)
        center: new google.maps.LatLng(49.2389092, 28.4600767), // New York

        // How you would like to style the map.
        // This is where you would paste any style found on Snazzy Maps.
        styles: [{ "featureType": "administrative", "elementType": "labels.text.fill", "stylers": [{ "color": "#444444" }] }, { "featureType": "landscape", "elementType": "all", "stylers": [{ "color": "#f2f2f2" }] }, { "featureType": "poi", "elementType": "all", "stylers": [{ "visibility": "off" }] }, { "featureType": "road", "elementType": "all", "stylers": [{ "saturation": -100 }, { "lightness": 45 }] }, { "featureType": "road.highway", "elementType": "all", "stylers": [{ "visibility": "simplified" }] }, { "featureType": "road.arterial", "elementType": "labels.icon", "stylers": [{ "visibility": "off" }] }, { "featureType": "transit", "elementType": "all", "stylers": [{ "visibility": "off" }] }, { "featureType": "water", "elementType": "all", "stylers": [{ "color": "#46bcec" }, { "visibility": "on" }] }]
    };

    // Get the HTML DOM element that will contain your map
    // We are using a div with id="map" seen below in the <body>
    var mapElement = document.getElementById('map');

    // Create the Google Map using our element and options defined above
    var map = new google.maps.Map(mapElement, mapOptions);

    // Let's also add a marker while we're at it
    var marker = new google.maps.Marker({
        position: new google.maps.LatLng(49.2391062, 28.4613573),
        map: map,
        title: 'Snazzy!'
    });
}