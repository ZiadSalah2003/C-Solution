// Problem-Link : https://leetcode.com/problems/minimum-number-of-moves-to-seat-everyone/
// Problem-ID : 2037 
// Problem Name: Minimum Number of Moves to Seat Everyone
// Verdict: AC
public class Solution {
    public int MinMovesToSeat(int[] seats, int[] students) {
        Array.Sort(seats);
        Array.Sort(students);
        int moves = 0;
        for (int i = 0; i < seats.Length; i++)
        {
            moves += Math.Abs(seats[i] - students[i]);
        }
        return moves;
    }
}