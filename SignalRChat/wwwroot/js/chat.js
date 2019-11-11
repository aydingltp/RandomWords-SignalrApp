"use strict";

var connection = new signalR.HubConnectionBuilder()
    .withUrl("/hubclass")
    .build();

connection.start().then(function () {

   // document.getElementById("sendButton").disabled = false;
    //console.log(connection.connectionId);
    //console.log(saniye);
    document.getElementById("gun").replaceWith(gun);
    document.getElementById("saat").replaceWith(saat);
    document.getElementById("dakika").replaceWith(dakika);
    document.getElementById("saniye").replaceWith(saniye);
    console.log(connection.connectionId)


}).catch(function (err) {
    return console.error(err.toString());
});
//var hub = connection.someHub;
//connection.connectionId
// After connection is started
//console.log(connection.connectionId)
//Disable send button until connection is established
//document.getElementById("sendButton").disabled = true;

connection.on("Zaman", function (gun, saat, dakika, saniye) {
    console.log(saniye);
    document.getElementById("gun").replaceWith(gun);
    document.getElementById("saat").replaceWith(saat);
    document.getElementById("dakika").replaceWith(dakika);
    document.getElementById("saniye").replaceWith(saniye);  
});



//document.getElementById("sendButton").addEventListener("click", function (event) {
//    var user = document.getElementById("userInput").value;
//    var message = document.getElementById("messageInput").value;
//    connection.invoke("SendMessage", user, message).catch(function (err) {
//        return console.error(err.toString());
//    });
//    event.preventDefault();
//});