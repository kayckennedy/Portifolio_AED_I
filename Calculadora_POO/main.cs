using System;

class MainClass {
  public static void Main (string[] args) {
     Console.WriteLine("Informe um número:"); 
     int num1 = int.Parse(Console.ReadLine());
     Console.WriteLine("Informe outro número:"); 
     int num2 = int.Parse(Console.ReadLine());

     int soma = CalculadoraInt.Soma(num1, num2);
     Console.WriteLine("Soma: {0}+{1}={2}", num1, num2, soma);

     soma = CalculadoraInt.Soma(23, 7);
     Console.WriteLine("Soma: {0}+{1}={2}", 23, 7, soma);

  

  }
}