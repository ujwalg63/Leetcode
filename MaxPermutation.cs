using System;
using System.Collections.Generic;
public class UserMainCode 
{
    public int maxPermutationValue(string[] input1, int input2)
    {
        if(input1 == null || input1.Length == 0 || input2 <= 0)
        {
            return 0;
        }
        int max = 0;
        int n = Math.Min(input2, input1.Length);
        for(int i=0; i<n; i++)
        {
            string s = input1[i];
            int fact = 1;
            int consonantCount = 0;
            foreach(char c in s)
            {
                if(!IsVowel(c))
                {
                    consonantCount++;
                }
            }
            if(consonantCount==0) fact =0;
            else
            {
                while(consonantCount>=1)
                {
                    fact = consonantCount*fact;
                    consonantCount--;
                }
            }
            if(fact>max)
            {
                max = fact;
            }
        }
        return max;
    }
    public static bool IsVowel(char c)
    {
        HashSet<char> set = new HashSet<char>{'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U'};
        if(set.Contains(c))
        {
            return true;
        }
        return false;
    }
}
