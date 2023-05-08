/**
 * Definition for singly-linked list.
 * function ListNode(val, next) {
 *     this.val = (val===undefined ? 0 : val)
 *     this.next = (next===undefined ? null : next)
 * }
 */
/**
 * @param {ListNode} head
 * @return {ListNode}
 */
var deleteDuplicates = function(head) {
    if (head != null) {
        var oldVal = head.val;
        var oldNode = head;
        var currentNode = head.next;
        while (currentNode != null) {
            if (oldVal != currentNode.val) {
                oldNode.next = currentNode;
                
                oldVal = currentNode.val;
                oldNode = currentNode;
            }
            currentNode = currentNode.next;
        }
        oldNode.next = null;
    }
    return head;
};
