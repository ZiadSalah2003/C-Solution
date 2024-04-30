// Problem-Link : https://leetcode.com/problems/unique-morse-code-words/
// Problem-ID : 804
// Problem Name: Unique Morse Code Words
// Verdict: AC
public class Solution {
    public int UniqueMorseRepresentations(string[] words) {
        string[] morse = new string[] {".-","-...","-.-.","-..",".","..-.","--.","....","..",".---","-.-",
                                       ".-..","--","-.","---",".--.","--.-",".-.","...","-","..-","...-",
                                       ".--","-..-","-.--","--.."};
        HashSet<string> set = new HashSet<string>();
        foreach (string word in words) {
            string morseCode = "";
            foreach (char c in word) {
                morseCode += morse[c - 'a'];
            }
            set.Add(morseCode);
        }
        return set.Count;
    }
}