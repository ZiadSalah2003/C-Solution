// Problem-Link : https://leetcode.com/problems/neither-minimum-nor-maximum/description/
// Problem-ID : 2733
// Problem Name: Neither Minimum nor Maximum
// Verdict: AC
public class Solution {
    public int FindNonMinOrMax(int[] nums) {
        int mn = int.MaxValue, mx = int.MinValue;
        foreach (int num in nums) {
            mn = Math.Min(mn, num);
            mx = Math.Max(mx, num);
        }
        foreach (int num in nums) {
            if (num != mn && num != mx) {
                return num;
            }
        }
        return -1;
    }
}