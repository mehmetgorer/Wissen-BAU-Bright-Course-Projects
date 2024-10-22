//Öncelikle package.json dosyasını oluşturuyoruz.
// >npm init -y

//Expressjs kurulumunu gerçekleştiriyoruz.
// >npm i express --save

const express = require('express');

const app = express();
const port = 3000;

app.get('/products', (req, res) => {
    res.send('<h2>Product List</h2>');
})

app.get('/', (req, res) => {
    res.send('<h2>Welcome ExpressJs</h2>');
})

app.listen(port, () => {
    console.log(`${port} nolu port dinleniyor...`);
})
