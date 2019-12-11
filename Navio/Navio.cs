class Navio{
  private int capacidadeTotal;
  private int cargaAtual;
  private int capacidadeLivre;
  private string cor;
  private string tipo;
  private int tripulacao;

  //construtor da classe
  public Navio(int i, int a,string u, string o, int b){
    capacidadeTotal = i;
    cargaAtual = a;
    cor = u;
    tipo = o;
    tripulacao = b;
  }
  //contrutor padrao
  public Navio(){
    capacidadeTotal = 150;
    cargaAtual = 0;
    cor = "Branco";
    tipo = "Cruzeiro";
    tripulacao = 50;
  }
  
  //Metodos de acesso get 
  public int getLivre(){
    return capacidadeTotal - cargaAtual;  
  }
  public int getCapacidadeTotal(){
    return capacidadeTotal;
  }
  public int getCapacidadeAtual(){
    return cargaAtual;
  }
  public string getCor(){
    return cor;
  }
  public string gettipo(){
    return tipo;
  }
  public int getTripulacao(){
    return tripulacao;
  }
  //metodos set
  public void setCargaAtual(int carga){
    cargaAtual += carga;
  }

  //metodos que retorna se o objeto barco tem uma carga atual maior que o objeto canoa
  public bool maiorCarga(Navio outroNavio){
    if (this.cargaAtual > outroNavio.cargaAtual){

      return true;
    }
    return false;
  }
  
  //metodo que retorna se o objeto canoa tem capacidade livre para receber a carga do objeto barco e ajusta a carga do objeto canoa caso atenda a condição 
  public bool transfereCarga(Navio outroNavio){
    if (outroNavio.getLivre() > this.cargaAtual){
      outroNavio.setCargaAtual(this.cargaAtual);
      return true;
    }
    return false;
  }


}


