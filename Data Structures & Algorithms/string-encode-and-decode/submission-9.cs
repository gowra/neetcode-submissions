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

        var currentLength = new List<char>();
        var pointer = 0;
        while (pointer < s.Length)
        {
            while (s[pointer] != '#')
            {
                currentLength.Add(s[pointer++]);
            }

            var length = int.Parse(currentLength.ToArray());
            var str = s.Substring(pointer + 1, length);
            strs.Add(str);
            pointer += length + 1;

            currentLength.Clear();
        }
        
        return strs;
    }
}
