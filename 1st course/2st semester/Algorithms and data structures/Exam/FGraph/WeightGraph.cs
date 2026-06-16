namespace Graph;

public class WeightGraph
{
    public int Count;
    public int[,] graph;
    public WeightGraph(int count)
    {
        Count = count;
        graph = new int[Count, Count];
    }

    public void Add(int a, int b, int weight)
    {
        if(a >= Count || b >= Count || a < 0 || b < 0)
            return;

        graph[a,b] = weight;
    }
    
    public void DjikstraRecursive(int start)
    {
        int[] distances = new int[Count];
        bool[] visited = new bool[Count];

        for(int i=0; i<Count; i++)
        {
            distances[i] = int.MaxValue;
            visited[i] = false;
        }
        distances[start] = 0;

        SolveDjikstra(distances, visited, 0);

        for(int i=0; i<Count; i++)
            Console.WriteLine($"To  {i} -> Distance: {distances[i]}");
    }

    public void SolveDjikstra(int[] distances, bool[] visited, int count)
    {
        if(count == Count) return;

        int current = FindMinDistance(distances, visited);

        if(current == -1)
            return;

        visited[current] = true;

        for(int i=0; i<Count; i++)
        {
            if(graph[current, i] > 0 && !visited[i] && distances[current] != int.MaxValue)
            {
                int distance = distances[current] + graph[current, i];
                if(distance < distances[i])
                    distances[i] = distance;
            }
        }

        SolveDjikstra(distances, visited, count + 1);
    }

    public int FindMinDistance(int[] distances, bool[] visited)
    {
        int min = int.MaxValue;
        int minIndex = -1;

        for(int v=0; v < Count; v++)
            if(!visited[v] && distances[v] <= min)
            {
                min = distances[v];
                minIndex = v;
            }

        return minIndex;
    }
}
