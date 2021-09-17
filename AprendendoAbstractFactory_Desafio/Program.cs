using AprendendoAbstractFactory_Desafio.Client;
using AprendendoAbstractFactory_Desafio.Creator;
using AprendendoAbstractFactory_Desafio.Enums;
using System;

namespace AprendendoAbstractFactory_Desafio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, informe a raça do seu cachorro");
            string raca = Console.ReadLine();

            Console.WriteLine("\nQual o porte do seu cachorro? \n");
            Console.WriteLine("1 - Pequeno\n2 - Médio \n3 - Grande\n");
            int porte = Convert.ToInt32(Console.ReadLine());

            if (!Enum.IsDefined(typeof(Porte), porte))
                throw new Exception("Porte inválido");

            OrcamentoCasaCachorro.CriarOrcamentoCasaCachorro(CachorroCreator.Criar((Porte)porte, raca)).RealizarOrcamento();

            Console.ReadKey();
        }
    }
}
