using System;
using System.Text;

public abstract class Animal : ICriptografavel{
  public string nome;

  public string ChaveCriptografia {get; set;}

  public void Criptografar() { 
    string padrao = " ABCDEFGHIJKLMNOPQRSTUVXWYZ0123456789";
    Console.WriteLine("Criptografando...");

    StringBuilder myNome = new StringBuilder("");
    for(int i=0; i<nome.Length; i++){
      int indice = padrao.IndexOf(nome.ToUpper()[i]);
      if(indice >=0 )
        myNome.Append(ChaveCriptografia[indice]);  
    }
    nome = myNome.ToString();
  
  }
  public void Descriptografar() { 

    Console.WriteLine("Descriptografando...");
    string padrao = " ABCDEFGHIJKLMNOPQRSTUVXWYZ0123456789";

    StringBuilder myNome = new StringBuilder("");
    for(int i=0; i<nome.Length; i++){
      int indice = ChaveCriptografia.IndexOf(nome[i]);
      if(indice >=0 )
        myNome.Append(padrao[indice]);  
      else{
        myNome.Append(nome[i]);
      }

    }
    nome = myNome.ToString();
  }  

  public abstract void ImprimirResumo();

}