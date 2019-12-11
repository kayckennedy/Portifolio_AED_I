class ObraDeArte {

    private string nome;
    private string artista;
    private int ano_de_criacao;
    private string descricao;

    // Método construtor sem parâmetros para caso de obra anônima
    public ObraDeArte() {
        this.nome = "Desconhecido";
        this.artista = "Desconhecido";
        this.ano_de_criacao = 0;
        this.descricao = "Desconhecido";
    }

    // Método construtor recebendo parâmetros para instância do objeto
    public ObraDeArte(string p_nome, string p_artista, int p_ano_de_criacao, string p_descricao) {
        this.nome = p_nome;
        this.artista = p_artista;
        this.ano_de_criacao = p_ano_de_criacao;
        this.descricao = p_descricao;
    }
        
    public ObraDeArte(string p_nome, int p_ano_de_criacao, string p_descricao) {
        this.nome = p_nome;
        this.artista = p_artista;
        this.ano_de_criacao = p_ano_de_criacao;
        this.descricao = p_descricao;
    }
    

    // Método para retornar o nome da obra
    public string GetNome() {
        return this.nome;
    }
    // Método para retornar o nome do artista criador
    public string GetNomeArtista() {
        return this.artista;
    }
    // Método para retornar o ano de criacao
    public int GetAnoCriacao() {
        return this.ano_de_criacao;
    }
    // Método para retornar a descricao da obra
    public string GetDescricao() {
        return this.descricao;
    }

    // Método para armazenar informações
    public void ArmazenarInformacoes() {
        GravarArquivo gravar_nome = new GravarArquivo("_infos\\info_obra\\nome.txt");
        gravar_nome.GravarAppend(this.nome);

        GravarArquivo gravar_nome_artista = new GravarArquivo("_infos\\info_obra\\nome_artista.txt");
        gravar_nome_artista.GravarAppend(this.artista);

        GravarArquivo gravar_ano_criacao = new GravarArquivo("_infos\\info_obra\\ano_criacao.txt");
        gravar_ano_criacao.GravarAppend(this.ano_de_criacao.ToString());

        GravarArquivo gravar_descricao = new GravarArquivo("_infos\\info_obra\\descricao.txt");
        gravar_descricao.GravarAppend(this.descricao);
    }

    // Método estático para pegar o nome de todas as obras de arte
    public static string[] LerObras() {
        LerArquivo ler_obras = new LerArquivo("_infos\\info_obra\\nome.txt");
        return ler_obras.LerTodas();
    }
    // Método estático para pegar o nome do criador de cada obra
    public static string[] LerArtistas() {
        LerArquivo ler_artistas = new LerArquivo("_infos\\info_obra\\nome_artista.txt");
        return ler_artistas.LerTodas();
    }
    // Método estático para pegar o ano de criação das obras
    public static string[] LerAnosCriacao() {
        LerArquivo ler_ano_criacao = new LerArquivo("_infos\\info_obra\\ano_criacao.txt");
        return ler_ano_criacao.LerTodas();
    }
    // Método estático para ler todas as descrições
    public static string[] LerDescricoes() {
        LerArquivo ler_descricoes = new LerArquivo("_infos\\info_obra\\descricao.txt");
        return ler_descricoes.LerTodas();
    }
}