using System;

namespace AcomulePontos.Domain.Entities
{
    public class Cliente
    {
        public Cliente()
        {

        }

        public int ClienteId { get; set; }

        public string Nome { get; set; }

        public int Iade { get; set; }

        public DateTime DataNascimento { get; set; }
        
        public string Telefone { get; set; }

        public virtual Ponto Ponto { get; set; }

        public override string ToString()
        {
            return Nome;
        }
    }
}