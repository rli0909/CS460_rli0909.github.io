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
var word = "";

//var BoringWords = ["i", "you"];

// Callback function registered on a button. get words from user input and send an async request to server, requesting sticker
$("#words").keyup(function (e) {
    if (e.key == " ") {
        //Get user input value
        var words = $("#words").val();
        // parsing to a list of words
        var wArray = words.split(" ");
        // get the last word after each space pressed
        word = wArray[wArray.length - 2];
        // show word as debug
        console.log('"'+word+'"');


        var s = "/Translator/Translate/" + word;

        $.ajax({
            type: "GET",
            url: s,
            success: display,
            error: error
        });
    }
 
});

function handleData(e) {

}

function getNoun(e) {
    
}

function display(e) {
    console.log(e);
    $("#Message").append(word + " ");
    // get images url

    //var WordPOS = require('wordpos');
    //wordpos = new WordPOS();

    // how to get a list of nouns...
    var ignoreWords = ["I", "am", "a"];
    if (ignoreWords.includes(word)) {
        picurl = e["data"]["images"]["fixed_height_small"]["url"];
        // append each picture
        $("#ShowPic").append("<img src=\"" + picurl + "\"" + ">" + "  ");
    } else {
        $("#ShowPic").append(word + " ");
    }

  

}
    

function error() {
    console.log("error");
}
