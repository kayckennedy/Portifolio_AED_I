class Pcgamer{
  private int memoriaRam;
  private int hd;
  private string processador;
  private string marca;
  private string cor;

  //Construtores da classe
  public Pcgamer(int m, int h, string p, string ma, string c){
    memoriaRam = m;
    hd = h;
    processador = p;
    marca = ma;
    cor = c;    
  }

  public Pcgamer(){
    memoriaRam = 8;
    hd = 500;
    processador = "intel i3";
    marca = "samsung";
    cor = "preto";
  }

  //metodos de acesso aos dados, que por sua vez estao privados
  public string getMarcaCor(){
    return marca;
    return cor;
  }

  public int getmemoriaHd(){
    return hd;
    return memoriaRam;
  }

  public string RetornaDados(){
    return string.Format("O computador tem {0} de memoria ram, {1} de espaçço no Hd, a cor é {2}, o processador é {3}, e a marca dele é {4}",memoriaRam, hd, cor, processador, marca);
  }



}