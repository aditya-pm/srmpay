using Microsoft.EntityFrameworkCore;
using SRMPay.Entities;

namespace SRMPay.Data;

public class SRMPayContext(DbContextOptions<SRMPayContext> options) : DbContext(options)
{
    protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
    {
        base.ConfigureConventions(configurationBuilder);

        configurationBuilder.Properties<Enum>().HaveConversion<string>();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {   
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Vendor>()
            .HasOne(v => v.Queue)
            .WithOne(q => q.Vendor)
            .HasForeignKey<Queue>(q => q.VendorId);

        modelBuilder.Entity<Order>()
            .HasOne(o => o.Payment)
            .WithOne(p => p.Order)
            .HasForeignKey<Payment>(p => p.OrderId);

        modelBuilder.Entity<Order>()
            .HasOne(o => o.QueueEntry)
            .WithOne(qE => qE.Order)
            .HasForeignKey<QueueEntry>(qE => qE.OrderId);
    }

    public DbSet<Student> Students { get; set; }
    public DbSet<Vendor> Vendors { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderItem> OrderItems { get; set; }
    public DbSet<Queue> Queues { get; set; }
    public DbSet<QueueEntry> QueueEntries { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Payment> Payments { get; set; }
    public DbSet<Settlement> Settlements { get; set; }
    public DbSet<Notification> Notifications { get; set; }
    public DbSet<Complaint> Complaints { get; set; }
}