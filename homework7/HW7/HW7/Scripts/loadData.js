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
$("#words").keyup(function (e) {
    if (e.key == " ") {
        //Get user input value
        var words = $("#words").val();
        // parsing
        var wArray = words.split(" ");
        var word = wArray[wArray.length - 2];

        console.log('"'+word+'"');

        $.ajax({
            type: "GET",
            url: '/Translator/Translate/' + word,
            success: display,
            error: error
        });
    }
 
});


function display(data) {
    $("#Message").append(data["message"] + " "); 


}

function error(e) {
    console.log(e);
}
