using System;
class UserMainCode {
  public int maxSongs(string input1, int k)
  {
    if(input1 == null || k <= 0 || k > input1.Length)
    {
        return 0;
    }
    int count =0;
    for(int j=0; j<=k-1; j++)
    {
        if(input1[j]=='a' || input1[j] == 'A')
        {
            count++;
        }
    }
    int max = count;
    for(int i=1; i<=input1.Length-k; i++)
    {
        if(input1[i-1] == 'a' || input1[i-1] == 'A')
        {
            count-=1;   
        }
        if(input1[i+k-1] == 'a' || input1[i+k-1] == 'A')
        {
            count+=1;
        }
        if(count > max)
        {
            max = count
        }
    }
    return max;
  }
}
