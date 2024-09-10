using System;

namespace CalculadoraPontuacaoMissaoApp
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.Write("Digite a dificuldade da missão (Fácil, Média, Difícil): ");
            string dificuldadeMissao = Console.ReadLine().Trim().ToLower();

            
            Console.Write("Digite o número de inimigos derrotados: ");
            int inimigosDerrotados = int.Parse(Console.ReadLine());

           
            Console.Write("Digite o tempo gasto (em minutos): ");
            int tempoGasto = int.Parse(Console.ReadLine());

           
            int pontuacaoFinal = CalcularPontuacaoMissao(dificuldadeMissao, inimigosDerrotados, tempoGasto);
            Console.WriteLine($"Pontuação final do jogador: {pontuacaoFinal} pontos");
        }

        static int CalcularPontuacaoMissao(string dificuldade, int inimigosDerrotados, int tempoGasto)
        {
            int pontosPorInimigo = 0;
            int penalidade = 0;

          
            switch (dificuldade)
            {
                case "fácil":
                    pontosPorInimigo = 5;
                   
                    break;
                case "média":
                    pontosPorInimigo = 10;
                    
                    if (tempoGasto > 10)
                    {
                        penalidade = (tempoGasto - 10) * 2;
                    }
                    break;
                case "difícil":
                    pontosPorInimigo = 15;
                    
                    if (tempoGasto > 15)
                    {
                        penalidade = (tempoGasto - 15) * 5;
                    }
                    break;
                default:
                    Console.WriteLine("Dificuldade inválida.");
                    return 0;
            }

           
            int pontuacao = inimigosDerrotados * pontosPorInimigo - penalidade;
            return Math.Max(0, pontuacao); // Garantir que a pontuação não seja negativa
        }
    }
}