using System;

class MainClass {
  public static void Main (string[] args) {
  
    Console.WriteLine("digte sua idade: ");
    int idade = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite seu nome: ");
    string nome = Console.ReadLine();
    Console.WriteLine("digite seu sexo:M ou F");
    char sexo = char.Parse(Console.ReadLine());

    //atribuindo as variaveis ao meu objeto pessoa
    Pessoa humana = new Pessoa(nome,idade,sexo);

    Console.WriteLine(humana.saidaDados());
  

  }
}