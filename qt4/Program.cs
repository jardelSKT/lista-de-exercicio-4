using System;

namespace ResgateApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solicitar a energia do jogador
            Console.Write("Digite a energia do jogador: ");
            int energia = int.Parse(Console.ReadLine());

            // Solicitar a distância até o aliado em metros
            Console.Write("Digite a distância até o aliado (em metros): ");
            int distancia = int.Parse(Console.ReadLine());

            // Solicitar o nível de ameaça
            Console.Write("Digite o nível de ameaça (Baixo, Médio, Alto): ");
            string nivelAmeaca = Console.ReadLine().Trim().ToLower();

            
            string resultadoResgate = VerificarResgate(energia, distancia, nivelAmeaca);
            Console.WriteLine(resultadoResgate);
        }

        static string VerificarResgate(int energia, int distancia, string nivelAmeaca)
        {
           
            if (distancia < 20)
            {
                energia += 10;
            }

           
            switch (nivelAmeaca)
            {
                case "baixo":
                   
                    break;
                case "médio":
                    energia -= 10;
                    break;
                case "alto":
                    energia -= 20;
                    break;
                default:
                    Console.WriteLine("Nível de ameaça inválido.");
                    return "Resgate falhou";
            }

           
            if (energia > 50)
            {
                return "Resgate bem-sucedido";
            }
            else
            {
                return "Resgate falhou";
            }
        }
    }
}