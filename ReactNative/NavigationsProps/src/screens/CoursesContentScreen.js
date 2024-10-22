import { ScrollView, StyleSheet, Text, View } from "react-native";
import React from "react";
import Course from "../components/Course";

const CoursesContentScreen = () => {
  return (
    <ScrollView>
      <Course
        title="Reactjs Eğitimi"
        imageSource={require("../../assets/ReactJS.png")}
        content="React component mimarisi, state ve props yönetimi, context api ve axios ile veri yönetimi..."
      />
      <Course
        title="Nodejs Eğitimi"
        imageSource={require("../../assets/nodejs.png")}
        content="Nodejs ile server side javascript kodlama, jwt authentication ile api yönetimi..."
      />
      <Course
        title="Angularjs Eğitimi"
        imageSource={require("../../assets/angularjs.png")}
        content="Angularjs ile frontend javascript kodlama, formlara two binding veri aktarma kolaylığı..."
      />
    </ScrollView>
  );
};

export default CoursesContentScreen;

const styles = StyleSheet.create({});
