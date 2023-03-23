public class Solution {
    public int MakeConnected(int n, int[][] connections) {
        if (n == 1)
            return 0;

        if (connections.Length < (n - 1))
            return -1;

        bool[] v = new bool[n];
        List<int>[] adj = new List<int>[n];
        foreach (var con in connections)
        {
            if (adj[con[0]] == null)
                adj[con[0]] = new List<int>();
            if (adj[con[1]] == null)
                adj[con[1]] = new List<int>();

            adj[con[0]].Add(con[1]);
            adj[con[1]].Add(con[0]);
        }
        
        int com = 0;
        for (int i = 0; i < n; i++)
        {
            if (!v[i])
            {
                TravelGraph(i, adj, v);
                com++;
            }
        }

        return com - 1;
    }

    private void TravelGraph(int i, List<int>[] adj, bool[] v)
    {
        v[i] = true;
        if (adj[i] != null)
        {
            foreach (int x in adj[i])
            {
                if (!v[x])
                    TravelGraph(x, adj, v);
            }
        }
    }
}