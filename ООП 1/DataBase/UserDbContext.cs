using Microsoft.EntityFrameworkCore;
using ООП_1.Entities;
using ООП_1.Entities.BaseEntities;
using Group = ООП_1.Entities.Group;
namespace ООП_1.DataBase
{
    public class UserDbContext : DbContext

    {
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Student> Students { get; set; }

        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>()
                .HasIndex(u => u.Login)
                .IsUnique();

            modelBuilder.Entity<Role>()
                .HasIndex(r => r.Name)
                .IsUnique();
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var entries = ChangeTracker.Entries()
                .Where(e => e.Entity is BaseEntity && (e.State == EntityState.Added ||
                e.State == EntityState.Modified));

            foreach (var entityEntry in entries)
                if (entityEntry.Entity is BaseEntity baseEntity)
                {
                    if (entityEntry.State == EntityState.Added)
                    {
                        baseEntity.CreatedAt = DateTime.UtcNow;
                    }
                    baseEntity.UpdatedAt = DateTime.UtcNow;
                }

            return base.SaveChangesAsync(cancellationToken);
        }
    }
}





 