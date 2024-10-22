import { StyleSheet, Text, View } from 'react-native'
import React from 'react'

const HomeScreen = () => {
  return (
    <View  style={styles.title}>
      <Text style={{color: 'red', fontSize: 20}}>Home Page</Text>
    </View>
  )
}

export default HomeScreen

const styles = StyleSheet.create({
    title: {
        flex:1,
        alignItems: 'center',
        justifyContent: 'center'
    }
})