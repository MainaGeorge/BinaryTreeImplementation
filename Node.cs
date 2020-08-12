namespace BinaryTreeImplementation
{
    public class Node
    {
        public int Value;
        public Node LeftNode;
        public Node RightNode;

        public Node(int value, Node leftNode = null, Node rightNode = null)
        {
            Value = value;
            LeftNode = leftNode;
            RightNode = rightNode;
        }
        public void AddBinaryNode(int valueToAdd)
        {
            if (valueToAdd > Value)
            {
                if (RightNode == null)
                {
                    RightNode = new Node(valueToAdd);
                }
                else
                {
                    RightNode.AddBinaryNode(valueToAdd);
                }
            }
            else if (valueToAdd < Value)
            {
                if (LeftNode == null)
                {
                    LeftNode = new Node(valueToAdd);
                }
                else
                {
                    LeftNode.AddBinaryNode(valueToAdd);
                }
            }
        }
        public void AddBinaryNode(Node nodeToAdd)
        {
            if (nodeToAdd.Value > Value)
            {
                if (RightNode == null)
                {
                    RightNode = nodeToAdd;
                }
                else
                {
                    RightNode.AddBinaryNode(nodeToAdd);
                }
            }
            else if (nodeToAdd.Value < Value)
            {
                if (LeftNode == null)
                {
                    LeftNode = nodeToAdd;
                }
                else
                {
                    LeftNode.AddBinaryNode(nodeToAdd);
                }
            }
        }
    }
}
