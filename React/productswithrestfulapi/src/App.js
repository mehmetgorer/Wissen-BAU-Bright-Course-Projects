import './App.css';
import { Routes, Route } from 'react-router-dom'
import Home from './components/Home'
import ProductList from './components/ProductList'
import CreateProduct from './components/CreateProduct'
import Navbar from './components/Navbar';
import axios from 'axios'
import { useEffect, useState } from 'react';
import { useNavigate } from 'react-router-dom';
import EditProduct from './components/EditProduct';

function App() {

  const navigate = useNavigate();

  const [products, setProducts] = useState([])
  const [product, setProduct] = useState({})

  useEffect(() => {   //Sayfa ilk yüklendiğinde çalışır.
    getProducts();
  }, [])

  useEffect(() => {   //sayfa ilk yüklendiğinde ve products state'i her değiştiğinde çalışır.
    navigate('/products')

  }, [products])
  
  const getProducts = async() => {
    const response = await axios.get('http://localhost:3002/products')
    // console.log(response.data);
    setProducts(response.data)
  }

  const postProducts = async(name, price, stock, category) => {
    const response = await axios.post('http://localhost:3002/products', {
      name,
      price,
      stock,
      category
    })
    getProducts();
    // navigate(-1) -> geldiği sayfaya döner.
  }
  const getProductById = async (id) => {
    const response = await axios.get(`http://localhost:3002/products/${id}`);
    setProduct(response.data); 
    navigate('editProduct')
  };

  const updateProduct = async (updatedProduct) => {
    const response = await axios.put(`http://localhost:3002/products/${updatedProduct.id}`,updatedProduct); 
     getProducts();   
  };

  const deleteProduct = async(productId) => {
    const response = await axios.delete(`http://localhost:3002/products/${productId}`)
    getProducts();
  }

  return (
    <div className="App">
        <Navbar />
        <br></br>
        <Routes>
          <Route path="/" element={<Home />} />
          <Route path="/products" element={<ProductList products = {products} onDelete={deleteProduct} editProduct={getProductById} />} />
          <Route path="/addProduct" element={<CreateProduct addProducts={postProducts}/>} />
          <Route path="/editProduct" element={<EditProduct  product={product} updateProduct={updateProduct} />} />
        </Routes>
    </div>
  );
}

export default App;
