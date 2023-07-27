using Crm.Entities;
using Crm.Services;


    System.Console.Write("vvedite komandu : ");

string client = Console.ReadLine();
if (string.IsNullOrEmpty(client))
    {
        throw new ArgumentException("клиент не может быть пустым");
    }
string cmd = (string.IsNullOrWhiteSpace(client) ? "exit" : client);
bool result1 = (string.IsNullOrWhiteSpace(client) ? true : false);
if (string.IsNullOrWhiteSpace(client))
    cmd = "exit";

ClientService clientService = new();
OrderService orderService = new();

CreateClient();


void CreateClient()
{
    System.Console.Write("FirstName : ");
    string firstName = Console.ReadLine();
     if (string.IsNullOrEmpty(firstName))
    {
        throw new ArgumentException("FirstName клиента не может быть пустым");
    }
    System.Console.Write("LastName : ");
    string lastName = Console.ReadLine();
     if (string.IsNullOrEmpty(lastName))
    {
        throw new ArgumentException("FirstName клиента не может быть пустым");
    }
    System.Console.Write("MiddleName : ");
    string middleName = Console.ReadLine();
    if (string.IsNullOrEmpty(middleName))
    {
        throw new ArgumentException("FirstName клиента не может быть пустым");
    }
    System.Console.Write("Age : ");
    short age = short.Parse(Console.ReadLine());
    if (short.IsNullOrEmpty(age))
    {
        throw new ArgumentException("FirstName клиента не может быть пустым");
    }
    System.Console.Write("PassportNumber : ");
    string passportNumber = Console.ReadLine();
    if (string.IsNullOrEmpty(passportNumber))
    {
        throw new ArgumentException("FirstName клиента не может быть пустым");
    }
    System.Console.Write("Gernder : ");
    Gender gender = (Gender) int.Parse(Console.ReadLine());
    if (Gender.IsNullOrEmpty(gender))
    {
        throw new ArgumentException("FirstName клиента не может быть пустым");
    }

    Client newClient = clientService.CreateClient(
        firstName,
        lastName,
        middleName,
        age,
        passportNumber,
        gender
    );

CreateOrder();
void CreateOrder()
{
    System.Console.Write("Order Name : ");
    string orderName = Console.ReadLine();
    if (string.IsNullOrEmpty(orderName))
    {
        throw new ArgumentException("OrderName клиента не может быть пустым");
    }
    System.Console.Write("Order Price : ");
    decimal orderPrice = Convert.ToInt32(Console.ReadLine());
     if (decimal.IsNullOrEmpty(orderPrice))
    {
        throw new ArgumentException("OrderName клиента не может быть пустым");
    }

    Order newOrder = orderService.CreateOrder(
        orderName,
        orderPrice


    );
    System.Console.WriteLine(" ");
    System.Console.WriteLine(" ");

     Console.WriteLine("Client Name : {0}",
        string.Join(' ', newClient.FirstName, newClient.MiddleName, newClient.LastName));

    Console.WriteLine("Client Age : {0}", newClient.Age);
    Console.WriteLine("Client Passport Number : {0}", newClient.PassportNumber);

    Console.WriteLine("Order Name: {0}",
        string.Join(' ', newOrder.OrderName));

    Console.WriteLine("Order Price: {0}", newOrder.OrderPrice);
}
}


