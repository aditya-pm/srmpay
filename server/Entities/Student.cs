namespace SRMPay.Entities;

public class Student
{
    public Guid Id { get; set; }

    public required string RegistrationNumber { get; set; }

    public required string Name { get; set; }
    
    public required string Email { get; set; }

    public required string PasswordHash { get; set; }

    public List<Order> Orders { get; set; } = [];

    public List<Notification> Notifications { get; set; } = [];
    
    public List<Complaint> Complaints { get; set; } = [];
}
