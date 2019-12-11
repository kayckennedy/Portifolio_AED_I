using System;

class MainClass {
  public static void Main (string[] args) {
    Pessoa jao = new Pessoa("kayc", 19, new Data("01/05/2001"));
    Pessoa ze = new Pessoa("amanda", 29, new Data("15/05/2000"));  
    Pessoa mar = new Pessoa("deivi", 29, new Data("15/05/2001"));  

    ze.setPai(jao);
    ze.setMae(mar);

    Console.WriteLine(ze.PaiMae());
  }
}