using System.Globalization;

namespace Exercise1.Entities;

public class Installment
{
    public DateTime DueDate { get; set; }
    public double Amount { get; set; }

    public Installment(DateTime due, double amount)
    {
        DueDate = due;
        Amount = amount;
    }


    override public string ToString()
    {
        return $"Due Date: {DueDate.ToString("dd/MM/yyyy")}, Amount: {Amount.ToString("F2",CultureInfo.InvariantCulture)}";
    }
}