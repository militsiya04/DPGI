using System.Configuration;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Lab5.EF
{
    public partial class ProductGuideContext : DbContext
    {
        public ProductGuideContext()
        {
        }

        public ProductGuideContext(DbContextOptions<ProductGuideContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<UnitsOfMeasurement> UnitsOfMeasurements { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["connectionStringLab5"].ConnectionString
                );
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Cyrillic_General_CI_AS");

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.Article)
                    .HasName("PK__Products__4943444BE6E2828B");

                entity.Property(e => e.Article).HasMaxLength(50);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Quantity).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.UnitCodeNavigation)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.UnitCode)
                    .HasConstraintName("FK_Products_UnitsOfMeasurement");
            });

            modelBuilder.Entity<UnitsOfMeasurement>(entity =>
            {
                entity.HasKey(e => e.UnitCode)
                    .HasName("PK__UnitsOfM__0665E6D8DCB6C05C");

                entity.ToTable("UnitsOfMeasurement");

                entity.Property(e => e.UnitCode).ValueGeneratedNever();

                entity.Property(e => e.UnitName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
