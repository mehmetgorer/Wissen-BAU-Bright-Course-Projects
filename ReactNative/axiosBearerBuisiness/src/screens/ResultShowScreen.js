import { FlatList, StyleSheet, Text, View, Image } from 'react-native'
import React, { useEffect, useState } from 'react'
import dbApi from '../../api/dbApi';
import { AntDesign , MaterialIcons } from '@expo/vector-icons';


export default function ResultShowScreen({ route }) {
  const [result, setResult] = useState(null)

  const id = route.params.id;
  console.log(id);
  const getResult = async (id) => {
    const response = await dbApi.get(`/${id}`);
    console.log(response.data);
    setResult(response.data)
  }
  useEffect(() => {
    getResult(id);
  }, [])
  if (!result) {
    return null
  }

  return (
    <View style={styles.container}>
      <Text style={styles.title}>{result.name}</Text>
      <Text style={styles.phone}>{result.phone}</Text>
      <View style={styles.icon}>
        {
        (result.is_closed) ? (
        <AntDesign name="closecircleo" size={30} color="black" />) : (
        <MaterialIcons name="delivery-dining" size={30} color="black" />)
        }
      </View>
      <FlatList
        data={result.photos}
        renderItem={({ item }) => {
          return (
            <Image style={styles.image}
              source={{
                uri: item
              }}
            />
          )
        }}
      ></FlatList>
    </View>
  )
}

const styles = StyleSheet.create({
  title: {
    alignSelf: 'center',
    fontSize: 25,
    marginVertical: 10,
  },
  phone: {
    alignSelf: 'center',
    fontSize: 20
  },
  image: {
    height: 200,
    margin: 10,
    borderRadius: 20
  },
  icon:{
    alignSelf:'center'
  }
})