using System;
namespace LargestElementInArray
{
    class Compare
    {
        static void Main(string[] args)
        {
            int[] Array1 = { 15, 6, 10, 8, 35 };
            Console.WriteLine("Numbers within the Array: ");
            foreach (int num in Array1)
            {
                Console.WriteLine(num);
            }
            int bigger = Array1[0];
            for (int i = 1; i < Array1.Length; i++)
            {
                if (Array1[i] > bigger)
                {
                    bigger = Array1[i];
                }
            }
            Console.WriteLine("The largest element in the array is: " + bigger);
            Console.ReadKey();
        }
    }
}
