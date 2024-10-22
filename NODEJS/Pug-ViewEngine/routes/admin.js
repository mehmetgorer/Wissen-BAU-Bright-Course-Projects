//express router işlemlerinde öncelikle bir router oluşturup, bunu exports ile dışarıya açıyoruz.
const express = require('express')
const router = express.Router();

const bodyParser = require('body-parser');
router.use(bodyParser.urlencoded({extended:false}));

const path = require('path');

router.get('/addUser', (req, res, next) => {
    // res.send(`
    //     <html>
    //         <head><title>bodyParser</title></head>
    //         <body>
    //             <form action="addUser" method="POST">
    //                 <input type="text" name="username">
    //                 <input type="submit" value="Save">
    //             </form>
    //         </body>
    //     </html>
    // `);
    res.sendFile(path.join(__dirname, '../views', 'addUser.html'));
})

router.post('/addUser', (req, res, next) => {
    console.log(req.body);
    res.redirect('/');
})

module.exports = router;    //router global nesne (public) oluyor.