using System;
using System.Collections.Generic;
/*
1. Push your code to your personal code repo (e.g. mine is 2002-feb24-net/nick-code).
2. Make a new project named `PersonList` in a folder named `PersonList`. (So the path to the
   Program.cs file will be: `<repo>/PersonList/Program.cs`).

9. In a comment, describe the difference between insertion sort and bubble sort.
//Insertion Sort: In each iteration the next element is bubbled through the sorted section until it reaches the right spot
//Bubble Sort: In each iteration, sift through the unsorted section to find the maximum.
10. Call these two methods on the created List and use Console to show the user the results.*/
namespace PersonList
{
    class Program
    {
        static void Main(string[] args)
        {
            /*6. In the Program class, create a List of at least five Persons, and use Console to show the user
            the List's contents.*/
            /*List<string> persons = new List<string>();
            persons.Add(ToString(Person("Adam")));
            persons.Add(ToString(Person("Benjy")));
            persons.Add(ToString(Person("Charlie")));
            persons.Add(ToString(Person("Dave")));
            persons.Add(ToString(Person("Eddie")));*/
            

            /*6. In the Program class, create a List of at least five Persons, and use Console to show the user
            the List's contents.*/
            ToString(Persons("Adam"));
            ToString(Persons("Benjy"));
            ToString(Persons("Charlie"));
            ToString(Persons("Dave"));
            ToString(Persons("Eddie"));

            InsertSort(persons);

            Console.WriteLine(persons);
            
            /*7. Implement a method that will efficiently check for any duplicate names in a List of Persons,
            returning true or false.*/
            if(list.Count != list.Distinct().Count())
            {
                Console.WriteLine("You've got duplicates!");
            }
        }

        /*Implement a method that will sort a List of Persons by name, using *insertion sort*.*/
        static void InsertSort(IComparable[] array)
        {
            int i, j;

            for (i = 1; i < array.Length; i++)
            {
                IComparable value = array[i];
                j = i - 1;
                while ((j >= 0) && (array[j].CompareTo(value) > 0))
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = value;
            }
        }
    }

    /*3. Create a Person class to represent a person, having (1) a name, and (2) at least one other piece
    of data. Do not use any public fields.*/
    public static class Person
    {
        /*4. Implement 1 or more constructors, to enforce a requirement that a Person can't exist without a
        name.*/
        private string name;
        private int id;
        private static int statId;
        public static List<Person> persons = new List<Person>();
        public static void Persons(string name) //make this a constructor instead of a method !!!
        {
            this.name = name;

            //id increments each time Person is created
            id = statId;
            statId++;

            //Everytime a new instance of Person class is created, it will be added to the list
            persons.Add(this);
        }

        /*5. Override ToString method, to return the name of each Person.*/
        public override string ToString()
        {
            return "Person: " + name + " " + id;
        }
    }
}
