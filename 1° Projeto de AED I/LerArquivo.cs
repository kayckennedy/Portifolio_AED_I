using System.IO;
using System.Text;

class LerArquivo {
    private int qtd_linhas;

    public int getQtd_linhas(){
        return qtd_linhas;
    }
    // Atributo privado da classe, "path" onde o arquivo .txt se encontra
    private string caminho;

    // Construtor da classe, recebendo como parâmetro o caminho de onde o arquivo está
    public LerArquivo(string p_caminho) {
        this.caminho = p_caminho;
    }

    // Lendo apenas a primeira linha do arquivo
    public string LerLinha() {
        FileStream ler_arquivo_stream = new FileStream(this.caminho, FileMode.Open, FileAccess.Read);
        StreamReader ler_arquivo_reader = new StreamReader(ler_arquivo_stream, Encoding.UTF8);

        string linha;

        if (QtdLinhas() == 0) {
            linha = "SEM VALOR SALVO NO ARQUIVO \"" + this.caminho + "\"";
        } else {
            linha = ler_arquivo_reader.ReadLine();
        }

        ler_arquivo_reader.Close();
        ler_arquivo_stream.Close();

        return linha;
    }

    // Lendo todas as linhas de um arquivo
    public string[] LerTodas() {
        FileStream ler_arquivo_stream = new FileStream(this.caminho, FileMode.Open, FileAccess.Read);
        StreamReader ler_arquivo_reader = new StreamReader(ler_arquivo_stream, Encoding.UTF8);

        int qtd_linhas = QtdLinhas();

        string[] dados;

        if (qtd_linhas == 0) {
            dados = new string[1];
            dados[0] = "SEM VALOR SALVO NO ARQUIVO \"" + this.caminho + "\"";
        } else {
            dados = new string[qtd_linhas];

            for (int i = 0; i < qtd_linhas; i++) {
                dados[i] = ler_arquivo_reader.ReadLine();
            }
        }
        
        ler_arquivo_reader.Close();
        ler_arquivo_stream.Close();

        return dados;
    }

    // Método para saber quantas linhas tem em um arquivo
    public int QtdLinhas() {
        FileStream ler_arquivo_stream = new FileStream(this.caminho, FileMode.Open, FileAccess.Read);
        StreamReader ler_arquivo_reader = new StreamReader(ler_arquivo_stream, Encoding.UTF8);

        qtd_linhas = 0;

        while (!ler_arquivo_reader.EndOfStream) {
            ler_arquivo_reader.ReadLine();
            qtd_linhas += 1;
        }

        ler_arquivo_reader.Close();
        ler_arquivo_stream.Close();

        return qtd_linhas;
    }

}