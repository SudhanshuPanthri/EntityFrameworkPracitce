using Microsoft.EntityFrameworkCore;
namespace DBOperationsWithEFCore.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CurrencyType>().HasData(
                new CurrencyType() { Id = 1, Currency = "INR", Description = "INR (INDIAN RUPEES)" },
                new CurrencyType() { Id = 2, Currency = "USD", Description = "USD (US DOLLARS)" },
                new CurrencyType() { Id = 3, Currency = "EUR", Description = "EUR (EUROS)" }
                );
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Language> Languages { get; set; }

        public DbSet<BookPrice> Prices { get; set; }
        public DbSet<CurrencyType> CurrencyTypes { get; set; }
    }
}
