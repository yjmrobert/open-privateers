// noinspection JSVoidFunctionReturnValueUsed

export function initMap() {
    const map = L.map('map', {
        crs: L.CRS.Simple,
        minZoom: -4,
    });

    const imageUrl = "https://openprivateersstorage.blob.core.windows.net/opa-images/intel-bg_1000x1000.jpg";

    const bounds = [[0, 0], [9000, 9000]];
    const image = L.imageOverlay(imageUrl, bounds).addTo(map);

    map.fitBounds(bounds);

    // fetch the csv and then parse it into an array of objects
    // the first row is the header row
    fetch('https://docs.google.com/spreadsheets/d/e/2PACX-1vTpf5Z045PpXZ4vNsxS5YijkpwJVt3jmp1PNR3e7qfcvtzK3_UzoRTASUJ1iQh2hq9ZxEBmWU8t4qj0/pub?gid=0&single=true&output=csv')
        .then(response => response.text())
        .then(text => {
            // split the text into lines
            // replace \r\n with \n to handle mac/linux
            text = text.replace('\r\n', '\n');
            const lines = text.split('\n');
            console.log(lines);
            lines.forEach(function (item, index) {
                if (index == 0) return; // skip the header row
                let cols = item.split(',');
                
                // parse as an integer and add 0.5
                let x = parseInt(cols[1], 10) + 0.5;
                let y = parseInt(cols[2], 10) + 0.5;
                
                L.marker([x,y])
                    .bindPopup(cols[0])
                    .addTo(map);
            });
        });

    var options = {interval: 20,
        redraw: 'move',
        hidden: false,
        zoomIntervals: [
            {start: -4, end: -2, interval: 1000},
            {start: -2, end: 0, interval: 100},
            
            {start: 0, end: 2, interval: 10},
            // {start: 4, end: 5, interval: 5},
            // {start: 6, end: 20, interval: 1}
        ]
    };

    L.simpleGraticule(options).addTo(map);

    map.setView([4500, 4500], 0);

}



