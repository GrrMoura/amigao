
using AmigaoAPI.Domain.Modelos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace AmigaoAPI.Infra.Data.Maps
{

    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuarios");

            builder.HasKey(u => u.Id);
            builder.Property(u => u.Nome).IsRequired().HasMaxLength(100);
            builder.Property(u => u.Email).IsRequired().HasMaxLength(100);
            builder.Property(u => u.PasswordHash).IsRequired();
            builder.Property(u => u.TipoUsuario).IsRequired();

            builder.HasMany(u => u.Reservas)
                .WithOne(r => r.Usuario)
                .HasForeignKey(r => r.IdUsuario);
        }

    }
}



