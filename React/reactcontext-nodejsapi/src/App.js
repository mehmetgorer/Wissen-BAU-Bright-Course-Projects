import './App.css';
import { Routes, Route } from 'react-router-dom'
import { useEffect, useContext } from 'react';
import ProductContext from './context/StockContext'
import Navbar from './components/Navbar';
import ProductList from './components/products/ProductList';
import Home from './components/Home';
import EditProduct from './components/products/EditProduct';
import CreateProduct from './components/products/CreateProduct';
import Login from './components/users/Login';


function App() {
  const {getProducts} = useContext(ProductContext);
  // const [products, setProducts] = useState([])

  // const getProducts = async() => {
  //   const response = await axios.get('http://localhost:3000/api/products')
  //   console.log(response.data);
  //   setProducts(response.data)
  // }
  useEffect(() => {
    getProducts()

  }, [])
  
  return (
    <div className="App">
          <Navbar/>
          <Routes>
          <Route path="/" element={<Home />} />
          <Route path="/products" element={<ProductList />} />
          <Route path="/addProduct" element={<CreateProduct />} />
          <Route path="/editProduct" element={<EditProduct />} />
          <Route path="/addProduct" element={<CreateProduct />} />
          <Route path="/login" element={<Login />} />
          </Routes>
    </div>
  );
}

export default App;
