using AprendendoAbstractFactory_Desafio.AbstractProduct;
using AprendendoAbstractFactory_Desafio.Enums;

namespace AprendendoAbstractFactory_Desafio.ConcreteProduct.CachorroProduct
{
    public class CachorroPorteGrande : Cachorro
    {
        public CachorroPorteGrande(string raca) : base(Porte.Grande, raca)
        {
        }
    }
}
