namespace SRMPay.Entities;

public class QueueEntry
{
    public Guid Id { get; set; }

    public required int TokenNo { get; set; }

    public required DateTime JoinedAt { get; set; }

    public Guid QueueId { get; set; }

    public required Queue Queue { get; set; }

    public Guid OrderId { get; set; }
    
    public required Order Order { get; set; }
}
