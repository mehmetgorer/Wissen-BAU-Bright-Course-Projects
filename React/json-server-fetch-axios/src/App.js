import './App.css';
import { useState } from 'react';
import axios from 'axios'

function App() {

const [posts, setPosts] = useState([])

const getPostsWithFetch = async () => {
  const response = await fetch('http://localhost:3002/posts')
  .then((response) => response.json())

  console.log(response);

  setPosts(response);
}

const getPostsWithAxios = async () => {
  const response = await axios.get('http://localhost:3002/posts')

  console.log(response.data);
  setPosts(response.data)
}

const postPostsWithAxios = async (title, author) => {
  title = 'react hooks';
  author = 'hasan kaya';
  const response = await axios.post('http://localhost:3002/posts', {
    title,
    author
  })

  console.log(response.data);
}

const putPostWithAxios = async (title, author, id) => {
  id=5;
  title = 'react state management';
  author = 'ayşe coşar';
  const response = await axios.put(`http://localhost:3002/posts/${id}`, {
    title,
    author
  })
  console.log(response.data);
}

const deletePostWithAxios = async (id) => {
  id=5;
  const response = await axios.delete(`http://localhost:3002/posts/${id}`)
  console.log(response.data);
}

  return (
    <div className="App">
        <h3>json-server restful fake api</h3>
        <button onClick={getPostsWithFetch}>Get Posts - Fetch</button>
        <button onClick={getPostsWithAxios}>Get Posts - Axios</button>
        <button onClick={postPostsWithAxios}>Post Posts - Axios</button>
        <button onClick={putPostWithAxios}>Put Posts - Axios</button>
        <button onClick={deletePostWithAxios}>Delete Posts - Axios</button>
    </div>
  );
}

export default App;
