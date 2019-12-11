using System;

class MainClass {
  public static void Main (string[] args) {
    int capacidadeTotal =500;
    int cargaAtual =500; 
    string cor = "vermelho";
    string tipo = "cargueiro";
    int tripulacao = 5000;

    Navio barco = new Navio(capacidadeTotal, cargaAtual, cor, tipo, tripulacao);
    
    Navio canoa = new Navio(200,100, "vermelho", "cruzeiro", 450);

    
    Console.WriteLine("Carga atual do barco: {0}, capacidade total: {1}", barco.getCapacidadeAtual(),barco.getLivre());
    
    Console.WriteLine();
    
    Console.WriteLine("A carga do barco é maior que a da canoa: {0}",barco.maiorCarga(canoa));
    
    Console.WriteLine();
    
    Console.WriteLine("O objeto canoa tem capacidade livre para receber a carga do objeto barco: {0}",barco.transfereCarga(canoa));
    Console.WriteLine();
    
    Console.WriteLine("Carga disponivel da canoa após receber a carga do barco: {0}",canoa.getCapacidadeAtual());

  }
}