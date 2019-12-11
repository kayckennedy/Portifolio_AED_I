using System;

namespace projeto_aed1_remaster
{
    class Program
    {
        static void Main(string[] args)
        {
            

            // Loop para repetição do menu de acordo com as opções do usuário
            int escolha_menu_principal = 0;
            while (escolha_menu_principal != 9) {

                // Menu para escolha entre as opções
                Console.WriteLine("\n*===========================================*");
                Console.WriteLine("*= Escolha UMA entre as opções disponíveis =*");
                Console.WriteLine("*===========================================*");
                Console.WriteLine("*= 1 - Ver informações sobre o museu");
                Console.WriteLine("*= 2 - Obras em exposição");
                Console.WriteLine("*= 3 - Agendar uma visita");
                Console.WriteLine("*= 4 - Listar artistas cadastrados");
                Console.WriteLine("*= 5 - Avalie sua visita, nos ajude a melhorar");
                Console.WriteLine("*= 8 - Administração do museu");
                Console.WriteLine("*= 9 - Sair do programa");
                Console.WriteLine("*===========================================*");
                Console.Write("*= Escolha: ");
                escolha_menu_principal = int.Parse(Console.ReadLine());
                
                // Interage de acordo com a escolha do usuário
                switch (escolha_menu_principal) {
                    case 1:
                    
                        Museu museu = new Museu();
                        LerArquivo qtd_obras = new LerArquivo("_infos\\info_obra\\nome.txt");

                        Console.WriteLine("\n*===============================================*");
                        Console.WriteLine("* Bem vindo ao Museu Estadual do Espirito Santo *");
                        Console.WriteLine("*===============================================*");
                        Console.WriteLine("- O Museu foi inaugurado em {0}", museu.GetDataFundacao());
                        Console.WriteLine("- Fundando por Kayc Kennedy e Deivisson Altoé");
                        Console.WriteLine("- Nosso Museu conta com um grande acervo de obras, dos mais variados tipos e gostos, são cerca de {0} obras", qtd_obras.QtdLinhas());
                        Console.WriteLine("- Nosso presidente atual é o {0}", museu.GetNomePresidente());
                        Console.WriteLine("- Contamos com cerca de {0} colaboradores, prontos para lhe prestar o melhor atendimento", museu.GetQtdFuncionarios());
                        Console.WriteLine("- Temos {0} metros² disponiveis para os visitantes", museu.GetMetrosQuadrados());
                        Console.WriteLine("*===============================================*");
                    
                    break;
                    case 2:

                        Console.WriteLine("\n==========================================");
                        Console.WriteLine("= As obras em exposição são as seguintes =");
                        Console.WriteLine("==========================================\n");

                        string[] obras_nomes = ObraDeArte.LerObras();
                        string[] obras_artistas = ObraDeArte.LerArtistas();
                        string[] obras_data = ObraDeArte.LerAnosCriacao();
                        string[] obras_descricao = ObraDeArte.LerDescricoes();

                        for (int i = 0; i < obras_nomes.Length; i++) {
                            Console.WriteLine("Título da Obra: {0}", obras_nomes[i]);
                            Console.Write("Criada por: {0}", obras_artistas[i]);
                            Console.WriteLine(". Em: {0}", obras_data[i]);
                            Console.WriteLine("Descrição: {0}\n", obras_descricao[i]);
                            
                        }
                    
                    break;
                    case 3:

                        Console.Write("Por favor, insira seu nome: ");
                        string nome = Console.ReadLine();
                        Console.Write("Agora insira o dia para a visita pelo seguinte formato [DD/MM/AAAA]: ");
                        string data = Console.ReadLine();
                        Console.Write("Insira a hora para começar a excursão [HH:MM]: ");
                        string hora_ini = Console.ReadLine();
                        Console.Write("Insira a hora de término da excursão [HH:MM]: ");
                        string hora_fin = Console.ReadLine();

                        Console.WriteLine(Agendador.Agendar(nome, data, hora_ini, hora_fin));

                    break;
                    case 4:

                        Console.WriteLine("\n==========================================");
                        Console.WriteLine("= Os artistas cadastrados são os seguintes =");
                        Console.WriteLine("==========================================\n");

                        string[] nomes_artistas = Artista.LerNomes();
                        string[] datas_nascimentos = Artista.LerDatasNascimentos();
                        string[] todos_campos_juntos = Artista.LerCampos();

                        for (int i = 0; i < nomes_artistas.Length; i++) {
                            Console.WriteLine("Nome: {0}", nomes_artistas[i]);
                            Console.WriteLine("Nascido em: {0}", datas_nascimentos[i]);
                            Console.Write("Sua(s) área(s) de atuação é/são a(s) seguinte(s): ");
                            int qtd_linhas_campos = todos_campos_juntos[i].Split(";").Length;
                            string[] campos_separados = new string[qtd_linhas_campos];
                            campos_separados = todos_campos_juntos[i].Split(";");
                            for (int j = 0; j < campos_separados.Length; j++) {
                                Console.Write("{0} / ", campos_separados[j]);
                            }
                            Console.WriteLine("\n");
                        }

                    break;

                    case 5: 
                        GravarArquivo gravar_avaliacoes = new GravarArquivo("_infos\\avaliacoes.txt");
                        Console.Write("Informe sugestões de melhorias:");
                        string sugestoes_usuario = Console.ReadLine();

                        gravar_avaliacoes.GravarAppend(sugestoes_usuario);
                        Console.WriteLine("\nObrigado pelo Feedback, iremos fazer o possivel para melhorar cada vez mais");
                        break;
                    

                    case 8:

                        GerenciaMuseu.Menu();

                    break;
                    default:
                    Console.WriteLine("Escolha inválida, tente novamente.");
                    break;
                }

            }


        }
    }
}

