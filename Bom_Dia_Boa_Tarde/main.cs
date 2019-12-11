using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Digite a hora sem os minutos:");
    int hora = int.Parse(Console.ReadLine());

    if (hora >= 0 && hora < 12) {
      Console.WriteLine ("Bom dia companheiro !!!");
    }

    else if (hora >= 12  && hora < 18) {
      Console.WriteLine ("Boa tarde companheiro !!!");
    }

    else if (hora >= 18 && hora <= 23) {
      Console.WriteLine ("Boa noite companheiro !!!");
    }

    else {
      Console.WriteLine ("Hora inválida !!!");
      
    }
  }
}
