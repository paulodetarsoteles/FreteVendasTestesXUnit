using FreteVendasTestesXUnit.Negocio;
using FreteVendasTestesXUnit.Repositorio.Repositorios;

bool controle = true;

do
{
    bool controleMes;
    string mesString = string.Empty;
    short mes = 0;
    var valorMediaMensal = 0.00m;

    Console.Clear();
    Console.WriteLine("*** Bem vindo ***");
    Console.WriteLine();

    controleMes = false;

    while (!controleMes)
    {
        Console.Write("Digite o mês para saber a média de vendas: ");
        mesString = Console.ReadLine() ?? "";

        if (string.IsNullOrEmpty(mesString) || !short.TryParse(mesString, out mes))
        {
            Console.WriteLine("ERRO: Mês inválido");
            break;
        }
        else if (mes < 1 || mes > 12)
        {
            Console.WriteLine("ERRO: Mês menor que 1 ou maior que 12");
            break;
        }
        else
        {
            controleMes = true;
            var vendasRepos = new VendasRepositorio();
            var vendasNegocios = new VendasNegocio(vendasRepos);

            try
            {
                valorMediaMensal = vendasNegocios.CalcularMediaMensal(mes, 2021);

                Console.WriteLine($"- Valor Médio de Vendas no Mês: R${valorMediaMensal}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERRO: {ex.Message}");
            }
        }
    }

    Console.WriteLine("- Pressione qualquer tecla para continuar ou ESC para encerrar...");

    if (Console.ReadKey().Key == ConsoleKey.Escape)
    {
        controle = false;
        Console.Beep();
        Environment.Exit(0);
    }

} while (controle);
