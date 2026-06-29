namespace SRMPay.Entities;

public class OrderItem
{
    public Guid Id { get; set; }

    public Guid ProductId { get; set; }
    
    public required Product Product { get; set; }

    public Guid OrderId { get; set; }

    public required Order Order { get; set; }

    public required int Quantity { get; set; }

    public required decimal UnitPrice { get; set; }
}
