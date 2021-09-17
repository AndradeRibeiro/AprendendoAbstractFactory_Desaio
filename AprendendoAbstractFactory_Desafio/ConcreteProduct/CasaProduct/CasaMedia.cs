using AprendendoAbstractFactory_Desafio.AbstractProduct;
using AprendendoAbstractFactory_Desafio.Enums;
using System;

namespace AprendendoAbstractFactory_Desafio.ConcreteProduct.CasaProduct
{
    public class CasaMedia : Casa
    {
        public override string Descricao => "Casinha feita de material reciclável para cachorros médios";
        public override Porte Porte => Porte.Medio;
        public override double Preco => 150.00;

        public override void ApresentarOrcamento(Cachorro cachorro)
        {
            Console.WriteLine("O modelo ideal de casa para a raça {0} de porte médio é: \n{1}\nNo preço de: {2} reais", cachorro.Raca, Descricao, Preco);
        }
    }
}
