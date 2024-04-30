using Microsoft.EntityFrameworkCore;

namespace EFcoreExercise1.Models
{
    public class CompanyContext : DbContext
    {
        public CompanyContext(DbContextOptions<CompanyContext> options) : base(options)
        { }

        #region MyRegion
        public DbSet<Department> Department { get; set; }

        public DbSet<Employee> Employee { get; set; }

        public DbSet<Information> Information { get; set; }
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>(entity =>
            {
                entity.Property(e => e.Name)
                      .IsRequired()
                      .HasMaxLength(50)
                      .IsUnicode(false);
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.Property(e => e.Designation)
                      .IsRequired()
                      .HasMaxLength(25)
                      .IsUnicode(false);
                entity.Property(e => e.Name)
                      .IsRequired()
                      .HasMaxLength(100)
                      .IsUnicode(false);
                entity.HasOne(d => d.Department)
                      .WithMany(p => p.Employee)
                      .HasForeignKey(d => d.DepartmentId)
                      .OnDelete(DeleteBehavior.ClientSetNull) // Cascade Delete 級聯刪除
                      .HasConstraintName("FK_Employee_Department");
            });
        }

        #region Lazy Loading in EF Core
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseLazyLoadingProxies();
            }
        }
        #endregion
    }
}
