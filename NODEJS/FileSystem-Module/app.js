const fs = require('fs');

//Klasördeki dosyaları listelemek fs.readdir()

// const files = fs.readdir('./', function(err, data){
//     if(err)
//         console.log(err);
//     else    
//         console.log(data);
// });

//Dosya içeriği görüntülemek fs.readFile()
// const file = fs.readFile('./index.html', 'utf8',function(err, data){
//     if(err)
//         console.log(err);
//     else    
//         console.log(data);
// });

//Yeni dosya oluşturmak fs.writeFile()
// fs.writeFile('yenidosya.txt', 'Dosya yoksa yeni oluşturur, varsa yeniden baştan oluşturur.', function(err){
//     if(err)
//         console.log(err);
//     else
//         console.log('yeni dosya oluşturuldu.');
// });

//Mevcut dosyayı yenilemeden ekleme yapmak fs.appendFile()
// fs.appendFile('eskidosya.txt', 'Dosya yoksa yeni oluşturur, varsa mevcut dataya ekleme yapar.'

// fs.appendFile('eskidosya.txt', 'Bu data da eski içeriğe eklenir.', function(err){
//     if(err)
//         console.log(err);
//     else
//         console.log('dosyaya eklendi.');
// });

//Mevcut dosyayı tamamen silmek fs.unlink()
// fs.unlink('yenidosya.txt', function(error){
//     console.log('dosya silindi.');
// });

//Dosya ismi değiştirmek fs.rename()
fs.rename('eskidosya.txt', 'yenidosya.txt', function(error){
    console.log('dosya ismi değiştirildi.');
});
