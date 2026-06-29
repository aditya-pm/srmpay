using SRMPay.Endpoints;

namespace SRMPay.Extensions;

public static class WebApplicationExtensions
{
    public static void MapEndpoints(this WebApplication app)
    {
        app.MapVendorEndpoints();
    }
}