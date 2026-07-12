public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) 
    {
        var stringDistributions = new Dictionary<string, List<string>>();

        foreach (var str in strs)
        {
            var distribution = GetDistribution(str);

            if(!stringDistributions.ContainsKey(distribution))
                stringDistributions[distribution] = new List<string>();

            stringDistributions[distribution].Add(str);
        }

        return stringDistributions.Values.ToList();
    }

    private string GetDistribution(string str)
    {
        var distribution = new char[26];
        Array.Fill(distribution, '0');
        foreach (var c in str)
        {
            var index = (int)(c - 'a');
            distribution[index] = (char)((int)(distribution[index]) + 1);
        }

        return new string(distribution);
    }
}
