//IIFE (Immediately Invoked Function Expression)
// var controllerA = (function(exports, require, __dirname, __filename){


var age = 20;           //private
var lastName = "Uçar";   //lastName başlangıçta private değişken

var sendMessage = function(message){
    console.log(message);
}

module.exports.lastName = lastName;  //artık global (public) değişken
module.exports.send = sendMessage;




// })();    //(IIFE)