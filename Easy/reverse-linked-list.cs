// 1st
public class Solution {
    public ListNode ReverseList(ListNode head) {
        ListNode rev = null;
        while (head != null)
        {
            ListNode n = new ListNode(head.val);
            n.next = rev;
            rev = n;
            head = head.next; // next
        }
        return rev;
    }
}

// 2nd
public class Solution {
    public ListNode ReverseList(ListNode head) {
        if (head != null)
        {
            ListNode prev = null;
            while (head.next != null)
            {
                ListNode NextLN = head.next;
                head.next = prev;
                prev = head;
                head = NextLN;
            }
            if (prev != null)
                head.next = prev;
        }
        return head;
    }
}
