import { Button, StyleSheet, Text, View } from "react-native";
import React, { useReducer } from "react";

const reducer = (state, action) => {
  // console.log(action);
  switch (action.type) {
    case "increment":
      return { count: state.count + action.payload };
    case "decrement":
      return { count: state.count - action.payload };
    default:
      return state
  }
};

const ReducerScreen = () => {
  const [state, dispatch] = useReducer(reducer, { count: 0 });
  return (
    <View>
      <Button
        title="Arttır"
        onPress={() => {
          dispatch({ type: "increment", payload: 1 });
        }}
      />
      <Button
        title="Eksilt"
        onPress={() => {
          dispatch({ type: "decrement", payload: 1 });
        }}
      />
      <Text style={styles.text}>Number : {state.count}</Text>
    </View>
  );
};

export default ReducerScreen;

const styles = StyleSheet.create({
  text: {
    fontSize: 20,
    paddingStart: 90,
  },
});
