import "./App.css";
import { useState } from "react"; //Hooks -> useState
import Card from "./Card";
import AngularImage from "./images/angularjs.png";
import NodeJsImage from "./images/nodejs.png";
import ReactJsImage from "./images/ReactJS.png";
import VueJsImage from "./images/vuejs.jpeg";

const educations = [
  { title: "Reactjs", image: ReactJsImage },
  { title: "VueJs", image: VueJsImage },
  { title: "AngularJs", image: AngularImage },
  { title: "NodeJs", image: NodeJsImage },
];

function App() {
  // const [value, setValue] = useState(0)

  // const tikla = () => {
  //   // alert('buton tıklandı!')
  //   // setValue(1);
  //   setValue(value + 1);
  // }

  const [cards, setCards] = useState([]);

  const addRandomEducations = () => {
    setCards([...cards, getRandomEducations()]);
    //SPREAD SYNTAX Burada ...cards dizinin elemanlarının mevcut değerlerini ekler.
  };

  const getRandomEducations = () => {
    const randomIndex = Math.floor(Math.random() * educations.length);
    return educations[randomIndex];
  };

  return (
    // SPREAD SYNTAX  (...Dizi, 25) Dizinin önceki değerlerini eleman olarak verir.

    <div className="App">
      <button className="btn btn-success" onClick={addRandomEducations}>
        Random Eğitim Ekle
      </button>
      <div className="row">
        
        {
          // educations.map((education, index) => {
          // return <Card key={index} title={education} />
          //})

          cards.map((education, index) => {
            return <Card key={index} education={education} />;
          })
         

          // {/* <h1>State Kullanımı</h1>
          // <button onClick={tikla}>Tıklayın</button>
          // <div>{value}</div> */}
        }
      </div>
    </div>
  );
}

export default App;
