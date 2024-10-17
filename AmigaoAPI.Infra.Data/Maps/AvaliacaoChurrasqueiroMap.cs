using AmigaoAPI.Domain.Modelos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmigaoAPI.Infra.Data.Maps
{
    public class AvaliacaoChurrasqueiroMap : IEntityTypeConfiguration<AvaliacaoChurrasqueiro>
    {
        public void Configure(EntityTypeBuilder<AvaliacaoChurrasqueiro> builder) // o contrato obriga você a implemeentar essa classe.
        {
            builder.ToTable("AvaliacaoChurrasqueiro"); // nome da tabela 

            builder.Property(a => a.Id)
                   .HasColumnName("IdAvaliacaoChurrasqueiro")// mudando o nome da coluna
                   .UseIdentityColumn(); // dizendo para o banco que vai gerar ids automaticado
        }
    }
}
