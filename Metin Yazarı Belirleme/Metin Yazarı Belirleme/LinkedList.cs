using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metin_Yazarı_Belirleme
{
    public class LinkedList : LinkedListADT
    {
        public override void DeleteFirst()
        {
            if (IsEmpty())
                Message("List is already null");
            else
            {
                Head = Head.Next;
                Size--;
            }
        }
        public override void DeleteLast()
        {
            if (IsEmpty())
                Message("List is already null");
            else
            {
                Node temp = Head;
                while (temp.Next.Next != null)
                    temp = temp.Next;
                temp.Next = null;
                Size--;
            }
        }
        public override void DeletePosition(int position)
        {
            if (position > Size || position <= 0)
                Message("Position no exist or very long.");
            else if (position == 1)
                DeleteFirst();
            else if (position == Size)
                DeleteLast();
            else
            {
                int count = 1;
                Node temp = Head;
                while (count < position-1)
                {
                    temp = temp.Next;
                    count++;
                }
                temp.Next=temp.Next.Next;
                Size--;
            }
        }
        public override string DisplayElements()
        {
            if (!IsEmpty())
            {
                string temp = "";
                Node node = Head;
                while(node!= null)
                {
                    temp += node.Data.ToString() + " ";
                    node = node.Next;
                }
                return temp;
            }
            return "";
        }
        public override Node GelElement(int position)
        {
                 Node temp = Head;
                int count = 1;
                while (count<position)
                {
                    temp = temp.Next;
                    count++;
                }
                return temp;
        }
        public override void InsertFirst(object value)
        {
            if(IsEmpty())
            {
                Node temp = new Node
                {
                    Data = value
                };
                Head = temp;
            }
            else
            {
                Node temp = new Node
                {
                    Data = value
                };

                temp.Next = Head;
                Head = temp;
            }
            Size++;
        }
        public override void InsertLast(object value)
        {
            if (IsEmpty())
                InsertFirst(value);
            else
            {
                Node temp = Head;
                while (temp.Next != null)
                    temp = temp.Next;
                temp.Next = new Node
                {
                    Data = value
                };
                temp = temp.Next;
                Size++;
            }
        }
        public override void InsertPosition(object value, int position)
        {
            if (position > Size + 1)
                ;
            else if (position == Size + 1)
                InsertLast(value);
            else if (position == 1)
                InsertFirst(value);
            else
            {
                int count = 1;
                Node temp = Head;
                while (count < position-1)
                {
                    temp = temp.Next;
                    count++;
                }
                Node node = new Node
                {
                    Data = value,
                    Next = temp.Next
                };
                temp.Next= node;
                Size++;
            }
        }
        public override bool IsEmpty()
        {
            if (Head == null)
                return true;
            else return false;
        }
        public override string Message(string message)
        {
            return message;
        }
    }
}
