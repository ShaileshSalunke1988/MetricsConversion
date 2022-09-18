using Microsoft.EntityFrameworkCore;

namespace MetricConversion.Model
{
    public partial class ConversionContext : DbContext
    {
        public ConversionContext()
        {
        }

        public ConversionContext(DbContextOptions<ConversionContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Conversion> Conversion { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=TESTSQLD1;Encrypt=True;TrustServerCertificate=True;Initial Catalog=Conversion; Integrated Security=True;Connect Timeout=301; MultipleActiveResultSets=True; Pooling=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Conversion>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ConversionCode)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(true);

                entity.Property(e => e.ConversionId)
                    .HasColumnName("ConversionID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Unit1).HasColumnType("decimal(6, 4)");

                entity.Property(e => e.Unit2).HasColumnType("decimal(6, 4)");

                entity.Property(e => e.Description )
                   .IsRequired()
                   .HasMaxLength(50)
                   .IsUnicode(true);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
