

using Estacionamento.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Menu menu = new Menu();
        Veiculo veiculo = new Veiculo();

        bool exibirMenu = true;
        string? opcaoUsuario;
        decimal valorBase;
        decimal valorHora;

        menu.ValorBase();
        valorBase = Convert.ToDecimal(Console.ReadLine());
        menu.ValorHora();
        valorHora = Convert.ToDecimal(Console.ReadLine());

        while (exibirMenu)
        {

            menu.Main();
            opcaoUsuario = Console.ReadLine();


        }
    }
}