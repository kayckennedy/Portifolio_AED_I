using System;

class MainClass {
  public static void Main (string[] args) {
    int cont =0;
    int numeros;
    int soma = 0;
    int media = 0;
    

    while (cont < 11) {
      Console.WriteLine("Digite um numero: ");
      numeros = int.Parse(Console.ReadLine());
      soma = soma + numeros;
      cont += 1;
    }

    media = (soma / 10);
    Console.WriteLine("A soma dos 10 valores é {0}, e a média é {1}", soma, media);
  }
}