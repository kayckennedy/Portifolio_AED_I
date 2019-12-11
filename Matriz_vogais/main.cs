/***************
Exercício 3: Crie um programa em C# que realize o preenchimento de uma matriz 3x4 com caracteres e, em seguida, imprima na tela apenas as vogais presentes na matriz.
****/
using System;

class MainClass {
  public static void Main (string[] args) {
    char[,] letras = new char[3,4];

    for(int i=0; i<3; i++){
      Console.WriteLine("Informe as letras para a {0}ª linha",i+1);
      for(int j=0; j<4; j++){
         letras[i,j] = char.Parse(Console.ReadLine());
      }
    }

    for(int i=0; i<3; i++){
      for(int j=0; j<4; j++){
            Console.Write("{0}  ",letras[i,j]);
        }
        Console.WriteLine();
    }

    Console.WriteLine("Vogais : ");
    for(int i=0; i<3; i++){
        for(int j=0; j<4; j++){
          char ch = letras[i,j];
          if(ch=='a' || ch=='e' || ch=='i' || ch=='o' || ch=='u'){
             Console.WriteLine(ch);
          }
        }
    }  

  }
}