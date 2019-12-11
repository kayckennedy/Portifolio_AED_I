using System;

/*Exercício 2 - Crie uma classe para representar uma Data que possua:
    - Pelo menos 2 construtores
    - Os métodos GET e SET
    - Implemente o método público NomeMes() que retorna o nome do mês atualmente configurado em um objeto da classe Data
    - Implemente o método Bissexto() que retorna verdadeiro se o ano atual for bissexto, e retorna falso caso contrário
    - Implemente o método Incrementa(int dias) da classe Data. Esse método adiciona à data atual o número de dias informado como parâmetro
    - Implemente o método Diferenca() que retorna o número de dias entre duas datas (a atual e uma outra informada como parâmetro)*/

class MainClass {
  public static void Main (string[] args) {

//recebendo os valores do usuario
    Console.WriteLine("Qual é o dia, mes e ano do seu aniversario ?");
    int dia = int.Parse(Console.ReadLine());
    string mes = Console.ReadLine();
    int ano = int.Parse(Console.ReadLine());

//passando os valores padroes como parametro
    Data hoje = new Data(11,09,2019);

//passando os valores do usuario como parametro
    Data aniversario = new Data(dia, mes, ano);
    
//imprimindo na tela
    Console.WriteLine(hoje.verificarAno());

    Console.WriteLine(aniversario.saidaDados());

  }
}