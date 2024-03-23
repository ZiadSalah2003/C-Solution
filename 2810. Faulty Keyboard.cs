// Problem-Link : https://leetcode.com/problems/faulty-keyboard/description/
// Problem-ID : 2810
// Problem Name: Faulty Keyboard
// Verdict: AC
public class Solution {
    public string FinalString(string s) {
        var ls = new List<char>();
        bool r = false;
        foreach (char c in s) {
            if (c == 'i') {
                ls.Reverse();
                r = !r;
            }
            else {
                if (r) {
                    ls.Insert(0, c);
                } else {
                    ls.Add(c);
                }
            }
        }
        return new string(ls.ToArray());
    }
}