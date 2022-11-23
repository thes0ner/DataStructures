using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    internal class DoublyLinkedList
    {
        DllNode head;
        public DoublyLinkedList()
        {
            head = null;
        }
        


















      public void DisplayList()
        {
            DoublyNode temp;
            temp = head;

            if(temp != null)
            {
                while (temp != null)
                {
                    Console.WriteLine(temp.data + " ");
                    temp = temp.next;
                }
            }
            else
            {
                Console.WriteLine("The list is empty.");
            }
           

        }          
    }
}
