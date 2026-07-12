public class Solution {
    public int[] TopKFrequent(int[] nums, int k)
    {
        var frequencyMap = new Dictionary<int, int>();

        foreach (var n in nums)
        {
            frequencyMap[n] = frequencyMap.GetValueOrDefault(n, 0) + 1;
        }

        var frequencyBuckets = new List<int>[nums.Length + 1];

        foreach (var kv in frequencyMap)
        {
            frequencyBuckets[kv.Value] ??= new List<int>();
            frequencyBuckets[kv.Value].Add(kv.Key);
        }

        var frequentElements = new List<int>();
        var filled = 0;
        var currentBucket = nums.Length;

        for (var i = nums.Length; i >= 0; i--)
        {
            if (frequencyBuckets[i] == null)
                continue;

            foreach (var n in frequencyBuckets[i])
            {
                frequentElements.Add(n);

                if (frequentElements.Count == k)
                    break;
            }

            if (frequentElements.Count == k)
                break;
        }

        return frequentElements.ToArray();
    }
}
