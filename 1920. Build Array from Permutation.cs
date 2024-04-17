// Problem-Link : https://leetcode.com/problems/build-array-from-permutation/description/
// Problem-ID : 1920
// Problem Name: Build Array from Permutation
// Verdict: AC
public class Solution {
    public int[] BuildArray(int[] nums) {
        int[] ans=new int[nums.Length];
        for(int i=0;i<nums.Length;i++){
            ans[i]=nums[nums[i]];
        }
        return ans;
    }
}