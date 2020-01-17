using System;
using Pedido.Entities.Enums;
using Pedido.Entities;
using System.Globalization;

namespace Pedido
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
            Console.Write("Birth Date (DD/MM/YY): ");
            DateTime dateN = DateTime.Parse(Console.ReadLine());
            Console.WriteLine();

           

            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client client = new Client(name, email, dateN);
            Order order = new Order(DateTime.Now, status, client);
            
            Console.Write("How many items to this order? ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine($"Enter #{i} item data: ");
                Console.Write("Product Name: ");
                string productName = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Product product = new Product(productName, price);

                Console.Write("Quantity :");
                int quantity = int.Parse(Console.ReadLine());
                
                OrderItem orderItem = new OrderItem(quantity, price, product);
                order.AddItem(orderItem);


            }

            Console.WriteLine();

            Console.WriteLine("ORDER SUMMARY:");

            Console.WriteLine(order);

        }
    }
}
