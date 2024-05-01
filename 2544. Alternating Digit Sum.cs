// Problem-Link : https://leetcode.com/problems/alternating-digit-sum/description/
// Problem-ID : 2544
// Problem Name: Alternating Digit Sum
// Verdict: AC
public class Solution {
    public int AlternateDigitSum(int n) {
        string s = n.ToString();
        int sum = 0;

        for (int i = 0; i < s.Length; i++) {
            int d = s[i] - '0'; 
            if (i % 2 == 0) {
                sum += d;
            } else {
                sum -= d;
            }
        }
        return sum;
    }
}