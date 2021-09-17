using AprendendoAbstractFactory_Desafio.Enums;

namespace AprendendoAbstractFactory_Desafio.AbstractProduct
{
    public abstract class Cachorro
    {
        public Porte Porte { get; set; }
        public string Raca { get; set; }

        public Cachorro(Porte porte, string raca)
        {
            Porte = porte;
            Raca = raca;
        }
    }
}
