using AmigaoAPI.Domain.Modelos;
using AmigaoAPI.Infra.Data.Maps;
using Microsoft.EntityFrameworkCore;
using System;

namespace AmigaoAPI.Infra.Data.Context
{

    public class ApplicationDbContext : DbContext // a classe ApplicationDBcontext herda de DBContext que vem do EntityFramework Core
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Churrasqueiro> Churrasqueiros { get; set; } // aqui é onde cria classe com os metodos(get, dele, update etc.) com o banco de dados para o respositorio
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Reserva> Reservas { get; set; }
        public DbSet<AvaliacaoChurrasqueiro> AvaliacaoChurrasqueiros { get; set; }
        public DbSet<Divulgacao> Divulgacoes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) // aqui é onde modela as tabelas para criar no banco, 
                                                                           // por exemplo eu quero que o atributo id ,
                                                                           // dentro da tabela se chame "id_churrasqueiro" ou que limite os caracteres do nome em 30, ou que só aceite letras.
        {
            // para fazer essa configuracao pode ser de duas formas 
            // a primeira:
            modelBuilder.ApplyConfiguration(new ChurrasqueiroMap());
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new ReservaMap());
            modelBuilder.ApplyConfiguration(new AvaliacaoChurrasqueiroMap());

            base.OnModelCreating(modelBuilder);


        }

    }
}
