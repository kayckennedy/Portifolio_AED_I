using System; 

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Digite um número:");
    int num1 = int.Parse(Console.ReadLine());

    int somador = 1;
    int aux = num1;

    if (num1 <=10){
    while (aux >0){
      somador = somador * aux;
      aux --;
    }
    }

    Console.WriteLine ("O fatorial de {0} é {1}:", num1, somador);
  }
}
