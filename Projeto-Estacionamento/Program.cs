using Projeto;

Console.WriteLine("Digite o preço inicial: ");
decimal precoInicial = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Agora digite o preço por hora: ");
decimal precoPorHora = Convert.ToDecimal(Console.ReadLine());

Estacionamento estacionamento = new Estacionamento(precoInicial, precoPorHora);

bool exibirMenu= true;

while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("1 - Cadastrar Veículo");
    Console.WriteLine("2 - Remover Veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");

    string? opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            estacionamento.AdicionarVeiculo();
            break;

        case "2":
            estacionamento.RemoverVeiculo();
            break;

        case "3":
            estacionamento.ListarVeiculo();
            break;

        case "4":
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida. Tente novamente.");
            break;
    }
      Console.WriteLine("\nPressione Enter para continuar...");
      Console.ReadLine();
}



