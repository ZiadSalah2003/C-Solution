// Problem-Link : https://leetcode.com/problems/reverse-integer/description/
// Problem-ID : 7
// Problem Name: Reverse Integer
// Verdict: AC
public class Solution {
    public int Reverse(int x) {
        long res = 0;
        while (x != 0) {
            res = res * 10 + x % 10;
            if (res > int.MaxValue || res < int.MinValue) {
                return 0;
            }
            x /= 10;
        }
        return (int)res;
    }
}