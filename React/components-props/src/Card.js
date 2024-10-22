import React from 'react'

const Card = ({title, description, image}) => {
  return (
    <div className= 'card my-2 bg-success'>
        <div className='card-title text-white fs-3'>
            {title}
        </div>
        <div className='card-image'>
            <img src={image} alt={title} width="300px" height="150px" />
        </div>
        <div className='card-text text-white p-2'>
            {description}
        </div>
    </div>
  )
}

export default Card