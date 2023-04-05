public class Solution {
    public int MinReorder(int n, int[][] connections) {
        var graph = new Dictionary<int, HashSet<int>>();
        var hashset = new HashSet<string>();

        foreach (var connect in connections)
        {
            if(!graph.ContainsKey(connect[0]))
            {
                graph.Add(connect[0], new HashSet<int>());
            }
            graph[connect[0]].Add(connect[1]);

            if(!graph.ContainsKey(connect[1]))
            {
                graph.Add(connect[1], new HashSet<int>());
            }
            graph[connect[1]].Add(connect[0]);
            hashset.Add($"{connect[1]}-{connect[0]}");
        }

        var queue = new Queue<int>();
        queue.Enqueue(0);

        var visited = new bool[n];
        var res = 0;

        while(queue.Count > 0)
        {
            var node = queue.Dequeue();
            visited[node]= true;

            foreach(var next in graph[node])
            {
                if(!visited[next])
                {
                    var key = $"{next}-{node}";
                    if(hashset.Contains(key))
                    {
                        res++;
                    }
                    queue.Enqueue(next);
                }
            }
        }
        return res;
}
}