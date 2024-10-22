const url = require('node:url');

const address = "https://www.example.com/users?name=ali&age=22";

let result = url.parse(address, true);

console.log(result);

console.log(result.host);
console.log(result.protocol);
console.log(result.query.age);

