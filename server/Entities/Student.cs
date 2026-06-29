namespace SRMPay.Entities;

public class Student
{
    public Guid Id { get; set; }

    public required string RegistrationNumber { get; set; }

    public required string Name { get; set; }
    
    public required string Email { get; set; }

    public required string PasswordHash { get; set; }

    public ICollection<Order> Orders { get; set; } = [];

    public ICollection<Notification> Notifications { get; set; } = [];
    
    public ICollection<Complaint> Complaints { get; set; } = [];
}
