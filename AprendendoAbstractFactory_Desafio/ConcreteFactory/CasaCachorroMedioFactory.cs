using AprendendoAbstractFactory_Desafio.AbstractFactory;
using AprendendoAbstractFactory_Desafio.AbstractProduct;
using AprendendoAbstractFactory_Desafio.Creator;
using AprendendoAbstractFactory_Desafio.Enums;

namespace AprendendoAbstractFactory_Desafio.ConcreteFactory
{
    public class CasaCachorroMedioFactory : CasaCachorroFactory
    {
        public override Cachorro CriarCachorro(Porte porte, string raca)
        {
            return CachorroCreator.Criar(porte, raca);
        }

        public override Casa CriarCasa()
        {
            return CasaCreator.Criar(Porte.Medio);
        }
    }
}
