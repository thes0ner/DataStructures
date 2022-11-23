using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;
using System.Collections.Generic;
namespace LinkedLists
{
    internal class Program
    {
        static void Main(string[] args)
        {

            SingleLinkedList singleList = new SingleLinkedList();

            //Adding - Front
            singleList.AddFront(1);

            //Adding - Rear
            singleList.AddRear(30);
            singleList.AddRear(10);
            singleList.AddRear(20);
            singleList.AnyPosition(40, 2);
            singleList.DisplayList();

            //Poping - Front
            singleList.PopFront();
            singleList.DisplayList();

            //Poping - Rear
            singleList.PopBack();
            singleList.PopBack();
            singleList.DisplayList();

            //Poping - All
            singleList.PopAll();
            singleList.DisplayList();

            DoublyLinkedList doublyList= new DoublyLinkedList();


        }

    }
}