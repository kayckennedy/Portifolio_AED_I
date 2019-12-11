using System;

class MainClass {
  public static void Main (string[] args) {
    int[] dados = new int[6] {7, 4, 5, 1, 0, 3};

    int soma = 0;
    for(int cont=0; cont<dados.Length; cont++){
      soma = soma + dados[cont];
    }
    float media = soma / (float)dados.Length;

    Console.WriteLine("Média Calculada: {0}", media);
  }
}