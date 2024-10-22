import React, { createContext, useContext } from "react";
import axios from 'axios'
import { useState } from 'react';
import { useNavigate } from "react-router-dom";


const userContext = createContext();

export const UserProvider = ({children}) => {
    const [users, setUsers] = useState([])
    const [user, setUser] = useState({})

    const navigate = useNavigate();

    const getUsers = async() => {
      const response = await axios.get('http://localhost:3000/users')
      setUsers(response.data)
    }
    const getUserById = async (id) => {
        const response = await axios.get(`http://localhost:3000/users/${id}`);
        setUser(response.data); 
        // navigate('editProduct')
    };

    const postRegister = async(name, surname, email, password) => {
    const response = await axios.post('http://localhost:3000/users/register', {
      name,
      surname,
      email,
      password
    })
    // getUsers();
  }
  const postLogin = async(email, password) => {
    const response = await axios.post('http://localhost:3000/users/login', {
      email,
      password
    })
    localStorage.setItem('token', response.data)
    //console.log(localStorage.getItem('token'));
    navigate('/products');
    // getUsers();
  }

  const sharedUsers = {
    users,
    user,
    getUsers,
    getUserById,
    postRegister,
    postLogin
  }

    return(
        <userContext.Provider value={sharedUsers}>
            {children}
        </userContext.Provider>
    )
}


export default userContext;