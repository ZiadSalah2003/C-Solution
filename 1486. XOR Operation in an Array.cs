// Problem-Link : https://leetcode.com/problems/xor-operation-in-an-array/description/
// Problem-ID : 1486
// Problem Name: XOR Operation in an Array
// Verdict: AC
public class Solution {
    public int XorOperation(int n, int start) {
        int result=start;
        for (int i = 1; i <n; i++) {
            result ^= (start + 2 * i);
        }
        return result;
    }
}