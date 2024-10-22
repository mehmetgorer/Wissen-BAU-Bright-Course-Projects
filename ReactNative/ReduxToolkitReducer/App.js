import { StyleSheet, Text, View } from "react-native";
import { store } from "./store/redux/store";
import { Provider } from "react-redux";
import Counter from "./Counter";

export default function App() {
  return (
    <Provider store={store}>
      <View style={styles.container}>
        <Counter />
      </View>
    </Provider>
  );
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: "#fff",
    alignItems: "center",
    justifyContent: "center",
  },
});
