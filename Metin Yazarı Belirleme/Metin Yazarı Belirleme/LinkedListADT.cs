using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metin_Yazarı_Belirleme
{
   public abstract class LinkedListADT
    {
        public Node Head;
        public int Size=0;
        public abstract void InsertFirst(object value);
        public abstract void DeleteFirst();
        public abstract void InsertLast(object value);
        public abstract void DeleteLast();
        public abstract void InsertPosition(object value, int position);
        public abstract void DeletePosition(int position);
        public abstract Node GelElement(int position);
        public abstract string DisplayElements();
        public abstract bool IsEmpty();
        public abstract string Message(string message);
    }


   public class Node
    {
       public object Data;
       public Node Next;
    }

}
