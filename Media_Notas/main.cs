using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Digite o peso da N1 e N2:");
    int peso = int.Parse(Console.ReadLine());
    Console.WriteLine ("Digite o peso da semestral:");
    int semestral = int.Parse(Console.ReadLine());
    Console.WriteLine ("Digite a nota N1:");
    float n1 = float.Parse(Console.ReadLine());
    Console.WriteLine ("Digite a nota N2:");
    float n2 = float.Parse(Console.ReadLine());
    Console.WriteLine ("Digite a nota da semestral");
    float notaSemestral = float.Parse(Console.ReadLine());

    float media = ((peso/100f) * n1) + ((peso/100f) * n2) + ((semestral/100f) * notaSemestral); //Uiliza-se o f para declarar que a divisão dará um float

    Console.WriteLine (media);    

    if (media >= 5){
      Console.WriteLine ("Parabéns, aprovado");      
    }

    else if (media >= 4 && media <5){
      Console.WriteLine ("Você poderá fazer o exame suplementar");
    }

    else{
      Console.WriteLine ("Reprovado");    
    }
  }
}

