using System;

namespace DemoObject
{
    class Program
    {
        static void Main(string[] args)
        {
            //now that we've defined a class, we can take objects from that class
            //the class serves as a template to create the object
            Product candyBar = new Product();
            candyBar.SetDefaultValues();
            Console.WriteLine(candyBar);

            int cerealAmount = GetStock("cereal");

            Product cereal = new Product();
            cereal.SetValues("Cocoa Pebbles", cerealAmount, 4.4);
            Console.WriteLine(cereal);
        }

        static int GetStock(string name)
        {
            int quantity;
            do
            {
                Console.WriteLine("Please enter the stock for " + name + ": ");
                quantity = int.Parse(Console.ReadLine());
            }
            while(quantity < 0);
            return quantity;
        }
    }
}
