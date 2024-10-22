import { StyleSheet, Text, View, TouchableOpacity } from "react-native";
import React from "react";
import { auth } from "../firebase";
import { useNavigation } from "@react-navigation/native";

export default function HomeScreen() {
  const navigation = useNavigation();

  const handleLogout = () => {
    auth.signOut().then(() => {
      navigation.navigate("Login");
    });
  };
  return (
    <View style={styles.container}>
      <View style={styles.buttonContainer}>
        <Text style={styles.text}>{auth.currentUser?.email}</Text>
        <TouchableOpacity style={styles.button} onPress={handleLogout}>
          <Text style={styles.buttonText}>Log Out</Text>
        </TouchableOpacity>
      </View>
    </View>
  );
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    alignItems: "center",
    justifyContent: "center",
  },
  text:
  {
    fontSize: 16,
    alignSelf: 'center',
    marginBottom: 20
  },
  buttonContainer: {
    width: "60%",
    marginTop: 40,
  },
  button: {
    backgroundColor: "#0782F9",
    padding: 15,
    alignItems: "center",
    borderRadius: 10,
    marginBottom: 10,
  },
  buttonText: {
    color: "white",
    fontSize: 16,
  },
});
