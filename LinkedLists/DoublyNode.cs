using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    internal class DllNode
    {
        public int data;
        public DllNode prev;
        public DllNode next;

        public DllNode()
        {
            data = 0;
            prev = null;
            next = null;
        }


    }
}
