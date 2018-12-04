using System;

namespace CompanhiaAerea
{
    class Program
    {
        public static void Main(string[] args)
        {

            string cpf = null;
            string nome = null;
            string sobrenome = null;
            string endereco = null;
            int telefone = 0;
            int numeropassagem = 0;
            int numerovoo = 0;
            string horario = null;
            int poltrona = 0;

            string VooEscolhido = null;
            string voo = null;

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n\n\n\n\t\t\tSEJA BEM-VINDO A AIR FORCE ONE\n\n\n");
            Console.WriteLine(
                              "\t---------------------Selecione o seu Voo----------------------\n\n" +
                "\t\t  31 -From Belo Horizonte to Sao paulo\n " +
                "\t\t  21- From Belo Horizonte to Rio de Janeiro\n " +
                "\t\t  81- From Belo Horizonte to Recife\n ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\t\t\t Digite o número do seu voo: \n\n");
            Console.Write("\t\t\t\t");

            voo = Console.ReadLine();


            if (voo == "31")
            {
                VooEscolhido = "From (CNF) TO (GRU)";
            }

            else if (voo == "21")
            {
                VooEscolhido = "From (CNF) TO (GIG)";
            }

            else if (voo == "81")
            {
                VooEscolhido = "From (CNF) TO (REC)";
            }
         

            while (true)
            {

                Passageiros passageiro1 = new Passageiros("05867322416", "Domingos", "Neto", "Rua Papoula Azul 225", 997497451, 01, 01, "00:00", 54);
                passageiro1.Cadastrar();
                Passageiros passageiro2 = new Passageiros("08007487603", "Aline", "Alves", "Rua Papoula Azul 225", 995202426, 01, 01, "00:00", 55);
                passageiro2.Cadastrar();
                Passageiros passageiro3 = new Passageiros("01122345609", "Danilo", "Alves", "Rua Papoula Azul 225", 995202426, 01, 02, "00:00", 33);
                passageiro3.Cadastrar();
                Passageiros passageiro4 = new Passageiros("01122345609", "Patricia", "Alves", "Rua Papoula Azul 225", 995202426, 01, 03, "00:00", 17);
                passageiro4.Cadastrar();
                Passageiros passageiro5 = new Passageiros("01122345609", "Caio", "Alves", "Rua Papoula Azul 225", 995202426, 01, 03, "00:00", 14);
                passageiro5.Cadastrar();
              


                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("-------------------MENU DE OPÇÕES---------------\n    ");

                Console.WriteLine("║  Menu referente ao Voo -> " + VooEscolhido );

                Console.WriteLine("║                                               ║    ");

                Console.WriteLine("║                                               ║    ");

                Console.WriteLine("║ 1 LISTA DE PASSAGEIROS                        ║    ");

                Console.WriteLine("║                                               ║    ");

                Console.WriteLine("║ 2 PESQUISAR                                   ║    ");

                Console.WriteLine("║                                               ║    ");

                Console.WriteLine("║ 3 CADASTRAR PASSAGEIROS                       ║    ");

                Console.WriteLine("║                                               ║    ");

                Console.WriteLine("║ 4 EXCLUIR PASSAGEIRO DA LISTA                 ║    ");

                Console.WriteLine("║                                               ║    ");

                Console.WriteLine("║ 5 MOSTRAR LISTA DE ESPERA                     ║    ");

                Console.WriteLine("║                                               ║    ");

                Console.WriteLine("║ 6 SAIR                                        ║    ");

                Console.WriteLine("╚═══════════════════════════════════════════════╝    ");

                Console.WriteLine(" ");


                Console.Write("Selecione a opção desejada : ");

                var leitura = Console.ReadLine();


                if (leitura == "3")
                {
                    Console.Clear();
                    Console.WriteLine("Digite o CPF do passageiro :");
                    cpf = Console.ReadLine();
                    Console.WriteLine("Digite o nome do passageiro :");
                    nome = Console.ReadLine();
                    Console.WriteLine("Digite o sobrenome do passageiro :");
                    sobrenome = Console.ReadLine();
                    Console.WriteLine("Digite o endereço do passageiro :");
                    endereco = Console.ReadLine();
                    Console.WriteLine("Digite o Telefone do passageiro :");
                    telefone = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite o numero da passagem do passageiro :");
                    numeropassagem = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite o numero do voo do passageiro :");
                    numerovoo = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite a poltrona do passageiro :");
                    poltrona = Convert.ToInt32(Console.ReadLine());

                }

  
                if (leitura == "1")
                {
                    Console.Clear();
                    Console.WriteLine(passageiro1.MostrarDados() + "\n\n");
                    Console.WriteLine(passageiro2.MostrarDados() + "\n\n");
                    Console.WriteLine(passageiro3.MostrarDados() + "\n\n");
                    Console.WriteLine(passageiro4.MostrarDados() + "\n\n");
                    Console.WriteLine(passageiro5.MostrarDados() + "\n\n");
                    Console.ReadKey();

                }

                if (leitura == "2")
                {
                    Console.Clear();
                    string SolicitaCpf = null;
                    Console.WriteLine("Favor digitar o numero do CPF");
                    SolicitaCpf = Console.ReadLine();

                    if (SolicitaCpf == passageiro1.Contem(SolicitaCpf))
                    {
                        Console.Clear();
                        Console.WriteLine(passageiro1.DadosCompleto() + "\n\n");
                        Console.ReadKey();
                    }

                    if (SolicitaCpf == passageiro2.Contem(SolicitaCpf))
                    {
                        Console.Clear();
                        Console.WriteLine(passageiro2.DadosCompleto() + "\n\n");
                        Console.ReadKey();
                    }
                    if (SolicitaCpf == passageiro3.Contem(SolicitaCpf))
                    {
                        Console.Clear();
                        Console.WriteLine(passageiro3.DadosCompleto() + "\n\n");
                        Console.ReadKey();
                    }
                    if (SolicitaCpf == passageiro4.Contem(SolicitaCpf))
                    {
                        Console.Clear();
                        Console.WriteLine(passageiro4.DadosCompleto() + "\n\n");
                        Console.ReadKey();
                    }
                    if (SolicitaCpf != passageiro5.Contem(SolicitaCpf) && SolicitaCpf != passageiro1.Contem(SolicitaCpf)
                        && SolicitaCpf != passageiro3.Contem(SolicitaCpf) && SolicitaCpf != passageiro2.Contem(SolicitaCpf)
                        && SolicitaCpf != passageiro4.Contem(SolicitaCpf))

                    {
                        Console.WriteLine("\n\nPassageiro não localizado neste voo!");
                        Console.ReadKey();
                    }

                }
                if (leitura == "6")
                {

                    System.Environment.Exit(0);


                }




                Console.Clear();
                Console.ReadKey();

            }

        }
    }

 }