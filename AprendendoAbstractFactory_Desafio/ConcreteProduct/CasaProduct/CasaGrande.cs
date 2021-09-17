using AprendendoAbstractFactory_Desafio.AbstractProduct;
using AprendendoAbstractFactory_Desafio.Enums;
using System;

namespace AprendendoAbstractFactory_Desafio.ConcreteProduct.CasaProduct
{
    public class CasaGrande: Casa
    {
        public override string Descricao => "Casinha feita de tijolo para cachorros grandes";
        public override Porte Porte => Porte.Grande;
        public override double Preco => 350.00;

        public override void ApresentarOrcamento(Cachorro cachorro)
        {
            Console.WriteLine("O modelo ideal de casa para a raça {0} de porte grande é: \n{1}\nNo preço de: {2} reais", cachorro.Raca, Descricao, Preco);
        }
    }
}
