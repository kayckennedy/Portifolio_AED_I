
using System;
class MainClass{
  public static void Main(){
    int linha= 3;
    int coluna = 6;
    int[,] matriz = new int [,]{{2,3,4,5,6,8},
                              {4,2,9,4,2,7},
                              {8,9,0,2,4,1}};
  
    for (int i=0; i<linha; i++){
      for (int j =0; j<coluna; j++){
        Console.WriteLine("O número na posição {0},{1} é: {2}", i,j, matriz[i,j]);
      }
    }
  }
}