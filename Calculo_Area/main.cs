using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Digite 1 para retângulo, 2 para triângulo e 3 para circuferência:");
    int forma = int.Parse(Console.ReadLine());

    float largura;
    float altura;
    float raio;
    
    switch (forma)
    {
      case 1:
        Console.WriteLine ("Digite o valor da largura:");
        largura = float.Parse(Console.ReadLine());
        Console.WriteLine ("Digite o valor da altura:");
        altura = float.Parse(Console.ReadLine());

        Console.WriteLine ("O valor da área é {0} m²", largura * altura);

        break;

      case 2:
        Console.WriteLine ("Digite o valor da largura:");
        largura = float.Parse(Console.ReadLine());
        Console.WriteLine ("Digite o valor da altura:");
        altura = float.Parse(Console.ReadLine());

        Console.WriteLine ("O valor da área é {0} m²",(largura * altura)/2);

        break;

      case 3:
        Console.WriteLine ("Digite o valor do raio:");
        raio = float.Parse(Console.ReadLine());
        double area = (3.141592*(raio * raio));

        Console.WriteLine ("O valor da área é {0} m²",area);

        break;

    }  
  }
}

