public class Solution 
{
    public string Encode(IList<string> strs)
    {
        if (strs.Count == 0)
            return "";

        var builder = new StringBuilder();

        foreach (var s in strs)
        {
            builder.Append(s.Length);
            builder.Append('#');
            builder.Append(s);
        }

        return builder.ToString();
    }

    public List<string> Decode(string s)
    {
        if (s == "")
            return new List<string>();

        var strs = new List<string>();

        var length = 0;
        var pointer = 0;
        while (pointer < s.Length)
        {
            while (s[pointer] != '#')
            {
                length = length * 10 + (s[pointer] - '0');
                pointer++;
            }

            pointer++;

            var str = s.Substring(pointer, length);
            strs.Add(str);
            pointer += length;

            length = 0;
        }
        
        return strs;
    }
}
