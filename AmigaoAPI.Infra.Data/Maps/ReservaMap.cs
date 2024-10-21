
using AmigaoAPI.Domain.Modelos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;


namespace AmigaoAPI.Infra.Data.Maps
{

    public class ReservaMap : IEntityTypeConfiguration<Reserva>
    {
        public void Configure(EntityTypeBuilder<Reserva> builder)
        {
            builder.ToTable("Reservas");

            builder.HasKey(r => r.Id);
            builder.Property(r => r.DataReserva).IsRequired();
            builder.Property(r => r.ValorTotal).HasColumnType("decimal(18,2)").IsRequired();

            builder.HasOne(r => r.Churrasqueiro)
                .WithMany(c => c.Reservas)
                .HasForeignKey(r => r.IdChurrasqueiro);

            builder.HasOne(r => r.Usuario)
                .WithMany(u => u.Reservas)
                .HasForeignKey(r => r.IdUsuario);
        }

    }
}
