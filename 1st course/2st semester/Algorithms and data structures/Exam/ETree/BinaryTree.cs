namespace Tree;

public class BNode
{
    public int Value;
    public BNode Left, Right;

    public BNode(int value)
    {
        Value = value;
        Left = Right = null;
    }
}

public class BinaryTree
{
    public BNode Root = null;

    public void Add(int value)
    {
        if(Root == null)
        {
            Root = new BNode(value);
            return;
        }

        Queue<BNode> queue = new();
        queue.Enqueue(Root);

        while(queue.Count > 0)
        {
            BNode curr = queue.Dequeue();

            if(curr.Left == null)
            {
                curr.Left = new BNode(value);
                return;
            }
            else
                queue.Enqueue(curr.Left);

            if(curr.Right == null)
            {
                curr.Right = new BNode(value);
                return;
            }
            else
                queue.Enqueue(curr.Right);
        }
    }
}
