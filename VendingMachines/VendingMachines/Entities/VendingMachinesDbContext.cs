using Microsoft.EntityFrameworkCore;

namespace VendingMachines.Entities
{
    public class VendingMachinesDbContext : DbContext
    {
        public VendingMachinesDbContext(DbContextOptions options) : base(options) { }
        
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<Denominations> Denominations { get; set; }
        public virtual DbSet<Transactions> Transactions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            #region Products
            modelBuilder.Entity<Products>().HasKey(key => key.ProductId);
            modelBuilder.Entity<Products>(entity =>
            {
                entity.Property(p => p.ProductId).ValueGeneratedOnAdd();
                entity.Property(p => p.ProductName).HasMaxLength(50);
                entity.Property(p => p.Price).HasColumnType("decimal(19,4)");
            });
            #endregion

            #region Denominations
            modelBuilder.Entity<Denominations>().HasKey(key => key.Denomination);
            modelBuilder.Entity<Denominations>(entity =>
            {
                entity.Property(p => p.Denomination).HasColumnType("decimal(19,4)");
            });
            #endregion

            #region Transactions
            modelBuilder.Entity<Transactions>().HasKey("TransactionId", "ProductId");
            modelBuilder.Entity<Transactions>(entity =>
            {
                entity.Property(p => p.SubTotal).HasColumnType("decimal(19,4)");
                entity.Property(p => p.Total).HasColumnType("decimal(19,4)");
                entity.Property(p => p.Paid).HasColumnType("decimal(19,4)");
                entity.Property(p => p.Change).HasColumnType("decimal(19,4)");

                entity.HasOne(p => p.Products)
                .WithMany(p => p.Transactions)
                .HasForeignKey(p => p.ProductId)
                .HasConstraintName("FK_Transactions_Products_ProductId");
            });
            #endregion
        }
    }
}
