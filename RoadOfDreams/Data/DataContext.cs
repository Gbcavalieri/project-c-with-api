using RoadOfDreams.Model;
using Microsoft.EntityFrameworkCore;


namespace RoadOfDreams.Data
{

  public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Passagem> Passagens { get; set; }
       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Passagem>().HasData(
                new Passagem { Id = 1, Agencia = "GOL", Ida = "27/07/2022", Volta = "27/07/2023", Destino = "Rio de Janeiro", Origem = "São Paulo", Lugares = "2"},
                 new Passagem { Id = 2, Agencia = "AZUL", Ida = "09/09/2021", Volta = "01/01/2024", Destino = "Miami", Origem = "São Paulo", Lugares = "1" },
                  new Passagem { Id = 3, Agencia = "EMIRATES", Ida = "27/07/2022", Volta = "27/08/2022", Destino = "Congo", Origem = "São Paulo", Lugares = "4" },
                   new Passagem { Id = 4, Agencia = "GOL", Ida = "08/10/2019", Volta = "10/11/2025", Destino = "Emirados Árabes", Origem = "Rio de janeiro", Lugares = "2" }

            );
        }
    }
}

