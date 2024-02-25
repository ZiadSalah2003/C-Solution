// Problem-Link : https://leetcode.com/problems/number-of-1-bits/description/
// Problem-ID : 191
// Problem Name: Number of 1 Bits
// Verdict: AC
public class Solution
{
    public int HammingWeight(uint n)
    {
        int sum = 0;
        while (n != 0)
        {
            sum += (int)(n & 1);
            n >>= 1;
        }
        return sum;
    }
}