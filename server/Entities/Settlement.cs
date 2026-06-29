using SRMPay.Enums;
namespace SRMPay.Entities;

public class Settlement
{
    public Guid Id { get; set; }

    public required DateTime StartDate { get; set; }

    public required DateTime EndDate { get; set; }

    public required decimal GrossAmount { get; set; }

    public required decimal CommissionAmount { get; set; }

    public required decimal NetAmount { get; set; }

    public required SettlementStatus Status { get; set; }

    public required DateTime GeneratedAt { get; set; }

    public DateTime? PaidAt { get; set; }

    public Guid VendorId { get; set; }
    
    public required Vendor Vendor { get; set; }
}