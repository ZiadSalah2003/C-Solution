// Problem-Link : https://leetcode.com/problems/determine-if-string-halves-are-alike/description/
// Problem-ID : 1704
// Problem Name: Determine if String Halves Are Alike
// Verdict: AC
public class Solution {
    public bool HalvesAreAlike(string s) {
        int sum = 0;
        for (int i = 0; i < s.Length / 2; i++) {
            if ("aeiouAEIOU".Contains(s[i])) {
                sum++;
            }
        }
        for (int i = s.Length / 2; i < s.Length; i++) {
            if ("aeiouAEIOU".Contains(s[i])) {
                sum--;
            }
        }
        return sum == 0;
    }
}