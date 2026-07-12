public class Solution 
{
    public string Encode(IList<string> strs)
    {
        if (strs.Count == 0)
            return "";

        var builder = new StringBuilder();
        builder.Append(string.Join(",", strs.Select(x => x.Length)));

        builder.Append("#");

        builder.Append(string.Join("", strs));

        return builder.ToString();
    }

    public List<string> Decode(string s) 
    {
        if (s == "")
            return new List<string>();

        var lengthMarker = s.IndexOf('#', 0);

        var lengthSection = s.Substring(0, lengthMarker);
        var lengths = lengthSection.Split(new[] { ',' });

        var strsSection = s.Substring(lengthMarker + 1);

        var strs = new List<string>();
        var checkedLength = 0;
        foreach (var lengthString in lengths)
        {
            var length = int.Parse(lengthString);
            strs.Add(strsSection.Substring(checkedLength, length));
            checkedLength += length;
        }

        return strs;
    }
}