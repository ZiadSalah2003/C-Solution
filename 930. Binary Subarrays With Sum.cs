// Problem-Link : https://leetcode.com/problems/binary-subarrays-with-sum/
// Problem-ID : 930
// Problem Name: Binary Subarrays With Sum
// Verdict: AC
public class Solution {
    public int NumSubarraysWithSum(int[] nums, int goal) {
        var sumCount = new Dictionary<int, int> {{0, 1}};
        int prefixSum = 0, result = 0;
        foreach (var num in nums) {
            prefixSum += num;
            if (sumCount.ContainsKey(prefixSum - goal)) {
                result += sumCount[prefixSum - goal];
            }
            if (sumCount.ContainsKey(prefixSum)) {
                sumCount[prefixSum]++;
            } else {
                sumCount[prefixSum] = 1;
            }
        }
        return result;
    }
}