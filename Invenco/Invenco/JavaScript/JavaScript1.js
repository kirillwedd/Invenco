window.addEventListener('DOMContentLoaded', (event) => {
    navigator.geolocation.getCurrentPosition((position) => {
        var message = {
            Latitude: position.coords.latitude,
            Longitude: position.coords.longitude
        };
        window.chrome.webview.postMessage(JSON.stringify(message));
    });
});