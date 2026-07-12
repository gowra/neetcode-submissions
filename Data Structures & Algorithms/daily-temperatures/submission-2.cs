public class Solution {
    public int[] DailyTemperatures(int[] temperatures)
    {
        var n = temperatures.Length;
        var result = new int[n];

        for (var i = 0; i < n; i++)
        {
            var current = temperatures[i];

            var streak = 0;
            var j = i + 1;
            while (j < n)
            {
                if (temperatures[j] <= current)
                {
                    streak += 1;
                }
                else
                {
                    //we need to include the cut off position as well
                    result[i] = streak + 1;
                    break;
                }

                j++;
            }
        }    

        return result;
    }
}
