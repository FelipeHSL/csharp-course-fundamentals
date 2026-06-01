using System;
using System.Globalization;
using S8exercise3.Entities;
using S8exercise3.Entities.Enums;

namespace  S8exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateOnly birthdate = DateOnly.Parse(Console.ReadLine());
            Console.WriteLine("Enter order Data: ");
            Console.Write("Status: ");
            OrderStatus status = (OrderStatus)Enum.Parse<OrderStatus>(Console.ReadLine(), true);
            Client client = new Client(name, email, birthdate);
            Order order = new Order(client, DateTime.Now, status);

            Console.WriteLine("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data: ");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                Product product = new Product(productName, productPrice);
                OrderItem orderItem = new OrderItem(quantity, productPrice, product);
                order.AddOrderItem(orderItem);
            }

            Console.WriteLine();

            Console.WriteLine("Order Summary: ");
            
            Console.WriteLine($"Order Moment: {order.Moment.ToString("dd/MM/yyyy HH:mm:ss")}");
            Console.WriteLine($"Order Status: {order.Status}");
            Console.WriteLine($"Cliente: {client.Name} ({client.BirthDate}) - {client.Email} ");
            Console.WriteLine();
            Console.WriteLine("OrderItems: ");
            foreach (OrderItem item in order.OrderItems)
            {
                Console.WriteLine($"Product Name: {item.Product.Name} - Price: {item.Product.Price.ToString("F2",CultureInfo.InvariantCulture)} - Quantity: {item.Quantity} - Total: {item.SubTotal().ToString("F2",CultureInfo.InvariantCulture)}");
            }

            Console.WriteLine($"Total Price: {order.Total().ToString("F2",CultureInfo.InvariantCulture)}");
        }
    }
}