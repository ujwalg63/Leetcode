//It returns the list of lists of anagrams, when given a list of words(strings)
using System;
using System.Collections.Generic;
using System.Linq;
public static List<List<string>> GroupAnagrams(string[] words)
{
    
    Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();
    foreach(string word in words)
    {
        char[] chararr = word.ToCharArray();
        Array.Sort(chararr);
        string key = new string(chararr);
        if(!map.ContainsKey(key))
        {
            map[key] = new List<string>();
        }
        map[key].Add(word);
    }
    return map.Values.ToList();
    
}
