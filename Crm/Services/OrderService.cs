using Crm.Entities;
namespace Crm.Services;

public sealed class OrderService
{
    public Order CreateOrder(
        string orderName,
        decimal orderPrice
    )
    {
        // TODO: Validate input parameters.
        return new()
        {
            OrderName = orderName,
            OrderPrice = orderPrice
        };
    }
}
   