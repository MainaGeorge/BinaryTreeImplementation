namespace BinaryTreeImplementation
{
    public class Tree
    {
        public Node RootNode;
        public Tree()
        {
        }
        public Tree(Node node)
        {
            RootNode = node;
        }
        public void AddNode(int valueToAdd)
        {
            if (RootNode == null)
            {
                RootNode = new Node(valueToAdd);
            }
            else
            {
                if (valueToAdd > RootNode.Value && RootNode.RightNode != null)
                {
                    RootNode.RightNode.AddBinaryNode(valueToAdd);
                }
                else if (valueToAdd < RootNode.Value && RootNode.LeftNode != null)
                {
                    RootNode.LeftNode.AddBinaryNode(valueToAdd);
                }
                else if (valueToAdd < RootNode.Value && RootNode.LeftNode == null)
                {
                    RootNode.LeftNode = new Node(valueToAdd);
                }
                if (valueToAdd > RootNode.Value && RootNode.RightNode == null)
                {
                    RootNode.RightNode = new Node(valueToAdd);
                }
            }
        }
        public void AddNode(Node node)
        {
            if (RootNode == null)
            {
                RootNode = node;
            }
            else
            {
                {
                    if (node.Value > RootNode.Value && RootNode.RightNode != null)
                    {
                        RootNode.RightNode.AddBinaryNode(node);
                    }
                    else if (node.Value < RootNode.Value && RootNode.LeftNode != null)
                    {
                        RootNode.LeftNode.AddBinaryNode(node);
                    }
                    else if (node.Value < RootNode.Value && RootNode.LeftNode == null)
                    {
                        RootNode.LeftNode = node;
                    }
                    if (node.Value > RootNode.Value && RootNode.RightNode == null)
                    {
                        RootNode.RightNode = node;
                    }
                }
            }
        }
    }
}