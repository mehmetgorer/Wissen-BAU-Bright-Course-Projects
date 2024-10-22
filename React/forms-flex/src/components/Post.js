import React from 'react'

const Post = ({post , onDelete}) => {

const deletePost=()=>{
  const title= post.title
  onDelete(title)
  
}

  return (
    <div className='post-border'>
          <label className='post-label'>Başlık</label>
          <input value={post.title} className='post-input' />
          <label className='post-label'>İçerik</label>
          <textarea value={post.content} className='post-input' row={5} />
          <div>
            <button className='post-button' onClick={deletePost}>Post Sil</button>
            <button className='post-button'>Güncelle</button>
          </div>
    </div>
  )
}

export default Post