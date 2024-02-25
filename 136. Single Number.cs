// Problem-Link : https://leetcode.com/problems/single-number/
// Problem-ID : 136
// Problem Name: Single Number
// Verdict: AC
class Solution {
public:
    int singleNumber(vector<int>& nums) {
           int sum = nums[0];
        for (int i = 1; i < nums.size(); i++)
        {

            sum ^= nums[i];
        }
        return sum;
    }
};