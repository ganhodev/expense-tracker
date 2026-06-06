using ControleDeGastos;
DespesaService despesaService = new DespesaService();
string opcao;

do
{
    Console.Clear();
    Console.WriteLine("=== SISTEMA DE CONTROLE DE GASTOS ===");
    Console.WriteLine("1 - Adicionar despesa");
    Console.WriteLine("2 - Listar despesas (Controle de Pagamento)");
    Console.WriteLine("3 - Realizar pagamento");
    Console.WriteLine("4 - Remover despesa");
    Console.WriteLine("5 - Ver despesa total");
    Console.WriteLine("6 - Listar por categoria");
    Console.WriteLine("7 - Sair");
    Console.Write("\nEscolha uma opção: ");

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            {
                Console.WriteLine("\nVocê escolheu adicionar despesa(s)");

                Console.WriteLine("Qual nome para essa despesa?");
                string? nomeProduto = Console.ReadLine();

                Console.WriteLine("Qual o valor para essa despesa?");
                decimal valorDespesa = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Qual a categoria para essa despesa?");
                string? categoria = Console.ReadLine();

                despesaService.AdicionarProduto(nomeProduto ?? "Sem título", valorDespesa, categoria ?? "Geral");

                Console.WriteLine("\nDespesa adicionada com sucesso!");
                break;
            }

        case "2":
            Console.WriteLine("\n--- Controle de Pagamentos ---");
            despesaService.ControlePagamento();
            break;

        case "3":
            Console.WriteLine("\n--- Realizar Pagamento ---");
            Console.Write("Digite o ID da compra que deseja pagar: ");
            if (int.TryParse(Console.ReadLine(), out int idPagar))
            {
                despesaService.RealizarPagamento(idPagar);
                Console.WriteLine("Processamento de pagamento concluído.");
            }
            else
            {
                Console.WriteLine("ID inválido.");
            }
            break;

        case "4":
            Console.WriteLine("\n--- Remover Despesa ---");
            Console.Write("Digite o ID da despesa que deseja remover: ");
            if (int.TryParse(Console.ReadLine(), out int idRemover))
            {
                despesaService.RemoverDespesa(idRemover);
                Console.WriteLine("Despesa removida.");
            }
            else
            {
                Console.WriteLine("ID inválido.");
            }
            break;

        case "5":
            Console.WriteLine("\n--- Resumo Financeiro ---");
            despesaService.DespesaTotal();
            break;

        case "6":
            {
                Console.WriteLine("\n--- Filtrar por Categoria ---");
                Console.Write("Digite a categoria desejada: ");
                string categoria = Console.ReadLine() ?? "";
                despesaService.ListarPorCategoria(categoria);
                break;
            }

        case "7":
            Console.WriteLine("\nSaindo do sistema... Pressione qualquer tecla.");
            Console.ReadKey();
            break;

        default:
            Console.WriteLine("\nOpção inválida!");
            break;
    }

    if (opcao != "7")
    {
        Console.WriteLine("\nPressione qualquer tecla para continuar...");
        Console.ReadKey();
    }

} while (opcao != "7");