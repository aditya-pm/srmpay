using SRMPay.Enums;

namespace SRMPay.Contracts.Vendor;

public record CreateVendorRequest(
    string Name,
    VendorType Type,
    string Description,
    string Location,
    string OperatingHours,
    string Email,
    bool IsQueueEnabled
);