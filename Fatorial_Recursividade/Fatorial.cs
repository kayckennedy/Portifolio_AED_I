class Fatorial{

  public static int fat(int num){
    
    if (num <= 1)
      return num;

    return num * (num - 1); 
  }
}