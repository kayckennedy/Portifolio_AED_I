using System; 

class MainClass {
  public static void Main (string[] args) {

    int [] vetor = new int [10];

    for(int i=0;i <10; i++){

      Console.Write ("Digite um número:");
      vetor[i] = int.Parse(Console.ReadLine());    
    }
    
    for(int i=9;i >=0; i--){
      
      Console.Write (vetor[i]);
      if (i>0){
        Console.Write (",");
      }

    }
  }
}