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
public class Solution
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode dummy = new ListNode(0);
        ListNode curr = dummy;
        int carry = 0;
        int sum = 0;
        while (l1 != null || l2 != null || carry != 0)
        {
            sum = 0;
            if (l1 != null)
            {
                sum = sum + l1.val;
                l1 = l1.next;
            }
            if (l2 != null)
            {
                sum = sum + l2.val;
                l2 = l2.next;
            }

            curr.next = new ListNode((sum + carry) % 10);
            if (sum + carry > 9)
            {
                carry = 1;
            }
            else
            {
                carry = 0;
            }
            curr = curr.next;
        }
        return dummy.next;
    }
}