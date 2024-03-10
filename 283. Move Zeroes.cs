// Problem-Link : https://leetcode.com/problems/move-zeroes/
// Problem-ID : 283
// Problem Name: Move Zeroes
// Verdict: AC
public class Solution {
    public void MoveZeroes(int[] nums) {
        List<int>l=new List<int>();
        int c=0;
        for(int i=0;i<nums.Length;i++)
        {
            if(nums[i]==0)
            {
                c++;
            }
            if(nums[i]!=0)
            {
                l.Add(nums[i]);
            }
        }
        while(c>0){
            l.Add(0);
            c--;
        }
        for(int i=0;i<nums.Length;i++)
        {
            nums[i]=l[i];
        }
    }
}