// Problem-Link : https://leetcode.com/problems/xor-operation-in-an-array/description/
// Problem-ID : 1486
// Problem Name: XOR Operation in an Array
// Verdict: AC
public class Solution {
    public bool ArrayStringsAreEqual(string[] word1, string[] word2) {
        string str1 = string.Join("", word1);
        string str2 = string.Join("", word2);
        return str1 == str2;
    }
}