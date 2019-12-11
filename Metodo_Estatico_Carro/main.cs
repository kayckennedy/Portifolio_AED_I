using System;

class MainClass {
  public static void Main (string[] args) {
  Carros carro1 = new Carros("fusca");
  Carros carro2 = new Carros("chevet");

  //passagem de valor para o metodo estatico
  Carros.fornecedoraV("fiat");
  
  //acessando o metodo que imprime os dados usando os objetos como parametro
  carro1.veiculo();
  carro2.veiculo();
  }
}