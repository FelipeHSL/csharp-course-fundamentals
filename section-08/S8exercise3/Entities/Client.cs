using System.Runtime.InteropServices.JavaScript;

namespace S8exercise3.Entities;

public class Client
{
    public string Name { get; set; }
    public string Email { get; set; }
    public DateOnly BirthDate { get; set; }


    public Client()
    {
        
    }
    
    public Client(string name, string email, DateOnly birthdate)
    {
        Name = name;
        Email = email;
        BirthDate = birthdate;
    }
    
}