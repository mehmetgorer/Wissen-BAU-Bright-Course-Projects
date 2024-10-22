import { StyleSheet, Text, View, Button } from "react-native";
import React from "react";

const HomeScreen = ({ navigation }) => {
  return (
    <View style={{ flex: 1, alignItems: "center", justifyContent: "center" }}>
      <Text style={styles.title}>Home Page</Text>
      <View style={{ marginVertical: 5 }}>
        <Button
          title="Go to Courses"
          onPress={() => navigation.navigate("Courses")}
        />
      </View>
      <View style={{ marginVertical: 5 }}>
        <Button
          title="Go to Courses Content"
          onPress={() => navigation.navigate("CoursesContent")}
        />
      </View>
    </View>
  );
};

export default HomeScreen;

const styles = StyleSheet.create({
  title: {
    fontSize: 25,
    color: "blue",
    marginVertical: 20,
  },
});
