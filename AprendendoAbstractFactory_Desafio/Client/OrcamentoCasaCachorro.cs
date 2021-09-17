using AprendendoAbstractFactory_Desafio.AbstractFactory;
using AprendendoAbstractFactory_Desafio.AbstractProduct;
using AprendendoAbstractFactory_Desafio.ConcreteFactory;
using AprendendoAbstractFactory_Desafio.Enums;
using System;

namespace AprendendoAbstractFactory_Desafio.Client
{
    public class OrcamentoCasaCachorro
    {
        private readonly Cachorro _cachorro;
        private readonly Casa _casa;

        public OrcamentoCasaCachorro(CasaCachorroFactory factory, Cachorro cachorro)
        {
            _cachorro = factory.CriarCachorro(cachorro.Porte, cachorro.Raca);
            _casa = factory.CriarCasa();
        }

        public static OrcamentoCasaCachorro CriarOrcamentoCasaCachorro(Cachorro cachorro)
        {
            switch (cachorro.Porte)
            {
                case Porte.Pequeno:
                    return new OrcamentoCasaCachorro(new CasaCachorroPequenoFactory(), cachorro);
                case Porte.Medio:
                    return new OrcamentoCasaCachorro(new CasaCachorroMedioFactory(), cachorro);
                case Porte.Grande:
                    return new OrcamentoCasaCachorro(new CasaCachorroGrandeFactory(), cachorro);
                default:
                    throw new ApplicationException("Não foi possível identificar o veículo");
            }
        }

        public void RealizarOrcamento()
        {
            _casa.ApresentarOrcamento(_cachorro);
        }
    }
}
