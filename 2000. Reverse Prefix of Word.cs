// Problem-Link : https://leetcode.com/problems/reverse-prefix-of-word/
// Problem-ID : 2000
// Problem Name: Reverse Prefix of Word
// Verdict: AC
public class Solution {
    public string ReversePrefix(string word, char ch) {
        int index = word.IndexOf(ch);
        if (index == -1) {
            return word;
        }
        char[] wordArray = word.ToCharArray();
        Array.Reverse(wordArray, 0, index + 1);
        return new string(wordArray);
    }
}