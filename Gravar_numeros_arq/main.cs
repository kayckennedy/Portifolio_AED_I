using System;
using System.IO;
using System.Text;

class MainClass {
  public static void Main (string[] args) {

    Console.WriteLine("Digite o primeiro numero");
    int numero_01 = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite o segundo numero");
    int numero_02 = int.Parse(Console.ReadLine());

    FileStream arquivo = new FileStream("arquivo.txt", FileMode.Open, FileAccess.Write);
    StreamWriter gravarLinha = new StreamWriter(arquivo, Encoding.UTF8);

    gravarLinha.WriteLine(numero_01 + numero_02);

    gravarLinha.Close();

    arquivo.Close();

  }
}
