using System;
namespace SwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Informe o valor de 1-3: \n");
                int Valor = Convert.ToInt32(Console.ReadLine());
                switch (Valor)
                {
                    case 1:
                        Console.WriteLine("Prestação de 100 reais");
                        break;
                    case 2:
                        Console.WriteLine("Prestação de 200 reais");
                        break;
                    case 3:
                        Console.WriteLine("Prestação de 300 reais");
                        break;
                    default:
                        Console.WriteLine("Valor inválido");
                        break;
                }
                Console.WriteLine("Deseja continuar? (s/n)");
                string resposta = Console.ReadLine().ToLower();
                if (resposta != "s")
                {
                    break;
                }
            }
        }
    }
}