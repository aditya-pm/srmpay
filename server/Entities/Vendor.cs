using SRMPay.Enums;

namespace SRMPay.Entities;

public class Vendor
{
    public Guid Id { get; set; }

    public required string Name { get; set; }

    public required VendorType Type { get; set; }

    public required string Description { get; set; }

    public required string Location { get; set; }

    public required string OperatingHours { get; set; }

    public required string Email { get; set; }

    public required string PasswordHash { get; set; }

    public bool IsActive { get; set; } = true;

    public bool IsQueueEnabled { get; set; }

    public List<Product> Products { get; set; } = [];

    public Queue? Queue { get; set; }

    public List<Order> Orders { get; set; } = [];
    
    public List<Settlement> Settlements { get; set; } = [];
}