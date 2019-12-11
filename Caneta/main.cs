using System;

class MainClass {
  public static void Main (string[] args) {
    Caneta amanda = new Caneta("Azul","bic", 40f);
    Caneta tia = new Caneta("Azul","bic", 40f);
   
    Console.WriteLine(amanda.ResumoDados());
    Console.WriteLine(tia.ResumoDados());

    amanda.TransferirCarga(tia, 40);

    Console.WriteLine("Transferindo...");
    Console.WriteLine(amanda.ResumoDados());
    Console.WriteLine(tia.ResumoDados());

  }
}