import './App.css';
import {Routes, Route} from 'react-router-dom'
import Home from './components/Home'
import About from './components/About'
import Contact from './components/Contact'
import Navbar from './components/Navbar';

function App() {
  return (
    <div className="App">
        {/* <h1>React Routing</h1> */}
        <Navbar />
        <br></br>
        <Routes>
          <Route path="/" element={<Home />} />
          <Route path="/about" element={<About />} />
          <Route path="/contact" element={<Contact />} />
        </Routes>
    </div>
  );
}

export default App;
