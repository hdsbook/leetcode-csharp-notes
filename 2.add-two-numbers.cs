/*
 * @lc app=leetcode id=2 lang=csharp
 *
 * [2] Add Two Numbers
 */

// @lc code=start
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
        ListNode l3 = new ListNode();
        ListNode pointer = l3;

        int carry = 0,
            sum = 0,
            val1 = 0,
            val2 = 0;

        while (l1 != null || l2 != null || carry == 1)
        {
            val1 = val2 = 0;
            if (l1 != null)
            {
                val1 = l1.val;
                l1 = l1.next;
            }
            if (l2 != null)
            {
                val2 = l2.val;
                l2 = l2.next;
            }

            sum = val1 + val2 + carry;
            carry = sum / 10;

            pointer.next = new ListNode(sum % 10);
            pointer = pointer.next;
        }

        return l3.next;
    }
}
// @lc code=end

