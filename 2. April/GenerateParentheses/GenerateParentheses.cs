public class Solution {
    
        List<string> result = new List<string>();
        int maxLen;

        public IList<string> GenerateParenthesis(int n)
        {
            maxLen = n;
            GenerateAndCheck("",0,0);
            return result;
        }

        public void GenerateAndCheck(string str, int opened, int closed)
        {
            if(opened == closed && opened == maxLen)
            {
                result.Add(str);
                return;
            }

            if(opened < maxLen)
            {
                GenerateAndCheck(str + "(", opened + 1, closed);
            }

            if(closed < opened)
            {
                GenerateAndCheck(str + ")", opened, closed + 1);
            }
        }
    
}