// Problem-Link : https://leetcode.com/problems/minimum-array-length-after-pair-removals/description/
// Problem-ID : 2856
// Problem Name: Minimum Array Length After Pair Removals
// Verdict: AC
public class Solution {
    public int MinLengthAfterRemovals(IList<int> nums) {
        int i=0,j=(nums.Count+1)/2,sum=0;
        while (j<nums.Count){
            if(nums[i]<nums[j]){
                sum++;
                i++;
            }
            j++;
    }
    return nums.Count-2*sum;
    }
}