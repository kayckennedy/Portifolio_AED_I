using System;

class Carros{
  //Claração dos atributos
  private string marca;
  private static string fornecedora;

  //Metodo que imprime os dados na tela
  public void veiculo(){
    Console.WriteLine("Marca do veiculo:{0}, fornecedora:{1}",marca,fornecedora);
  }
  //metodo estatico, atribui valor para todas as instancias das variaveis
  public static void fornecedoraV(string f){
    fornecedora = f;
  }
  //construtor da classe
  public Carros(string m){
    marca = m;
  }
}