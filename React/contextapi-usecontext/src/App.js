import "./App.css";
import Users from "./components/Users";
import AuthContext from "./context/Auth-Context";
import { useState } from "react";

function App() {
  const [AuthStatus, setAuthStatus] = useState(false)

  const loginCheck = () => {
    // alert('tıklandı.')
    AuthStatus ? setAuthStatus(false) : setAuthStatus(true)
  }
  return (
    <div className="App">
      <h2>Context-API</h2>
      <AuthContext.Provider value={{isAuthenticated:AuthStatus, user:{id:1, name:"Ali Uçar"}, isLogin: loginCheck}}>
        <Users />
      </AuthContext.Provider>
    </div>
  );
}

export default App;
