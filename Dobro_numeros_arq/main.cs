using System;

class MainClass {
  public static void Main (string[] args) {
    
    FileStream ler_arquivo_stream = new FileStream("arquivo.txt", FileMode.Open, FileAccess.Read);
    StreamReader ler_arquivo_reader = new StreamReader(ler_arquivo_stream, Encoding.UTF8);

    string[] dados_lidos;

    for (int i = 0; i < 10; i++) {
      dados_lidos[i] = ler_arquivo_reader.ReadLine();
      }
    }
    
    for(int i=0; i < dados_lidos.Lenght; i++){
      Console.WriteLine(dados_lidos[i] * 2);
    }



    ler_arquivo_reader.Close();
    ler_arquivo_stream.Close();
    
}
}