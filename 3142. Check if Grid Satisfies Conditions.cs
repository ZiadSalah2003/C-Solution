// Problem-Link : https://binarysearch.com/problems/check-if-grid-satisfies-conditions
// Problem-ID : 3142
// Problem Name: Check if Grid Satisfies Conditions
// Verdict: AC
public class Solution {
    public bool SatisfiesConditions(int[][] grid) {
        int m = grid.size();
        int n = grid[0].size();
        for(int i = 0; i < m; i++){
            for(int j = 0; j < n; j++){
                if(i < m - 1 && grid[i][j] != grid[i + 1][j]){
                    return false;
                }
                if(j < n - 1 && grid[i][j] == grid[i][j + 1]){
                    return false;
                }
            }
        }
        return true;
    }
}