using AprendendoAbstractFactory_Desafio.AbstractProduct;
using AprendendoAbstractFactory_Desafio.Enums;
using System;

namespace AprendendoAbstractFactory_Desafio.ConcreteProduct.CasaProduct
{
    public class CasaPequena : Casa
    {
        public override string Descricao => "Casinha feita de plástico para cachorros pequenos"; 
        public override Porte Porte => Porte.Pequeno;

        public override double Preco => 50.00;

        public override void ApresentarOrcamento(Cachorro cachorro)
        {
            Console.WriteLine("O modelo ideal de casa para a raça {0} de porte pequeno é: \n{1}\nNo preço de: {2} reais", cachorro.Raca, Descricao, Preco);
        }
    }
}
