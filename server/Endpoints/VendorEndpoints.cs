using SRMPay.Services;

namespace SRMPay.Endpoints;

public static class VendorEndpoints
{
    public static void MapVendorEndpoints(this WebApplication app)
    {
        var vendorGroup = app.MapGroup("/vendors");

        vendorGroup.MapGet("/", async (VendorService service) =>
            Results.Ok(await service.GetAllAsync()));

    }
}