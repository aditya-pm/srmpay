namespace SRMPay.Entities;

public class Queue
{
    public Guid Id { get; set; }

    public List<QueueEntry> QueueEntries { get; set; } = [];

    public Guid VendorId { get; set; }
    
    public required Vendor Vendor { get; set; }
}