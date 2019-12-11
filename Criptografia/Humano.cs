using System;

class Humano: Animal{
  public Humano(string nome){
    this.nome = nome; 
  }
  
  public override void ImprimirResumo(){
    Console.WriteLine("Nome: {0}", this.nome);
  } 
}