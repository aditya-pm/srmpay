using Microsoft.EntityFrameworkCore;
using SRMPay.Data;
using SRMPay.Contracts.Vendor;

namespace SRMPay.Services;

public class VendorService(SRMPayContext db)
{
    private readonly SRMPayContext _db = db;

    public async Task<IReadOnlyList<VendorResponse>> GetAllAsync()
    {
        return await _db.Vendors
            .Select(v => new VendorResponse(
                v.Id,
                v.Name,
                v.Type,
                v.Description,
                v.Location,
                v.OperatingHours,
                v.IsQueueEnabled
            ))
            .ToListAsync();
    }
}
