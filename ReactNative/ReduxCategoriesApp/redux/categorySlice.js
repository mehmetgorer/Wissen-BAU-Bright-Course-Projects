import { createSlice } from "@reduxjs/toolkit";
import {Categories} from '../data/db'

const initialState = {
  categories: [],
};

export const categorySlice = createSlice({
  name: "category",
  initialState,
  reducers: {
    getCategories: (state) => {
        state.categories = Categories;
      }
      
  }

});

export const { getCategories } = categorySlice.actions;

export default categorySlice.reducer;
