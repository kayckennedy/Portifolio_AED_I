class Pessoa{
  private string nome;
  private int idade;
  private Data dataNascimento;
  private Pessoa pai;
  private Pessoa mae;

  public Data getDataNascimento(){
    return dataNascimento;
  }

  public void setDataNascimento(Data dt){
    dataNascimento = dt;
  }

  public string getNome(){
    return nome;
  }

  public int getIdade(){
    return idade;
  }

  public Pessoa getPai(){
    return pai;
  }

  public Pessoa getMae(){
    return mae;
  }

  public void setPai(Pessoa pai){
    this.pai = pai;
  }

  public void setMae(Pessoa mae){
    this.mae = mae;
  }

  public string PaiMae(){
    return pai.getNome() + " / " + mae.getNome();
  }

  //Acesso  TipoRetorno  Nome(  Parametros )
  public string maisVelho(int id, string n){
    if(idade > id)
      return nome;
    else
      return n;
  }
  //Acesso  TipoRetorno  Nome(  Parametros )
  public Pessoa maisVelho(Pessoa outra){
    if(idade > outra.idade)
      return this;
    
    return outra;
  }

  //Construtor da classe:
  public Pessoa(){
    nome = "Sem nome ainda!";
    idade = 0;
    dataNascimento = new Data("01/01/2000");
  }
  public Pessoa(string n, int i){
    nome = n;
    idade = i;
    dataNascimento = new Data(01, 01, 2000);
  }

  public Pessoa(string n, int i, Data dt){
    nome = n;
    idade = i;
    dataNascimento = dt;   
  }

  public Pessoa AvoPaternoH(){
    return pai.getPai();
  }

  public Pessoa AvoPaternoM(){
    return pai.getMae();
  }


  public int Diferenca(Pessoa outra_pes){
    return this.dataNascimento.Diferenca(outra_pes.dataNascimento);
  }

}