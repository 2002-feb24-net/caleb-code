using System;
using System.Collections.Generic;
using System.Text;

namespace ClassAndInterface
{
    class MyClass : Interface1
    {
        public int myInt1 = 112233;
        public String myString1 { get; }

        private int myInt2 = 10;
        private String myString2 = "Second String (I am private)";

        public static String myString3 = "I'm a static string";

        //will only work in a separate class if you add static
        public static String nullString = "A null value in a string will not show up even if you attach it to a string" + null;

        public MyClass() { }
        public MyClass(int myInt1, String myString1)
        {
            this.myInt1 = myInt1;
            this.myString1 = myString1;
        }
        public void PrintPrivateFields()
        {
            Console.WriteLine($"Int == {myInt2}, String == {myString2}");
        }

        public String InstanceMethod()
        {
            return myString2;
        }

        public void refMethod(ref int x)
        {
            x = x + 100;
            Console.WriteLine(x);
        }

        public void valueMethod(int x)
        {
            x = x + 222;
            Console.WriteLine(x);
        }

        public int outMethod(int number, out int outVar)  //out means you don't have to assign it a value in the class where this method is called
        {
            Console.WriteLine(number);
            outVar = number + 333;
            int outReturn = outVar * 10;
            return outReturn;
        }

        public void ParameterArrayMethod(string s, params int[] arg)
        {
            foreach (var ints in arg)
            {
                if (ints == 0)
                {
                    Console.WriteLine("There is a zero!");
                }
            }
        }

        public int returnDouble(int x)
        {
            x += x;
            return x;
        }
    }
}

