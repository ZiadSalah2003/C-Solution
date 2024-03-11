// Problem-Link : https://leetcode.com/problems/custom-sort-string/
// Problem-ID : 791
// Problem Name: Custom Sort String
// Verdict: AC
public class Solution {
    public string CustomSortString(string order, string s) {
        int[] count = new int[26];
        foreach (char c in s) count[c - 'a']++;
        string result = "";
        foreach (char c in order) {
            while (count[c - 'a']-- > 0) result+=c;
        }
        for (char c = 'a'; c <= 'z'; c++) {
            while (count[c - 'a']-- > 0)
                result+=c;
        }
        return result.ToString();
    }
}