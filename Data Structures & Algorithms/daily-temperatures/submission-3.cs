public class Solution {
    public int[] DailyTemperatures(int[] temperatures) 
    {
        // 30 38 30 36 35 40 28
        //  1  4  1  2  1  0  0
        // as we scan from left to right

        var stack = new Stack<int>();
        var result = new int[temperatures.Length];

        for (var i = 0; i < temperatures.Length; i++)
        {
            if (stack.Count == 0 || temperatures[i] <= temperatures[stack.Peek()])
            {
                stack.Push(i);
            }
            else
            {
                while(stack.Count > 0 && temperatures[stack.Peek()] < temperatures[i])
                {
                    var pos = stack.Pop();
                    result[pos] = i - pos;
                }

                stack.Push(i);
            }
        }

        return result;
    }
}
