// Problem-Link : https://leetcode.com/problems/maximum-average-subarray-i/description/?envType=study-plan-v2&envId=leetcode-75
// Problem-ID : 643 
// Problem Name: Maximum Average Subarray I
// Verdict: AC
public class Solution {
    public double FindMaxAverage(int[] nums, int k) {
        int l=0,r=0;
        double sum=0,mx=-1000000;
        while(r<nums.Length){
            sum+=nums[r];
            if(r-l+1==k){
                mx=Math.Max(mx,(sum/k));
                sum-=nums[l++];
            }
            r++;
        }
        return mx;
    }
}