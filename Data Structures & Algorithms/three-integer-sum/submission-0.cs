public class Solution {
    public List<List<int>> ThreeSum(int[] nums) 
    {
        // we can take each element in the array 
        // and try to find the complement pair in rest of array
        // if found, store it

        // for complement pair, we can use 2 pointer if the array is sorted

        Array.Sort(nums);

        var result = new List<List<int>>();

        for (var i = 0; i < nums.Length - 2; i++)
        {
            if (i > 0 && nums[i] == nums[i - 1])
                continue;

            var left = i + 1;
            var right = nums.Length - 1;

            while (left < right)
            {
                var sum = nums[i] + nums[left] + nums[right];

                if (sum == 0)
                {
                    result.Add(new List<int> { nums[i], nums[left], nums[right] });
                    left++;
                    right--;

                    while(left < right && nums[left] == nums[left - 1])
                        left++;

                    while(left < right && nums[right] == nums[right + 1])
                        right--;
                }
                else if (sum < 0)
                    left++;
                else
                    right--;
            }
        }

        return result;   
    }
}
