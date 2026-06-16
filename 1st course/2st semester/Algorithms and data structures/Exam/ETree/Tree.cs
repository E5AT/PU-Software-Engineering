namespace Tree;

public class TreeNode
{
    public int Value;
    public List<TreeNode> Children;

    public TreeNode(int value)
    {
        Value = value;
        Children = new();
    }
}

public class Tree
{
    public TreeNode Root = null;

    public void Add(int parent, int value)
    {
        if(Root == null)
            Root = new TreeNode(value);

        TreeNode Parent = Search(Root, value);

        if(Parent == null)
            throw new InvalidOperationException(nameof(Parent));

        Parent.Children.Add(new TreeNode(value));
    }

    public TreeNode Search(TreeNode start, int target)
    {
        if(start == null)
            return null;

        Queue<TreeNode> queue = new();
        queue.Enqueue(start);

        while(queue.Count > 0)
        {
            TreeNode Current = queue.Dequeue();

            if(Current.Value == target)
                return Current;

            foreach(TreeNode Child in Current.Children)
                queue.Enqueue(Child);
        }

        return null;
    }

    public void DFS(TreeNode node)
    {
        if(node == null)
            return;
        Console.Write(node.Value + " ");

        foreach(TreeNode Child in node.Children)
            DFS(Child);
    }

    public void BFS()
    {
        if(Root == null)
            return;

        Queue<TreeNode> queue = new();
        queue.Enqueue(Root);

        while(queue.Count > 0)
        {
            TreeNode Current = queue.Dequeue();
            Console.Write(Current.Value + " ");

            foreach(TreeNode Child in Current.Children)
                queue.Enqueue(Child);
        }
    }

    public int CountNodesWithoutChildren()
    {
        if(Root == null)
            return 0;

        int count = 0;

        Queue<TreeNode> queue = new();
        queue.Enqueue(Root);

        while(queue.Count > 0)
        {
            TreeNode Current = queue.Dequeue();

            if(Current.Children.Count == 0)
                count++;

            foreach(TreeNode Child in Current.Children)
                queue.Enqueue(Child);
        }

        return count;
    }
}
