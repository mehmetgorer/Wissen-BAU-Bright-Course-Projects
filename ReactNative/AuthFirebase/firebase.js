// import { initializeApp } from "firebase/app";

import firebase from 'firebase/compat/app'
import 'firebase/compat/auth'
// Your web app's Firebase configuration
const firebaseConfig = {
  apiKey: "AIzaSyAeQdDTWjibfEQhi2ukt1nb_Y8J93weK74",
  authDomain: "authfirebase-efa90.firebaseapp.com",
  projectId: "authfirebase-efa90",
  storageBucket: "authfirebase-efa90.appspot.com",
  messagingSenderId: "1001093281302",
  appId: "1:1001093281302:web:02f0bbaa6afba23a2e6737"
};

// Initialize Firebase
// const app = initializeApp(firebaseConfig);
if(!firebase.apps.length) {
    firebase.initializeApp(firebaseConfig)
}

const auth = firebase.auth();

export {auth};