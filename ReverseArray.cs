using System;
namespace ReverseArray
{
    class Program
    {
        static void reverseArray(int[] arr, int n)
        {
            //correct but not optimal, it is complex but still O(n) complexity
            // int mid = (n-1)/2;
            // if(n%2 != 0)
            // {
            //     for(int i=0; i<mid; i++)
            //     {
            //         int temp = arr[n-(i+1)];
            //         arr[n-(i+1)] = arr[i];
            //         arr[i] = temp;
            //     }
            // } 
            // if(n%2 == 0)
            // {
            //     for(int i=0; i<=mid; i++)
            //     {
            //         int temp = arr[n-(i+1)];
            //         arr[n-(i+1)] = arr[i];
            //         arr[i] = temp;
            //     }   
            // }

            //optimal two pointer approach, this is more optimal, intuitive and better thinking
            int left = 0;
            int right = n-1;
            while(left<right)
            {
                (arr[left],arr[right]) = (arr[right],arr[left]);
                left++;
                right--;
            }
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
            Console.WriteLine($"[The original array is : {string.Join("  ", arr)}]");
            Console.WriteLine("\n");
            reverseArray(arr, n);
            Console.WriteLine($"[The array after reversing: {string.Join("  ", arr)}]");
            Console.WriteLine("\n  \n");
            //Console.WriteLine($"The no of unique elements in the array is : {no_of_uniqueElements}");
        } 
    }
}

