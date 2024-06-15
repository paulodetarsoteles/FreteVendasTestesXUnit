using FreteVendasTestesXUnit.Negocio;
using FreteVendasTestesXUnit.Repositorio.Repositorios;

bool controle = true;

do
{
    Console.Clear();
    Console.WriteLine("*** Bem vindo ***");
    Console.WriteLine();

    var valorMediaMensal = new VendasNegocio(new VendasRepositorio()).CalcularMediaMensal(04, 2021);

    Console.WriteLine($"- Valor Médio de Vendas no Mês: R${valorMediaMensal}");
    Console.WriteLine("- Pressione qualquer tecla para continuar ou ESC para encerrar...");

    if (Console.ReadKey().Key == ConsoleKey.Escape)
    {
        controle = false;
        Console.Beep();
        Environment.Exit(0);
    }

} while (controle);
