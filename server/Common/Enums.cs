namespace SRMPay.Enums;

public enum VendorType
{
    Food,
    Beverages,
    Stationery,
    Printing,
    Pharmacy,
    Merchandise,
    Services,
    Other
}

public enum OrderSource
{
    WalkIn,
    Online
}

public enum OrderStatus
{
    AwaitingAcceptance,
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
    Open,
    UnderReview,
    Closed
}

public enum PaymentMethod
{
    Cash,
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
