// Problem-Link : https://leetcode.com/problems/generate-parentheses/
// Problem-ID : 237
// Problem Name: Delete Node in a Linked List
// Verdict: AC
struct ListNode {
    public int val;
    public ListNode next;
    public ListNode(int x) { val = x; }
}
public class Solution {
    public void DeleteNode(ListNode node) {
        node.val = node.next.val;
        node.next = node.next.next;
    }
}