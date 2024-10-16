import 'dart:io';
import 'package:flutter/material.dart';
import 'package:http/http.dart' as http;
import 'dart:convert' as convert;


void main() => runApp(MyApp());

class MyApp extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      home: MyHomePage(),
      title: 'Flutter Demo',
      // theme: ThemeData(
      //   primarySwatch: Colors.red,
      // ),
    );
  }
}

class MyHomePage extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      backgroundColor: Colors.black,
      body: Container(
          padding: EdgeInsets.only(top: 100.0),
          child: Column(
            children: [
              Center(
                child: Text(
                  "Atlas weight lifting",
                  style: TextStyle(
                      color: Colors.white,
                      fontSize: 30,
                      fontFamily: 'Handwriting'),
                ),
              ),
              Container(
                  padding: EdgeInsets.only(top: 100.0),
                  child: Image(
                      image: AssetImage('graphics/Images/dumbellicon.png'))),
              Container(
                padding: EdgeInsets.only(top: 100.0),
                child: Column(
                  children: [
                    OutlinedButton(
                      onPressed: () {},
                      child: Text("Login"),
                      style: OutlinedButton.styleFrom(
                        side: BorderSide(color: Colors.blue, width: 3),
                        primary: Colors.black,
                        backgroundColor: Colors.white,
                        minimumSize: const Size(300, 40),
                      ),
                    ),
                    OutlinedButton(
                      onPressed: () {},
                      child: Text("Register"),
                      style: OutlinedButton.styleFrom(
                        side: BorderSide(color: Colors.red, width: 3),
                        primary: Colors.black,
                        backgroundColor: Colors.white,
                        minimumSize: const Size(300, 40),
                      ),
                    ),
                  ],
                ),
              ),
            ],
          )),
    );
  }
}
