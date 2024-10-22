const express = require('express')
const router = express.Router();

const path = require('path');

router.get('/about', (req, res, next) => {
    // res.send('<h2>Hakkımızda</h2>');
    res.sendFile(path.join(__dirname, '../views', 'about.html'));
})

router.get('/', (req, res, next) => {
    // res.send('<h2>Anasayfa</h2>');
    res.sendFile(path.join(__dirname, '../views', 'index.html'));
})


module.exports = router;