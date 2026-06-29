using SRMPay.Enums;

namespace SRMPay.Entities;

public class Complaint
{
    public Guid Id { get; set; }

    public required string Title { get; set; }

    public required string Description { get; set; }

    public required DateTime CreatedAt { get; set; }

    public required ComplaintStatus Status { get; set; }

    public Guid? RelatedOrderId { get; set; }

    public Order? RelatedOrder { get; set; }

    public Guid StudentId { get; set; }
    
    public required Student Student { get; set; }
}