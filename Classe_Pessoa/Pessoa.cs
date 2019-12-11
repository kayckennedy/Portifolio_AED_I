class Pessoa {
  private string nome;
  private int idade;
  private float altura;
  private float peso;  

  public Pessoa(){
    nome = "Sem nome";
    idade = 0;
    altura = 0f;
    peso = 0f;
  }  

  public Pessoa(string n, int i, float a, float p){
    nome = n;
    idade = i;
    altura = a;
    peso = p;
  }


  public Pessoa MaisVelho(Pessoa outra_pessoa){
    if(idade > outra_pessoa.idade){
      return this;
    }
    else{
      return outra_pessoa;
    }
  }

  public float IMC(){
    float imc = peso/(altura*altura);
    return imc;
  }


  public string resumoDados(){
    return string.Format("Nome: {0}, {1} anos\nAltura: {2} - Peso:{3}",nome, idade, altura, peso);
  }

}