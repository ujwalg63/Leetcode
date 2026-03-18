using System;
namespace checkIfSorted
{
    class checkIfSorted
    {

        static bool checkSorted(int[] arr)
        {
            for(int i=1; i<arr.Length; i++)
            {
                if(arr[i] < arr[i-1])
                {
                    return false;
                }
            }
            return true;

        }
        static void Main()
        {
            Console.WriteLine("Enter the size of the array:");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for(int i=0; i<n; i++)
            {
                Console.WriteLine("Enter the element:");
                int element = int.Parse(Console.ReadLine());
                arr[i] = element;
            }
            Console.WriteLine($"[The entered array is: {string.Join("  ", arr)}]");
            bool TorF = checkSorted(arr);
            if(TorF)
            {
                Console.WriteLine("The array is sorted");
            }
            else
            {
                Console.WriteLine("The array is not sorted");
            }
        } 
    }
}
