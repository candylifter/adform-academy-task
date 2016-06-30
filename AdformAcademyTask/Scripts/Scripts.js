//Get needed DOM elements
var button = document.getElementById('get-cars');
var carsEl = document.getElementById('cars');
var isMakingAjaxCall = false;

//Bind onclick event when document is ready
$(document).ready(function () {
    button.onclick = function (e) {
        e.preventDefault();

        //Allow user to only click button once
        if (!isMakingAjaxCall) {
            isMakingAjaxCall = true;

            $.ajax({
                url: '/Cars/getCars',
                dataType: 'json',
                method: 'GET',
                success: function (resp) {
                    //Pass JSON array to render data to DOM. On callback set button attribute to disabled and set bool to false 
                    renderCarsToDom(resp.carList, function () {
                        button.setAttribute('disabled', true);
                        isMakingAjaxCall = false;
                    });
                },
                error: function (xhr, ajaxOptions, thrownError) {
                    //Error handling when request fails
                    console.error('Error while getting carList: ' + xhr.status + ', ' + thrownError);
                    isMakingAjaxCall = false;
                }

            });
        }

    
    }
});

//Render data to DOM
function renderCarsToDom(cars, callback) {
    cars.map(function (car) {
        $(carsEl).append(jsonToHtml(car));
    });

    callback();
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

