public class Solution {
    public int LongestConsecutive(int[] nums) 
    {
        if (nums.Length == 0)
            return 0;

        if (nums.Length == 1)
            return 1;

        Array.Sort(nums);

        var sequence = new HashSet<int>();

        var maxLength = 1;

        Console.WriteLine($"Adding {nums[0]}");
        sequence.Add(nums[0]);
        
        for (var i = 1; i < nums.Length; i++)
        {
            if (sequence.Contains(nums[i]))
                continue;

            Console.WriteLine($"Checking {nums[i]} and {nums[i - 1]}");
            if (nums[i] - nums[i - 1] == 1)
            {
                Console.WriteLine($"Adding {nums[i]}");
                sequence.Add(nums[i]);
            }
            else
            {
                maxLength = Math.Max(maxLength, sequence.Count);
                sequence.Clear();
                sequence.Add(nums[i]);
                Console.WriteLine($"Clearing and adding {nums[i]}");
                Console.WriteLine($"Maxlength = {maxLength}");
            }
        }    

        return Math.Max(maxLength, sequence.Count);
    }
}
