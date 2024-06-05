using System;
using System.Collections.Generic;

class Program {
  public static void Main (string[] args) {
    int x = -121;
    bool respuesta = false;
    string number = String.Empty;
    Stack<char> miPila = new Stack<char>();

    number = x.ToString();

    foreach(char i in number){
      miPila.Push(i);
    }

    string cadena = string.Join("", miPila);

    if(number == cadena){
      respuesta = true;
    }

    Console.WriteLine($"EL número {x} es Palindrome: {respuesta}");

    Console.ReadLine();
  }
}