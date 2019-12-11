class CalculadoraInt{
  //Atributos da classe:
  private int oper1, oper2;

  //Métodos de acesso: get
  public int getOperando1(){
    return oper1;
  } 
  public int getOperando2(){
    return oper2;
  } 
  //Métodos de acesso: set
  public void setOperando1(int op1){
    oper1 = op1;
  } 
  public void setOperando2(int op2){
    oper2 = op2;
  } 

  //Construtores:
  public CalculadoraInt(){
    oper1 = 0;
    oper2 = 0;
  }

  public CalculadoraInt(int op1, int op2){
    oper1 = op1;
    oper2 = op2;
  }
  //Métodos não estáticos (de instância):
  public int Soma(){
    return oper1 + oper2;
  }
  public int Multiplicacao(){
    return oper1 * oper2;
  }
  public int Divisao(){
    return oper1 / oper2;
  }
  public int Subtracao(){
    return oper1 - oper2;
  }

  public int Maior(){
    if(oper1 > oper2)
      return oper1;

    return oper2;
  }

  //Método estático:
  public static int Soma(int op1, int op2){
    return op1 + op2;
  }

}