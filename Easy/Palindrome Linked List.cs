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
    public bool IsPalindrome(ListNode head) {
        List<int> myList = new List<int>();
        
        while (head != null) // get all values
        {
            myList.Add(head.val);
            head = head.next;
        }
        
        int m = myList.Count/2;
        int n0 = 0;
        int n1 = myList.Count - 1;
        while (n0 < m)
        {
            if (myList[n0] != myList[n1])
                return false;
            n0++;
            n1--;
        }
        
        return true;
    }
}
