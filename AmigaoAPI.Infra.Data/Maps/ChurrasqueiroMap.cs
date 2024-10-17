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
    // essa classe pode ser chamada de Map pq mapeia tuas classe para o banco de dados ou de config  pq ela configura tuas tabelas
    public class ChurrasqueiroMap : IEntityTypeConfiguration<Churrasqueiro> // precisa herdar e como é interface---  contrato, lembra ???
    {
        public void Configure(EntityTypeBuilder<Churrasqueiro> builder) // o contrato obriga você a implemeentar essa classe.
        {
            builder.ToTable("Churrasqueiro"); // nome da tabela 

            builder.Property(f => f.Id)
                   .HasColumnName("funcionario_id")// mudando o nome da coluna
                   .UseIdentityColumn(); // dizendo para o banco que vai gerar ids automaticado
        }
    }
}
