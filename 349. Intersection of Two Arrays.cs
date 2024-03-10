// Problem-Link : https://leetcode.com/problems/intersection-of-two-arrays/
// Problem-ID : 349
// Problem Name: Intersection of Two Arrays
// Verdict: AC
public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        Dictionary<int, int> di = new Dictionary<int, int>();
        List<int> r = new List<int>();
        for (int i = 0; i < nums1.Length; i++)
        {
            if (!di.ContainsKey(nums1[i]))
            {
                di.Add(nums1[i], 1);
            }
        }
        for (int i = 0; i < nums2.Length; i++)
        {
            if (di.ContainsKey(nums2[i]))
            {
                r.Add(nums2[i]);
                di.Remove(nums2[i]);
            }
        }
        return r.ToArray();
    }
}