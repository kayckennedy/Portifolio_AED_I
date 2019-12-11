class Data {

    private int dia;
    private int mes;
    private int ano;
    private int[] qtd_dias_no_mes = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
    public bool data_validada = false;

    // Construtor sem parâmetros para casos de artista anônimo, obra anônima ou data inválida
    public Data() {
        this.dia = 0;
        this.mes = 0;
        this.ano = 0;
    }

    // Construtor da classe, verifica se a data é válida ou não
    public Data(string data_completa) {
        string[] data_quebrada = new string[3];
        data_quebrada = data_completa.Split("/");

        int p_dia = int.Parse(data_quebrada[0]);
        int p_mes = int.Parse(data_quebrada[1]);
        int p_ano = int.Parse(data_quebrada[2]);

        VerificarBissexto(p_ano);

        if (ValidarData(p_dia, p_mes)) {
            this.dia = p_dia;
            this.mes = p_mes;
            this.ano = p_ano;
            this.data_validada = true;
        } else { // Caso não seja validado
            this.dia = 0;
            this.mes = 0;
            this.ano = 0;
        }
    }

    // Método privado para verificar se o ano é bissexto ou não
        private void VerificarBissexto(int p_ano) {
            if ((p_ano % 400 == 0) || (p_ano % 4 == 0 && p_ano % 100 != 0)) {
                this.qtd_dias_no_mes[1] = 29;
            }
        }

    // Verifica se a data é válida ou não
    private bool ValidarData(int p_dia, int p_mes) {
        if ((p_mes >= 1 && p_mes <= 12) && (p_dia >= 1 && p_dia <= this.qtd_dias_no_mes[p_mes - 1])) {
            return true;
        }
        return false;
    }

    // Método para retornar uma string contendo a data completa
    public string GetDataCompleta() {
        string s_dia;
        string s_mes;
        string s_ano;

        if (this.dia >= 0 && this.dia <= 9) {
            s_dia = "0" + this.dia.ToString();
        } else {
            s_dia = this.dia.ToString();
        }

        if (this.mes >= 0 && this.mes <= 9) {
            s_mes = "0" + this.mes.ToString();
        } else {
            s_mes = this.mes.ToString();
        }

        if (this.ano == 0) {
            s_ano = "0000";
        } else {
            s_ano = this.ano.ToString();
        }

        return s_dia + "/" + s_mes + "/" + s_ano;
    }

}