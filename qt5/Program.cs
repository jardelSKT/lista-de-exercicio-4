using System;

namespace HabilidadeSugeridaApp
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Console.Write("Digite a quantidade de mana: ");
            int mana = int.Parse(Console.ReadLine());

           
            Console.Write("Digite o tipo de inimigo (Normal, Forte, Boss): ");
            string tipoInimigo = Console.ReadLine().Trim().ToLower();

            
            Console.Write("Digite a distância do alvo (em metros): ");
            int distancia = int.Parse(Console.ReadLine());

           
            string habilidadeSugerida = SugerirHabilidade(mana, tipoInimigo, distancia);
            Console.WriteLine(habilidadeSugerida);
        }

        static string SugerirHabilidade(int mana, string tipoInimigo, int distancia)
        {
            
            int manaNecessaria = 50; 

            if (tipoInimigo == "forte" || tipoInimigo == "boss")
            {
                manaNecessaria += 10;
            }

            
            if (distancia < 10)
            {
                manaNecessaria -= 5;
            }

            
            if (mana > 50)
            {
                return "Use Habilidade Poderosa";
            }
            else if (mana >= manaNecessaria)
            {
                return "Use Habilidade Básica";
            }
            else
            {
                return "Mana insuficiente para usar a habilidade";
            }
        }
    }
}