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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode head = new ListNode(0);
        ListNode node = null;
        int carry = 0;
        
        while (l1 != null || l2 != null || carry > 0)
        {
            // get values
            int val0 = l1 == null ? 0 : l1.val;
            int val1 = l2 == null ? 0 : l2.val;
            
            // add values
            int val = val0 + val1 + carry;
            carry = 0;

            // if val has carry, truncate first decimal
            if (val >= 10)
            {
                val %= 10; // get last digit
                carry = 1;
            }
            
            // create new node and add value
            if (node == null)
            {
                node = new ListNode(val);
                head.next = node;
            }
            else
            {
                node.next = new ListNode(val);
                node = node.next;
            }
            
            // increment to the next node
            if (l1 != null)
                l1 = l1.next;
            if (l2 != null)
                l2 = l2.next;
        }
        
        return head.next;
    }
}
