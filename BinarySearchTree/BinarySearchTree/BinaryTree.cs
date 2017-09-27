using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BinaryTree
    {
        private Node rootNode;

        public BinaryTree()
        {
            rootNode = null;
        }

        public void DisplayNode()
        {

        }

        public void Add()
        {

        }

        public void Search()
        {

        }

        public void StartTree()
        {
            rootNode = new Node(10);
            rootNode.leftChild = new Node(5);
            rootNode.rightChild = new Node(15);
            rootNode.leftChild.leftChild = new Node(2);
            rootNode.leftChild.rightChild = new Node(8);
            rootNode.rightChild.leftChild = new Node(14);
        }
    }
}
