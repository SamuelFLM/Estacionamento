

using Estacionamento.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        List<string?> veiculos = new List<string?>();
        string? placaVeiculo;
        bool exibirMenu = true;
        string? opcaoUsuario;
        decimal valorBase;
        decimal valorHora;

        Menu menu = new Menu();
        Veiculo veiculo = new Veiculo(veiculos);


        menu.ValorBase();
        valorBase = Convert.ToDecimal(Console.ReadLine());
        menu.ValorHora();
        valorHora = Convert.ToDecimal(Console.ReadLine());

        while (exibirMenu)
        {

            menu.Main();
            opcaoUsuario = Console.ReadLine();

            switch (opcaoUsuario)
            {
                case "1": menu.AdicionarVeiculo(); placaVeiculo = Console.ReadLine(); veiculo.AdicionarVeiculo(placaVeiculo); Console.WriteLine("\nPressione para continuar..."); Console.ReadKey(); break;
                case "2": menu.RemoverVeiculo(); Console.Write("\nPLACAS VEICULOS\n\n"); veiculo.ListarVeiculo(); Console.Write("\nDigite: "); placaVeiculo = Console.ReadLine(); veiculo.RemoverVeiculo(placaVeiculo); Console.WriteLine("\nPressione para continuar..."); Console.ReadKey(); break;
                case "3": menu.ListarVeiculo(); veiculo.ListarVeiculo(); Console.WriteLine("\nPressione para continuar..."); Console.ReadKey(); break;
                case "4": menu.Encerrar(); exibirMenu = false; break;
                default: Console.WriteLine("\nPor favor, tente novamente..."); Console.ReadKey(); break;
            }


        }
    }
}