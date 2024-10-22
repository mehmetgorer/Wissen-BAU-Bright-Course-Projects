import React, { createContext } from "react";
import axios from 'axios'
import { useState } from 'react';
import { useNavigate } from "react-router-dom";


const productContext = createContext();

export const Provider = ({children}) => {
    const [products, setProducts] = useState([])
    const [product, setProduct] = useState({})

    const navigate = useNavigate();

    const getProducts = async() => {
      const token = localStorage.getItem('token');
      // debugger
      if (token){
        const response = await axios.get('http://localhost:3000/api/products', {headers : {'access-token' : token}})
        // console.log(response.data);
        setProducts(response.data);
      }
      else{
        navigate('/login');
      }
    }
  const getProductById = async (id) => {
      const response = await axios.get(`http://localhost:3000/api/products/${id}`);
        setProduct(response.data); 
        // navigate('editProduct')
  };

  const postAddProducts = async(name, price, stock, category) => {
    const response = await axios.post('http://localhost:3000/api/products', {
      name,
      price,
      stock,
      category
    })
    getProducts();
    // navigate(-1) -> geldiği sayfaya döner.
  }

  const updateProduct = async (updatedProduct) => {
    const response = await axios.put('http://localhost:3000/api/products',updatedProduct) 
     getProducts();   
  };

  const deleteProduct = async (productId) => {
    const response = await axios.delete(`http://localhost:3000/api/products/${productId}`);
     getProducts();   
  };
  
  const sharedProducts = {
    products,
    product,
    getProducts,
    getProductById,
    postAddProducts,
    updateProduct,
    deleteProduct
  }

    return(
        <productContext.Provider value={sharedProducts}>
            {children}
        </productContext.Provider>
    )
}



export default productContext;