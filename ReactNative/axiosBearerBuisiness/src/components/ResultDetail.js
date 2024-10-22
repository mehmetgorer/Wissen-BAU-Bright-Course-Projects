import { StyleSheet, Text, View, Image } from 'react-native'
import React from 'react'

const ResultDetail = ({result}) => {
    //console.log(result);
  return (
    <View style={styles.container}>
      <Text style={styles.name}>{result.name}</Text>
      <Image style={styles.image} source={{
        uri:result.image_url
      }}></Image>
      <Text>Yıldız: {result.rating} Değerlendirme: {result.review_count}</Text>
    </View>
  )
}

export default ResultDetail

const styles = StyleSheet.create({
    container: {
        marginLeft:15,
    },
    name: {
        fontWeight:'bold',
        marginBottom:5
    },
    image:{
        width:200,
        height:100,
        borderRadius:8,
        marginBottom:5
    }
})