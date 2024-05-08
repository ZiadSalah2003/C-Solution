// Problem-Link : https://leetcode.com/problems/relative-ranks/
// Problem-ID : 506
// Problem Name: Relative Ranks
// Verdict: AC
public class Solution {
    public string[] FindRelativeRanks(int[] score) {
        Dictionary<int, int> di = new Dictionary<int, int>();
        for (int i = 0; i < score.Length; i++)
        {
            di.Add(score[i], i);
        }
        Array.Sort(score);
        string[] r = new string[score.Length];
        for (int i = 0; i < score.Length; i++)
        {
            if (i == score.Length - 1)
            {
                r[di[score[i]]] = "Gold Medal";
            }
            else if (i == score.Length - 2)
            {
                r[di[score[i]]] = "Silver Medal";
            }
            else if (i == score.Length - 3)
            {
                r[di[score[i]]] = "Bronze Medal";
            }
            else
            {
                r[di[score[i]]] = (score.Length - i).ToString();
            }
        }
        return r;
    }
}