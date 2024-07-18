using Microsoft.EntityFrameworkCore;

namespace Net1711_231_ASM2_SE160414_HuynhHoangKhoiNguyen_JWT.Models
{
    public class MilkStoreContext : DbContext
    {
        public MilkStoreContext(DbContextOptions<MilkStoreContext> options) : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Account> Accounts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .HasOne(p => p.Category)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.CategoryId);
        }
    }
}
