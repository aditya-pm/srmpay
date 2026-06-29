using SRMPay.Enums;
namespace SRMPay.Entities;

public class Payment
{
    public Guid Id { get; set; }

    public required decimal Amount { get; set; }

    public required PaymentMethod Method { get; set; }

    public required PaymentStatus Status { get; set; }

    public required string TransactionReference { get; set; }

    public DateTime? PaidAt { get; set; }

    public Guid OrderId { get; set; }
    
    public required Order Order { get; set; }
}
