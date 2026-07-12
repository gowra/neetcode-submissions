public class Solution {
    public int LengthOfLongestSubstring(string s) 
    {
        if (string.IsNullOrEmpty(s))
            return 0;

        var maxLength = 0;

        var left = 0;
        var window = new HashSet<char>();

        for (var right = 0; right < s.Length; right++)
        {
            if (window.Contains(s[right]))
            {
                maxLength = Math.Max(maxLength, window.Count);

                while(window.Contains(s[right]))
                    window.Remove(s[left++]);
            }

            window.Add(s[right]);
        }

        return Math.Max(maxLength, window.Count);
    }
}
