// Problem-Link : https://leetcode.com/problems/two-sum/
// Problem-ID : 1
// Problem Name: Two Sum
// Verdict: AC
 public class Solution
 {
     public int[] TwoSum(int[] nums, int target)
     {
         int[] result = new int[2];
         for (int i = 0; i < nums.Length; i++)
         {
             for (int j = i + 1; j < nums.Length; j++)
             {
                 if (nums[i] + nums[j] == target)
                 {
                     result[0] = i; result[1] = j;
                     return result;
                 }
             }
         }
         return result;
     }
 }