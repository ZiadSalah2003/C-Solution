// Problem-Link : https://leetcode.com/problems/break-a-palindrome/description/
// Problem-ID : 1328
// Problem Name: Break a Palindrome
// Verdict: AC
public class Solution {
   public string BreakPalindrome(string palindrome) {
    if (palindrome.Length == 1) return "";
    
    char[] arr = palindrome.ToCharArray();
    for (int i = 0; i < arr.Length / 2; i++) {
        if (arr[i] != 'a') {
            arr[i] = 'a';
            return new string(arr);
        }
    }
    
    arr[arr.Length - 1] = 'b';
    return new string(arr);
    }
}