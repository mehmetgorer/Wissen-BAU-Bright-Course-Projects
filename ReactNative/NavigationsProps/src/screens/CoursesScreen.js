import { StyleSheet, Text, View, FlatList } from 'react-native'
import React from 'react'

const CoursesScreen = () => {
  const courses = [
    { id:1, name: "Reactjs Eğitimi"},
    { id:2, name: "Angularjs Eğitimi"},
    { id:3, name: "Nodejs Eğitimi"},
    { id:4, name: "Vuejs Eğitimi"}
  ]
  return (
    <View style={styles.container}>
      <Text style={styles.title}>Course List</Text>
      <FlatList
        data= {courses}
        // horizontal={true}
        // showsHorizontalScrollIndicator={false}
        keyExtractor={item => item.id}
        renderItem={({item}) => {
          return (
            <Text style={styles.content}>{item.name}</Text>
          )
        }}
      />
    </View>
  );
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: 'lightgray',
    alignItems: 'center',
    justifyContent: 'center',
  },
  title: {
    fontSize: 25,
    color: 'blue',
    marginVertical: 20
  },
  content: {
    fontSize: 20,
    marginVertical:10,
    backgroundColor: 'yellow',
    textAlign: 'center',
    padding: 10,

  }
});

export default CoursesScreen