using graphQlApi_tutoriel_CRUD.Entities.Context.Configuration;
using Microsoft.EntityFrameworkCore;

namespace graphQlApi_tutoriel_CRUD.Entities.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Account> Accounts { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var ids = new Guid[] {Guid.NewGuid(),Guid.NewGuid() };

            modelBuilder.ApplyConfiguration(new OwnerConfiguration(ids));
            modelBuilder.ApplyConfiguration(new AccountConfiguration(ids));

        }
    }
}
