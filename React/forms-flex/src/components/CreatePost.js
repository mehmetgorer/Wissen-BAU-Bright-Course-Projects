import React from 'react'
import {useState} from 'react'

const CreatePost = ({onCreate}) => {

const [title, setTitle] = useState('')
const [content, setContent] = useState('')

const changeTitle = (event) => {
    setTitle(event.target.value);
}

const changeContent = (event) => {
    setContent(event.target.value);
}

const submitForm = (event) => {
    event.preventDefault();

    onCreate(title, content);

    setTitle('')
    setContent('')
}
  return (
    <div>
        <h3>Yeni Post</h3>
        <div className='post-body'>
            <form className='post-form'>
                <label className='post-label'>Başlık</label>
                <input value={title} className='post-input' onChange={changeTitle} />
                <label className='post-label'>İçerik</label>
                <textarea value={content} className='post-input' row={5}  onChange={changeContent}/>
                <button className='post-button' onClick={submitForm}>Kaydet</button>
            </form>
        </div>
    </div>
  )
}

export default CreatePost