class Data{
  private int dia, mes, ano;

  public int getDia(){
    return dia;
  }
  public int getMes(){
    return mes;
  }
  public int getAno(){
    return ano;
  }
  public void setDia(int d){
    dia = d;
  }

  public void setMes(int m){
    mes = m;
  } 

  public void setAno(int a){
    ano = a;
  }

  public void setData(string str_data){
    string[] dat = str_data.Split("/");
    dia = int.Parse(dat[0]);
    mes = int.Parse(dat[1]);
    ano = int.Parse(dat[2]);    
  } 

  public Data(){
    dia=1;
    mes=1;
    ano=2000;
  }

  public Data(int d, int m, int a){
    dia = d;
    mes = m;
    ano = a;
  }

  public Data(string str_data){
    setData(str_data);
  }

  public override string ToString(){
    return string.Format("{0}/{1}/{2}",dia, mes, ano);
  } 

  public string NomeMes(){
    string[] meses = new string[] {"Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro"};

    return meses[mes-1];
  }

  public bool Bissexto(){   
    return (ano%4==0 && ano%100!=0) || (ano%400==0);
  }

  public int MaxDiasMes(){
    switch(mes){
      case 1: case 3: case 5: case 7: 
      case 8: case 10: case 12:
        return 31;
       case 4: case 6: case 9: case 11:
         return 30;
        case 2:
          return Bissexto() ? 29 : 28;
        default:
          return 0;  
    }
  }

  public bool Maior(Data outra_data){
    if(ano > outra_data.ano){
      return true;
    }
    else{
      if(ano==outra_data.ano && mes > outra_data.mes){
        return true;
      }
      else{
        if(ano==outra_data.ano && mes == outra_data.mes && dia > outra_data.dia){
          return true;
        }
      }
    }

    return false;    
  }

  public bool Igual(Data outra){   
    return dia==outra.dia && mes==outra.mes && ano==outra.ano;
  }

  private void IncrementaUmDia(){
    if(dia < MaxDiasMes()){
      dia++;
    }
    else{
      dia = 1;
      if( mes == 12 ){
        mes = 1;
        ano++;
      }else{
        mes++;
      }
    }
  }

  public void Incrementa(int dias){
    for(int cont=1; cont<=dias; cont++)
      IncrementaUmDia();
  }

  public int Diferenca(Data outra){  
    Data maior, menor;

    if(this.Maior(outra)){
      maior = this;
      menor = new Data(outra.dia, outra.mes, outra.ano);
    }else{
      maior = outra;
      menor = new Data(this.dia, this.mes, this.ano);  
    }

    int dif_dias = 0;
    while(!menor.Igual(maior)){
      menor.IncrementaUmDia();
      dif_dias++;
    }

     return dif_dias;
  }



}