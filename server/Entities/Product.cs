using SRMPay.Enums;
namespace SRMPay.Entities;

public class Product
{
    public Guid Id { get; set; }

    public required string Name { get; set; }

    public string? Description { get; set; }

    public required ProductType Type { get; set; }

    public required decimal Price { get; set; }

    public bool IsAvailable { get; set; } = true;

    public string? ImageUrl { get; set; }

    public Guid VendorId { get; set; }

    public Vendor Vendor { get; set; } = null!;
}
