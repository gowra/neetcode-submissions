public class Solution {
    public List<int> PartitionLabels(string s) 
    {
        // xyxxy zbzbb i s l

        // the partition end is the max last index of all chacters in the partion
        // so we need a last index for each charcter
        // then we can walk through the string and see how far we can go without extending the partion

        // 1: store last index of all characters
        var lastIndex = new Dictionary<char, int>();
        for (var i = 0; i < s.Length; i++)
        {
            lastIndex[s[i]] = i;
        }

        // 2: start from left
        //     if current char has last index somewhere, then that is the tentative last index
        //     continue and extend as and when required
        //     stop when partition end is reached or the string end is reached
        
        var partitionSizes = new List<int>();
        
        var currentLastIndex = 0;
        var currentPartitionSize = 0;

        for (var i = 0; i < s.Length; i++)
        {
            currentPartitionSize += 1;

            currentLastIndex = Math.Max(currentLastIndex, lastIndex[s[i]]);

            if (currentLastIndex == i)
            {
                partitionSizes.Add(currentPartitionSize);
                currentPartitionSize = 0;
            }
        }

        return partitionSizes;
    }
}
