/*var request = new XMLHttpRequest();

request.onreadystatechange = handleResponse;

request.open('GET', 'https://api.giphy.com/v1/stickers/translate?api_key=XXXYourKeyHereXXX&s=lobster', true);

request.send();

function handleResponse(word) {
    if (request.readyState == 4 && request.status == 200) {
        Console.log("Everything has completed");
        var response = JSON.parse(request.responseText);
        alert(response.ip);
    }
}
*/


// Callback function registered on a button. get words from user input and send an async request to server, requesting sticker
$("#sub").click(function () {
    //#words is text input id name in View
    //Get user input value
    var word = $("#words").val();
    console.log(word);

    $.ajax({
        type: "GET",
        url: 'https://api.giphy.com/v1/stickers/translate?api_key=XXXYourKeyHereXXX&s=lobster',
        success: display,
        error: error
    });

});


function display(data) {
    console.log(data);

    //$("#Message").text(data["message"]);  #Message is id name in View


}

function error() {
    console.log("error");
}
