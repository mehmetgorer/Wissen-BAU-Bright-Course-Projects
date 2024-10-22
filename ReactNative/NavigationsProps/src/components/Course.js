import { StyleSheet, Text, View, Image } from 'react-native'
import React from 'react'

const Course = ({title, imageSource, content}) => {
  return (
    <View style={styles.body}>
      <Text style={styles.title}>{title}</Text>
      <Image style={styles.image} source={imageSource}></Image>
      <Text style={styles.content}>{content}</Text>
    </View>
  )
}

export default Course

const styles = StyleSheet.create({
    body: {
        height: 260,
        backgroundColor: 'lightblue',
        margin: 5,
        padding: 5
    },
    image: {
        width: '100%',
        height: '55%'      
    },
    title: {
        fontSize: 25,
        color: 'blue',
        textAlign: 'center'
    },    
    content: {
        fontSize: 15,
        color: 'blue',
    }
})