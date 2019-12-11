class Agendador {

    public static string Agendar(string p_nome, string p_data, string pa_hora_ini, string pa_hora_fin) {

        // VARIÁVEIS PARA VALIDAR NO FINAL DO MÉTODO //
        bool nome_verificado;
        bool data_verificada;
        bool horario_verificado;
        // FIM VARIÁVEIS VERIFICAR NO FINAL //

        // VARIÁVEL COM A DATA VERIFICADA
        Data pa_data = new Data(p_data);
        data_verificada = pa_data.data_validada;
        // FIM VARIÁVEL
        
        // VERIFICANDO A HORA DE VISITA //
        string[] horario_inicial = new string[2];
        horario_inicial = pa_hora_ini.Split(":");
        string[] horario_final = new string[2];
        horario_final = pa_hora_fin.Split(":");

        int hora_ini = int.Parse(horario_inicial[0]);
        int minu_ini = int.Parse(horario_inicial[1]);
        int hora_fin = int.Parse(horario_final[0]);
        int minu_fin = int.Parse(horario_final[1]);

        if ((hora_ini >= 8 && hora_ini <= 17) && (minu_ini >= 0 && minu_ini <= 59) && (hora_fin >= hora_ini && hora_fin <= 17) && (minu_fin >= 0 && minu_fin <= 59)) {
            horario_verificado = true;
        } else {
            horario_verificado = false;
        }
        // FIM VERIFICAR HORA DE VISITA //

        // VERIFICAR NOME DO VISITANTE //
        if (!string.IsNullOrEmpty(p_nome)) {
            nome_verificado = true;
        } else {
            nome_verificado = false;
        }
        // FIM VERIFICAR NOME DO VISITANTE //

        // GRAVAR NO ARQUIVO CASO DADOS VÁLIDOS //
        if (nome_verificado && data_verificada && horario_verificado) {
            string texto_formatado_para_gravar;
            texto_formatado_para_gravar = "Nome: " + p_nome + ". Data: " + p_data + ". Hora da Entrada: " + pa_hora_ini + ". Hora Saída: " + pa_hora_fin + ".";

            GravarArquivo gravar_visita = new GravarArquivo("_infos\\agenda.txt");
            gravar_visita.GravarAppend(texto_formatado_para_gravar);

            return "\nAgendado com sucesso!\nFoi armazenado o seguinte registro...\n" + texto_formatado_para_gravar;
        }
        return "\nNão foi possível fazer o agendamento...\nPor favor, verifique os dados e tente novamente.";
        // FIM GRAVAR NO ARQUIVO OS DADOS VÁLIDOS //

    }

}