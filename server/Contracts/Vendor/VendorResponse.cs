using SRMPay.Enums;

namespace SRMPay.Contracts.Vendor;

public record VendorResponse(
    Guid Id,
    string Name,
    VendorType Type,
    string Description,
    string Location,
    string OperatingHours,
    bool IsQueueEnabled
);
