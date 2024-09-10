using System;

namespace CalculadoraDanoCriticoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Digite o valor do ataque base: ");
            int ataqueBase = int.Parse(Console.ReadLine());

            

            Console.Write("Digite o multiplicador crítico (1.5x, 2x, 3x): ");
            string multiplicadorCriticoStr = Console.ReadLine().Trim().ToLower();

           
            double multiplicadorCritico = ConverterMultiplicador(multiplicadorCriticoStr);

           
            Console.Write("Digite o tipo de arma (Espada, Arco, Cajado): ");
            string tipoArma = Console.ReadLine().Trim().ToLower();

           
            double danoTotal = CalcularDanoCritico(ataqueBase, multiplicadorCritico, tipoArma);
            Console.WriteLine($"Dano total causado pelo ataque crítico: {danoTotal} pontos");
        }

        static double ConverterMultiplicador(string multiplicadorStr)
        {
            switch (multiplicadorStr)
            {
                case "1.5x":
                    return 1.5;
                case "2x":
                    return 2.0;
                case "3x":
                    return 3.0;
                default:
                    Console.WriteLine("Multiplicador crítico inválido.");
                    return 1.0; 
            }
        }

        static double CalcularDanoCritico(int ataqueBase, double multiplicadorCritico, string tipoArma)
        {
           
            int bonusDano = 0;

            switch (tipoArma)
            {
                case "espada":
                    bonusDano = 10;
                    break;
                case "arco":
                    bonusDano = 5;
                    break;
                case "cajado":
                    bonusDano = 15;
                    break;
                default:
                    Console.WriteLine("Tipo de arma inválido.");
                    return 0;
            }

           
            double danoTotal = ataqueBase * multiplicadorCritico + bonusDano;
            return danoTotal;
        }
    }
}