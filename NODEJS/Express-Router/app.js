const express = require('express')

const app = express();      //createServer gerçekleşiyor.
const port = 3000;

const adminRoutes = require('./routes/admin');
const userRoutes = require('./routes/user');

const path = require('path');

app.use('/admin', adminRoutes);
app.use(userRoutes);

//css, img gibi dosyaları koyduğumuz klasörü expres'e static klasör olarak tanımlıyoruz.
app.use(express.static(path.join(__dirname, 'public')));

//Yukarıdaki hiçbir route çalışmazsa program buraya gelir.
app.use((req, res) => {
    // res.status(404).send('<h2>Page Not Found - 404</h2>')
    //Dosya görüntülemek için dosyanın yolunu gösteren bir path tanımlamalıyız.

    res.status(404).sendFile(path.join(__dirname, 'views', '404.html'));
})

app.listen(port, () => {
    console.log(`${port} dinleniyor...`);
})