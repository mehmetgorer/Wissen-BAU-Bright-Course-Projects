import { Button, StyleSheet, Text, View } from 'react-native'
import React, {useState} from 'react'

const CounterScreen = () => {
    const [number, setNumber] = useState(0)
  return (
    <View>
        <Button title="Arttır" onPress={() => {
            setNumber(number + 1)
        }} />
        <Button title="Eksilt" onPress={() => {
            setNumber(number - 1)}}/>
      <Text style={styles.text}>Number : {number}</Text>
    </View>
  )
}

export default CounterScreen

const styles = StyleSheet.create({
    text: {
        fontSize: 20,
        paddingStart: 90
    }
})