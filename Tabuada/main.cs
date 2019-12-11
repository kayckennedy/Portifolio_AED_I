using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Digite o valor da tabuada:");
    int valor = int.Parse(Console.ReadLine());

    for (int i = 0; i <10; i++){
      Console.WriteLine ("{0} x {1} = {2}", valor, i, valor*i);
      
    }
  }
}

