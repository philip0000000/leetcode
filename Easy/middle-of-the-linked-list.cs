/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode MiddleNode(ListNode head) {
        int c = 0;
        ListNode NodeRet = head;
        while (head != null)
        {
            c++;
            head = head.next;
        }
        c /= 2;
        while (c > 0)
        {
            c--;
            NodeRet = NodeRet.next;
        }
        return NodeRet;
    }
}
