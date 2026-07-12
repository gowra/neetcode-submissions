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
        var distribution = new int[26];
        foreach (var c in str)
        {
            distribution[c - 'a']++;
        }

        return string.Join("|", distribution);
    }
}
