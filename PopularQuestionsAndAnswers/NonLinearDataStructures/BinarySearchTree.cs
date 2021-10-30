using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopularQuestionsAndAnswers.NonLinearDataStructures
{
    public class BinarySearchTree<T>
    {
        private Node<T> root;

        public void Insert(T value)
        {
            //check the root isnt empty // if it is , insert on the spot
            //if it is less than the value , current becomes leftchild else current becomes right child 
            var node = new Node<T>(value);
            if (root != null)
            {
                var currentNode = root;
                while(true)
                {
                    if (value.GetHashCode() < currentNode.value.GetHashCode())
                    {
                        if (currentNode.leftChild is null)
                        {
                            currentNode.leftChild = node;
                            break;
                        }
                        else
                        {
                            currentNode = currentNode.leftChild;
                        }
                    }
                    else if (value.GetHashCode() > currentNode.value.GetHashCode())
                    {
                        if (currentNode.rightChild is null)
                        {
                            currentNode.rightChild = node;
                            break;
                        }
                        else
                        {
                            currentNode = currentNode.rightChild;
                        }
                    };
                }
            }
            else
            {
                root = node;
            }
        }

        public bool Find(T value)
        {
            var currentNode = root;
            while (currentNode != null)
            {
                if (value.GetHashCode() == currentNode.value.GetHashCode())
                {
                    return true;
                }
                else
                {
                    if (value.GetHashCode() < currentNode.value.GetHashCode())
                    {
                        currentNode = currentNode.leftChild;
                    }
                    else
                    {
                        currentNode = currentNode.rightChild;
                    }
                }
            }
            return false;
        }

        private class Node<Tvalue>
        {
            public Tvalue value;
            public Node<Tvalue> leftChild;
            public Node<Tvalue> rightChild;

            public Node(Tvalue tvalue)
            {
                value = tvalue;
            }

            public override string ToString()
            {
                return value.ToString();
            }
        }


        public void PreOrderTraversal()
        {
            PreOrderTraversal(root);
        }

        public void InOrderTraversal()
        {
            InOrderTraversal(root);
        }

        public void PostOrderTraversal()
        {
            PostOrderTraversal(root);
        }

        public int Height()
        {
            return HeightOfTree(root);
        }

        public int MinimumValue()
        {
            return MinimumValue(root);
        }

        public bool Equal(BinarySearchTree<T> tree)
        {
            if (tree is null) return false;
            return Equals(root, tree.root);
        }
        
        public bool isBinarySearchTree()
        {
            return  isBinarySearchTree(root,int.MinValue,int.MaxValue);
        }


        public void PrintNodeAtDistance(int distance)
        {
            PrintNodeAtDistance(root, distance);
        }

        private void PrintNodeAtDistance(Node<T> root, int distance)
        {
            if (root is null)
                return;

            if (distance == 0)
                Console.WriteLine(root.value);

            if (distance != 0)
                PrintNodeAtDistance(root.leftChild, distance - 1);
                PrintNodeAtDistance(root.rightChild, distance - 1);

        }

        private bool isBinarySearchTree(Node<T> root, int min, int max)
        {
            if (root is null) return true;

            if (root.value.GetHashCode() < min || root.value.GetHashCode() > max)
                return false;

           return  isBinarySearchTree(root.leftChild, min, root.value.GetHashCode() - 1) &&
            isBinarySearchTree(root.leftChild, root.value.GetHashCode() + 1, max);
        }

        private bool Equals(Node<T> first, Node<T> second)
        {
            if (first == null && second == null)
                return true;
            if (first != null && second != null)
            return first.value.GetHashCode() == second.value.GetHashCode()
                && Equals(first.leftChild) == Equals(second.leftChild)
                && Equals(first.rightChild) == Equals(second.rightChild);

            return false;
        }


        private int MinimumValue(Node<T> root)
        {
            if (root.leftChild is null && root.rightChild is null)
                return root.value.GetHashCode();
            var minToLeft = MinimumValue(root.leftChild);
            var minToRight = MinimumValue(root.rightChild);

            return Math.Min(Math.Min(root.value.GetHashCode(), minToLeft.GetHashCode())
             ,Math.Min(root.value.GetHashCode(), minToLeft.GetHashCode()));

        }

        private int HeightOfTree(Node<T> root)
        {
            if (root is null)
                return -1;
            if (root.leftChild is null && root.rightChild is null)
                return 0;
            return 1 + Math.Max(
                HeightOfTree(root.leftChild),
                HeightOfTree(root.rightChild));
        }

        private void PostOrderTraversal(Node<T> root)
        {
            if (root is null)
                return;
            PostOrderTraversal(root.leftChild);
            PostOrderTraversal(root.rightChild);
            Console.WriteLine(root.value);
        }

        private void PreOrderTraversal(Node<T> root)
        {
            if (root is null)
                return;
            Console.WriteLine(root.value);
            PreOrderTraversal(root.leftChild);
            PreOrderTraversal(root.rightChild);
        }

        private void InOrderTraversal(Node<T> root)
        {
            if (root is null)
                return;
            InOrderTraversal(root.leftChild);
            Console.WriteLine(root.value);
            InOrderTraversal(root.rightChild);
        }

    }



}
 
