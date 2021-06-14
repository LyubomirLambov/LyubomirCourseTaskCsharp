using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    public class Program
    {

        static int binarySearch(int[] MyArray, int desired)
        {
            int start = 0;
            int end = MyArray.Length - 1;
            while(start <= end)
            {
                int mid = (start + end) / 2;
                if (desired == MyArray[mid])
                {
                    return mid;
                }
                else if (desired<MyArray[mid])
                {
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }
            }

           
            return -1;
        }

        public static void Main(string[] args)
        {

            int[] MyArray = new int[10] { 1, 2, 3, 4, 6, 7, 8, 9, 10, 12 };
            int desired;
            Console.WriteLine("Enter your desired integer : ");
            desired = Convert.ToInt32(Console.ReadLine());
            int target = desired;
            int result = binarySearch(MyArray, desired);
            if (result<0)
            {
                //Console.WriteLine("Searched item is not found",desired-1);
                Console.WriteLine(" Integer not found , returning last number : " + Math.Abs(desired - 1));
            }
            else
            {
                Console.WriteLine("Searched item {0} is found at position {1}",desired,result);
            }
            

            

        }
       
    }
}

