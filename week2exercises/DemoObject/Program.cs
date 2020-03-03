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
        }
    }
}
