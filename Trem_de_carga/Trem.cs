class Trem{
 private int carga;
 private int velocidade;
 private string tipoTrem;
 private int cargaMaxima;

 Vagao primeiroVagao;
 Vagao segundoVagao;
 Vagao terceiroVagao;


//Contrutor principal da classe

public Trem(int ve, string ti, Vagao a, Vagao b, Vagao c, int ca){//Contrutor da classe que recebe parametros do tipo vagao 
velocidade = ve;
tipoTrem = ti;
carga = a.getTonelada() + b.getTonelada() + c.getTonelada(); // variavel carga recebendo acraga dos 3 vagoes e somando
cargaMaxima = ca;
}


 /*public Trem(int ve, string ti){//construtor que recebe apenas 2 parâmetros 
    velocidade = ve;
    tipoTrem = ti;
 }
 
  public Trem(){
   velocidade = 250;
   tipoTrem = "";
      
 }*/
  // metodos de acesso de dados/ get
  public string getTipo(){
    return tipoTrem;
  }
  public int getCargaMaxima(){
    return cargaMaxima;
  }
  
  public int getVelocidade(){
    return velocidade;
  }
  
  //metodo de definição de dados / set
  public void setPrimeiro(int getTonelada, string t){
    primeiroVagao = new Vagao(getTonelada,t);//cria um novo objeto usando os valores passados como parâmetro 
  }
  public void setSegundo(int getTonelada, string t){
    segundoVagao = new Vagao(getTonelada,t);//cria um novo objeto usando os valores passados como parâmetro
  }  
  public void setTerceiro(int getTonelada, string t){
    terceiroVagao = new Vagao(getTonelada,t);//cria um novo objeto usando os valores passados como parâmetro
  }

  public string cargaRestante(){//Retorna a capacidade de carga restante que o trem ainda consegue carregar 
    if (cargaMaxima >= carga){
      return string.Format("Espaço de carga restante: {0}",cargaMaxima - carga);
    }
    return "Carga excedeu o limite maximo";
  }

  public int cargaTotal(){
    return carga;//retorna a quantidade de carga dos tres vagoes somados
  }
}
