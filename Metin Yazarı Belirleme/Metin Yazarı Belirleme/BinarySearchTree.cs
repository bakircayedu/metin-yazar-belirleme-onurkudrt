using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metin_Yazarı_Belirleme
{
    public class BinarySearchTree : BinarySearchTreeADT
    {
        //Constructor method
        public BinarySearchTree()
        {
            this.Size = 0;
        }


        //Insert an object to tree
        public override void Insert(object data,object info)
        {
            convert convert = new convert();
            //Create a parent node
            BinaryTreeNode parent = new BinaryTreeNode();

            //Create a searched node
            BinaryTreeNode searched = root;

            //if searched node not null, assign the searched node to parent node 
            while(searched != null)
            {
                parent = searched;
                if (convert.convertObject(data) == convert.convertObject(searched.data))
                    return; //data already exist
                else if (convert.convertObject(data) < convert.convertObject(searched.data))
                    searched = searched.left;
                else
                    searched = searched.right;
            }
            //Create the will be add node
            BinaryTreeNode willBeAdded = new BinaryTreeNode(data,info);
            
            if (root == null) //Tree is null
                root = willBeAdded;

            else if (convert.convertObject(data) < convert.convertObject(parent.data)) //if data low than parent, Add new node to left of parent
                parent.left = willBeAdded;

            else //if data big than parent node, add new node to right of parent node
                parent.right = willBeAdded;

            Size++;
        }


        //Remove an object from tree
        public override bool Delete(object data)
        {
            convert convert = new convert();
            BinaryTreeNode current = root;
            BinaryTreeNode parent = root;
            bool isLeft = true;
            //Find the node
            while(current.data != data)
            {
                parent = current;
                if (convert.convertObject(data) < convert.convertObject(current.data))
                {
                    current = current.left;
                    isLeft = true;
                }
                else
                {
                    isLeft = false;
                    current = current.right;
                }
                if (current == null)
                    return false;
            }

            //if the node is a leaf node
            if(current.left == null && current.right == null)
            {
                if (current == root)
                    root = null;
                else if (isLeft)
                    parent.left = null;
                else
                    parent.right = null;
            }

            //if the node have a child node
            else if(current.right == null)
            {
                if (current == root)
                    root = current.left;
                else if (isLeft)
                    parent.left = current.left;
                else
                    parent.right = current.left;
            }
            else if(current.left == null)
            {
                if (current == root)
                    root = current.right;
                else if (isLeft)
                    parent.left = current.right;
                else
                    parent.right = current.right;
            }

            //if the node have two child nodes
            else
            {
                BinaryTreeNode successor = Successor(current);
                if (current == root)
                    root = successor;
                else if (isLeft)
                    parent.left = successor;
                else
                    parent.right = successor;
                successor.left = current.left;
            }
            Size--;
            return true;
        }


        //Travel on the tree with InOrder
        protected override void InOrder()
        {
            nodes = "";
            InOrderInt(root);
        }
        protected override void InOrderInt(BinaryTreeNode node)
        {
            if (node == null)
                return;
            InOrderInt(node.left);
            visit(node);
            InOrderInt(node.right);
        }

        //Return the leaf count in tree
        public override int leafCount()
        {
            return leafCount(root);
        }
        protected override int leafCount(BinaryTreeNode node)
        {
            int count = 0;
            if(node!=null)
            {
                if ((node.left == null) && (node.right == null))
                    count = 1;
                else
                    count += leafCount(node.left) + leafCount(node.right);
             }
            return count;
        }

        //Return the node that have maximum value
        public override BinaryTreeNode maxValue()
        {
            return maxValue(root);
        }
        protected override BinaryTreeNode maxValue(BinaryTreeNode node)
        {
            BinaryTreeNode tempRight = node;
            while (tempRight.right != null)
                tempRight = tempRight.right;
            return tempRight;
        }

        //Return the node that have minimum value
        public override BinaryTreeNode minValue()
        {
            return minValue(root);
        }
        protected override BinaryTreeNode minValue(BinaryTreeNode node)
        {
            BinaryTreeNode tempLeft = node;
            while (tempLeft.left != null)
                tempLeft = tempLeft.left; ;
            return tempLeft;
        }

        //Find Tree Nodes Count
        public override int nodeCount()
        {
            return nodeCount(root);
        }
        protected override int nodeCount(BinaryTreeNode node)
        {
            int count = 0;
            if(node != null)
            {
                count = 1;
                 return ( count + nodeCount(node.left) + nodeCount(node.right) );
            }
            return count;
        }

        //Travel on the tree with PostOrder
        protected override void PostOrder()
        {
            nodes = "";
            PostOrderInt(root);
        }
        protected override void PostOrderInt(BinaryTreeNode node)
        {
            if (node == null)
                return;
            PostOrderInt(node.left);
            PostOrderInt(node.right);
            visit(node);
        }

        //Travel on the tree with PreOrder
        protected override void PreOrder()
        {
            nodes = "";
            PreOrderInt(root);
        }
        protected override void PreOrderInt(BinaryTreeNode node)
        {
            if (node == null)
                return;
            visit(node);
            PreOrderInt(node.left);
            PreOrderInt(node.right);
        }

        //Search object
        public override BinaryTreeNode search(object data)
        {
            return searchObj(data,root);
        }
        protected override BinaryTreeNode searchObj(object data, BinaryTreeNode node)
        {
            convert convert = new convert();
            if (node == null)
                return null;
            if ( node.data == data || convert.convertObject(data) == convert.convertObject(node.data) )
                return node;
            else
            {
                if (convert.convertObject(data) <= convert.convertObject(node.data))
                    return searchObj(data, node.left);
                else
                    return searchObj(data, node.right);
            }
        }

        //Search info
        public string searchInfo(object info)
        {
            return searchInfo(root, info);
        }
        protected string searchInfo(BinaryTreeNode node, object info)
        {
            if (node == null)
                return "";
            if (node.info.ToString() == info.ToString())
                return node.data.ToString();
            return searchInfo(node.left, info) + searchInfo(node.right, info);
        }

        //Return the successor node
        public override BinaryTreeNode Successor(object data)
        {
            BinaryTreeNode node = search(data);
            if (node == null)
                return null;
            if (node.right != null)
                return minValue(node.right);
            BinaryTreeNode temp = findParent(node);
            while(temp!=null && node==temp.right)
            {
                node = temp;
                temp = findParent(temp);
            }
            return temp;
        }

        //find parent of node
        public override BinaryTreeNode findParent(BinaryTreeNode node)
        {
            convert convert = new convert();
            BinaryTreeNode temp = root;
            while(temp.left!=node && temp.right!=node)
            {
                if (temp == null)
                    return null;
                if (convert.convertObject(node.data) > convert.convertObject(temp.data))
                    temp = temp.right;
                else
                    temp = temp.left;
            }
            return temp;
        }

        //Visit the node
        protected override void visit(BinaryTreeNode node)
        {
            nodes += node.info+"\n"+node.data + "\n\n";
        }

        //Write nodes by option
        public override string writeNodesInOrder()
        {
            InOrder();
            return nodes;
        }
        public override string writeNodesPostOrder()
        {
            PostOrder();
            return nodes;
        }
        public override string writeNodesPreOrder()
        {
            PreOrder();
            return nodes;
        }

        //Check if tree is empty
        public override bool isEmpty()
        {
            if (root == null)
                return true;
            return false;
        }
    }
}
