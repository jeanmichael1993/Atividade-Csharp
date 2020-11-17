using Atividades.Entities;
using Atividades.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Atividades.Program
{
    class Program
    {
        static void Main(String[]args)
        {
            Console.WriteLine("Enter cliente data:");
            Console.Write("Name:");
            String name = Console.ReadLine();
            Console.Write("Email:");
            String email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY):");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Client client = new Client(name, email, birthDate);
            Console.WriteLine("Enter order data:");
            Console.Write("Status:");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.Write("How many items to this order?");
            int n = int.Parse(Console.ReadLine());
            Order order = new Order(DateTime.Now, status, client);
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter #{i+1} item data:");
                Console.Write("Product name:");
                String nameProduct = Console.ReadLine();
                Console.Write("Product Price:");
                double priceProduct = double.Parse(Console.ReadLine());
                Console.Write("Quantity:");
                int quantity = int.Parse(Console.ReadLine());
                Product product = new Product(nameProduct, priceProduct);
                OrderItem orderItems = new OrderItem(quantity, priceProduct, product);
                order.AddItem(orderItems);

            }
            
            Console.WriteLine(order);
        }
    }
}
