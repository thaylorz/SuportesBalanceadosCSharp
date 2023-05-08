namespace SuportesBalanceados.Application;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Insira uma sequência de colchetes para determinar se sua ordem é válida.");
        Console.WriteLine("Um colchete é considerado qualquer um dos seguintes caracteres: (, ), {, }, [, ou ].");

        var s = Console.ReadLine() ?? string.Empty;

        var result = ValidaColchetes.Validar(s) ? "Sequência de colchetes é válida" : "Sequência de colchetes não é válida";

        Console.WriteLine(result);
    }
}