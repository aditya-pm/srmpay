using SRMPay.Services;

namespace SRMPay.Endpoints;

public static class VendorEndpoints
{
    public static void MapVendorEndpoints(this WebApplication app)
    {
        var vendorGroup = app.MapGroup("/vendors");

        vendorGroup.MapGet("/", async (VendorService service) =>
            Results.Ok(await service.GetAllAsync()));

        vendorGroup.MapGet("/{id}", async (Guid id, VendorService service) =>
        {
            var vendor = await service.GetByIdAsync(id);

            return vendor is null
                ? Results.NotFound()
                : Results.Ok(vendor);
        });
    }
}