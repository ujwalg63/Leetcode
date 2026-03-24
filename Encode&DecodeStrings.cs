public class Solution {

    public string Encode(IList<string> strs) {
        StringBuilder result = new StringBuilder();
        foreach(string str in strs)
        {
            result.Append(str.Length);
            result.Append("#");
            result.Append(str);
        }
        return result.ToString();
    }

    public List<string> Decode(string s) {
        List<string> result = new List<string>();
        int i = 0;
        while(i < s.Length)
        {
            int j = i;
            while(s[j] != '#')
            {
                j++;
            }
            int len = int.Parse(s.Substring(i,j-i));
            result.Add(s.Substring(j+1, len));
            i=j+1+len;
        }
        return result;

   }
}
