using System;

namespace CalculadoraVidaRecuperadaApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Digite o tipo de poção (Pequena, Média, Grande): ");
            string tipoPocao = Console.ReadLine().Trim().ToLower();

            
            Console.Write("Digite o nível do personagem: ");
            int nivelPersonagem = int.Parse(Console.ReadLine());

            
            Console.Write("Digite a quantidade de poções usadas: ");
            int quantidadePocoes = int.Parse(Console.ReadLine());

            
            int vidaRecuperada = CalcularVidaRecuperada(tipoPocao, nivelPersonagem, quantidadePocoes);
            Console.WriteLine($"Total de vida recuperada: {vidaRecuperada} pontos");
        }

        static int CalcularVidaRecuperada(string tipoPocao, int nivelPersonagem, int quantidadePocoes)
        {
            int vidaPorPocao = 0;

           
            switch (tipoPocao)
            {
                case "pequena":
                    vidaPorPocao = 10;
                    break;
                case "média":
                    vidaPorPocao = 20;
                    break;
                case "grande":
                    vidaPorPocao = 30;
                    break;
                default:
                    Console.WriteLine("Tipo de poção inválido.");
                    return 0;
            }

            
            int pontosAdicionais = Math.Max(0, nivelPersonagem - 5) * 5;

            
            int vidaTotalRecuperada = (vidaPorPocao + pontosAdicionais) * quantidadePocoes;
            return vidaTotalRecuperada;
        }
    }
}