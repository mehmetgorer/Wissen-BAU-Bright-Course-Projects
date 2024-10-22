const path = require('node:path');

let result = path.resolve('app.js')

result = path.extname('app.js');

result = path.parse(__filename);

console.log(result);

console.log(result.base, result.name, result.ext);

console.log(result.root);

console.log(__filename); //bulunduğumuz dosyanın tam yolunu ve adını verir.
console.log(__dirname);  //bulunduğumuz dosyanın tam yolunu verir.
