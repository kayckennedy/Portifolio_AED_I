using System.IO;
using System.Text;

class GravarArquivo {

    // Atributo privado da classe, "path" onde o arquivo .txt se encontra
    private string caminho;

    // Construtor da classe, recebendo como parâmetro o caminho de onde o arquivo está
    public GravarArquivo(string p_caminho) {
        this.caminho = p_caminho;
    }

    // Grava apenas uma linha no arquivo, substituindo o que tinha antes
    
    public void GravarLinha(string texto) {
        try{
            //Se o caminho do arquivo existir, o texto será gravado
        FileStream gravar_linha_stream = new FileStream(this.caminho, FileMode.Open, FileAccess.Write);
        StreamWriter gravar_linha_writer = new StreamWriter(gravar_linha_stream, Encoding.UTF8);

        gravar_linha_writer.WriteLine(texto);

        gravar_linha_writer.Close();
        gravar_linha_stream.Close();
        }
        catch{
            //caso dê erro, o arquivo será criado usando o caminho que foi passado
            StreamWriter gravar_linha_writer = File.CreateText(caminho);
            gravar_linha_writer.WriteLine(texto);
            gravar_linha_writer.Close();


        }
    }

    // Grava no arquivo mantendo o que tinha antes
    public void GravarAppend(string texto) {
        File.AppendAllText(this.caminho, texto + "\n");
    }

    // Limpa o arquivo, gravando uma string vazia no mesmo
    public void LimparArquivo() {
        System.IO.File.WriteAllText(this.caminho, string.Empty);
    }
    
}