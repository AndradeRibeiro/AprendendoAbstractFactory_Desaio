using AprendendoAbstractFactory_Desafio.AbstractProduct;
using AprendendoAbstractFactory_Desafio.Enums;

namespace AprendendoAbstractFactory_Desafio.AbstractFactory
{
    public abstract class CasaCachorroFactory
    {
        public abstract Casa CriarCasa();
        public abstract Cachorro CriarCachorro(Porte porte, string raca);
    }
}
