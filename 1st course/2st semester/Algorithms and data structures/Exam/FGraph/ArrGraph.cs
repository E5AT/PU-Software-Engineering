namespace Graph;

public class ArrGraph
{
    public int Count;
    int[,] graph;

    public ArrGraph(int count)
    {
        Count = count;
        graph = new int[Count, Count];

        for(int i = 0; i < Count; i++)
            for(int j = 0; j < Count; j++)
                graph[i,j] = 0;
    }

    public void Add(int a, int b)
    {
        if(a >= Count || b >= Count || a < 0 || b < 0)
            throw new ArgumentOutOfRangeException();

        graph[a, b] = 1;
        graph[b, a] = 1;
    }

    public void DFS(int curr, bool[] visited)
    {
        visited[curr] = true;
        Console.Write(curr + " ");

        for(int neigh = 0; neigh < Count; neigh++)
            if(graph[curr, neigh] == 1 && !visited[neigh])
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

            for(int neigh = 0; neigh < Count; neigh++)
                if(graph[curr, neigh] == 1 && !visited[neigh])
                {
                    queue.Enqueue(neigh);
                    visited[neigh] = true;
                }
        }
    }
}
