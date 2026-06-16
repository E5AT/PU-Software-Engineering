namespace Graph;

public class ListGraph
{
    int Count;
    List<int>[] graph;

    public ListGraph(int count)
    {
        Count = count;
        graph = new List<int>[Count];
    }

    public void Add(int a, int b)
    {
        if(a >= Count || b >= Count || a < 0 || b < 0)
            throw new ArgumentOutOfRangeException();

        graph[a].Add(b);
        graph[b].Add(a);
    }

    public void DFS(int Curr, bool[] visited)
    {
        visited[Curr] = true;
        Console.WriteLine(Curr + " ");

        foreach(int neigh in graph[Curr])
            if(!visited[neigh])
                DFS(neigh, visited);
    }

    public void BFS(int start)
    {
        bool[] visited = new bool[Count];
        Queue<int> queue = new();
        queue.Enqueue(start);

        while(queue.Count > 0)
        {
            int curr = queue.Dequeue();
            Console.Write(curr + " ");

            foreach(int neigh in graph[curr])
                if(!visited[neigh])
                {
                    queue.Enqueue(neigh);
                    visited[neigh] = true;
                }
        }
    }
}
