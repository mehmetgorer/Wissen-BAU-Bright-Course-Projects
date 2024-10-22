const express = require('express');

const app = express();
const port = 3000;

const bodyParser = require('body-parser');
app.use(bodyParser.urlencoded({extended:false}));

//post ile request body'de gönderilen bilgileri elde edebilmek için body-parser kullanmalıyız.

//use hem get hem post kabul ettiğinden aynı zamanda method filtrelemesi de yapması için GET ve POST tercih ediyoruz.
app.get('/addUser', (req, res, next) => {
    // if(req.method === "GET")
    res.send(`
        <html>
            <head><title>bodyParser</title></head>
            <body>
                <form action="addUser" method="POST">
                    <input type="text" name="username">
                    <input type="submit" value="Save">
                </form>
            </body>
        </html>
    `);
})

app.post('/addUser', (req, res, next) => {
    console.log(req.body);
    res.redirect('/');
})

app.use('/', (req, res, next) => {
    res.send('<h2>Anasayfa</h2>');
})

app.listen(port, () => {
    console.log(`${port} nolu port dinleniyor...`);
})
