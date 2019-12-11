using System;

class MainClass {
  public static void Main (string[] args) {
    Pessoa fulano = new Pessoa("kayc", 17, 1.75f, 80.0f);
    Pessoa beltrano = new Pessoa("amanda", 27, 1.75f, 80.0f);

    Pessoa mais_velho = fulano.MaisVelho(beltrano);

    Console.WriteLine("Mais Velho: \n{0}", mais_velho.resumoDados());
  }
}