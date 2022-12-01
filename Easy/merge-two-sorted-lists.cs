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
    public ListNode glist1 = null;
    public ListNode glist2 = null;
    public ListNode retList = null;
    public void LowestValueAdd()
    {
        if (glist1 != null || glist2 != null)
        {
            int a = (glist1 != null) ? glist1.val : 99;
            int b = (glist2 != null) ? glist2.val : 99;
            if (b <= a)
            {
                retList.val = b; // add
                glist2 = glist2.next; // next
            }
            else if (a <= b)
            {
                retList.val = a; // add
                glist1 = glist1.next; // next
            }
            if (glist1 != null || glist2 != null) // redo
            {
                retList.next = new ListNode(); // next
                retList = retList.next;
                LowestValueAdd();
            }
        }
    }
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        ListNode Head = retList;
        if (list1 != null || list2 != null)
        {
            glist1 = list1;
            glist2 = list2;
            retList = new ListNode();
            Head = retList;
            LowestValueAdd();
        }
        return Head;
    }
}
