import { StyleSheet, TextInput, View } from 'react-native'
import React from 'react'
import { Ionicons } from '@expo/vector-icons';


const SearchBar = () => {

  return (
    <View style={styles.container}>
      <Ionicons style={styles.searchicon} name="search" size={30} color="black" />
      <TextInput style={styles.searchbar} placeholder=' Search...'></TextInput>
    </View>
  )
}

export default SearchBar

const styles = StyleSheet.create({
    container:{
    backgroundColor:'lightgrey',
    alignItems:'center',
    flexDirection:'row',
    borderRadius: 50,
    marginTop:10
    },
    searchbar: {
        // borderWidth:.6,
        marginLeft:10,
        marginRight:22,
        marginBottom:22,
        marginTop:22,
        fontSize:20,
        flex:1,
        borderRadius:5
    },
    searchicon: {
        marginLeft:10
    }
})