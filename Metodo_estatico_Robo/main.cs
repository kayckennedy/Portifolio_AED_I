
using System;

class Robo{
  private string nome;  

  private static string mensagem_geral;

  private static ConsoleColor cor = ConsoleColor.White;

  public void Mensagem(){
    Console.ForegroundColor = cor; 
    Console.WriteLine("[{0}]:{1}",nome, mensagem_geral);
    Console.ForegroundColor = ConsoleColor.White; 
  }

  public static void NovaMensagem(string msg){
    mensagem_geral = msg;
  }

  public void setCor(ConsoleColor c){
    cor = c;
  }

  public Robo(string n){
    nome = n;
  }

}

class MainClass {
  public static void Main (string[] args) {
    Robo xpto = new Robo("Robozao");
    Robo r2d2 = new Robo("Robozin");

    Robo.NovaMensagem("Somos mt parecidos!");

    xpto.setCor(ConsoleColor.Green);

    xpto.Mensagem();
    r2d2.Mensagem();

    r2d2.setCor(ConsoleColor.Red);

    Robo.NovaMensagem("Alguns mais parecidos ainda!");
    xpto.Mensagem();
    r2d2.Mensagem();
  }
}