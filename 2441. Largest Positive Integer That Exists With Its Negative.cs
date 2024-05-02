// Problem-Link : https://leetcode.com/problems/largest-positive-integer-that-exists-with-its-negative/
// Problem-ID : 2441
// Problem Name: Largest Positive Integer That Exists With Its Negative
// Verdict: AC
public class Solution {
    public int FindMaxK(int[] nums) {
        Dictionary<int, int> d = new Dictionary<int, int>();
        foreach (int n in nums) {
            if (n < 0) {
                d[-n] = 1;
            }
        }
        int mx = -1;
        foreach (int n in nums) {
            if (n > 0 && d.ContainsKey(n)) {
               mx = Math.Max(mx, n);
            }
        }
        return mx;
    }
}