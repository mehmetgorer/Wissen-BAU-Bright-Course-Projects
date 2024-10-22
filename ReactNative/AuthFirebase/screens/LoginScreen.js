import { StyleSheet, Text, TextInput, TouchableOpacity, View } from "react-native";
import React, {useEffect, useState} from "react";
import {auth} from '../firebase'
import { useNavigation } from "@react-navigation/native";

export default function LoginScreen() {
 const navigation = useNavigation()

  const [email, setEmail] = useState('')
  const [password, setPassword] = useState('')

  useEffect(() => {
    auth.onAuthStateChanged((user) => {
      if(user) {
          navigation.navigate('Home')
      }
    })
  },[])

  const handleLogin = () => {
    auth
    .signInWithEmailAndPassword(email, password)
    .then(userCredentials => {
      const user = userCredentials.user;
      console.log("kullanıcı giriş yaptı. ", user.email)
    })
  }
  const handleSignUp = () => {
    auth
      .createUserWithEmailAndPassword(email, password)
      .then(userCredentials => {
        const user = userCredentials.user;
        console.log(user.email)
      })
  }
  return (
    <View style={styles.container}>
      <View style={styles.textContainer}>
        <TextInput style={styles.text} placeholder="email" onChangeText={(item) => setEmail(item)} />
        <TextInput style={styles.text} placeholder="password" onChangeText={setPassword} secureTextEntry/>
      </View>
      <View style={styles.buttonContainer}>
      <TouchableOpacity style={styles.button} onPress={handleLogin}>
        <Text style={styles.buttonText}>Login</Text>
      </TouchableOpacity>
      <TouchableOpacity style={[styles.button, styles.buttonOutline]} onPress={handleSignUp}>
      <Text style={styles.outlineText}>Sign Up</Text>
      </TouchableOpacity>
      </View>
    </View>
  );
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    alignItems: 'center',
    justifyContent: 'center'
  },
  textContainer: {
    width: '80%'
  },
  text: {
    backgroundColor: 'lightgray',
    paddingHorizontal: 15,
    paddingVertical: 10,
    marginTop: 5,
    borderRadius: 10,
    fontSize: 14
  },
  buttonContainer: {
    width: '60%',
    marginTop: 40,
  },  
  button: {
    backgroundColor: '#0782F9',
    padding: 15,
    alignItems: 'center',
    borderRadius: 10,
    marginBottom: 10
  },
  buttonText: {
    color: 'white',
    fontSize: 16
  },
  buttonOutline: {
    backgroundColor: 'white',
    borderWidth: 1,
    borderColor: '#0782F9'
  },
  outlineText: {
    color: '#0782F9',
    fontSize: 16
  }
});
