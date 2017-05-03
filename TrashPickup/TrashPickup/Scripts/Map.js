    $(document).ready(function () { 
        Initialize(); 
    }); 
 
    function Initialize() { 
        google.maps.visualRefresh = true; 
        var Wisconsin = new google.maps.LatLng(43.7844, 88.7879); 
 
        var mapOptions = { 
            zoom: 8, 
            center: Wisconsin, 
            mapTypeId: google.maps.MapTypeId.G_NORMAL_MAP 
    }; 
 
    var map = new google.maps.Map(document.getElementById("map_canvas"), mapOptions); 
 
    // you can either make up a JSON list server side, or call it from a controller using JSONResult 
    var data = [ 
              { "Id": 1, "PlaceName": "Zaghouan", "GeoLong": "36.401081", "GeoLat": "10.16596" }, 
              { "Id": 2, "PlaceName": "Hammamet ", "GeoLong": "36.4", "GeoLat": "10.616667" }, 
              { "Id": 3, "PlaceName": "Sousse", "GeoLong": "35.8329809", "GeoLat": "10.63875" }, 
              { "Id": 4, "PlaceName": "Sfax", "GeoLong": "34.745159", "GeoLat": "10.7613" } 
    ]; 
 
    $.each(data, function (i, item) { 
        var marker = new google.maps.Marker({ 
            'position': new google.maps.LatLng(item.GeoLong, item.GeoLat), 
            'map': map, 
            'title': item.PlaceName 
        }); 

        marker.setIcon('http://maps.google.com/mapfiles/ms/icons/blue-dot.png') 

        // put in some information about each json object - in this case, the opening hours. 
        var infowindow = new google.maps.InfoWindow({ 
            content: "<div class='infoDiv'><h2>" + item.PlaceName + "</div></div>" 
        });

        google.maps.event.addListener(marker, 'click', function () { 
            infowindow.open(map, marker); 
        }); 
    }) 
    }