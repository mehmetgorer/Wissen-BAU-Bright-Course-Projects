import { StyleSheet, Text, View, Image } from 'react-native'
import React from 'react'

export default function ProductScreen({route}) {
    const productId = route.params.id;
  return (
    <View style={styles.container}>
      <Text>Product : {productId}</Text>
    </View>
  )
}

const styles = StyleSheet.create({
    container: {
        flex: 1,
        backgroundColor: '#fff',
        alignItems: 'center',
        justifyContent: 'center',
      },
})