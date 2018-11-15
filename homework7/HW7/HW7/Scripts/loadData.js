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


var api = "http://api.giphy.com/v1/gifs/translate?";
var apiKey = "&api_key=gMrqiddCIe001wwIeLKG0llVIXfOKmh9";
var picurl = "";

// Callback function registered on a button. get words from user input and send an async request to server, requesting sticker
$("#words").keyup(function (e) {
    if (e.key == " ") {
        //Get user input value
        var words = $("#words").val();
        // parsing to a list of words
        var wArray = words.split(" ");
        // get the last word after each space pressed
        var word = wArray[wArray.length - 2];
        // show word as debug
        console.log('"'+word+'"');


        var s = "/Translator/Translate/" + word;
        var url = api + apiKey + s;

        $.ajax({
            type: "GET",
            url: s,
            success: getSticker,
            error: error
        });
    }
 
});


function getSticker(data) {
    var url = api + apiKey + "&s=" + data["message"];

    $.ajax({
        url: url,
        Type: "GET",
        success: display,
        error: error
    });

    function display(e) {

        $("#Message").append(e["message"] + " ");
        $("#Typeof").append(typeof (e) + " ");
        $("#Type").append(e["data"]["type"] + " ");
        picurl = e["data"]["images"]["fixed_width"]["url"]
        $("#PicURL").append(e["data"]["images"]["fixed_width"]["url"] + "  ");
        $("#ShowPic").attr("src", picurl);
    }

}

function error(e) {
    console.log(e);
}
