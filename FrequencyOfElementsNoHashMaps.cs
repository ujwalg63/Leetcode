using System;
using System.Transactions;
using System.Linq;
namespace FrequencyOfElements
{
    class Program
    {
        static void Main()
        {
            //this is without using the hashmaps/dictionaries
            int[] array = new int[] { 3, 1, 2, 2, 3, 3, 4, 4, 6, 6, 7,7,7,7,7};
            Array.Sort(array);
            List<List<int>> frequencies = new List<List<int>>();
            int current = array[0];
            int Count = 1;
            for(int i=1; i<array.Length;i++)
            {
                if(array[i]==current)
                {
                    Count++;
                }
                else
                {
                    frequencies.Add(new List<int>(){array[i-1], Count});
                    current = array[i];
                    Count = 1;
                }
            }
            frequencies.Add(new List<int>(){array[array.Length-1], Count});
            // frequencies = frequencies.OrderByDescending(x=>x[1]).ThenBy(x=>x[0]).ToList();
            frequencies = frequencies.OrderByDescending(x=>x[1]).ToList();
            Console.WriteLine("\n");
            Console.WriteLine(string.Join("_ _", frequencies.Select(list=>$"[{list[0]}, {list[1]}]")));
            Console.WriteLine("\n");
            List<int> returnList = new List<int>();
            foreach(List<int> i in frequencies)
            {
                returnList.Add(i[0]);
            }
            int[] result = returnList.ToArray();
            foreach(int i in result)
            {
                Console.Write(i + " ");
            }
        } 
    }
}

