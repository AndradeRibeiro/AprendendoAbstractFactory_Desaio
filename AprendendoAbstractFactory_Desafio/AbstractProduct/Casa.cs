using AprendendoAbstractFactory_Desafio.Enums;

namespace AprendendoAbstractFactory_Desafio.AbstractProduct
{
    public abstract class Casa
    {
        public abstract string Descricao { get; }
        public abstract Porte Porte { get; }
        public abstract double Preco { get; }
        public abstract void ApresentarOrcamento(Cachorro cachorro);
    }
}
