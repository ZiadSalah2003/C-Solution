// Problem-Link : https://leetcode.com/problems/find-closest-number-to-zero/
// Problem-ID : 2339
// Problem Name: Find Closest Number to Zero
// Verdict: AC
public class Solution {
    public int FindClosestNumber(int[] nums) {
        int closest = nums[0];
        for (int i = 1; i < nums.Length; i++) {
            if (Math.Abs(nums[i]) < Math.Abs(closest) || (Math.Abs(nums[i]) == Math.Abs(closest) && nums[i] > closest)) {
                closest = nums[i];
            }
        }
        return closest;
    }
}