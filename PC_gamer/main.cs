using System;

class MainClass {
  public static void Main (string[] args) {
    int memoria, hd;
    string marca, cor, processador;

    Console.WriteLine("memoria");
    memoria = int.Parse(Console.ReadLine()); 

    Console.WriteLine("hd");
    hd = int.Parse(Console.ReadLine());

    Console.WriteLine("marca");
    marca = Console.ReadLine();

    Console.WriteLine("cor");
    cor = Console.ReadLine();

    Console.WriteLine("processador");
    processador = Console.ReadLine();
    

    Pcgamer padrao = new Pcgamer();
  
    Pcgamer computador = new Pcgamer(memoria, hd, processador, marca, cor);
    
    Console.WriteLine(computador.RetornaDados());

    Console.WriteLine(padrao.RetornaDados());
  }
}