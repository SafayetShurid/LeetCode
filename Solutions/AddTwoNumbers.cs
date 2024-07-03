using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    
   public class ListNode {
       public int val;
       public ListNode next;
       public ListNode(int val=0, ListNode next=null) {
           this.val = val;
          this.next = next;
       }
   }
  
    public class AddTwoNumbersClass
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            int carry = 0;

            ListNode dummyNode = new ListNode(); 
            ListNode currentNode = dummyNode; //pointer

            while (l1.next != null || l2.next != null || carry!=0)
            {
                int sum = 0;                

                if (l1 != null)
                {
                    sum += l1.val;
                    l1 = l1.next;
                }

                if (l2 != null)
                {
                    sum += l2.val;
                    l2 = l2.next;
                }

                sum = l1.val + l2.val + carry;
                carry = sum / 10;
                ListNode listNode = new ListNode();
                listNode.val = sum % 10;
                currentNode.next = listNode;

                currentNode = listNode;

            }

            return dummyNode.next;
        }
    }
}
