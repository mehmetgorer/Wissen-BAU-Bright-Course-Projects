import { StyleSheet, Text, TouchableOpacity, View } from "react-native";
import React from "react";
import { useSelector, useDispatch } from "react-redux";
import { decrement, increment, incrementByAmount } from "./store/redux/counterSlice";

export default function Counter() {
  const count = useSelector((state) => state.counter.value);

  const dispatch = useDispatch();

  return (
    <View>
      <TouchableOpacity style={styles.button}  onPress={() => dispatch(increment())}>
        <Text style={styles.textButton}>Increment</Text>
      </TouchableOpacity>
      <Text style={styles.text}>{count}</Text>
      <TouchableOpacity style={styles.button} onPress={() => dispatch(decrement())}>
        <Text style={styles.textButton}>Decrement</Text></TouchableOpacity>
      <TouchableOpacity style={styles.button} onPress={() => dispatch(incrementByAmount(5))}>
      <Text style={styles.textButton}>IncrementByAmount</Text>
      </TouchableOpacity>
    </View>
  );
}

const styles = StyleSheet.create({
  text: {
    alignSelf: 'center',
    fontSize: 18
  },
  button: {
    backgroundColor: '#0782F9',
    margin: 2,
    paddingHorizontal: 20,
    paddingVertical: 10,
    borderRadius: 10,
  },
  textButton: {
    alignSelf: 'center',
    color: 'white',
    fontSize: 16,
    fontWeight: 'bold'
  }
});
