namespace Exercise1.Entities.Exceptions;

public class DomainExceptions : ApplicationException
{

    public DomainExceptions(string message) : base(message)
    {
        
    }
}