using System;

namespace passing_array
{
    class Program
    {
        int Add(params int[] arr)
        {
            int s = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                s += arr[i];
            }
            return s;
        }
        static void Main(string[] args)
        {
            Program a = new Program();
            int[] arr = new int[5];
            for (int i = 0; i < 5; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int c = a.Add(arr);
            Console.WriteLine(c);
            Console.ReadLine();
        }
    }
}
