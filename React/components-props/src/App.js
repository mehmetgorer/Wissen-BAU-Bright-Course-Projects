import './App.css';
import Card from './Card';
import RccComponent from './RccComponent';
import RfcComponent from './RfcComponent';
import ReactImage from './images/ReactJS.png';
import AngularImage from './images/angularjs.png';
import NodejsImage from './images/nodejs.png';
import VuejsImage from './images/vuejs.jpeg';

function App() {
  return (
    <div className="App">
      <div className='container mt-2'>
        <h1 className='bg-success text-white text-center mt-10 p-3 rounded-3'>YAZILIM EĞİTİMLERİ</h1>
        <div className='row'>
            <div className='col-md-4'>
              <Card title='React' description='Reactjs içinde parent componentten child componente Props ile veri aktarımı...' image={ReactImage}/>
            </div>
            <div className='col-md-4'>
              <Card title='Angular' description='Angularjs içinde formlarda one-binding ve two-binding kullanımı...' image={AngularImage}/>
            </div>
            <div className='col-md-4'>
              <Card title='Nodejs' description='Nodejs ile artık backend server side javascript kodu yazabilirsiniz...' image={NodejsImage}/>
            </div>
            <div className='col-md-4'>
              <Card title='Vuejs' description='Vuejs, frontend tarafında populer javascript framework avantajı...' image={VuejsImage}/>
            </div>
        </div>
      </div>

        {/* <h2>Component Yapısı</h2>
        <RfcComponent title='React' description='Reactjs Props veri aktarımı' image={ReactImage} />
        <br></br>
        <RccComponent /> */}
    </div>
  );
}

export default App;
