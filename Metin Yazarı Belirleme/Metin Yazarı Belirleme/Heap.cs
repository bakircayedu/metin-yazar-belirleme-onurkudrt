using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metin_Yazarı_Belirleme
{
    public class Heap : HeapADT
    {
        public Heap(int maxSize)
        {
            heapArray = new heapNode[maxSize];
            this.maxSize = maxSize;
            this.currentSize = 0;
        }

        public override string DisplayHeap()
        {
            heapNode[] array = heapNodes();
            string temp = "";
            for (int i = 0; i < array.Length; i++)
                temp += "Kelime: "+array[i].data + "\nTekrar Sayısı: " + array[i].repetitionNumber + "\n\n";
            return temp;
        }

        public override heapNode[] heapNodes()
        {
            heapNode[] array = new heapNode[currentSize-1];
            for (int i = 0; i < currentSize - 1; i++)
                array[i] = heapArray[i];
            return array;
        }

        public override bool insert(heapNode newHeapNode)
        {
            if (currentSize == maxSize)
                return false;
            heapArray[currentSize] = newHeapNode;
            MoveToUp(currentSize++);
            return true;
        }

        public override bool isEmpty()
        {
            if (currentSize < 0)
                return true;
            else
                return false;
        }

        public override void MoveToDown(int index)
        {
            int largerChild;
            heapNode top = heapArray[index];
            while(index < currentSize/2)
            {
                int leftChild = 2 * index - 1;
                int rightChild = leftChild + 1;
                //Find largerchild
                if (rightChild < currentSize && heapArray[leftChild].repetitionNumber < heapArray[rightChild].repetitionNumber)
                    largerChild = rightChild;
                else
                    largerChild = leftChild;
                if (top.repetitionNumber >= heapArray[largerChild].repetitionNumber)
                    break;
                heapArray[index] = heapArray[largerChild];
                index = largerChild;
            }
            heapArray[index] = top;
        }

        public override void MoveToUp(int index)
        {
            int parent = (index - 1) / 2;
            heapNode bottom = heapArray[index];
            while(index>0 && heapArray[parent].repetitionNumber < heapArray[index].repetitionNumber)
            {
                heapArray[index] = heapArray[parent];
                index = parent;
                parent = (parent - 1) / 2;
            }
            heapArray[index] = bottom;
        }

        public override bool remove(heapNode node)
        {
            throw new NotImplementedException();
        }

        public override heapNode removeMax()
        {
            if (heapArray[0] == null)
                return null;
            heapNode root = heapArray[0];
            heapArray[0] = heapArray[--currentSize];
            MoveToDown(0);
            return root;
        }

        public override heapNode showHeap(object data)
        {

            heapNode[] array = heapNodes();
            for(int i=0;i<array.Length;i++)
                if(array[i].data == data)
                {
                    return array[i];
                }
            return null;
        }
    }
}
