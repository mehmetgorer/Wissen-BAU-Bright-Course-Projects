import { StatusBar } from 'expo-status-bar';
import { StyleSheet, Text, View } from 'react-native';

export default function App() {
  const name = "Ali Uçar"
  return (
    <View style={styles.container}>
      <Text style={styles.title}>Hello React Native Mobile App</Text>
      <Text style={{color:'red', fontSize: 25}}>Hello Expo Go</Text>
      <Text style={styles.item}>{name}</Text>
      {/* <StatusBar style="auto" /> */}
    </View>
  );
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: '#fff',
    alignItems: 'center',
    justifyContent: 'center',
  },
  title: {
    backgroundColor: 'blue',
    color: 'white',
    fontSize: 20,
    padding: 10
  },
  item: {
    backgroundColor: 'yellow',
    color: 'blue',
    fontSize: 20,
    padding: 20,
    fontWeight: 'bold',
    borderRadius: 20
  }
});
