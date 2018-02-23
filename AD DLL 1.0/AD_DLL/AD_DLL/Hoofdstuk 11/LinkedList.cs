using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD_DLL.Hoofdstuk_11
{
    public class LinkedList
    {
        private LinkedListNode<string> strNode = new LinkedListNode<string>(""); //make a string linkedListNode
        private LinkedList<string> names = new LinkedList<string>(); //create a new LinkedList

        private LinkedListNode<int> intNode = new LinkedListNode<int>(0); //make a integer linkedListNode
        private LinkedList<int> nums = new LinkedList<int>(); //create a new LinkedList

        private int[] intArray; //create a int Array for storing integer Array's


        //--------------- STRING NODE METHODS ---------------------//

        //add NEXT node or first node if there aren't any nodes
        public void addNextStringNode(string myString)
        {
            LinkedListNode<string> node = new LinkedListNode<string>(myString);
            this.strNode = node;

            LinkedListNode<string> aNode = this.names.First;
            if (aNode == null)
            {
                this.names.AddFirst(this.strNode);
            }
            else
            {
                this.names.AddLast(node);
            }
        }

        //add LAST node or first node if there aren't any nodes
        public void addLastStringNode(string myString)
        {
            LinkedListNode<string> node = new LinkedListNode<string>(myString);
            LinkedListNode<string> aNode = this.names.First;
            if (aNode == null)
            {
                this.names.AddFirst(node);
            }
            else
            {
                this.names.AddLast(node);
            }
        }

        //add an array of string nodes
        public void addArrayOfStringNodes(string[] myString)
        {
            foreach (string name in myString)
            {
                LinkedListNode<string> node = new LinkedListNode<string>(name);
                this.strNode = node;

                LinkedListNode<string> aNode = this.names.First;
                if (aNode == null)
                {
                    this.names.AddFirst(this.strNode);
                }
                else
                {
                    this.names.AddLast(node);
                }
            }
        }

        //add a string node after the selected node
        public void addAfterStringNode(string firstNode, string secondNode)
        {
            LinkedListNode<string> nodeFirst = new LinkedListNode<string>(firstNode);
            LinkedListNode<string> nodeAfter = new LinkedListNode<string>(secondNode);

            LinkedListNode<string> aNode = this.names.First;
            if (aNode == null)
            {
                this.names.AddFirst(nodeFirst);
                this.names.AddLast(secondNode);
            }
            else
            {
                while (aNode.Value != nodeFirst.Value)
                {
                    aNode = aNode.Next;
                }

                if (aNode.Value == nodeFirst.Value)
                {
                    nodeFirst = aNode;
                    this.names.AddAfter(nodeFirst, nodeAfter);
                }
            }
        }


        //--------------- INT NODE METHODS ---------------------//

        //add NEXT node or first node if there aren't any nodes
        public void addNextIntNode(int myInt)
        {
            LinkedListNode<int> node = new LinkedListNode<int>(myInt);
            this.intNode = node;

            LinkedListNode<string> aNode = this.names.First;
            if (aNode == null)
            {
                this.nums.AddFirst(this.intNode);
            }
            else
            {
                this.nums.AddLast(node);
            }
        }

        //add LAST node or first node if there aren't any nodes
        public void addLastIntNode(int myInt)
        {
            LinkedListNode<int> node = new LinkedListNode<int>(myInt);
            LinkedListNode<int> aNode = this.nums.First;
            if (aNode == null)
            {
                this.nums.AddFirst(node);
            }
            else
            {
                this.nums.AddLast(node);
            }
        }

        //add an array of nodes
        public void addArrayOfIntNodes(int[] myInteger)
        {
            foreach (int num in myInteger)
            {
                LinkedListNode<int> node = new LinkedListNode<int>(num);
                this.intNode = node;

                LinkedListNode<string> aNode = this.names.First;
                if (aNode == null)
                {
                    this.nums.AddFirst(this.intNode);
                }
                else
                {
                    this.nums.AddLast(node);
                }
            }
        }

        //add a node after the selected node
        public void addAfterIntNode(int firstNode, int secondNode)
        {
            LinkedListNode<int> nodeFirst = new LinkedListNode<int>(firstNode);
            LinkedListNode<int> nodeAfter = new LinkedListNode<int>(secondNode);

            LinkedListNode<int> aNode = this.nums.First;
            if (aNode == null)
            {
                this.nums.AddFirst(nodeFirst);
                this.nums.AddLast(secondNode);
            }
            else
            {
                while (aNode.Value != nodeFirst.Value)
                {
                    aNode = aNode.Next;
                }

                if (aNode.Value == nodeFirst.Value)
                {
                    nodeFirst = aNode;
                    this.nums.AddAfter(nodeFirst, nodeAfter);
                }
            }
        }


        //--------------- GENERAL NODE METHODS ---------------------//

        //show node list results (string)
        public void showStringNodes()
        {
            LinkedListNode<string> aNode = names.First; // eerste item
            while (aNode != null) // gaat langs alle items
            {
                Console.WriteLine(aNode.Value); // display item
                aNode = aNode.Next; // pak volgende item
            }
        }

        //show node list results (int)
        public void showIntNodes()
        {
            LinkedListNode<int> aNode = nums.First; // eerste item
            while (aNode != null) // gaat langs alle items
            {
                Console.WriteLine(aNode.Value); // display item
                aNode = aNode.Next; // pak volgende item
            }
        }

        //remove string node
        public void removeStringNode(string stringNode)
        {
            this.names.Remove(stringNode);
        }

        //remove integer node
        public void removeIntNode(int intNode)
        {
            this.nums.Remove(intNode);
        }

        //clear string node list
        public void clearStringNodes()
        {
            this.names.Clear();
        }

        //clear int node list
        public void clearIntNodes()
        {
            this.nums.Clear();
        }

        //clear all node list
        public void clearAllNodes()
        {
            this.names.Clear();
            this.nums.Clear();
        }
    }
}
