using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Merge_sort
{    
    class Program
    {
        static void Main(string[] args)
        {
            //create lists for b/f and a/f sorting
            List<int> unsorted = new List<int>();
            List<int> sorted;

            Random random = new Random();

            //generate random list for unsorted
            Console.WriteLine("Random array:" );
            for(int i = 0; i< 10;i++){
                unsorted.Add(random.Next(0,100));
                //print unsorted list
                Console.Write(unsorted[i]+" ");
            }
            Console.WriteLine();

            //call mergesort function
            sorted = MergeSort(unsorted);

            //print sorted list
            Console.WriteLine("Sorted array: ");
            foreach (int x in sorted)
            {
                Console.Write(x+" ");
            }
			Console.Write("\n");
        }
		

        private static List<int> MergeSort(List<int> unsorted)
        {
            if (unsorted.Count <= 1)
            {
                return unsorted;
            }
            //create new list elements for temporary containment
            List<int> left = new List<int>();
            List<int> right = new List<int>();

            //determine where to split the unsorted list
            int middle = unsorted.Count / 2;
            //Dividing the unsorted list
            for (int i = 0; i < middle;i++)
            {
                left.Add(unsorted[i]);
            }
            for (int i = middle; i < unsorted.Count; i++)
            {
                right.Add(unsorted[i]);
            }

            left = MergeSort(left);
            right = MergeSort(right);
            return Merge(left, right);
        }

        private static List<int> Merge(List<int> left, List<int> right)
        {
            //create list variable to return
            List<int> result = new List<int>();

            //continue while either side is still being sorted
            while(left.Count > 0 || right.Count > 0)
            {
                if (left.Count > 0 && right.Count > 0)
                {
                    //Comparing First two elements to see which is smaller
                    if (left.First() <= right.First())
                    {
                        result.Add(left.First());
                        //pull the rest of the list minus the first element
                        left.Remove(left.First());
                    }
                    else
                    {
                        result.Add(right.First());
                        //pull the rest of the list minus the last element
                        right.Remove(right.First());
                    }
                }
                else if(left.Count > 0)
                {
                    //keep pulling list items for sorting (left)
                    result.Add(left.First());
                    left.Remove(left.First());
                }
                else if (right.Count > 0)
                {
                    //keep pulling list items for sorting (right)
                    result.Add(right.First());
                    right.Remove(right.First());    
                }    
            }
            return result;
        }
    }
}
