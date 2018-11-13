var request = new XMLHttpRequest();

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



//var url = 'https://api.giphy.com/v1/stickers/translate?api_key=XXXYourKeyHereXXX&s=lobster';
//$.ajax({
  //  dataType: "json",
    //url: 'https://api.giphy.com/v1/stickers/translate?api_key=XXXYourKeyHereXXX&s=lobster'
    //success: function () { Console.log("success")},
    //error: function () { Console.log("not success")},
//});