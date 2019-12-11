using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Digite um número:");
    float num1 = float.Parse(Console.ReadLine());
    Console.WriteLine ("Digite um número:");
    float num2 = float.Parse(Console.ReadLine());
    Console.WriteLine ("Digite um número:");
    float num3 = float.Parse(Console.ReadLine());

    float maior = num1;

    if (num2 > maior){
      maior = num2;
    }

    if (num3>maior){
      maior = num3;
    }
    Console.WriteLine (maior);
  
  }
}