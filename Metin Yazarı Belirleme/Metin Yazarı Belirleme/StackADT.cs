using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metin_Yazarı_Belirleme
{
   public abstract class StackADT
    {
        public LinkedList list = new LinkedList();
        public int Size=0;
        public Node Top {get; protected set; }
        public abstract void Push(object value);
        public abstract void Pop();
        public abstract Node Peek();
        public abstract bool IsEmpty();
        public abstract List<Node> showStack();
    }
}
