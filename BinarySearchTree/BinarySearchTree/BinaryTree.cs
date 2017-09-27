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

        public void Start()
        {
            Console.WriteLine("Main Menu\nEnter '1' to Search for a Node or '2' to Add a Node to the tree.\n");
            char pick = Convert.ToChar(Console.ReadLine());
            switch (pick)
            {
                case '1':
                    Console.WriteLine("Enter the Node(int) you want to search for to see if its present in the tree.\n");
                    Search(GetQuery(), rootNode);
                    break;
                case '2':
                    break;
                default:
                    Console.WriteLine("Please enter a valid option.\n");
                    Start();
                    break;
            }
        }

        public void DisplayNode()
        {

        }

        public void Add()
        {

        }

        public void AlertFoundNode()
        {
            Console.WriteLine("Node Present in tree.");
            Console.ReadLine();
        }
        public void AlertNodeNotFound()
        {
            Console.WriteLine("That Node does not exist in this tree.");
            Console.WriteLine("You can add that Node with the 'Add Node' option in the Main Menu.");
            Console.ReadLine();
        }
        public int GetQuery()//User Input
        {
            int query = Convert.ToInt32(Console.ReadLine());
            return query;
        }

        public void Search(int query, Node node)
        {
            Node leftSide = node.leftChild;
            Node rightSide = node.rightChild;
            if(query == node.data)
            {
                AlertFoundNode();
            }
            if(query < node.data)//Search left of root
            {
                Search(query, leftSide);
            }
            if (query > node.data)
            {
                Search(query, leftSide);
            }
            if (leftSide == null || rightSide == null)
            {
                AlertNodeNotFound();
            }
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
