// Problem-Link : https://leetcode.com/problems/valid-anagram/
// Problem-ID : 242
// Problem Name: Valid Anagram
// Verdict: AC
   public class Solution
  {
 public bool IsAnagram(string s, string t)
      {
        if (s.Length!=t.Length)
            return false;
        char[] ss = s.ToCharArray();
        char[] tt = t.ToCharArray();
        Array.Sort(ss);
        Array.Sort(tt);
        for (int i = 0; i < ss.Length; i++)
        {
            if (ss[i] != tt[i])
                return false;
        }
        return true;
    }
}