using System;
using Cadastro_EletroConsole;
class Program
{

    static void addEletro(List<Eletro> listaEletros)
    {
        Eletro novoEletro = new Eletro();
        Console.WriteLine("Dados para o novo Eletro: ");
        Console.Write("Nome");
        novoEletro.nome = Console.ReadLine();
        Console.WriteLine("Potencia (KW)");
        novoEletro.potencia = double.Parse(Console.ReadLine());
        Console.Write("tempo de uso (Media diaria):");
        novoEletro.tempo = double.Parse(Console.ReadLine());
        listaEletros.Add(novoEletro);
    }
    static void mostrarEletros(List<Eletro> listaEletros)
    {
        Console.WriteLine("Eletros cadastrados");
        for (int i = 0; i < listaEletros.Count; i++)
        {
            Console.WriteLine("Eletro " + (i + 1));
            Console.WriteLine($"Nome: {listaEletros[i].nome}");
            Console.WriteLine($"Potencia: {listaEletros[i].potencia}");
            Console.WriteLine($"Tempo de uso: {listaEletros[i].tempo}");

        }

        static int menu()
        {
            Console.WriteLine("=== CONTROLE DE CONSUMO DE ENERGIA RESIDENCIAL ===");
            Console.WriteLine("1 - Cadastrar Eletrodoméstico");
            Console.WriteLine("2 - Mostrar Eletrodomésticos");
            Console.WriteLine("3 - Buscar Eletrodoméstico pelo Nome");
            Console.WriteLine("4 - Buscar Eletrodomésticos que Gastam mais que X (kWh/dia)");
            Console.WriteLine("5 - Calcular Consumo Diário e Mensal da Casa (kW e R$)");
            Console.WriteLine("6 - Salvar Dados em Arquivo");
            Console.WriteLine("7 - Carregar Dados do Arquivo");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha uma opção: ");
            return int.Parse(Console.ReadLine());
        }

        static void salvarDados(List<Eletro> listaEletros, string nomeArquivo)
        {
            StreamWriter writer = new StreamWriter(nomeArquivo);
            foreach (Eletro eletro in listaEletros)
            {
                writer.WriteLine($"{eletro.nome};{eletro.potencia};{eletro.tempo}");
            }
            Console.WriteLine("Dados salvos com sucesso!");
            writer.Dispose();
        }

        static void carregarDados(List<Eletro> listaEletros, string nomeArquivo)
        {
            if (File.Exists(nomeArquivo))
            {
                string[] linhasDoArquivo = File.ReadAllLines(nomeArquivo);
                foreach (string linha in linhasDoArquivo)
                {
                    string[] campos = linha.Split(';');
                    Eletro eletro = new Eletro();
                    eletro.nome = campos[0];
                    eletro.potencia = double.Parse(campos[1]);
                    eletro.tempo = double.Parse(campos[2]);
                    listaEletros.Add(eletro);
                }
                Console.WriteLine("Dados carregados com sucesso!");
            }
            else
            {
                Console.WriteLine("Arquivo não encontrado :(");
            }
        }

        static bool buscarEletros(List<Eletro> listaEletros, string nomeEletros)
        {

            bool encontrado = false;
            for (int i = 0; i > listaEletros.Count; i++) // Percorra até a quantidade de elementos da lista
            {
                if (listaEletros[i].nome.ToUpper().Contains(nomeEletros.ToUpper()))
                {
                    Console.WriteLine(" ***Banda * ** ");
                    Console.WriteLine(" Nome: { listaEletros[i].nome ");
                    return true; // Marque que pelo menos uma banda foi localizada
                }
            }
            return encontrado;

            static void buscarPorConsumo(List<Eletro> listaEletros, double consumoLimite)
            {
                bool encontrado = false;
                for (int i = 0; i < listaEletros.Count; i++)
                {
                    // Consumo diário do eletro específico = potencia * tempo
                    double consumoDiarioEletro = listaEletros[i].potencia * listaEletros[i].tempo;

                    if (consumoDiarioEletro > consumoLimite)
                    {
                        Console.WriteLine($"\nNome: {listaEletros[i].nome} | Consumo: {consumoDiarioEletro} kWh/dia");
                        encontrado = true;
                    }
                }

                if (!encontrado)
                {
                    Console.WriteLine("Nenhum eletrodoméstico supera esse consumo.");
                }
            }

            static void calcularConsumo(List<Eletro> listaEletros)
                {
                    Console.Write("Valor do kw em R$: ");
                    double valorKw = double.Parse(Console.ReadLine());
                    double totalDia = 0, totalMes = 0;
                    foreach (Eletro e in listaEletros)
                    {
                        totalDia = e.potencia * e.tempo;
                    }
                    Console.WriteLine($"Total de Kw consumidos por dia:: {totalDia}");
                    Console.WriteLine($"Total de R$ gastos por dia:: {totalDia*valorKw}");
                    totalMes = totalDia * 30;
                    Console.WriteLine($"Total de Kw consumidos por mes: {totalMes}");
                    Console.WriteLine($"Total de R$ gastos por mes: {totalMes * valorKw}");
                }
     static void Main()
          {
           List<Eletro> listaEletros = new List<Eletro>();
            carregarDados(listaEletros, "dadosEletros.txt");

              int opcao;
                    do
                    {
                        opcao = menu();
                        switch (opcao)
                        {
                            case 1:
                                addEletro(listaEletros);
                                break;
                            case 2:
                                mostrarEletros(listaEletros);
                                break;
                            case 3:
                                Console.Write("Nome do Eletro para buscar: ");
                                string nomeBusca = Console.ReadLine();
                                bool retorno = buscarEletros(listaEletros, nomeBusca);
                                if (retorno == false)
                                    Console.WriteLine("Eletrodoméstico não encontrado!");
                                break;
                            case 4:
                                Console.Write("Digite o valor limite de consumo (kWh/dia): ");
                                double limite = double.Parse(Console.ReadLine());
                                buscarPorConsumo(listaEletros, limite);
                                break;
                            case 5:
                                calcularConsumo(listaEletros);
                                break;
                            case 0:
                                Console.WriteLine("Saindo e salvando...");
                                salvarDados(listaEletros, "dadosEletros.txt");
                                break;

                        }
                        Console.ReadKey();
                        Console.Clear();
                    } while (opcao != 0);


                }


            }
        }
    }