class Artista {

    // Nome do artista
    private string nome;

    // Data de seu nascimento
    private Data data_nascimento;

    // Campos nos quais o artista trabalha (Ex. Arquitetura, Escultura, Pintura, etc)
    string[] campos;

    // Construtor padrão sem parâmetros, em caso de artista anônimo
    public Artista() {
        this.nome = "Artista Anônimo";
        this.data_nascimento = new Data();
        this.campos = new string[1] {"Desconhecido"};
    }

    // Construtor para caso o artista seja conhecido
    public Artista(string p_nome, string p_data_nascimento, string[] p_campos, int p_qtd_campos) {
        this.nome = p_nome;
        this.data_nascimento = new Data(p_data_nascimento);
        campos = new string[p_qtd_campos];
        this.campos = p_campos;
    }

    // Método para retornar o nome do artista
    public string GetNome() {
        return this.nome;
    }
    // Método que retorna a data de nascimento do artista
    public Data GetDataNascimento() {
        return this.data_nascimento;
    }
    // Método retornando os campos nos quais o artista trabalha
    public string[] GetCampos() {
        return this.campos;
    }

    // Método para armazenar informações do artista
    public void ArmazenarInformacoes() {
        GravarArquivo gravar_nome = new GravarArquivo("_infos\\info_artista\\nome.txt");
        gravar_nome.GravarAppend(this.nome);

        GravarArquivo gravar_data_nascimento = new GravarArquivo("_infos\\info_artista\\data_nascimento.txt");
        gravar_data_nascimento.GravarAppend(this.data_nascimento.GetDataCompleta());

        GravarArquivo gravar_campos = new GravarArquivo("_infos\\info_artista\\campos.txt");
        string campos_completo = "";
        for (int i = 0; i < this.campos.Length; i++) {
            campos_completo += ";" + this.campos[i];
        }
        gravar_campos.GravarAppend(campos_completo);
    }

    // Método estático para pegar o nome de todos os artistas
    public static string[] LerNomes() {
        LerArquivo ler_nomes = new LerArquivo("_infos\\info_artista\\nome.txt");
        return ler_nomes.LerTodas();
    }
    // Método estático para pegar as respectivas datas de nascimento
    public static string[] LerDatasNascimentos() {
        LerArquivo ler_datas = new LerArquivo("_infos\\info_artista\\data_nascimento.txt");
        return ler_datas.LerTodas();
    }
    // Método estático para pegar todos os campos que o artista trabalha
    public static string[] LerCampos() {
        LerArquivo ler_campos = new LerArquivo("_infos\\info_artista\\campos.txt");
        return ler_campos.LerTodas();
    }

}