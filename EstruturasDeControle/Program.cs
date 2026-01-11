using System;
namespace EstruturasDeControle
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Executando o projeto 6 - Estruturas de Controle");
            int idadeJoao = 16;
            int quantidadePessoas = 2;
            if (idadeJoao >= 18)
            {
                Console.WriteLine("João é maior de idade.");
            }
            else
            {
                if (quantidadePessoas >= 2)
                {
                    Console.WriteLine("João é menor de idade, mas está acompanhado.");
                }
                else
                {
                    Console.WriteLine("João é menor de idade e não está acompanhado.");
                }
            }
            Console.WriteLine("Tecle enter para fechar...");
            Console.ReadLine();
        }
    }
}