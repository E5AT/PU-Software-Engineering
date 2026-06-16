namespace Tree;

public class Node
{
    public int Value;
    public Node Left, Right;

    public Node(int value)
    {
        Value = value;
        Left = Right = null;
    }
}

public class BinarySearchTree
{
    public Node Root = null;

    public void Add(int value)
    {
        if(Root == null)
        {
            Root = new Node(value);
            return;
        }

        AddRec(Root, value);
    }

    private void AddRec(Node node, int value)
    {
        if(node == null) return;

        if(value < node.Value)
            if(node.Left == null)
                node.Left = new Node(value);
            else
                AddRec(node.Left, value);
        else if(value > node.Value)
            if(node.Right == null)
                node.Right = new Node(value);
            else
                AddRec(node.Right, value);
        else
        {
            Console.WriteLine("A node with the same value already exists!");
            return;
        }
    }

    public void Preorder(Node node)
    {
        if(node == null) return;

        Console.WriteLine(node + " ");
        Preorder(node.Left);
        Preorder(node.Right);
    }


    public void Inorder(Node node)
    {
        if(node == null) return;

        Console.WriteLine(node + " ");
        Inorder(node.Left);
        Inorder(node.Right);
    }


    public void Postorder(Node node)
    {
        if(node == null) return;

        Console.WriteLine(node + " ");
        Postorder(node.Left);
        Postorder(node.Right);
    }

    public void Remove(int value)
    {
        Root = RemoveRec(Root, value);
    }

    public Node RemoveRec(Node node, int value)
    {
        if(node == null)
            return null;

        if(value < node.Value)
            node.Left = RemoveRec(node.Left, value);
        else if(value > node.Value)
            node.Right = RemoveRec(node.Right, value);
        else
        {
            // 1st and 2nd - the node has no or one child
            if(node.Left == null)
                return node.Left;
            if(node.Right == null)
                return node.Right;

            //3rd - the node has two children
            node.Value = FindMinValue(node.Right);
            node.Right = RemoveRec(node.Right, node.Value);

        }

        return node;
    }

    public int FindMinValue(Node node)
    {
        int min = node.Value;
        while(node.Left != null)
        {
            min = node.Left.Value;
            node = node.Left;
        }
        return min;
    }

    public void BFS()
    {
        if(Root == null)
            return;

        Queue<Node> queue = new();
        queue.Enqueue(Root);

        while(queue.Count > 0)
        {
            Node Current = queue.Dequeue();
            Console.Write(Current.Value + " ");

            if(Current.Left != null)
                queue.Enqueue(Current.Left);
            if(Current.Right != null)
                queue.Enqueue(Current.Right);
        }
    }
}
