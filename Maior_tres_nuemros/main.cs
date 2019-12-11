using System; 

class MainClass {
  public static void Main (string[] args) {

    int maior = -99999999;

    for (int i = 0; i <3; i++){

      Console.WriteLine ("Digite um número:");
      int num = int.Parse(Console.ReadLine());
      if (num > maior){
        maior = num;
      }
    }
      Console.WriteLine ("O maior dos três números é {0}", maior);

  }
}
