using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    public class Linked_List_Cycle
    {
        //https://leetcode.com/problems/linked-list-cycle/description/
        public bool HasCycle(ListNode head)
        {
            if (head == null || head.next == null) return false;

            ListNode slow = head;
            ListNode fast = head;

            while (fast != null && fast.next != null)
            {
                slow = slow.next;     
                fast = fast.next.next;     

                if (slow == fast)
                {         
                    return true;
                }
            }

            return false;

        }

        //public bool HasCycle(ListNode head)
        //{
        //    HashSet<ListNode> check = new HashSet<ListNode>();
        //    while (head != null && head.next!=null )
        //    {
        //        if (check.Contains(head)) 
        //        {
        //            return true;
        //        }
        //        check.Add(head);
        //        head = head.next;

        //    }
        //    return false;
        //}    

        public class ListNode
        {
             public int val;
             public ListNode next;
             public ListNode(int x) 
             {
                 val = x;
                 next = null;
             }
        }
 
    }
}
