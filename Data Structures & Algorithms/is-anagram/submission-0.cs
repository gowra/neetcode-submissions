public class Solution {
    public bool IsAnagram(string s, string t) 
    {
        if (s.Length != t.Length)
            return false;

        var sMap = new Dictionary<char, int>();
        var tMap = new Dictionary<char, int>();

        for (var i = 0; i < s.Length; i++)
        {
            if (!sMap.ContainsKey(s[i]))
                sMap[s[i]] = 1;
            else
                sMap[s[i]]++;

            if (!tMap.ContainsKey(t[i]))
                tMap[t[i]] = 1;
            else
                tMap[t[i]]++;
        }

        if (sMap.Count != tMap.Count)
            return false;

        foreach(var c in sMap.Keys)
        {
            if (!tMap.ContainsKey(c) || sMap[c] != tMap[c])
            {
                return false;
            }
        }

        return true;
    }
}
