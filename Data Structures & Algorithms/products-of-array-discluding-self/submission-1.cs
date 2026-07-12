public class Solution {
    public int[] ProductExceptSelf(int[] nums) 
    {
        var product = new int[nums.Length];

        for (var i = 0; i < nums.Length; i++)
        {
            product[i] = 1;
            for (var j = 0; j < nums.Length; j++)
            {
                if (i != j)
                    product[i] *= nums[j];
            }
        }   

        return product;
    }
}
