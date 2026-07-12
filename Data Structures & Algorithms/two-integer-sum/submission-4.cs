public class Solution {
    public int[] TwoSum(int[] nums, int target) 
    {
        var indexMap = new int[nums.Length][];
        for (var i = 0; i < nums.Length; i++)
        {
            indexMap[i] = new[] { nums[i], i };
        }

        indexMap = indexMap.OrderBy(n => n[0]).ToArray();

        var left = 0;
        var right = indexMap.Length - 1;

        while (left < right)
        {
            var sum = indexMap[left][0] + indexMap[right][0];
            if (sum == target)
            {
                if (indexMap[left][1] < indexMap[right][1])
                    return new[] { indexMap[left][1], indexMap[right][1] };
                else
                    return new[] { indexMap[right][1], indexMap[left][1] };
            }
            else if (sum < target)
            {
                left++;
            }
            else
            {
                right--;
            }
        }

        return new int[0];
    }
}
