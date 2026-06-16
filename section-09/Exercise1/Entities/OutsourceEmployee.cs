namespace Exercise1.Entities;

public class OutsourceEmployee : Employee
{
    public double AddItionalCharge { get; set; }

    public OutsourceEmployee()
    {
        
    }

    public OutsourceEmployee(string name, int hours, double ValuePerHour, double additionalCharge) : base(name, hours,
        ValuePerHour)
    {
        AddItionalCharge = additionalCharge;
    }

    public override double Payment()
    {
        return base.Payment() + 1.1 * AddItionalCharge;
    }
}