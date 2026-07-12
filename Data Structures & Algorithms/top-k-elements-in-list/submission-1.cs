public class Solution {
    public int[] TopKFrequent(int[] nums, int k) 
    {
        var frequency = new Dictionary<int, int>();

        foreach (var n in nums)
        {
            frequency.TryAdd(n, 0);
            frequency[n]++;
        }

        var minHeap = new PriorityQueue<int, int>();
        foreach (var n in frequency)
        {
            minHeap.Enqueue(n.Key, n.Value);
            if (minHeap.Count > k)
                minHeap.Dequeue();
        }

        var topKElements = new int[k];
        for (var i = 0; i < k; i++)
        {
            topKElements[i] = minHeap.Dequeue();
        }

        return topKElements;
    }
}
