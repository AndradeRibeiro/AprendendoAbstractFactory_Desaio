using AprendendoAbstractFactory_Desafio.AbstractProduct;
using AprendendoAbstractFactory_Desafio.ConcreteProduct.CachorroProduct;
using AprendendoAbstractFactory_Desafio.Enums;
using System;

namespace AprendendoAbstractFactory_Desafio.Creator
{
    public class CachorroCreator
    {
        public static Cachorro Criar(Porte porte, string raca)
        {
            switch (porte)
            {
                case Porte.Pequeno:
                    return new CachorroPortePequeno(raca);
                case Porte.Medio:
                    return new CachorroPorteMedio(raca);
                case Porte.Grande:
                    return new CachorroPorteGrande(raca);
                default:
                    throw new ApplicationException("Porte de cachorro desconhecido.");
            }
        }
    }
}
