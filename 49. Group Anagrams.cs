// Problem-Link : https://leetcode.com/problems/group-anagrams/
// Problem-ID : 49
// Problem Name: Group Anagrams
// Verdict: AC
public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
    Dictionary<string,List<string>>mp= new Dictionary<string,List<string>>();
    for (int i = 0; i < strs.Length; i++)
    {
        char[] aa = strs[i].ToCharArray();
        Array.Sort(aa);
        string a = new string(aa);
         if(!mp.ContainsKey(a))
             mp[a] = new List<string>();
        mp[a].Add(strs[i]);
    }
    return new List<IList<string>>(mp.Values);
    }
}