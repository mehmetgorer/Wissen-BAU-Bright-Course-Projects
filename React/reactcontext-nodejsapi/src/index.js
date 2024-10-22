import React from "react";
import ReactDOM from "react-dom/client";
import "./index.css";
import App from "./App";
import reportWebVitals from "./reportWebVitals";
import { UserProvider, userProvider } from "./context/AuthContext";
import { Provider } from "./context/StockContext";
import { BrowserRouter } from "react-router-dom";

const root = ReactDOM.createRoot(document.getElementById("root"));
root.render(
  <BrowserRouter>
    <UserProvider>
      <Provider>
        <App />
      </Provider>
    </UserProvider>
  </BrowserRouter>
);

reportWebVitals();
