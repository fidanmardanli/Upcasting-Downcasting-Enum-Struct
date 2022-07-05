using System;

namespace Params
{
    class Program
    {
        public static void GetElements(params int[] nums)
        {
            foreach (var item in nums)
            {
                Console.WriteLine(item);
            }

        }

        static void Main(string[] args)
        {
            GetElements(1, 2, 3, 4, 5, 6, 7);
            int[] arr = { 1, 2, 6, 7 };
            Sum(arr);
        }

        static void Sum(int[] arr)
        {

        }

    }
}