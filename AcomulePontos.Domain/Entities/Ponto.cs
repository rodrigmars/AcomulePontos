using System;

namespace AcomulePontos.Domain.Entities
{
    public class Ponto
    {
        public Ponto()
        {
            AuditData = DateTime.Now;
        }

        public int PontoId { get; set; }

        public string TipoPonto { get; set; }

        public int TotalPontos { get; set; }

        public DateTime AuditData { get; set; }

        public int ClienteId { get; set; }

        public virtual Cliente Cliente { get; set; }

        public override string ToString()
        {
            return TipoPonto;
        }
    }
}
