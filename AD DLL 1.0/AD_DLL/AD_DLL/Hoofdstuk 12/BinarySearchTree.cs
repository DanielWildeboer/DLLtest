using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD_DLL.Hoofdstuk_12
{
    // Willem de Buck
    // BinarySearchTree klasse
    // T wat wordt opgeslagen in het object
    public class BinarySearchTree<T> where T : IComparable<T>
    {
        // variabelen declareren
        public DoublyNode<T> root;


        // BinarySearchTree constructor
        public BinarySearchTree()
        {
            root = null;
        }

        //Hier worden nieuwe waardes toegevoegd.
        //Er wordt bepaalt waar de waardes geplaats worden left of right of eerste node.
        public void Insert(T i)
        {
            DoublyNode<T> newNode = new DoublyNode<T>(i);
            if (root == null)
            {
                root = newNode;
            }
            else
            {
                DoublyNode<T> current = root;
                DoublyNode<T> parent;
                while (true)
                {
                    parent = current;
                    if (i.CompareTo(current.Data) < 0)
                    {
                        current = current.Vorige;
                        if (current == null)
                        {
                            parent.Vorige = newNode;
                            break;
                        }
                    }
                    else
                    {
                        current = current.Volgende;
                        if (current == null)
                        {
                            parent.Volgende = newNode;
                            break;
                        }
                    }
                }
            }
        }


        /// Het sorteren van de waardes.
        public void Order(DoublyNode<T> NodeRoot)
        {
            if (NodeRoot != null)
            {
                Order(NodeRoot.Vorige);
                NodeRoot.Data();
                Order(NodeRoot.Volgende);
            }
        }


        /// Waarden sorteren in pre order
        public void PreOrder(Node<T> NodeRoot)
        {
            if (NodeRoot != null)
            {
                NodeRoot.DisplayNode();
                PreOrder(NodeRoot.Left);
                PreOrder(NodeRoot.Right);
            }
        }


        // Waarden sorteren in post order
        public void PostOrder(Node<T> NodeRoot)
        {
            if (NodeRoot != null)
            {
                PostOrder(NodeRoot.Left);
                PostOrder(NodeRoot.Right);
                NodeRoot.DisplayNode();
            }
        }

        // Minimum waarde bepalen en returnen
        public T FindMin()
        {
            Node<T> current = root;
            while (current.Left != null)
            {
                current = current.Left;
            }
            return current.Data;
        }


        // Maximum waarde bepalen en returnen
        public T FindMax()
        {
            Node<T> current = root;
            while (current.Right != null)
            {
                current = current.Right;
            }
            return current.Data;
        }


        // Een waarde opzoeken en deze returnen indien gevonden. Niet gevonden is null returnen.
        public Node<T> Find(T key)
        {
            Node<T> current = root;
            while (current.Data.CompareTo(key) != 0)
            {
                if (key.CompareTo(current.Data) < 0)
                {
                    current = current.Left;
                }
                else
                {
                    current = current.Right;
                }

                if (current == null)
                {
                    return null;
                }
            }
            return current;
        }

        //Kijken waar een bepaalde node zich bevind.
        public Node<T> GetSuccessor(Node<T> delNode)
        {
            Node<T> successorParent = delNode;
            Node<T> successor = delNode;
            Node<T> current = delNode.Right;

            while (current != null)
            {
                successorParent = current;
                successor = current;
                current = current.Left;
            }

            if (successor != delNode.Right)
            {
                successorParent.Left = successor.Right;
                successor.Right = delNode.Right;
            }

            return successor;
        }


        //Node verwijderen van de searchtree
        public bool Delete(T key)
        {
            Node<T> current = root;
            Node<T> parent = root;
            bool isLeftChild = true;

            while (current.Data.CompareTo(key) != 0)
            {
                parent = current;
                if (key.CompareTo(current.Data) < 0)
                {
                    isLeftChild = true;
                    current = current.Right;
                }
                else
                {
                    isLeftChild = false;
                    current = current.Right;
                }

                if (current == null)
                {
                    return false;
                }
            }

            if ((current.Left == null) && (current.Right == null))
            {
                if (current == root)
                {
                    root = null;
                }
                else if (isLeftChild)
                {
                    parent.Left = null;
                }
                else
                {
                    parent.Right = null;
                }
            }
            else if (current.Right == null)
            {
                if (current == root)
                {
                    root = current.Left;
                }
                else if (isLeftChild)
                {
                    parent.Left = current.Left;
                }
                else
                {
                    parent.Right = current.Right;
                }
            }
            else if (current.Left == null)
            {
                if (current == root)
                {
                    root = current.Right;
                }
                else if (isLeftChild)
                {
                    parent.Left = parent.Right;
                }
                else
                {
                    parent.Right = current.Right;
                }
            }
            else
            {
                Node<T> successor = GetSuccessor(current);
                if (current == root)
                {
                    root = successor;
                }
                else if (isLeftChild)
                {
                    parent.Left = successor;
                }
                else
                {
                    parent.Right = successor;
                }
                successor.Left = current.Left;
            }
            return true;
        }
    }
}
