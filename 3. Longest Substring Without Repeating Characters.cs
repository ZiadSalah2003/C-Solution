// Problem-Link : https://leetcode.com/problems/longest-substring-without-repeating-characters/
// Problem-ID : 3
// Problem Name: Longest Substring Without Repeating Characters
// Verdict: AC
public class Solution {
    public int LengthOfLongestSubstring(string s) {
        HashSet<char> set = new HashSet<char>();
        int l = 0, r = 0, mx = 0;
        while (r < s.Length) {
            if (!set.Contains(s[r])) {
                set.Add(s[r]);
                mx = Math.Max(mx, r - l + 1);
                r++;
            } else {
                set.Remove(s[l]);
                l++;
            }
        }
        return mx;
    }
}