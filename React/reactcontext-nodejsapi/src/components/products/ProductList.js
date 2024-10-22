import React from "react";
import { useEffect, useContext } from "react";
import ProductContext from "../../context/StockContext";
import EditProduct from "./EditProduct";
import { useNavigate } from "react-router-dom";

const ProductList = () => {
  const { products, getProductById, deleteProduct} = useContext(ProductContext);
  const navigate = useNavigate();

  const editingProduct = async (productId) => {
    await getProductById(productId);
    navigate("/editProduct");
  };
  const deletingProduct = async (productId) => {
    await deleteProduct(productId)
  };
  return (
      <div>
         {(products.length<=0)?<h2>Herhangi bir ürün bulunamadı</h2>:
        <table className="table table-striped w-75 m-auto mt-5">
          <thead>
            <th>Id</th>
            <th>Name</th>
            <th>Price</th>
            <th>Stock</th>
            <th>Category</th>
            <th></th>
          </thead>
          <tbody>
            {products.map((product, index) => {
              return (
                <tr key="index">
                  <td>{product._id}</td>
                  <td>{product.name}</td>
                  <td>{product.price}</td>
                  <td>{product.stock}</td>
                  <td>{product.category}</td>
                  <td>
                    <button
                      className="btn btn-danger me-3"
                      onClick={() => editingProduct(product._id)}
                    >
                      Edit
                    </button>
                    <button className="btn btn-danger" onClick={() => deletingProduct(product._id)}>Delete</button>
                  </td>
                </tr>
              );
            })}
          </tbody>
        </table>
        }
      </div>
  );
};

export default ProductList;
