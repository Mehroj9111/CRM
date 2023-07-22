namespace Crm.Entities;

public sealed class Order
{
    public string? OrderName { get; set; }
    public decimal OrderPrice { get; set; }


    public void Validate()
     {
        if (string.IsNullOrEmpty(OrderName))
        {
            throw new ArgumentException("FirstName клиента не может быть пустым");
        }
     }
}