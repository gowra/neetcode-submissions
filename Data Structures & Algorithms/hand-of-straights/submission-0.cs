public class Solution {
    public bool IsNStraightHand(int[] hand, int groupSize) 
    {
        if (hand.Length % groupSize != 0)
            return false;

        // sort the array
        // go through each index
        // if the number is next to the first group, add to it
        // else check if this can be added to any group
        // if not, return false

        // 1,2,4,2,3,5,3,4
        // 1,2,2,3,3,4,4,5

        // 1,2,3,4
        // 2,3,4,5

        // 1,2,3,3,4,5,6,7

        // 1,2,3,4
        // 3
        // 5,6,7

        Array.Sort(hand);

        Console.WriteLine(string.Join(",", hand));
        var maxGroups = hand.Length / groupSize;

        var groups = new Stack<int>[maxGroups];
        
        for (var h = 0; h < hand.Length; h++)
        {
            Stack<int> group = null;
            for (var i = 0; i < maxGroups; i++)
            {
                Console.WriteLine($"Checking group {i} for {hand[h]}");
                if (groups[i] == null)
                {
                    Console.WriteLine("Null selection");
                    group = groups[i] = new Stack<int>(groupSize);
                    break;
                }
                else if (groups[i].Count != groupSize && (groups[i].Count == 0 || groups[i].Peek() == hand[h] - 1))
                {
                    Console.WriteLine("Empty or valid selection");
                    group = groups[i];
                    break;
                }
            }

            if (group == null)
                return false;

            group.Push(hand[h]);
            Console.WriteLine(string.Join(",", group));
        }

        return true;
    }
}
