import React, { useState, useEffect } from "react";


const EditProduct = ({ product, updateProduct }) => {

    const [name, setName] = useState(product.name);
    const [price, setPrice] = useState(product.price);
    const [stock, setStock] = useState(product.stock);
    const [category, setCategory] = useState(product.category);
  
    const changeName = (event) => {
        setName(event.target.value);
      };
    const changePrice = (event) => {
        const newPrice = parseInt(event.target.value,10);
        setPrice(newPrice);
      };
    const changeStock = (event) => {
        const newStock = parseInt(event.target.value, 10);
        setStock(newStock);
      };
    const changeCategory = (event) => {
        setCategory(event.target.value);
      };
    
    const productUpdate=()=>{
        const updatedProduct={
            id:product.id, name, price, stock, category
        }
        updateProduct(updatedProduct)
      }
 
  return (
    <div className="container mt-4 col-md-4">
      <h2>Create Product</h2>
      <form>
        <div className="mb-3">
          <label className="form-label">
            Name:
          </label>
          <input
            type="text"
            className="form-control"
            value={name}           
            onChange={changeName}
            required
          />
        </div>
        <div className="mb-3">
          <label  className="form-label">
            Price:
          </label>
          <input
            type="number"
            className="form-control"       
            value={price}
            onChange={changePrice}
            required
          />
        </div>
        <div className="mb-3">
          <label   className="form-label">
            Stock:
          </label>
          <input
            type="number"
            className="form-control"
            value={stock}      
            onChange={changeStock}
            required
          />
        </div>
        <div className="mb-3">
          <label  className="form-label">
            Category:
          </label>
          <input
            type="text"
            className="form-control"
            value={category}      
            onChange={changeCategory}
            required
          />
        </div>
        <button type="submit" className="btn btn-primary"   onClick={productUpdate}>
          Update Product
        </button>
      </form>
    </div>
  );
};


export default EditProduct