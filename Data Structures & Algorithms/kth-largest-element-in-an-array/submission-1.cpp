class Solution {
public:
    int findKthLargest(vector<int>& nums, int k) 
    {
        auto minHeap = priority_queue<int, vector<int>, greater<int>>();

        for (auto n : nums)
        {
            minHeap.push(n);

            if (minHeap.size() > k)
                minHeap.pop();
        }

        return minHeap.top();
    }
};
