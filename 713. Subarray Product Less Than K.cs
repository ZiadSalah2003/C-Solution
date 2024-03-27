// Problem-Link : https://leetcode.com/problems/subarray-product-less-than-k/
// Problem-ID : 713
// Problem Name: Subarray Product Less Than K
// Verdict: AC
public class Solution {
    public int NumSubarrayProductLessThanK(int[] nums, int k) {
        if (k <= 1) return 0;
        int cnt = 1, sum = 0, l = 0;
        for (int i = 0; i < nums.size(); i++) {
            cnt *= nums[i];
            while (cnt >= k) {
                cnt /= nums[l];
                l++;
            }
            sum += i - l + 1;
        }
        return sum;
    }
}
