using System;
using System.Runtime.Intrinsics;
using System.Security.Cryptography.X509Certificates;


//Prerequisites
public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

public class Learning
{
    public delegate void Print(ListNode x); //Change for different display types as need

    public static void Main(string[] args)
    {
        //Setup
        Print show = Display;

        ListNode l1 = new ListNode(9);
        l1.next = new ListNode(9);
        l1.next.next = new ListNode(9);
        l1.next.next.next = new ListNode(9);
        l1.next.next.next.next = new ListNode(9);
        l1.next.next.next.next.next = new ListNode(9);
        l1.next.next.next.next.next.next = new ListNode(9);

        ListNode l2 = new ListNode(9);
        l2.next = new ListNode(9);
        l2.next.next = new ListNode(9);
        l2.next.next.next = new ListNode(9);

        //Result
        ListNode result = AddTwoNumbers(l1, l2);

        show(result);


        //Solution
        ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode temp = new ListNode();
            ListNode p = temp;
            int carry = 0;

            while (l1 != null || l2 != null)
            {
                int v1 = (l1 == null) ? 0 : l1.val;
                int v2 = (l2 == null) ? 0 : l2.val;

                int val = v1 + v2 + carry;
                carry = val / 10;
                val = val % 10;

                p.next = new ListNode(val);

                p = p.next;

                if (l1 != null)
                    l1 = l1.next;
                if (l2 != null)
                    l2 = l2.next;
            }

            if (carry != 0)
            {
                p.next = new ListNode(carry);
            }

            return temp.next;
        }
    }

    //Flexible display method
    public static void Display(ListNode x)
    {
        ListNode p = x;

        while (p != null)
        {
            Console.Write(p.val);

            p = p.next;
        }
    }
}