// 1st
public class Solution {
    public ListNode DetectCycle(ListNode head) {
        var nodeList = new List<ListNode>();
        while (head != null)
        {
            if (nodeList.Contains(head) == true)
            {
                break;
            }
            else
                nodeList.Add(head);
            head = head.next; // go to next
        }
        return head;
    }
}

// 2nd
public class Solution {
    public ListNode DetectCycle(ListNode head) {
        var nodeHS = new HashSet<ListNode>();
        while (head != null)
        {
            if (nodeHS.Contains(head) == true)
                break;
            else
                nodeHS.Add(head);
            head = head.next; // go to next
        }
        return head;
    }
}
