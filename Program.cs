using System;

namespace BinaryTreeImplementation
{
    internal class Program
    {
        private static void Main()
        {
            var node = new Node(8)
            {
                RightNode = new Node(10),
                LeftNode = new Node(7)
            };

            var tree = new Tree(node);
            tree.AddNode(6);
            tree.AddNode(3);
            tree.AddNode(5);
            tree.AddNode(2);



            tree.RootNode.AddBinaryNode(node);

            var foundNode = tree.RootNode.FindNodeWithGivenValue(8);
            Console.WriteLine(foundNode.RightNode.Value);
            Console.WriteLine("in order: ");
            tree.RootNode.PrintInOrder();
            Console.WriteLine("\npre order: ");
            tree.RootNode.PrintPreOrder();
            Console.WriteLine("\npost order");
            tree.RootNode.PostOrder();
            Console.WriteLine();

            try
            {
                tree.RootNode.FindNodeWithGivenValue(20);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
