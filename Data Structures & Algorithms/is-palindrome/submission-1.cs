public class Solution {
    public bool IsPalindrome(string s) 
    {
        var left = 0;
        var right = s.Length - 1;

        while (left <= right)
        {
            while (left < s.Length && !char.IsLetterOrDigit(s[left]))
                left++;

            while (right >= 0 && !char.IsLetterOrDigit(s[right]))
                right--;

            if (left == s.Length || right == -1)
                return true;

            if (char.ToLower(s[left]) != char.ToLower(s[right]))
                return false;
            
            left++;
            right--;
        }

        return true;
    }
}
