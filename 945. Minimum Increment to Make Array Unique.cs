// Problem-Link : https://leetcode.com/problems/minimum-increment-to-make-array-unique/
// Problem-ID : 945
// Problem Name: Minimum Increment to Make Array Unique
// Verdict: AC
public class Solution {
    public int MinIncrementForUnique(int[] nums) {
        Array.Sort(nums);
        int moves = 0;
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] <= nums[i - 1])
            {
                moves += nums[i - 1] - nums[i] + 1;
                nums[i] = nums[i - 1] + 1;
            }
        }
        return moves;
    }
}