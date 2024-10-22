import { FlatList, StyleSheet, Text, TouchableOpacity, View } from 'react-native'
import React from 'react'
import ResultDetail from './ResultDetail'
import { useNavigation } from '@react-navigation/native'

const ResultsList = ({ title, results }) => {

    const navigation = useNavigation();

    return (
        <View style={styles.container}>
            <Text style={styles.title}>{title}</Text>
            <FlatList
                horizontal
                showsHorizontalScrollIndicator={false}
                data={results}
                keyExtractor={item => item.id}
                renderItem={({ item }) => {
                    return (
                        <TouchableOpacity
                            onPress={() => {
                                navigation.navigate('ResultShow', {
                                    id: item.id
                                })
                            }}
                        >
                            <ResultDetail result={item} />
                        </TouchableOpacity>
                    )
                }}
            />
        </View>
    )
}

export default ResultsList

const styles = StyleSheet.create({
    container: {
        marginBottom: 10,

    },
    title: {
        fontSize: 18,
        fontWeight: 'bold',
        marginLeft: 15,
        marginBottom: 5
    }
})