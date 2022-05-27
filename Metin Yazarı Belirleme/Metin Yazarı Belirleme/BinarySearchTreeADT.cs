using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metin_Yazarı_Belirleme
{
    public abstract class BinarySearchTreeADT
    {
        protected BinaryTreeNode root;
        public int Size;
        protected string nodes;

        public abstract BinaryTreeNode search(object data);
        protected abstract BinaryTreeNode searchObj(object data,BinaryTreeNode node);
        public abstract int nodeCount();
        protected abstract int nodeCount(BinaryTreeNode node);
        public abstract void Insert(object data,object info);
        public abstract bool Delete(object data);
        public abstract BinaryTreeNode Successor(object data);
        protected abstract void InOrder();
        protected abstract void InOrderInt(BinaryTreeNode node);
        protected abstract void PreOrder();
        protected abstract void PreOrderInt(BinaryTreeNode node);
        protected abstract void PostOrder();
        protected abstract void PostOrderInt(BinaryTreeNode node);
        protected abstract void visit(BinaryTreeNode node);
        protected abstract BinaryTreeNode maxValue(BinaryTreeNode node);
        public abstract BinaryTreeNode maxValue();
        protected abstract BinaryTreeNode minValue(BinaryTreeNode node);
        public abstract BinaryTreeNode minValue();
        public abstract int leafCount();
        protected abstract int leafCount(BinaryTreeNode node);
        public abstract bool isEmpty();
        public abstract string writeNodesPreOrder();
        public abstract string writeNodesInOrder();
        public abstract string writeNodesPostOrder();
        public abstract BinaryTreeNode findParent(BinaryTreeNode node);
    }

    public class BinaryTreeNode
    {
        public object data;
        public object info;
        public BinaryTreeNode left;
        public BinaryTreeNode right;
        public BinaryTreeNode(object data, object info)
        {
            this.data = data;
            this.info = info;
            this.left = null;
            this.right = null;
        }
        public BinaryTreeNode()
        {
        
        }
    }
}
