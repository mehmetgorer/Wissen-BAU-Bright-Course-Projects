import { FlatList, StyleSheet, Text, View, TouchableOpacity } from 'react-native'
import React, { useEffect } from 'react'
import { useSelector, useDispatch } from "react-redux";
import { getCategories } from "../redux/categorySlice";
import { useNavigation } from '@react-navigation/native';

export default function CategoryScreen() {

const navigation = useNavigation();

const categories = useSelector((state) => state.category.categories);

const dispatch = useDispatch();

useEffect(() => {
  dispatch(getCategories());
},[])

  return (
    <View style={styles.container}>
      <FlatList 
      data={categories}
      keyExtractor={(item) => item.id}
      renderItem={(item) => {
        return(
            <TouchableOpacity style={[styles.categoryBox, {backgroundColor:item.item.color}]}
            onPress={() =>
                navigation.navigate('Product', { id: item.item.id })
              }
            >
                <Text style={styles.text}>{item.item.name}</Text>
            </TouchableOpacity>
        )
      }}
      numColumns={2}
      />
    </View>
  )
}

const styles = StyleSheet.create({
    container:{
        flex:1,
        alignItems:'center',
        justifyContent: 'center',
        marginTop: 50,
        color: 'white',
        fontSize: 25
    },
    categoryBox: {
        width: 120,
        height: 100,
        alignItems:'center',
        justifyContent: 'center',
        margin: 10,
        borderWidth: 2,
        borderColor: 'gray',
        borderRadius: 10
    },
    text: {
        fontSize: 16,
        fontWeight: 'bold',
        color: 'white'
    }
})