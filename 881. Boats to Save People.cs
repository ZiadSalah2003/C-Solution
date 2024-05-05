// Problem-Link : https://leetcode.com/problems/boats-to-save-people/
// Problem-ID : 881
// Problem Name: Boats to Save People
// Verdict: AC
public class Solution {
    public int NumRescueBoats(int[] people, int limit) {
        Array.Sort(people);
        int i = 0, j = people.Length - 1;
        int boats = 0;
        while (i <= j) {
            if (people[i] + people[j] <= limit) {
                i++;
            }
            j--;
            boats++;
        }
        return boats;
    }
}