import React from 'react'
import AuthContext from "../context/Auth-Context";
import { useContext } from 'react';

const Users = () => {
  const {isAuthenticated, user, isLogin} = useContext(AuthContext);
  return (
    <div>
        {
            isAuthenticated ? <p>hoşgeldin {user.name}</p> : <p>Lütfen giriş yapınız</p>
        }
        <button onClick={isLogin}>Login</button>
    </div>
  )
}

export default Users