class Pessoa{
  private string nome;
  private int idade;
  private char sexo;
  
  //Contrutores da classe pessoa 
  public Pessoa(string n, int i, char s){
    nome = n;
    idade = i;
    sexo = s;
  }

  //metados de acesso, retona os valores
  public string getNome(){
    return nome;
  }
  public int getIdade(){
    return idade;
  }

  public char getSexo(){
    return sexo;
  }

  //Retona os valores para o programa principal e forma de texto 
  public string saidaDados(){
    return string.Format("O nome da pessoa é {0}, ela tem {1} anos, e é do sexo {2}.",nome, idade, sexo);
  }

}