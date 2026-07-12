public class Solution {
    public int FindKthLargest(int[] nums, int k) 
    {
        var minHeap = new PriorityQueue<int, int>();

        foreach(var n in nums)
        {
            minHeap.Enqueue(n, n);

            if(minHeap.Count > k)
            {
                minHeap.Dequeue();
            }
        }

        return minHeap.Peek();
    }
}
