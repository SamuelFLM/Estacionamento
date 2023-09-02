using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estacionamento.Models
{
    public class Veiculo
    {

        public List<string?> Veiculos { get; set; }
        public Veiculo(List<string?> veiculos)
        {
            this.Veiculos = veiculos;
        }
        public void AdicionarVeiculo(string? veiculo)
        {
            if (!Veiculos.Contains(veiculo))
            {
                Veiculos.Add(veiculo);
                Console.WriteLine("\nVeículo adicionado....");
            }
            else
            {
                Console.WriteLine("\nNão foi possivel, veiculo existente.");
            }
        }
        public void RemoverVeiculo(string? veiculo)
        {
            if (Veiculos.Contains(veiculo))
            {
                Veiculos.Remove(veiculo);
                Console.WriteLine("\nVeículo deletado....");
            }
            else
            {
                Console.WriteLine("\nNão foi possivel, placa não existente.");
            }
        }
        public void ListarVeiculo()
        {
            foreach (var item in Veiculos)
            {
                Console.WriteLine(item);
            }
        }

        public void FecharContaVeiculo(){

        }
    }
}