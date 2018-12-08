using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDetectCycle
{
    class SingleLinkedList
    {
        private Node First;

        public Node AddFirst(int value)
        {
            Node node = new Node();

            node.Value = value;
            node.Next = null;

            First = node;
            return node;
        }

        public Node AddAfter(Node node, int value)
        {
            Node newNode = new Node();
            newNode.Value = value;
            node.Next = newNode;

            return newNode;

        }

        public void PrintList()
        {
            Node currentNode = First;
            while (currentNode != null)
            {
                Console.Write(currentNode.Value + " ");

                currentNode = currentNode.Next;
            }
        }
        public bool DetectCycle()
        {
            Node currentNode = First;

            var listOfNodes = new List<Node>();
            var item = 0;
            while (currentNode != null)
            {
                item = listOfNodes.Count(elem => elem == currentNode.Next);

                if (item > 1)
                {
                    return false;
                }
                else
                {
                    listOfNodes.Add(currentNode.Next);
                }

                currentNode = currentNode.Next;
            }
            return true;
        }
    }
}
