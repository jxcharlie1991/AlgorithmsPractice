public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        Dictionary<char, int> hashTable = new Dictionary<char, int>();
        int leftWin = 0;
        int rightWin = 0;
        int maxLength = 0;
        for (rightWin = 0; rightWin < s.Length; rightWin++)
        {
            if (!(hashTable.ContainsKey(s[rightWin]) && hashTable[s[rightWin]] >= leftWin))
            {
                if ((rightWin - leftWin + 1) >= maxLength)
                {
                    maxLength = rightWin - leftWin + 1;
                }
            }
            else
            {
                leftWin = hashTable[s[rightWin]] + 1;
            }
            hashTable[s[rightWin]] = rightWin;
        }
        return maxLength;
    }
}