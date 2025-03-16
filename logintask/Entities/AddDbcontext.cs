using Microsoft.EntityFrameworkCore;

namespace logintask.Entities
{
    public class AddDbcontext : DbContext
    {
        public AddDbcontext(DbContextOptions<AddDbcontext> options) :base(options)
        {

        }
        public DbSet<UserAccount> UserAccounts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        internal async Task FindByNameAsync(string userNameOrEmail)
        {
            throw new NotImplementedException();
        }
    }
}
