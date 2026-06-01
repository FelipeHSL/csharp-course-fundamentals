using System.ComponentModel;
using S8exercise3.Entities.Enums;

namespace S8exercise3.Entities;

public class Order
{
    public Client Client { get; set; }
    public DateTime Moment { get; set; }
    public OrderStatus Status { get; set; }
    public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

    public Order()
    {
        
    }

    public Order(Client client,DateTime moment, OrderStatus status)
    {
        Client = client;
        Moment = moment;
        Status = status;
        
        
    }

    public void AddOrderItem(OrderItem orderitem)
    {
        OrderItems.Add(orderitem);
    }

    public void RemoveOrderItem(OrderItem orderitem)
    {
        OrderItems.Remove(orderitem);
    }

    public double Total()
    {
        double sum = 0.0;
        foreach (OrderItem item in OrderItems)
        {
            sum += item.SubTotal();
        }
        return sum;
    }
        
}