// Problem-Link : https://leetcode.com/problems/compare-version-numbers/
// Problem-ID : 165
// Problem Name: Compare Version Numbers
// Verdict: AC
public class Solution {
    public int CompareVersion(string version1, string version2) {
        string[] s1 = version1.Split('.');
        string[] s2 = version2.Split('.');
        int n = Math.Max(s1.Length, s2.Length);
        for (int i = 0; i < n; i++) {
            int a = i < s1.Length ? int.Parse(s1[i]) : 0;
            int b = i < s2.Length ? int.Parse(s2[i]) : 0;
            if (a < b) {
                return -1;
            }
            if (a > b) {
                return 1;
            }
        }
        return 0;
    }
}