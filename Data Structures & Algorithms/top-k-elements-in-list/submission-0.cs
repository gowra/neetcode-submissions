public class Solution {
    public int[] TopKFrequent(int[] nums, int k) 
    {
        var frequencyMap = new Dictionary<int, int>();
        foreach (var n in nums)
        {
            frequencyMap.TryAdd(n, 0);
            frequencyMap[n]++;
        }

        var maxQueue = new PriorityQueue<int, int>();
        foreach (var n in frequencyMap)
        {
            maxQueue.Enqueue(n.Key, -n.Value);
        }

        var frequentNumbers = new int[k];
        for (var i = 0; i < k; i++)
        {
            frequentNumbers[i] = maxQueue.Dequeue();
        }

        return frequentNumbers;
    }
}
