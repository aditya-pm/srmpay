namespace SRMPay.Enums;

public enum OrderSource
{
    Walkin,
    Online
}

public enum OrderStatus
{
    Pending,
    Accepted,
    Preparing,
    Ready,
    Collected,
    Cancelled
}

public enum ProductType
{
    Food,
    Drink,
    Printing,
    Stationery,
    Service,
    Other
}

public enum ComplaintStatus
{
    Issued,
    UnderReview,
    Closed
}

public enum PaymentMethod
{
    Offline,
    Online
}

public enum PaymentStatus
{
    Pending,
    Paid,
    Failed,
    Refunded
}

public enum SettlementStatus
{
    Pending,
    Processing,
    Completed,
    Failed
}
