using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace secondLargest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[50];
            int largest, largest_2;
            Console.Write("Enter the size of the array: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the elements: ");
            for(int i = 0; i < n; i++)
            {
                Console.Write("Enter element {0}: ",i+1);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            //Display array
            Console.Write("array: ");
            for (int i = 0; i < n;i++)
            {
                Console.Write(arr[i]+" ");
            }
            //largest element
            Console.WriteLine();

            if (arr[0] > arr[1])
            {
                largest = arr[0];  
                largest_2 = arr[1];
            }
            else
            {
                largest = arr[1];//56
                largest_2 = arr[0];//19
            }
           
            for(int i=2;i<n;i++)
            {
                if (arr[i] > largest)
                {
                    largest_2=largest;
                    largest = arr[i];
                }
                else if (arr[i] > largest_2)
                {
                    largest_2 = arr[i];
                }
            }

            Console.WriteLine("\nLargest: "+largest); 
            Console.WriteLine("2nd Largest: " + largest_2);
        }
    }
}
