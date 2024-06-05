using System;
using System.Collections;
using System.Collections.Generic;

class Program {
  public static void Main (string[] args) {
    
    string userDate = String.Empty;
    int numero;
    bool bucle = false;
    Stack pila = new Stack();
    List<object> pilaR = new List<object>();

    Console.WriteLine("Ingrese 5 números");
    Console.WriteLine("");
    
    for(int i = 0; i < 5; i++){

      while(!bucle){
        
        Console.Write("Número {0}: ", i+1);
        userDate = Console.ReadLine();
        
        if(int.TryParse(userDate, out numero)){
          bucle = true;
          pila.Push(numero);
        }else{
          Console.WriteLine("Ingresa un número");
        }
      }
      bucle = false;
    }
    
    Console.Clear();
    
    Console.WriteLine("Pila Original");
    foreach(int j in pila){
      Console.WriteLine(j);
    }

    
    while(pila.Count > 0){
      object copiar;
      copiar = pila.Pop();
      pilaR.Add(copiar);
    }

    Console.WriteLine("\nPila al Revéz");
    pilaR.Reverse();
    foreach(int j in pilaR){
      Console.WriteLine(j);
    }

    Console.ReadKey();
  }
}