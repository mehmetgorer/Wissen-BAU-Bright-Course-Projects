const express = require('express')

const Product = require('../models/product')

exports.getProducts=(req,res,next)=>{
    Product.find()
    // .populate('category', 'name') //İlişkili tablodan foreign key'e karşılık verileri çeker.
    .then(products=>{
        res.json(products)
    })
    .catch(err => {
        res.json({message:'Ürün bulunamadı!'})
    })  
}

exports.getProductsByAggregate = (req, res, next) => {
    // Product.aggregate([
    //     {
    //         $match: {price: {$gte:5000}}
    //     },
    //     {
    //         $project: {
    //             name: 1,
    //             price: 1,
    //             category: 1
    //         }
    //     },{
    //         $group: {
    //             _id: '$category',
    //             toplamAdet: {$sum: 1}
    //         }
    //     }
    // ])
    // .then(data => {
    //     res.json(data)
    // })
    Product.aggregate([
        { //relation olsun olmasın 2 collection arasında join sağlar.
            $lookup: {
                from: 'categories',  //2. collection
                localField: 'category',
                foreignField: '_id',
                as: 'Kategori' //sonuçların gösterileceği başlık
            }
        },
        {
            $unwind: '$category' //ilişkili tablodaki verileri çekiyor.
        }
    ])
    .then(data => {
        res.json(data)
    })
}

exports.postProduct=(req,res,next)=>{
    const {name,price,stock,imageUrl,category} = req.body
    const product = new Product({
        name:name,
        price:price,
        stock:stock,
        imageUrl:imageUrl,
        category:category
    })
    product.save()
    .then((product)=>{
        res.json(product)
    })
    .catch(err=>{
        res.json({message:'Ürün kayıt edilemedi'})
    })  
}

exports.putProductById = (req, res, next) => {
    Product.findByIdAndUpdate(req.body.id, req.body, {
        new: true //Güncellenen yeni datayı döndürür
    })
    .then( product => {
        res.json(product)
    })
    .catch(err=>{
        res.json({message:'Ürün güncellenemedi'})
    }) 
}

exports.deleteProductById = (req, res, next) =>{
    Product.findByIdAndDelete(req.params.id)
    .then(product=>{
        res.json(product)
    })
    .catch(err => {
        res.json({message:'Ürün silinemedi!'})
    })
}

exports.getProductById = (req, res, next) =>{
    Product.findById(req.params.id)
    .then(product=>{
        res.json(product)
    })
    .catch(err => {
        res.json({message:'Ürün bulunamadı!'})
    })
}







