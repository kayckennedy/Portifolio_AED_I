class Vagao{
  
  private int qtdTonelada;
  private string tipoCarga;
  
//construtor
  public Vagao(int p, string c){
    qtdTonelada = p;
    tipoCarga = c;
  }
  
  public Vagao(){
    qtdTonelada = 25;
    tipoCarga = "areia";
  }
  //
  
  public int getTonelada(){
    return qtdTonelada;
  }
  public string getTipo(){
    return tipoCarga;
  }


}