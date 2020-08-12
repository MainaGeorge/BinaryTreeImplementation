using System;

namespace BinaryTreeImplementation
{
    public static class BinaryTreeHelperFunctions
    {
        public static void PrintInOrder(this Node node)
        {
            if (node == null) return;
            PrintInOrder(node.LeftNode);
            Console.Write($"{node.Value} ");
            PrintInOrder(node.RightNode);
        }
        public static Node FindNodeWithGivenValue(this Node node, int value)
        {
            if (node == null)
            {
                throw new ArgumentException("no node with the value " + value);
            }
            if (node.Value == value)
            {
                return node;
            }
            else
            {
                return value > node.Value
                    ? node.RightNode.FindNodeWithGivenValue(value)
                    : node.LeftNode.FindNodeWithGivenValue(value);
            }
        }
        public static void PrintPreOrder(this Node node)
        {
            if (node == null) return;
                else
            {
                Console.Write($"{node.Value} ");
                node.LeftNode.PrintPreOrder();
                node.RightNode.PrintPreOrder();

            }
        }
        public static void PostOrder(this Node node)
        {
            if (node == null) return;
            node.LeftNode.PostOrder();
            node.RightNode.PostOrder();
            Console.Write($"{node.Value} ");
        }
    }
}