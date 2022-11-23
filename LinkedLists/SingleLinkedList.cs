using System;

namespace LinkedLists
{
    internal class SingleLinkedList
    {
        private Node head;

        public SingleLinkedList()
        {
            head = null;
        }


        public void AddFront(int newData)
        {
            Node newNode = new Node();
            newNode.data = newData;
            newNode.next = head;
            head = newNode;
        }


        //Adding Operations

        public void AddRear(int newData)
        {
            Node newNode = new Node();
            newNode.data = newData;
            newNode.next = null;

            //Check head is empty make newNode as head
            if (head == null)
                head = newNode;
            else
            {
                //Traverse to the last Node
                //Temp gets a temprory heads reference.
                Node temp = head;
                while (temp.next != null) // before the last node
                {
                    temp = temp.next; //last Node
                }
                //change the next of last node to the new Node
                temp.next = newNode;


            }

        }

        public void AnyPosition(int newData, int position)
        {
            Node newNode = new Node();
            newNode.data = newData;
            newNode.next = null;
            Node temp = head;

            if (position < 1)
            {
                Console.WriteLine("Position must be >= 1");
            }
            else if (position == 1)
            {
                newNode.next = head;
                head = newNode;
            }
            else
            {

                for (int i = 1; i < position - 1; i++)
                {

                    if (temp != null)
                    {
                        temp = temp.next;
                    }
                }
            }


            if (temp != null)
            {
                newNode.next = temp.next;
                temp.next = newNode;
            }
            else
            {
                Console.WriteLine("Previous Node is null");
            }

        }

        //Delete Operations

        public void PopFront()
        {
            Node temp = head;
            head = head.next;
            temp = null;
        }

        public void PopBack()
        {
            if(head != null)
            {

                if (head.next == null)
                    head = null;
                else
                {
                    Node temp = head;
                    while(temp.next.next != null)
                    {
                        temp = temp.next;
                    }

                    temp.next = null;

                }
            }
        }

        public void PopAll()
        {
            Node temp;

            while(head != null)
            {
                temp = head;
                head = head.next;
                temp = null;
            }
            Console.WriteLine("All nodes are deleted sucessfully.");
        }


        public void DisplayList()
        {
            Node temp = new Node();
            temp = this.head;

            if (temp != null)
            {
                Console.WriteLine("The list contains: ");

                while (temp != null)
                {
                    Console.Write(temp.data + " ");
                    temp = temp.next;

                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine($"The list is empty");
            }

            
        }
    }
}