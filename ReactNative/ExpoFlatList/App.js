import { FlatList, StyleSheet, Text, View } from 'react-native';

export default function App() {

  const categories = [
    { id:1, name: "Bilgisayar"},
    { id:2, name: "Telefon"},
    { id:3, name: "Yazıcı"},
    { id:4, name: "OEM Parçalar"}
  ]

  return (
    <View style={styles.container}>
      <Text style={styles.title}>Kategori Listesi</Text>
      <FlatList
        data= {categories}
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
