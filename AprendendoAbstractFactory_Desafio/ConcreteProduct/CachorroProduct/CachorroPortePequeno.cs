using AprendendoAbstractFactory_Desafio.AbstractProduct;
using AprendendoAbstractFactory_Desafio.Enums;

namespace AprendendoAbstractFactory_Desafio.ConcreteProduct.CachorroProduct
{
    public class CachorroPortePequeno : Cachorro
    {
        public CachorroPortePequeno(string raca) : base(Porte.Pequeno, raca)
        {
        }
    }
}
