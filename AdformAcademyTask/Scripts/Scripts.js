//Get needed DOM elements
var button = document.getElementById('get-cars');
var carsEl = document.getElementById('cars');

//Bind onclick event when document is ready
$(document).ready(function () {
    button.onclick = function (e) {
        e.preventDefault();
        button.setAttribute('disabled', true);

        $.ajax({
            url: '/Cars/getCars',
            dataType: 'json',
            success: function (resp) {
                renderCarsToDom(resp.carList);
            },
            error: function (xhr, ajaxOptions, thrownError) {
                console.error('Error while getting carList: ' + xhr.status + ', ' + thrownError);
            }

        });
    }
});

//Render 
function renderCarsToDom(cars) {
    cars.map(function (car) {
        $(carsEl).append(jsonToHtml(car));
    });
}

//Convert from JSON object to HTML element string
function jsonToHtml(jsonData) {
    var htmlData = '<li class="car"><div class="image"><img src="' +
                    jsonData.imgUrl +
                    '" alt="Photo of ' +
                    jsonData.id + jsonData.model + '" /></div>' +
                   '<div class="description"><p class="model"><span class="light-text">Model:</span> ' +
                    jsonData.model +
                   '</p><p class="year"><span class="light-text">Years:</span> ' +
                    jsonData.year +
                    '</p><p class="ration"><span class="light-text">Ration:</span> ' +
                    jsonData.ration + '</p></div></li>';

    return htmlData;
}

