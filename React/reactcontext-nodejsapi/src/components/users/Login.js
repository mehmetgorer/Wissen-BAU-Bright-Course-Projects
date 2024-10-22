import React from 'react'
import { useState, useContext } from 'react';
import UserContext from '../../context/AuthContext'
import ProductContext from '../../context/StockContext'


const Login = () => {

    const { postLogin } = useContext(UserContext)
    const {getProducts} = useContext(ProductContext);
    
    const [email, setEmail] = useState("")
    const [password, setPassword] = useState("")

    const changeEmail=(event)=>{
        setEmail(event.target.value)
    }
    const changePassword=(event)=>{
        setPassword(event.target.value)
    }

    const submitForm = async (event) => {
        event.preventDefault();
        await postLogin(email, password)
        await getProducts();
    }

  return (
    <div>
    <h2>Login</h2>
    <form className='w-25 m-auto '>
      <div className="mb-3">
        <label className="form-label">E-mail</label>
        <input type='email' className="form-control" onChange={changeEmail}/>
      </div>
      <div className="mb-3">
        <label className="form-label">Password</label>
        <input type='password' onChange={changePassword} className="form-control"/>
      </div>
      <button type="submit"  className="btn btn-primary" onClick={submitForm}>Submit</button>
    </form>
  </div>
  )
}

export default Login