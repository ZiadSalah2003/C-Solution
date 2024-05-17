// Problem-Link : https://binarysearch.com/problems/existence-of-a-substring-in-a-string-and-its-reverse
// Problem-ID : 3083
// Problem Name: Existence of a Substring in a String and Its Reverse
// Verdict: AC
public class Solution {
    public bool IsSubstringPresent(string s) {
        for (int i = 1; i < s.Length; i++)
        {
            string a = s[i].ToString() + s[i-1].ToString();
            if(s.Contains(a))
            return true;
        }
        return false;
    }
}