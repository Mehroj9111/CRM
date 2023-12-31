namespace Crm.Entities;

public sealed class Client
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? MiddleName { get; set; }
    public short Age { get; set; }
    public string? PassportNumber { get; set; }
    public Gender Gender { get; set; }
    public string OrderName { get; internal set; }
    public string OrderPrice { get; internal set; }

}
