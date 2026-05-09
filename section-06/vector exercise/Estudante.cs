namespace ExVect1;

public class Estudante
{
    public string Name { get; set; }
    public string Email { get; set; }

    public Estudante(string name, string email)
    {
        Name = name;
        Email = email;
    }

    override public string ToString()
    {
        return $"{Name} , {Email}";
    }
}