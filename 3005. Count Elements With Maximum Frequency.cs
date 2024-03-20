// Problem-Link : https://leetcode.com/problems/count-elements-with-maximum-frequency/description/
// Problem-ID : 3005
// Problem Name: Count Elements With Maximum Frequency
// Verdict: AC
public class Solution {
    public int CountMaxFrequency(int[] nums) {
        Dictionary<int, int> freq = new Dictionary<int, int>();
        foreach (int num in nums) {
            if (freq.ContainsKey(num)) {
                freq[num]++;
            } else {
                freq[num] = 1;
            }
        }
        int maxFreq = 0;
        foreach (int f in freq.Values) {
            maxFreq = Math.Max(maxFreq, f);
        }
        int count = 0;
        foreach (int f in freq.Values) {
            if (f == maxFreq) {
                count++;
            }
        }
        return count * maxFreq;
    }
}