// Problem-Link : https://leetcode.com/problems/score-of-a-string/description/
// Problem-ID : 3110
// Problem Name: Score of a String
// Verdict: AC
public class Solution {
    public int ScoreOfString(string s) {
        int sum=0;
        for(int i=0;i<s.Length-1;i++){
            sum+=Math.Abs(s[i]-s[i+1]);
        }
        return sum;
    }
}