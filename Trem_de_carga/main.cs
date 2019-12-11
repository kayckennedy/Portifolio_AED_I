using System;

class MainClass{
  //Crie o método CargaRestante que retorna a quantidade de carga que o trem ainda consegue suportar com base na carga carregada em seus vagões. 
  public static void Main (string[] args){


    Vagao primeiro = new Vagao(50,"Areia");
    Vagao segundo = new Vagao(30,"Carvao");
    Vagao terceiro = new Vagao(20,"Ferro");
  
    Trem locomotiva = new Trem(200,"Cargueiro",primeiro, segundo, terceiro,80);

    
    Console.WriteLine("{0}, Carga total dos vagoes: {1}",locomotiva.cargaRestante(),locomotiva.cargaTotal());//usando o objeto locomotiva como referencia eu chamei o metodos cargaRestante e cargaTotal 
    
   
  }
}