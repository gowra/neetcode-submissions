public class Solution {
    public int LargestRectangleArea(int[] heights) 
    {
        // for any bar, the bar can extend left or right
        // until it reaches a lower bar

        // so we need to calculate the extent of a bar in both directtions
        // max of these will be the max rectangle

        var maxArea = 0;
        for (var i = 0; i < heights.Length; i++)
        {
            var range = 1;
            
            var left = i - 1;
            while (left >= 0)
            {
                if (heights[left] < heights[i])
                    break;

                range += 1;

                if (left == 0)
                    break;
                
                left--;
            }

            var right = i + 1;
            while (right < heights.Length)
            {
                if (heights[right] < heights[i])
                    break;

                range += 1;

                if (range == heights.Length)
                    break;

                right++;
            }

            var area = range * heights[i];
            maxArea = Math.Max(area, maxArea);

            Console.WriteLine($"{heights[i]}, {range}, {area}, {maxArea}");
        }

        return maxArea;
    }
}
