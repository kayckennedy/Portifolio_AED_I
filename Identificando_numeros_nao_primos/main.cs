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
        int qtd = 0;
        for (int x = matriz[i,j]; x>0; x--){
          if (matriz[i,j]%x==0){
            qtd++;
          }
        }
        if (qtd>2){
          Console.WriteLine("Numero não primo {0}", matriz[i,j]);
        }
      }
    }
  }
}