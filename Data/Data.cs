class Data {
  private int dia;
  private int mes;
  private int ano;
  private int aniversarioD;
  private string aniversarioM;
  private int aniversarioA;
  //private int listaMes = new int[31,28,31,30,31,30,31,31,30,31,30,31];


//Construtores da classe

//atribui as variaveis a data atual, que será padrao
  public Data(int d, int m, int a){
    dia = d;
    mes = m;
    ano = a;
    
  }
//atribui as variaveis a data de aniversario do usuario
  public Data(int dia, string mes, int ano){
    aniversarioD = dia;
    aniversarioM = mes;
    aniversarioA = ano; 
  }


//retornando os valores

  //retorna os valores da data padrao, data de hoje
  public int getDia(){
    return dia;
  }
  public int getMes(){
    return mes;
  }
  public int getAno(){
    return ano;
  }

  //retorna os valores do aniversario do usuario
  public int getAniversarioD(){
    return aniversarioD;
  }

  public string getAniversarioM(){
    return aniversarioM;
  }

  public int getAniversarioA(){
    return aniversarioA;
  }


  //faz a verificação se o mes atual é valido e retorna ele para o usuário 
  public string getMesvalido(){
    switch(mes){
      case 01: return "Janeiro";
      case 02: return "Fevereiro";
      case 03: return "Março";
      case 04: return "Abril";
      case 05: return "Maio";
      case 06: return "Junho";
      case 07: return "Julho";
      case 08: return "Agosto";
      case 09: return "Setembro";
      case 10: return "Outubro";
      case 11: return "Novembro";
      case 12: return "Dezembro";

      default:
        return "Mês invalido"; 
          break;
    }
  }

  //faz a verificação se o mes que o usuario passou como parametro existe ou nao
   public string getAniversarioValido(){
    switch(aniversarioM){
      case "janeiro": return aniversarioM;
      case  "fevereiro": return aniversarioM;
      case "março": return aniversarioM;
      case "abril": return aniversarioM;
      case "maio": return aniversarioM;
      case "junho": return aniversarioM;
      case "julho": return aniversarioM;
      case "agosto": return aniversarioM;
      case "setembro": return aniversarioM;
      case "outubro": return aniversarioM;
      case "novembro": return aniversarioM;
      case "dezembro": return aniversarioM;


      default:
        return "Mês invalido"; 
          break;
    }
  }

  //verifica se o ano atual é bissexto e retorna se é verdadeiro ou falso
  public bool bissexto(){
    if(ano % 4 == 0 && ano % 100 != 0){
        return true;
    }
    else if (ano % 400 == 0){
      return true;
    }
    else{
      return false;
    }
  }

  //verifica se o ano que a pessoa nasceu é bissexto e retorna para o usuario
  public string aniversarioBissexto(){
    if (aniversarioA % 4 == 0 && ano % 100 != 0){
      return "Você nasceu em um ano bissexto ";
    }
    else if (aniversarioA % 400 == 0){
      return "Você nasceu em um ano bissexto ";
    }
    else{
      return "Você nao nasceu em um ano bissexto ";
    }
  } 

  public int getIncrementa(){
    dia = aniversarioD;
    return dia;
    
  }

  //demais metodos: faz a concatenação de strings e retorna os valores obtidos de outros metodos para o programa principal
  public string verificarAno(){
    return "O dia passado como parametro é "+ dia + ",o mês atual é " + getMesvalido() + " e o ano é bissexto: " + bissexto();
  }

  public string saidaDados(){
    return "Seu aniversario é " + aniversarioD + "/" + getAniversarioValido() + "/" + aniversarioA +" e " + aniversarioBissexto();
  }
  

}