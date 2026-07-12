public class Solution {
    public bool MergeTriplets(int[][] triplets, int[] target) 
    {
        var preparedTarget = new int[target.Length];

        for (var row = 0; row < triplets.Length; row++)
        {
            if (triplets[row][0] > target[0]
                || triplets[row][1] > target[1]
                || triplets[row][2] > target[2])
                continue;

            var targetAchieved = true;

            for (var column = 0; column < 3; column++)
            {
                preparedTarget[column] = Math.Max(preparedTarget[column], triplets[row][column]);

                if (preparedTarget[column] != target[column])
                    targetAchieved = false;
            }

            if (targetAchieved)
                return true;
        }

        return false;
    }
}