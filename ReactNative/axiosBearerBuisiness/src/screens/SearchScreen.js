import { StyleSheet, Text, View } from 'react-native'
import React, { useState } from 'react'
import SearchBar from '../components/SearchBar'
import useResults from '../hooks/useResults'
import ResultsList from '../components/ResultsList'


const SearchScreen = () => {
  const [searchApi, results] = useResults()

  const getResultsByPrice = (price) => {
    return results.filter((item) => {
      return item.price == price
    })

  }

  return (
    <View>
      <SearchBar />
      <ResultsList title="Ucuz Restoranlar" results={getResultsByPrice('₺')} />
      <ResultsList title="Uygun Restoranlar" results={getResultsByPrice('₺₺')} />
      <ResultsList title="Pahalı Restoranlar" results={getResultsByPrice('₺₺₺')} />
    </View>
  )
}

export default SearchScreen

const styles = StyleSheet.create({})