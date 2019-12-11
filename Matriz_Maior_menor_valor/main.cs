
using System;

class MainClass {
  public static void Main (string[] args) {
    int[,] dados = new int[4,3];

    for(int i=0; i<4; i++){
      Console.WriteLine("Informe os números da {0}ª linha :", i+1);
      for(int j=0; j<3; j++){
         dados[i,j] = int.Parse(Console.ReadLine());
      }
    }

    int maior=dados[0,0], menor=dados[0,0];
    for(int i=0; i<4; i++){
      for(int j=0; j<3; j++){
        if(dados[i,j] > maior)
          maior = dados[i,j];
        
        if(dados[i,j] < menor)
          menor = dados[i,j];
      }
    }    
    Console.WriteLine("Maior: {0} - Menor: {1}", maior, menor);
  }
}