using System;
class UserMainCode {
  public int maxSongs(string input1, int k)
  {
    if(input1 == null || k == 0 || k > input1.Length)
    {
        return 0;
    }
    int max = 0;
    for(int i=0; i<=input1.Length-k; i++)
    {
        int count = 0;
        for(int j=i; j<=i+k-1; j++)
        {
            if(input1[j] == 'a')
            {
                count++;
            }
        }
        if(count>max)
        {
            max = count;
        }
    }
    return max;
  }
}
