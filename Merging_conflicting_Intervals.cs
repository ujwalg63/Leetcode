// Given a jagged array(array of arrays), which contains, conflicting intervals(arrays)
//This code is suppoed to merge them such that overlapping is eliminated.
using System;
using System.Collections.Generic;
class HelloWorld {
  static int[][] Merge(int[][] intervals)
  {
      if(intervals.Length == 0)
      {
          return new int[0][];
      }
     Array.Sort(intervals, (a,b) => 
     {
         int startCompare = a[0].CompareTo(b[0]);
         if(startCompare != 0)
         {
             return startCompare;
         }
         else
         {
             return a[1].CompareTo(b[1]);
         }
     });
     List<int[]> resolvedIntervals = new List<int[]>();
     int[] current = intervals[0];
     for(int i=1; i<intervals.Length; i++)
     {
         int[] next = intervals[i];
         if(next[0]<=current[1])
         {
             current[1] = Math.Max(current[1],next[1]);
         }
         else
         {
             resolvedIntervals.Add(current);
             current = next;
         }
     }
     resolvedIntervals.Add(current);
     return resolvedIntervals.ToArray();

  }
  static void Main() {
    int[][] intervals = new int[][]
    {
        new int[] {1,3},
        new int[] {2,4},
        new int[] {6,8},
        new int[] {7,9}
    };
    int[][] answer = Merge(intervals);
    foreach(int[] interval in answer)
    {
        //Console.WriteLine("[\"" +interval[0]+ "\",\"" +interval[1]+ "\"]")
        Console.WriteLine($"[\"{interval[0]}\",\"{interval[1]}\"]");
    }
  }
}
