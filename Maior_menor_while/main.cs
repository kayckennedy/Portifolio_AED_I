using System; 

class MainClass {
  public static void Main (string[] args) {

  bool continuar = true; 
  int maior = -1;
  int menor = 999999999;
  
  while (continuar == true){

    Console.WriteLine ("Digite um número:");
    int num = int.Parse(Console.ReadLine());

    if (num > maior){
      maior = num;
      }

    else if ((num < menor) &&(num != -1)){
      menor = num;
      }

    if (num == -1){
      continuar = false;
      }
    }

    Console.WriteLine ("O maior número dessa série é o {0} e o menor é {1}", maior, menor);

  }
}