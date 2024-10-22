import React from 'react'
import { useState, useContext } from 'react';
import ProductContext from '../../context/StockContext'
import { useNavigate } from 'react-router-dom';
 
const CreateProduct = () => {
    const navigate = useNavigate();

    const { postAddProducts } = useContext(ProductContext)

    const [name, setName] = useState("")
    const [price, setPrice] = useState("")
    const [stock, setStock] = useState("")
    const [category, setCategory] = useState("")
 
   const changeName=(event)=>{
        setName(event.target.value)
    }
    const changePrice=(event)=>{
        setPrice(event.target.value)
    }
    const changeStock=(event)=>{
      setStock(event.target.value)
  }
  const changeCategory=(event)=>{
    setCategory(event.target.value)
}
    const submitForm=async (event)=>{
        event.preventDefault()
        
        await postAddProducts(name,price,stock,category)
 
        setName("")
        setPrice("")
        setStock("")
        setCategory("")

        navigate('/products')
    }
  return (
    <div>
      <h2>New Product</h2>
      <form className='w-25 m-auto '>
        <div className="mb-3">
          <label className="form-label">Product Name</label>
          <input  className="form-control" value={name} onChange={changeName} />
        </div>
        <div className="mb-3">
          <label className="form-label">Price</label>
          <input  className="form-control"value={price} onChange={changePrice}/>
        </div>
        <div className="mb-3">
          <label className="form-label">Stock</label>
          <input  className="form-control"value={stock} onChange={changeStock}  />
        </div>
        <div className="mb-3">
          <label className="form-label">Category</label>
          <input  className="form-control" type="text" value={category} onChange={changeCategory}  />
        </div>
       
        <button type="submit"  className="btn btn-primary" onClick={submitForm}>Submit</button>
      </form>
    </div>
  )
}
 
export default CreateProduct