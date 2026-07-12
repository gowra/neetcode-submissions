public class Solution {
    public bool IsAnagram(string s, string t) 
    {
        if (s.Length != t.Length)
            return false;

        var counter = new int[26];

        for (var i = 0; i < s.Length; i++)
        {
            counter[s[i] - 'a']++;
            counter[t[i] - 'a']--;
        }

        foreach (var count in counter)
        {
            if (count != 0)
                return false;
        }

        return true;
    }
}
