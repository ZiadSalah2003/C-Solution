// Problem-Link : https://leetcode.com/problems/find-the-pivot-integer/
// Problem-ID : 2485
// Problem Name: Find the Pivot Integer
// Verdict: AC
public class Solution {
    public int PivotInteger(int n) {
        int cnt = n * (n + 1) / 2;
        int sum = 0;
        for (int i = 1; i <= n; i++) {
            cnt -= i;
            if (sum == cnt) {
                return i;
            }
            sum += i;
        }
        return -1;
    }
}