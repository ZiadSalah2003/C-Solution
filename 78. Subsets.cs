// Problem-Link : https://leetcode.com/problems/subsets/description/
// Problem-ID : 78
// Problem Name: Subsets
// Verdict: AC
public class Solution {
    public IList<IList<int>> Subsets(int[] nums) {
        IList<IList<int>> res = new List<IList<int>>();
        res.Add(new List<int>());
        foreach (int num in nums) {
            int count = res.Count;
            for (int i = 0; i < count; i++) {
                IList<int> subset = new List<int>(res[i]);
                subset.Add(num);
                res.Add(subset);
            }
        }
        return res;
    }
}