// Problem-Link : https://leetcode.com/problems/counting-words-with-a-given-prefix/
// Problem-ID : 2185
// Problem Name: Counting Words With a Given Prefix
// Verdict: AC
public class Solution {
    public int PrefixCount(string[] words, string pref) {
        int count = 0;
        foreach (string word in words) {
            if (word.StartsWith(pref)) {
                count++;
            }
        }
        return count;
    }
}