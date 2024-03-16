// Problem-Link : https://leetcode.com/problems/contiguous-array/
// Problem-ID : 525
// Problem Name: Contiguous Array
// Verdict: AC
public class Solution {
    public int FindMaxLength(int[] nums) {
        var sumIndex = new Dictionary<int, int> {{0, -1}};
        int prefixSum = 0, maxLength = 0;
        for (int i = 0; i < nums.Length; i++) {
            prefixSum += nums[i] == 0 ? -1 : 1;
            if (sumIndex.ContainsKey(prefixSum)) {
                maxLength = Math.Max(maxLength, i - sumIndex[prefixSum]);
            } else {
                sumIndex[prefixSum] = i;
            }
        }
        return maxLength;
    }
}