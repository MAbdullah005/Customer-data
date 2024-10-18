using System;

public class PersonData
{
    private string lastName;
    private string firstName;
    private string address;
    private string city;
    private string state;
    private string zip;
    private string phone;
    public string LastName
    {
        get{return lastName;}
        set{lastName=value;}
    }
    public string FirstName
    {
        get{return firstName;}
        set{firstName = value;}
    }
    public string Address
    {
        get{return address;}
        set{address = value;}
    }
    public string City
    {
        get{return city;}
        set{city=value;}
    }
    public string State
    {
        get{ return state;}
        set{ state=value;}
    }
    public string Zip
    {
        get{return zip;}
        set{zip=value;}
    }
    public string Phone
    {
        get{return phone;}
        set{phone = value;}
    }
}

public class CustomerData : PersonData
{
    private int customerNumber;
    private bool mailingList;
    public int CustomerNumber
    {
        get{return customerNumber;}
        set{customerNumber=value;}
    }
    public bool MailingList
    {
        get{return mailingList;}
        set{mailingList = value;}
    }
}
class Program
{
    static void Main(string[] args)
    {
        CustomerData customer = new CustomerData();
        customer.FirstName = "John";
        customer.LastName = "Doe";
        customer.Address = "123 Main St";
        customer.City = "Anytown";
        customer.State = "CA";
        customer.Zip = "90210";
        customer.Phone = "555-1234";
        customer.CustomerNumber = 1;
        customer.MailingList = true;
        Console.WriteLine("Customer Information:");
        Console.WriteLine($"Name: {customer.FirstName} {customer.LastName}");
        Console.WriteLine($"Address: {customer.Address}, {customer.City}, {customer.State} {customer.Zip}");
        Console.WriteLine($"Phone: {customer.Phone}");
        Console.WriteLine($"Customer Number: {customer.CustomerNumber}");
        Console.WriteLine($"Mailing List: {(customer.MailingList ? "Yes" : "No")}");
    }
}
