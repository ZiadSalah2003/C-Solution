// Problem-Link : https://leetcode.com/problems/strong-password-checker-ii/
// Problem-ID : 2299
// Problem Name: Strong Password Checker II
// Verdict: AC
public class Solution {
    public bool StrongPasswordCheckerII(string password) {
        if (password.Length < 8) return false;
        bool lo = false, up = false, di = false, sp = false, ad = false;
        char pre = '\0';
        foreach (char c in password) {
            if (char.IsLower(c)) lo = true;
            else if (char.IsUpper(c)) up = true;
            else if (char.IsDigit(c)) di = true;
            else if ("!@#$%^&*()-+".Contains(c)) sp = true;
            if (c == pre) ad = true;
            pre = c;
        }
        return lo && up && di && sp && !ad;
    }
}