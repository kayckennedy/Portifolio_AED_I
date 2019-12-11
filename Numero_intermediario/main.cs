using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Digite um número:");
    float num1 = float.Parse(Console.ReadLine());
    Console.WriteLine ("Digite um número:");
    float num2 = float.Parse(Console.ReadLine());
    Console.WriteLine ("Digite um número:");
    float num3 = float.Parse(Console.ReadLine());

    if ((num2 > num3) && (num2 <num1)){
      Console.WriteLine ("O intermediário é {0}", num2);

    }
    else if ((num2>num1) && (num2<num3)){
      Console.WriteLine ("O intermediário é {0}", num2);

    }
    else if ((num3>num1) && (num3 <num2)){
      Console.WriteLine ("O intermediário é {0}", num3);

    }
    else if ((num3>num2) &&(num3<num1)){
      Console.WriteLine ("O intermediário é {0}", num3);

    }
    else{
      Console.WriteLine ("O intermediário é {0}", num1);
      
    }
  }
}