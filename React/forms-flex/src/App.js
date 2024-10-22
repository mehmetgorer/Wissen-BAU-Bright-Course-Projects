import './App.css';
import CreatePost from './components/CreatePost';
import ListPosts from './components/ListPosts';
import { useState } from 'react';

function App() {

const [posts, setPosts] = useState([])  

const addPosts = (title, content) => {
  const post = {
    title, content
  }
  setPosts([...posts, post]);
}
const removePost=(title)=>{
   const newPosts= posts.filter(post=>post.title !== title)
   setPosts(newPosts)
}

  return (
    <div className="App">
        <h2>Post İşlemleri</h2>

        <CreatePost onCreate = {addPosts} /> 
        <ListPosts posts = {posts} onDelete={removePost}/>


        
         
      {/* <h1>Flex-Box Kullanımı</h1>
      <div className="genel">
          <div className="box">1</div>
          <div className="box">2</div>
          <div className="box">3</div>
          <div className="box">1</div>
          <div className="box">2</div>
          <div className="box">3</div>
          <div className="box">1</div>
          <div className="box">2</div>
          <div className="box">3</div>
          <div className="box">1</div>
          <div className="box">2</div>
          <div className="box">3</div>

      </div> */}
    </div>
  );
}

export default App;
