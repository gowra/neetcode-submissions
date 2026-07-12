public class Solution {
    public int LargestRectangleArea(int[] heights) 
    {
        // here for every height, 
        // we need a next smaller index on left and right
        // to calculate the range

        // i.e for i, we need left[i] and right[i]

        // as we move from left to right
        // we can check if the incoming element is smaller than current top
        // if so, current top's right limiter is this element
        // current top's left limiter is the next top element

        // so eventually, we want to store the increasing heights 
        // at each point to find the limits
        // a stack can help

        // But we need a range, so store index instead of value

        var topHeights = new Stack<int>();

        // 7 1 7 2 2 4

        var maxArea = 0;

        for (var i = 0; i <= heights.Length; i++)
        {
            WriteLine($"i = {i}");
            PrintStack(topHeights, heights);

            var currentHeight = i == heights.Length ? 0 : heights[i];

            WriteLine($"CurrentHeight = {currentHeight}");

            while (topHeights.Count > 0 && currentHeight < heights[topHeights.Peek()])
            {
                var topPosition = topHeights.Pop();

                WriteLine($"Popping {heights[topPosition]} at {topPosition}");

                PrintStack(topHeights, heights);

                var right = i;
                var left = topHeights.Count == 0 ? -1 : topHeights.Peek();

                var range = right - left - 1;
                var area = range * heights[topPosition];

                maxArea = Math.Max(area, maxArea);

                WriteLine($"Left({topPosition}) = {left}");
                WriteLine($"Right({topPosition}) = {right}");
                WriteLine($"Range({topPosition}) = {range}");
                WriteLine($"Area({topPosition}) = {area}");
                WriteLine($"MaxArea = {maxArea}");
                WriteLine();
            }

            topHeights.Push(i);

            PrintStack(topHeights, heights);
            
            WriteLine();
        }

        return maxArea;
    }

    private void PrintStack(Stack<int> stack, int[] heights)
    {
        // Write("Stack: ");
        // WriteLine(string.Join(" ", stack.Select(x => (x >= 0 && x < heights.Length) ? $"{heights[x]}" : $"({x})")));
    }

    private void Write(string s = "")
    {
        // Console.Write(s);
    }

    private void WriteLine(string s = "")
    {
        // Console.WriteLine(s);
    }
}
