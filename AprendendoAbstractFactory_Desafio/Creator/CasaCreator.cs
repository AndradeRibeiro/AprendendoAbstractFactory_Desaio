using AprendendoAbstractFactory_Desafio.AbstractProduct;
using AprendendoAbstractFactory_Desafio.ConcreteProduct.CasaProduct;
using AprendendoAbstractFactory_Desafio.Enums;
using System;

namespace AprendendoAbstractFactory_Desafio.Creator
{
    public class CasaCreator
    {
        public static Casa Criar(Porte porte)
        {
            switch (porte)
            {
                case Porte.Pequeno:
                    return new CasaPequena();
                case Porte.Medio:
                    return new CasaMedia();
                case Porte.Grande:
                    return new CasaGrande();
                default:
                    throw new ApplicationException("Porte de cachorro desconhecido.");
            }
        }
    }
}
