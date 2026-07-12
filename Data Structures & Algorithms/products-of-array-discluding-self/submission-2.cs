public class Solution {
    public int[] ProductExceptSelf(int[] nums) 
    {
        var noOfZeroes = 0;
        var totalProduct = 1;
        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 0)
            {
                noOfZeroes++;
                if (noOfZeroes > 1)
                    break;
            }
            else
                totalProduct *= nums[i];
        }

        var product = new int[nums.Length];

        if (noOfZeroes > 1)
            return product;
        else if (noOfZeroes == 1)
        {
            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                    product[i] = totalProduct;
                else
                    product[i] = 0;
            }
        }
        else
        {
            for (var i = 0; i < nums.Length; i++)
            {
                product[i] = totalProduct / nums[i];
            }
        }

        return product;
    }
}
