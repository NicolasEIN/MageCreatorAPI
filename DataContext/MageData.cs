global using Microsoft.EntityFrameworkCore;

namespace MageCreatorAPI.DataContext
{
    public class MageData : DbContext
    {
        public MageData(DbContextOptions<MageData> options): base(options) 
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=MageDB;Trusted_Connection=True;TrustServerCertificate=true;");
        }

        public DbSet<Magician> Magicians { get; set; }

    }
}
