using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metin_Yazarı_Belirleme
{
    public abstract class HeapADT
    {
        public heapNode[] heapArray;
        public int currentSize;
        public int maxSize;
        public abstract bool insert(heapNode node);
        public abstract heapNode removeMax();
        public abstract bool remove(heapNode node);
        public abstract bool isEmpty();
        public abstract void MoveToUp(int index);
        public abstract void MoveToDown(int index);
        public abstract heapNode[] heapNodes();
        public abstract string DisplayHeap();
        public abstract heapNode showHeap(object data);

    }
    public class heapNode
    {
        public object data;
        public int repetitionNumber;
        public heapNode(object data,int repetitionNumber)
        {
            this.data = data; 
            this.repetitionNumber = repetitionNumber;
        }
    }
}
