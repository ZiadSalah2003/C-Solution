// Problem-Link : https://leetcode.com/problems/final-value-of-variable-after-performing-operations/
// Problem-ID : 2011
// Problem Name: Final Value of Variable After Performing Operations
// Verdict: AC
public class Solution {
    public int FinalValueAfterOperations(string[] operations) {
        int X = 0;
        foreach (string o in operations) {
            if (o.Contains("++")) {
                X++;
            } else if (o.Contains("--")) {
                X--;
            }
        }
        return X;
    }
}