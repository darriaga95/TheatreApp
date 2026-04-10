using Microsoft.EntityFrameworkCore;
using Web.Sql.Entities;
using Web.Sql.Models;

namespace Web.Sql;
public partial class Context(DbContextOptions<Context> options) : ContextBase<Context>(options)
{
    public virtual DbSet<UserEntity> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<UserEntity>(entity =>
        {
            entity.ToTable("Orders");
            entity.HasKey(e => e.UserId);
            entity.Property(e => e.Address).HasConversion(
                property => SerializeProperty(property),
                property => DeserializeProperty<Address>(property));
        });
        OnModelCreatingPartial(modelBuilder);
    }
    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}