using System;
using System.Collections;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayLists();

            //whenever we use a type with <> at the end that is a generic type and the specific thing you put in the <> is called 
            var list = new List<T>();
        }

        private static void ArrayLists()
        {
            var arraylist = new ArrayList();

            arraylist.Add(1);
            arraylist.Add(2);
            arraylist.Add(3);
            /*arraylist.Add(null);
            arraylist.Add(new ArrayList());
            arraylist.Add("asdf");*/

            //when used with the non-generic IEnumerable interface it will attempt to cast to whatever type you put here
            //         v
            foreach (int num in arraylist)
            {
                //int num2 = (int)num;
                Console.Write($"{num +1 } ");
            }
        }
    }
}
