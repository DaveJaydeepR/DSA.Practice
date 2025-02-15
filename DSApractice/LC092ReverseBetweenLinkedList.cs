﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DSA.Practice.LC206ReverseLinkList;

namespace DSA.Practice
{
    internal class LC092ReverseBetweenLinkedList
    {
        public ListNode ReverseBetween(ListNode head, int left, int right)
        {
            if (head.next == null || left == right) return head;

            ListNode dummy = new ListNode(0);
            dummy.next = head;
            ListNode prev = dummy;

            for (int i = 0; i < left - 1; ++i)
            {
                prev = prev.next;
            }

            ListNode current = prev.next;

            for (int i = 0; i < right - left; ++i)
            {
                ListNode nextNode = current.next;
                current.next = nextNode.next;
                nextNode.next = prev.next;
                prev.next = nextNode;
            }

            return dummy.next;
        }
    }
}
