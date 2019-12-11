using System;

class MainClass {
  public static void Main (string[] args) {
    Pessoa jao = new Pessoa("kayc", 19, new Data("04/03/2001"));
    Pessoa ze = new Pessoa("junior", 29, new Data("15/05/2000"));  

    Console.WriteLine("Diferença entre kayc e junior");
    Console.WriteLine(jao.Diferenca(ze));   
  }
}