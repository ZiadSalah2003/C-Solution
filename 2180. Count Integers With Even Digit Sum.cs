// Problem-Link : https://leetcode.com/problems/count-integers-with-even-digit-sum/description/
// Problem-ID : 2180
// Problem Name: Count Integers With Even Digit Sum
// Verdict: AC
public class Solution {
    public int CountEven(int num) {
        int count = 0;
        for (int i = 1; i <= num; i++) {
            int sum = 0, n = i;
            while (n > 0) {
                sum += n % 10;
                n /= 10;
            }
            if (sum % 2 == 0) {
                count++;
            }
        }
        return count;
    }
}