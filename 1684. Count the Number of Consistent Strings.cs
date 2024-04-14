// Problem-Link : https://leetcode.com/problems/count-the-number-of-consistent-strings/
// Problem-ID : 1684
// Problem Name: Count the Number of Consistent Strings
// Verdict: AC
public class Solution {
    public int CountConsistentStrings(string allowed, string[] words) {
        int sum = 0;
        foreach (string word in words) {
            int x = 0;
            foreach (char c in word) {
                if (allowed.Contains(c)) {
                    x++;
                }
            }
            if(x == word.Length){
                sum++;
            }
        }
        return sum;
    }
}