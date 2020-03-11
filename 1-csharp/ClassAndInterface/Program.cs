using System;

namespace ClassAndInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            MyClass myClass1 = new MyClass();
            Console.WriteLine(myClass1.myInt1);

            MyClass myClass2 = new MyClass(12, "This is a new string");
            Console.WriteLine("This is the int => {0} \n This is the string => {1}", myClass2.myInt1, myClass2.myString1);

            myClass2.PrintPrivateFields();

            Console.WriteLine(MyClass.myString3);
            String privateString = myClass2.InstanceMethod();
            Console.WriteLine(privateString);

            Console.WriteLine(MyClass.nullString);  //will only work in a separate class if you add static

            //rather than passing a copy of the variable, ref makes it pass the variable itself
            int y = 11;
            Console.WriteLine($"ref variable y == {y}");  //use dollar sign so you can then use bracket reference in the string
            myClass1.refMethod(ref y);
            Console.WriteLine($"ref variable y == {y}");

            int z = 22;
            Console.WriteLine($"value variable z == {z}");
            myClass1.valueMethod(z);  //the method receives a copy of z, and that is changed
            Console.WriteLine($"value variable z == {z}");  //the z within this class does not change, just the sent copy

            myClass1.outMethod(33, out int outV);
            Console.WriteLine($"the outvariable is {outV}");
            int outReturn = myClass1.outMethod(10, out int outVar);
            Console.WriteLine($"the outreturn is {outReturn}");  // console.writeline is a parameter array method

            Console.WriteLine("Param Array below:");
            myClass1.ParameterArrayMethod("test", 1, 2, 3, 4, 5, 7, 0, 5, 0);

            int returnOfDouble = myClass1.returnDouble(500);
            Console.WriteLine(returnOfDouble);
        }
    }
}
