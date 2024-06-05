using System;
using System.Collections.Generic;

class Program {
  public static void Main (string[] args) {
    char apertura;
    char cierre;
    bool respuesta = false;
    int cont = 0;
    Stack<char> miPila = new Stack<char>();
    miPila.Push('(');
    miPila.Push(']');

    int elementos = miPila.Count;

    Console.WriteLine("Pila");
    //POP PUSH PEEK COUNT
    foreach(char j in miPila){
      Console.WriteLine(j);
    }

    if(miPila.Count % 2 == 0){
        for(int i = 0; i <= (miPila.Count)/2; i++){
        //vamos a guardar el primer elemento de la pila y eliminarla con POP
        if(miPila.Peek() == '}' || miPila.Peek() == ')' || miPila.Peek() == ']'){
          apertura = miPila.Pop();
          Console.WriteLine("Apertura: {0}",apertura);
          
          foreach(char x in miPila){
            if(miPila.Contains('{') || miPila.Contains('(') || miPila.Contains('[')){
              Console.WriteLine("X: {0}",x);
              cierre = x;
              if((apertura == '}' && cierre == '{') || (apertura == ')' && cierre == '(')  || (apertura == ']' && cierre == '[')){
                respuesta = true;
                cont++;
              }
            }
          }
        }
      }
      
    }else{
      respuesta = false;
    }

    if(cont == elementos/2){
      respuesta = true;
    }

    Console.WriteLine(respuesta);
    Console.ReadKey();
  }
}