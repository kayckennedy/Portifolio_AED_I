using System; 

class MainClass {
  public static void Main (string[] args) {

    int termo1 = 1;
    int termo2 = 1;

    Console.Write("{0},{1},", termo1, termo2);

    for (int i = 0; i <=18; i++){

      int prox_termo = termo1 + termo2;
      Console.Write(prox_termo+",");

      termo1 = termo2;
      termo2 = prox_termo;

    }
  }
}