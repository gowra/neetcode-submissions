public class Solution {
    public bool IsValid(string s) 
    {
        var openers = new Dictionary<char, char>();
        openers[')'] = '(';
        openers['}'] = '{';
        openers[']'] = '[';

        var stack = new Stack<char>();
        foreach (char c in s)
        {
            if (c == '(' || c == '{' || c == '[')
            {
                stack.Push(c);
            }

            if (c == ')' || c == '}' || c == ']')
            {
                if (stack.Count == 0 || stack.Peek() != openers[c])
                    return false;

                stack.Pop();
            }
        }

        return stack.Count == 0;    
    }
}
