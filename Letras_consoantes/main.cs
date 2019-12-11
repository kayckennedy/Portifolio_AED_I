using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Digite uma letra");
    char letra = char.Parse (Console.ReadLine());
  
    while(letra != 'a' && letra !='e' && letra !='i' && letra !='o' && letra != 'u' ){
      Console.WriteLine ("Digite uma letra");
      letra = char.Parse(Console.ReadLine());
    }
  }
}