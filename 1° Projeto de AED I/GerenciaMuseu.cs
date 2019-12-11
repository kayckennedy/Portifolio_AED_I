using System;

class GerenciaMuseu {

    // Menu para a gerencia do museu, com "validação" de usuário
    public static void Menu() {

        // Pedindo informações de logon para o usuário
        Console.Write("\nEntre com seu usuário: ");
        string login = Console.ReadLine();
        Console.Write("Digite a Senha: ");
        string senha = Console.ReadLine();

        // Verificando/Validando informações de login
        if ((login == "kayc" || login == "deivisson" || login == "andre") && senha == "museumassa") {
            
            Museu museu = new Museu();

            Console.WriteLine("\nLogin efetuado com sucesso!\n");
        
            int escolha_menu_gerencia = 0;
            while (escolha_menu_gerencia != 8) {
            
                Console.WriteLine("======================================");
                Console.WriteLine("*= 1 - Presidência do museu");
                Console.WriteLine("*= 2 - Quantidade de funcionários");
                Console.WriteLine("*= 3 - Metros Quadrados");
                Console.WriteLine("*= 4 - Cadastrar Artista");
                Console.WriteLine("*= 5 - Avaliações dos visitantes");
                Console.WriteLine("*= 6 - Cadrastrar obras");
                Console.WriteLine("*= 7 - Listar visitas agendadas");
                Console.WriteLine("*= 8 - Para voltar ao Menu anterior");
                Console.WriteLine("*= 9 - Apagar avaliações gravadas na base");
                Console.WriteLine("*= 10 - Apagar visitas que estão agendadas");
                Console.WriteLine("*= 11 - Apagar lista de obras");
                Console.WriteLine("*= 12 - Apagar artistas cadastrados ");
                Console.WriteLine("======================================");
                Console.WriteLine("*= Escolha uma das opções acima ");
                Console.WriteLine("======================================");
                Console.Write("*= Escolha: ");

                escolha_menu_gerencia = int.Parse(Console.ReadLine());


                switch (escolha_menu_gerencia) {
                    case 1:
                        
                        Console.Write("\nDigite o nome do novo presidente: ");
                        string presidente = Console.ReadLine();
                        museu.SetNomePresidente(presidente);
                        Console.WriteLine("Alterado com sucesso!\n");

                    break;

                    case 2:

                        Console.Write("\nDigite o número novo de funcionários: ");
                        int funcionarios = int.Parse(Console.ReadLine());
                        museu.SetQtdFuncionarios(funcionarios);
                        Console.WriteLine("Alterado com sucesso!\n");

                    break;

                    case 3:

                        Console.Write("\nDigite a quantidade de metros² disponíveis para visitantes: ");
                        float metros_quadrados = float.Parse(Console.ReadLine());
                        museu.SetMetrosQuadrados(metros_quadrados);
                        Console.WriteLine("Alterado com sucesso!\n");

                    break;

                    case 4:
                        
                        Console.Write("\nDigite o nome do artista: ");
                        string nome_artista = Console.ReadLine();
                        Console.Write("Informe a data de seu nascimento noseguinte formato [DD/MM/AAAA]: ");
                        string data_nascimento = Console.ReadLine();

                        Console.Write("Informe o número de campos que o artista trabalha (Ex: Pintura, Arquitetura, etc): ");
                        int qtd_campos = int.Parse(Console.ReadLine());
                        string[] campos = new string[qtd_campos];

                        //A repetição acontecerá baseado na quantidade de campos passado pelo usuário
                        for (int i = 0; i < qtd_campos; i++) {
                            Console.Write("Informe o valor para o {0}° campo: ", i + 1);
                            campos[i] = Console.ReadLine();
                        }

                        Artista artista = new Artista(nome_artista, data_nascimento, campos, qtd_campos);
                        artista.ArmazenarInformacoes();

                        Console.WriteLine("\nArtista cadastrado com sucesso!\n");

                    break;

                    case 5: 
                        LerArquivo ler_avaliacoes = new LerArquivo("_infos\\avaliacoes.txt");
                        string[] vetor_avaliacoes = new string[ler_avaliacoes.QtdLinhas()];

                        vetor_avaliacoes = ler_avaliacoes.LerTodas();
                        for (int i = 0; i < vetor_avaliacoes.Length; i++){
                            Console.WriteLine("{0}° Avaliação {1}", i + 1, vetor_avaliacoes[i]);
                        }
                    break;
                    
                    case 9:
                        GravarArquivo limpar_avaliacoes = new GravarArquivo("_infos\\avaliacoes.txt");
                        limpar_avaliacoes.LimparArquivo();
                        Console.WriteLine("Avaliações apagadas com sucesso!");

                    break;

                    case 6:
                        
                        Console.Write("\nInforme o nome da obra: ");
                        string nome_obra = Console.ReadLine();
                        Console.Write("Informe o ano de criação da obra: ");
                        int ano_criacao_obra = int.Parse(Console.ReadLine());
                        Console.Write("Faça uma breve descrição da obra: ");
                        string descricao = Console.ReadLine();
                        Console.WriteLine("O autor é anonimo ? [S/n]");
                        string anonimato = Console.ReadLine();
                        
                        string nome_autor; 
                        if (anonimato.ToUpper() == "S"){
                            nome_autor = "Anonimo";
                        }
                        else{
                            LerArquivo ler_nomes_artistas = new LerArquivo("_infos\\info_artista\\nome.txt");
                            string[] artistas = new string[ler_nomes_artistas.QtdLinhas()];
                            artistas = ler_nomes_artistas.LerTodas();
                            
                            
                    
                            
                            for(int i = 0; i < artistas.Length; i++){
                                Console.WriteLine("\n{0} para {1}", i + 1, artistas[i]);
                            }

                            Console.WriteLine("\nSelecione um dos autores da obra que já estão cadastrados em nosso museu");
                            int autor_selecionado = int.Parse(Console.ReadLine());
                            nome_autor = artistas[autor_selecionado - 1];
                        }
                        
                        ObraDeArte criarObra = new ObraDeArte(nome_obra, nome_autor, ano_criacao_obra, descricao);
                        criarObra.ArmazenarInformacoes();
                    
                        Console.WriteLine("Obra salva com sucesso!");
                        
                    break;

                    case 7:

                        LerArquivo ler_visitas = new LerArquivo("_infos\\agenda.txt");
                        string[] vetor_visitas = new string[ler_visitas.QtdLinhas()];

                        vetor_visitas = ler_visitas.LerTodas();
                        for (int i = 0; i < vetor_visitas.Length; i++){
                            Console.WriteLine(vetor_visitas[i]);
                        }

                    break;

                    case 10:
                        GravarArquivo limpar_agenda = new GravarArquivo("_infos\\agenda.txt");
                        limpar_agenda.LimparArquivo();
                        Console.WriteLine("\nAgenda apagada com sucesso!");
                    break;

                    case 11:
                        GravarArquivo limpar_ano = new GravarArquivo("_infos\\info_obra\\ano_criacao.txt");
                        limpar_ano.LimparArquivo();

                        GravarArquivo limpar_nome_artista = new GravarArquivo("_infos\\info_obra\\nome_artista.txt");
                        limpar_nome_artista.LimparArquivo();

                        GravarArquivo limpar_nome_obra = new GravarArquivo("_infos\\info_obra\\nome.txt");
                        limpar_nome_obra.LimparArquivo();

                        GravarArquivo limpar_descricao = new GravarArquivo("_infos\\info_obra\\descricao.txt");
                        limpar_descricao.LimparArquivo();

                        Console.WriteLine("\nObras apagadas com sucesso!");

                    break;

                    case 12:
                        GravarArquivo limpar_artista_campos = new GravarArquivo("_infos\\info_artista\\campos.txt");
                        limpar_artista_campos.LimparArquivo();

                        GravarArquivo limpar_artista_nascimento = new GravarArquivo("_infos\\info_artista\\data_nascimento.txt");
                        limpar_artista_nascimento.LimparArquivo();

                        GravarArquivo limpar_artista_nome = new GravarArquivo("_infos\\info_artista\\nome.txt");
                        limpar_artista_nome.LimparArquivo();

                        Console.WriteLine("\n Lista de artistas cadrastados apagada com sucesso");
                    break;
                }

            }

        }
        else {
            Console.Write("\nVerifique as informações e tente novamente!\n");
        }

    }

}
