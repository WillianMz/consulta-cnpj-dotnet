using Microsoft.EntityFrameworkCore;

namespace ConsultaCnpjAPI.Data
{
    public class DadosContext : DbContext
    {
        public DadosContext(DbContextOptions options) : base(options) { }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DadosContext).Assembly, a => a.Namespace == "ConsultaCnpjAPI.Data.Mapeamentos");
            base.OnModelCreating(modelBuilder);
        }
    }
}
