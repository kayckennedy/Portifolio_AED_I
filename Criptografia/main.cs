using System;

class MainClass {
  public static void Main (string[] args) {
    Humano andre = new Humano("Andre Ribeiro da Silva - Professor");
    andre.ChaveCriptografia = "bcdefghijklmnopqrstuvxzwyz0123456789a";

    andre.ImprimirResumo();

    andre.Criptografar();    
    andre.ImprimirResumo();

    andre.Descriptografar();
    andre.ImprimirResumo();

  }
}