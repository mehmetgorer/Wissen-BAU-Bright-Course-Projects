const events = require('events');

const eventEmitter = new events.EventEmitter();

//event tetiklendiğinde çalışacak bir listener tanımlıyoruz (on veya addListener)
// eventEmitter.on('unauthorize', function(){
//     console.log("yetkiniz yok");
// });

eventEmitter.on('unauthorize', function(code){
    console.log(`yetkiniz doğrulanamadı : ${code}`);
});

//once ile tanımlanırsa sadece bir defa emit yapılabilir.
eventEmitter.once('forbidden', function(code){
    console.log(`işlem için yetkiniz yok : ${code}`);
});

if(true)
    eventEmitter.emit('unauthorize', '401');


if(true)
    eventEmitter.emit('forbidden', '403');

if(true)
    eventEmitter.emit('unauthorize', '401');


if(true)
    eventEmitter.emit('forbidden', '401');