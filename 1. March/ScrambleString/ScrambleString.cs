public class Solution {
    public bool IsScramble(string s1, string s2) {
        Dictionary<string, bool> mem = new Dictionary<string, bool>();
        return solve(s1,s2);

        bool solve(string s, string t)
        {
            if(s.Length == 1)
            {
                return s == t;
            }

            if(s == t)
            {
                return true;
            }

            string key = $"{s}_{t}";

            if(mem.ContainsKey(key))
            {
                return mem[key];
            }

            int n = s.Length;
            int[] f1 = new int[26];
            int[] f2 = new int[26];
            for(int i = 0; i < n; i++)
            {
                f1[s[i] - 'a'] += 1;
                f2[t[i] - 'a'] += 1;
            }

            if(string.Join('.', f1) != string.Join('.', f2))
            {
                mem[key] = false;
                return false;
            }

            for(int i = 1; i < n; i++)
            {
               if ((solve(s.Substring(0, i), t.Substring(0, i)) &&
                solve(s.Substring(i), t.Substring(i))) ||
                (solve(s.Substring(0, i), t.Substring(n - i)) && 
                solve(s.Substring(i), t.Substring(0, n - i)))) {
                    mem[key] = true;
                    return true; 
            }
        }

        mem[key] = false;
        return false;
    }
}
}