using Desafio.Fundamentos.Models;

try
{
    Estacionamento e = new Estacionamento();
    Console.Write("Digite o preço inicial: ");
    e.PrecoInicial = Convert.ToDecimal(Console.ReadLine());

    Console.Write("Digite o preço por hora: ");
    e.precoHora = Convert.ToDecimal(Console.ReadLine());

    while (true)
    {
        await Task.Delay(1000);
        Console.Clear();

        Console.WriteLine("Digite uma opção: \n 1- Cadastrar Veículo \n 2- Remover Veículo \n 3- Listar Veículos \n 4- Encerrar"
        );

        string? escolha = Console.ReadLine();

        bool resposta;
        switch (escolha)
        {

            case "1":
                Console.WriteLine("Cadastrar Veículo");
                Console.Write("Digite a placa do veículo: ");
                resposta = e.Cadastrar(Console.ReadLine());
                if (resposta)
                {
                    Console.WriteLine("cadastrado com sucesso");
                }
                break;
            case "2":
                Console.WriteLine("Remover Veículo");
                int veiculosPatio = e.QuantidadeVeiculos();
                if (veiculosPatio > 0)
                {
                    Console.WriteLine("Digite a quantidade de horas permanecidas");
                    int horasPermanecidas = 0;
                    int.TryParse(Console.ReadLine(), out horasPermanecidas);
                    decimal total = e.CalcularTotal(horasPermanecidas);
                    Console.WriteLine($"O total a pagar é: R$ {total}");
                    Console.Write("Digite a placa do veículo: ");
                    resposta = e.Remover(Console.ReadLine());
                    if (resposta)
                    {
                        Console.WriteLine("removido com sucesso");
                    }
                }
                else
                {
                    Console.WriteLine("Não possui veículos estacionados");
                }
                break;
            case "3":
                Console.WriteLine("Listar Veículos");
                string listaPlacas = e.Listar();
                Console.WriteLine(listaPlacas);
                break;
            case "4":
                Console.WriteLine("Encerrando");
                Environment.Exit(1);
                break;
            default:
                Console.WriteLine("Opção inválida");
                break;
        }

    }
}
catch (Exception error)
{
    Console.WriteLine("Ocorreu um erro:", error.Message);
    throw;
}