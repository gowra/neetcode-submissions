public class Solution {
    public int[] TwoSum(int[] nums, int target) 
    {
        var indexMap = new Dictionary<int, int>();

        for (var i = 0; i < nums.Length; i++)
        {
            var complement = target - nums[i];
            if (indexMap.ContainsKey(complement))
                return new[] { indexMap[complement], i };
            
            indexMap[nums[i]] = i;
        }

        return new[] {-1, -1};
    }
}
