using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estacionamento.Models
{
    public class Menu
    {
        public void Main()
        {
            Console.Clear();
            Console.WriteLine("\nEscolha uma opção: \n");
            Console.WriteLine("\n1 - Adicionar um veículo");
            Console.WriteLine("\n2 - Remover um veículo");
            Console.WriteLine("\n3 - Listar veículos");
            Console.WriteLine("\n4 - Alterar informação veículo");
            Console.WriteLine("\n5 - Encerrar");
            Console.Write("\nDigite: ");
        }

        public void ValorBase()
        {
            Console.Clear();
            Console.WriteLine("\nBem-vindo");
            Console.WriteLine("\nPara continuar, por favor informe o valor base do estacionamento...");
            Console.Write("\nValor Base: ");
        }
        public void ValorHora(){
            Console.Clear();
            Console.WriteLine("\nTudo certo...");
            Console.WriteLine("\nAgora informe o valor da hora do estacionamento...");
            Console.Write("\nValor Hora: ");
        }

        public void AdicionarVeiculo(){

        }
        public void RemoverVeiculo(){

        }
        public void ListarVeiculo(){

        }
        public void AlterarInformacaoVeiculo(){

        }
        public void Encerrar(){

        }

    }
}