public class Solution {
    public bool IsValidSudoku(char[][] board) 
    {
        var rowVisits = new Dictionary<int, HashSet<char>>();
        var colVisits = new Dictionary<int, HashSet<char>>();
        var boxVisits = new Dictionary<string, HashSet<char>>();

        for (var r = 0; r < 9; r++)
        {
            for (var c = 0; c < 9; c++)
            {
                var number = board[r][c];
                if (number == '.')
                    continue;

                if (!rowVisits.ContainsKey(r))
                    rowVisits[r] = new HashSet<char>();

                if (rowVisits[r].Contains(number))
                    return false;
                else
                    rowVisits[r].Add(number);

                if (!colVisits.ContainsKey(c))
                    colVisits[c] = new HashSet<char>();

                if (colVisits[c].Contains(number))
                    return false;
                else
                    colVisits[c].Add(number);
                
                var boxNumber = $"{r / 3},{c / 3}";

                if (!boxVisits.ContainsKey(boxNumber))
                    boxVisits[boxNumber] = new HashSet<char>();

                if (boxVisits[boxNumber].Contains(number))
                    return false;
                else
                    boxVisits[boxNumber].Add(number);
            }
        }

        return true;
    }
}
