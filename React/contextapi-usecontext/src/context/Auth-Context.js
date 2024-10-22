import React from 'react'

const authContext = React.createContext({
    isAuthenticated : false,
    user: null,
    isLogin: () => {}
});


export default authContext;