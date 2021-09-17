using AprendendoAbstractFactory_Desafio.AbstractProduct;
using AprendendoAbstractFactory_Desafio.Enums;

namespace AprendendoAbstractFactory_Desafio.ConcreteProduct.CachorroProduct
{
    public class CachorroPorteMedio : Cachorro
    {
        public CachorroPorteMedio(string raca) : base(Porte.Medio, raca)
        {
        }
    }
}
