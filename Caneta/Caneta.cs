class Caneta{
  //Atributos
  private string cor;
  private string marca;
  private float qtd_tinta;
  private float max_tinta;

  //Construtores
  public Caneta(){
    cor = "azul";
    marca = "bic";
    qtd_tinta = 100f;
    max_tinta = 100f;
  }

  public Caneta(string cor, string marca){
    this.cor = cor;
    this.marca = marca;   
    this.qtd_tinta = 50f;
    max_tinta = 100f;
  }

  public Caneta(string cor, string marca, float qtd_tinta){
    this.cor = cor;
    this.marca = marca;
    this.qtd_tinta = qtd_tinta;
    this.max_tinta = 100f;
  }

  //Métodos de Acesso   
  //get e set
  public string getCor(){
    return cor;
  } 

  public void setCor(string c){
    cor = c;
  }


  //Demais métodos
  public string ResumoDados(){
    return string.Format("Cor: {0}, Marca: {1}, Qtd:{2}",
                          cor, marca, qtd_tinta);
  }

  public bool TransferirCarga(Caneta destino, float qtd){
    //verificar se cabe no destino a quantidade solicitada
    if( (destino.max_tinta - destino.qtd_tinta) >= qtd){
      //verificar se há tinta suficiente na origem    
      if(this.qtd_tinta >= qtd){
        //verificar se a cor é a mesma
        if(this.cor == destino.cor){
          destino.qtd_tinta += qtd;
          this.qtd_tinta -= qtd;
          return true;
        }
      }
    }
    return false;
  }
}