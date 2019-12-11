class Museu {

    //atributos privados 
    private string presidente_atual;
    private Data data_fundacao;
    private float metros_quadrados_atual;
    private int qtd_funcionarios;
    //

    //Construtor "padrao" da classe, nao recebe parâmetro nenhum
    public Museu() {
        //objeto do tipo LerArquivo, passa como parÂmetro o caminho que o arquivo está
        LerArquivo ler_presidente = new LerArquivo("_infos\\info_museu\\nome_presidente.txt");

        //armazena o valor que é retornado pelo metodo LerLinha
        this.presidente_atual = ler_presidente.LerLinha();

        LerArquivo ler_data_fundacao = new LerArquivo("_infos\\info_museu\\data_fundacao.txt");

        //tratamento de excessão
        try {
            this.data_fundacao = new Data(ler_data_fundacao.LerLinha());//leia o arquivo normalmente 
        }catch {
            //caso dê erro, significa que o arquivo está vazio
            this.data_fundacao = new Data("0/0/0");//Então passo uma data em formato de string zerada como parâmetro
        }
        

        LerArquivo ler_metros_quadrados = new LerArquivo("_infos\\info_museu\\metros_quadrados.txt");

        try {
            this.metros_quadrados_atual = float.Parse(ler_metros_quadrados.LerLinha());//leia o arquivo normalmente
        } catch {
            this.metros_quadrados_atual = 0f;//caso dê erro, singnifica que o arquivo está vazio 
        }

        LerArquivo ler_qtd_funcionarios = new LerArquivo("_infos\\info_museu\\qtd_funcionario.txt");

        try {
            this.qtd_funcionarios = int.Parse(ler_qtd_funcionarios.LerLinha());//Ler o arquivo
        } catch {
            this.qtd_funcionarios = 0;//caso o arquivo esteja vazio, passo 0 como valor
        }
        //Fim do tratamento de excessão 
        
    }
    // Metodos para setar os valores e passar os parâmetros para a classe de gravar nos arquivos
    public void SetNomePresidente(string p_nome) {
        this.presidente_atual = p_nome;

        //passagem do caminho do arquivo para a classe
        GravarArquivo gravar_presidente = new GravarArquivo("_infos\\info_museu\\nome_presidente.txt");

        // Chamada de metodo para gravar passando como parâmetro os dados a serem gravados
        gravar_presidente.GravarLinha(this.presidente_atual);
    }
    public void SetDataFundacao(string p_data) {
        this.data_fundacao = new Data(p_data);

        GravarArquivo gravar_fundacao = new GravarArquivo("_infos\\info_museu\\data_fundacao.txt");

        gravar_fundacao.GravarLinha(this.data_fundacao.GetDataCompleta());
    }
    public void SetMetrosQuadrados(float p_metros) {
        this.metros_quadrados_atual = p_metros;

        GravarArquivo gravar_metros = new GravarArquivo("_infos\\info_museu\\metros_quadrados.txt");

        gravar_metros.GravarLinha(this.metros_quadrados_atual.ToString());
    }
    public void SetQtdFuncionarios(int p_qtd) {
        this.qtd_funcionarios = p_qtd;

        GravarArquivo gravar_qtd = new GravarArquivo("_infos\\info_museu\\qtd_funcionario.txt");

        gravar_qtd.GravarLinha(this.qtd_funcionarios.ToString());
    }
    //Fim dos metodos set

    //Metodos Get, para acessar os atributos privados
    public string GetNomePresidente() {
        return this.presidente_atual;
    }
    public string GetDataFundacao() {
        return this.data_fundacao.GetDataCompleta();
    }
    public float GetMetrosQuadrados() {
        return this.metros_quadrados_atual;
    }
    public int GetQtdFuncionarios() {
        return this.qtd_funcionarios;
    }
    //Fim dos metodos Get
}