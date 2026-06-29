using SRMPay.Enums;
namespace SRMPay.Entities;

public class Order
{
    public Guid Id { get; set; }

    public required int OrderNo { get; set; }

    public required decimal TotalAmount { get; set; }

    public required DateTime CreatedAt { get; set; }

    public QueueEntry? QueueEntry { get; set; }

    public List<OrderItem> OrderItems { get; set; } = [];

    public required OrderSource Source { get; set; }

    public required OrderStatus Status { get; set; }

    public required Payment Payment { get; set; }

    public Guid StudentId { get; set; }

    public required Student Student { get; set; }

    public Guid VendorId { get; set; }
    
    public required Vendor Vendor { get; set; }
}
