import 'package:flutter/material.dart';

class AuthButtonsStyle extends ButtonStyleButton {
  const AuthButtonsStyle({Key key}) : super(key: key);


  @override
  ButtonStyle defaultStyleOf(BuildContext context) {
    // TODO: implement defaultStyleOf

    throw UnimplementedError();
  }

  @override
  ButtonStyle themeStyleOf(BuildContext context) {
    // TODO: implement themeStyleOf
    throw UnimplementedError();
  }

   ButtonStyle loginButtonTheme() {
     return OutlinedButton.styleFrom(
       side: BorderSide(color: Colors.blue, width: 3),
       primary: Colors.black,
       backgroundColor: Colors.white,
       minimumSize: const Size(300, 40),
     );
  }

  ButtonStyle registerButtonTheme() {
    return OutlinedButton.styleFrom(
      side: BorderSide(color: Colors.red, width: 3),
      primary: Colors.black,
      backgroundColor: Colors.white,
      minimumSize: const Size(300, 40),
    );
  }

}
