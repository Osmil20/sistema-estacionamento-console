using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Projeto
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> Veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do Veículo: ");
            string? itemSert = Console.ReadLine();

            if (!string.IsNullOrEmpty(itemSert))
            {
                Veiculos.Add(itemSert);
                Console.WriteLine($"Item {itemSert} adicionado!");
            }
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            string? placa = Console.ReadLine();

                    if (!string.IsNullOrEmpty(placa))
        {
            if (Veiculos.Contains(placa))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo ficou estacionado:");
                int horas = Convert.ToInt32(Console.ReadLine());
                decimal valorTotal = precoInicial + precoPorHora * horas;

                Veiculos.Remove(placa);

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi: R$ {valorTotal},00");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui.");
            }
        }
            else
        {
            Console.WriteLine("Placa inválida. Tente novamente.");
        }
        }

        public void ListarVeiculo()
        {
            if (Veiculos.Any()) // Verifica se tem algum item na lista
    {
        Console.WriteLine("Os veículos estacionados são:");

        foreach (string placa in Veiculos)
        {
            Console.WriteLine(placa);
        }
    }
    else
    {
        Console.WriteLine("Não há veículos estacionados.");
    }
            
        }
        

    }
}
