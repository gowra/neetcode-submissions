public class Solution {
    public bool MergeTriplets(int[][] triplets, int[] target) 
    {
        var preparedTarget = new int[target.Length];

        for (var row = 0; row < triplets.Length; row++)
        {
            if (!IsLessThanOrEqualTo(triplets[row], target))
                continue;

            preparedTarget = Merge(preparedTarget, triplets[row]);

            if (AreEqual(preparedTarget, target))
                return true;
        }

        return false;
    }

    private bool IsLessThanOrEqualTo(int[] source, int[] target)
    {
        if (source.Length != target.Length)
            return false;

        for (var i = 0; i < source.Length; i++)
        {
            if (source[i] > target[i])
                return false;
        }

        return true;
    }

    private int[] Merge(int[] left, int[] right)
    {
        if (left.Length != right.Length)
            return new int[0];

        var result = new int[left.Length];

        for (var i= 0; i < left.Length; i++)
        {
            result[i] = Math.Max(left[i], right[i]);
        }

        return result;
    }

    private bool AreEqual(int[] left, int[] right)
    {
        if (left.Length != right.Length)
            return false;

        for (var i = 0; i < left.Length; i++)
        {
            if (left[i] != right[i])
                return false;
        }

        return true;
    }
}
