using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metin_Yazarı_Belirleme
{
    public class Stack : StackADT
    {
        public Stack()
        {
            Top = list.Head;
            Size = list.Size;
        }
        public override bool IsEmpty()
        {
            return list.IsEmpty();
        }

        public override Node Peek()
        {
            Top = list.Head;
            return Top;
        }

        public override void Pop()
        {
            list.DeleteFirst();
            Size = this.list.Size;
        }

        public override void Push(object value)
        {
            list.InsertFirst(value);
            Size = list.Size;
        }
        public override List<Node> showStack()
        {
            List<Node> list = new List<Node>();
            int counter = 1;
           while(counter<=Size)
            {
                list.Add(this.list.GelElement(counter));
                counter++;
            }
            return list;
        } 
    }
}
