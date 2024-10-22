const jwt = require('jsonwebtoken');

module.exports = (req, res, next) => {
    const secret_key='private Secret Key'
    //gelen token bilgisini alıyoruz.
    const token = req.headers['access-token'] || req.body.token || req.query.token;
    if(token){
        jwt.verify(token, secret_key, (err, decoded) => {
            if(err){
                res.json('token eşleşmedi!')
            }
            else{
                req.decodeToken = decoded; //request header'a yazıyoruz.
                next();
            }
        });
    }
    else{
        res.json('token bulunamadı!')
    }    

}