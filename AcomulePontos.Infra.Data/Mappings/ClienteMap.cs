using AcomulePontos.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace AcomulePontos.Infra.Data.Mappings
{
    public class ClienteMap : EntityTypeConfiguration<Cliente>
    {
        public ClienteMap()
        {
            ToTable("Cliente");

            HasKey(x => x.ClienteId);

            Property(x => x.Nome).HasMaxLength(60).IsRequired();

            HasRequired(x => x.Ponto);


            //um ponto tem muitos clientes
            HasRequired(x => x.Ponto)
                .WithMany()
                .HasForeignKey(p => p.ClienteId);
        }
    }
}
