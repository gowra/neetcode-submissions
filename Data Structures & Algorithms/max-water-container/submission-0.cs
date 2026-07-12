public class Solution {
    public int MaxArea(int[] heights) 
    {
        // here we can start with the widest container 
        // hoping that it will have largest area
        // then we have to move the shorter bar, 
        // since anyway width is reduced. we want to keep the maxheight
        // continue this until the container width becomes 0

        var left = 0;
        var right = heights.Length - 1;

        var maxArea = 0;

        while (left < right)
        {
            var range = right - left;
            var minHeight = 0;

            if (heights[left] < heights[right])
            {
                minHeight = heights[left];
                left++;
            }
            else
            {
                minHeight = heights[right];
                right--;
            }

            maxArea = Math.Max(maxArea, minHeight * range);
        }

        return maxArea;
    }
}
