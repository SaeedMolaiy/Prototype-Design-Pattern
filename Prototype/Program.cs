using System;
using Prototype.Models;

namespace Prototype
{
    internal class Program
    {
        private static void Main()
        {
            var p1 = new Product
            {
                ProductId = 1,
                GroupId = 1,
                Name = "Test",
                ShortDescription = "Test",
                Description = "Test",
                Price = 1000,
                Group = new Group
                {
                    GroupId = 1,
                    GroupName = "TestGroup"
                }
            };

            // Perform a shallow copy of p1 and assign it to p2.
            var p2 = p1.ShallowCopy();

            // Make a deep copy of p1 and assign it to p3.
            var p3 = p2.DeepCopy();

            // Display values of p1.    
            Console.WriteLine("Original Values :");
            Console.WriteLine(p1.ProductId);
            Console.WriteLine(p1.GroupId);
            Console.WriteLine(p1.Name);
            Console.WriteLine(p1.ShortDescription);
            Console.WriteLine(p1.Description);
            Console.WriteLine(p1.Price);
            Console.WriteLine(p1.Group.GroupName);

            // Change the value of p1 properties and display the values of p1,
            p1.ProductId = 5;
            p1.Name = "Copy";
            p1.ShortDescription = "Copy";
            p1.Description = "Copy";

            //p1
            Console.WriteLine("p1 Changed Values :");
            Console.WriteLine(p1.ProductId);
            Console.WriteLine(p1.GroupId);
            Console.WriteLine(p1.Name);
            Console.WriteLine(p1.ShortDescription);
            Console.WriteLine(p1.Description);
            Console.WriteLine(p1.Price);
            Console.WriteLine(p1.Group.GroupName);

            // p2
            Console.WriteLine("p2 Shallow Copy Values :");
            Console.WriteLine(p2.ProductId);
            Console.WriteLine(p2.GroupId);
            Console.WriteLine(p2.Name);
            Console.WriteLine(p2.ShortDescription);
            Console.WriteLine(p2.Description);
            Console.WriteLine(p2.Price);
            Console.WriteLine(p2.Group.GroupName);

            //p3
            Console.WriteLine("p3 Deep Copy Values :");
            Console.WriteLine(p3.ProductId);
            Console.WriteLine(p3.GroupId);
            Console.WriteLine(p3.Name);
            Console.WriteLine(p3.ShortDescription);
            Console.WriteLine(p3.Description);
            Console.WriteLine(p3.Price);
            Console.WriteLine(p3.Group.GroupName);

            Console.ReadKey();
        }
    }
}
