// Problem-Link : https://leetcode.com/problems/top-k-frequent-elements/
// Problem-ID : 347
// Problem Name: Top K Frequent Elements
// Verdict: AC
public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
Dictionary<int, int> mp = new Dictionary<int, int>();
List<int> list = new List<int>();

for (int i = 0; i < nums.Length; i++)
{
    if (!mp.ContainsKey(nums[i]))
        mp[nums[i]] = 0;
    mp[nums[i]]++;
}

var sortedDict = mp.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

for (int i = 0; i < k; i++)
{
    list.Add(sortedDict.ElementAt(i).Key);
}

return list.ToArray();
    }
}