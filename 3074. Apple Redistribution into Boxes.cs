// Problem-Link : https://leetcode.com/problems/apple-redistribution-into-boxes/description/
// Problem-ID : 3074
// Problem Name: Apple Redistribution into Boxes
// Verdict: AC
public class Solution {
    public int MinimumBoxes(int[] apple, int[] capacity) {
        Array.Sort(capacity);
        Array.Reverse(capacity);
        int sum = 0,sum2 = 0;
        for(int i=0;i<apple.Length;i++)
            sum+=apple[i];
         for(int i=0;i<capacity.Length;i++){
            sum2+=capacity[i];
            if(sum2>=sum)
            return i+1;
         }
        return -1;
    }
}