import React, { useContext } from "react";
import ProductContext from "../context/StockContext";
import { useNavigate } from "react-router-dom";

const Home = () => {
  const { products } = useContext(ProductContext);
  const navigate = useNavigate()
  
  return (
    <div className="row">
      {(products.length>0)?"":<h2>Herhangi bir ürün bulunamadı</h2>}
      {products.map((product, index) => {
        return (
          
            <div className="col-md-4">
              <div className="card my-2 bg-success">
                <div className="card-title text-white fs-3">{product.name}</div>
                <div className="card-image">
                  <img src={product.imageUrl} width="200px"  />
                </div>
                <div className="card-text text-white p-2">
                  Fiyat: {product.price} ₺
                </div>
              </div>
            </div>
          
        );
      })}
    </div>
  );
};

export default Home;
