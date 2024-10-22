import { useEffect, useState } from "react";
import dbApi from "../../api/dbApi";

export default () => {

  const [results, setResults] = useState([])

  const searchApi = async (searchTerm) => {
    const response = await dbApi.get("/search", {
      params: {
        limit: 30,
        term: searchTerm,
        location: "İstanbul",
      },
    });
    //console.log(response.data.businesses);
    setResults(response.data.businesses)
  };
  useEffect(() => {
    searchApi('Pizza')
  }, [])
  return [searchApi, results]
};


