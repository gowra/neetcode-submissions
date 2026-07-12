public class Solution {
    public bool IsValidSudoku(char[][] board) 
    {
        var rowCheck = new bool[9];
        var colCheck = new bool[9];

        for (var i = 0; i < 9; i++)
        {
            Array.Fill(rowCheck, false);
            Array.Fill(colCheck, false);

            for (var j = 0; j < 9; j++)
            {
                if (board[i][j] != '.')
                {
                    var rowIndex = board[i][j] - '0' - 1;
                    if (rowCheck[rowIndex])
                        return false;
                    else
                        rowCheck[rowIndex] = true;
                }

                if (board[j][i] != '.')
                {
                    var colIndex = board[j][i] - '0' - 1;
                    if (colCheck[colIndex])
                        return false;
                    else
                        colCheck[colIndex] = true;
                }
            }
        }

        var boxCheck = new bool[9];

        for (var i = 0; i < 9; i += 3)
        {
            for (var j = 0; j < 9; j += 3)
            {
                Array.Fill(boxCheck, false);
                
                for (var x = 0; x < 3; x++)
                {
                    for (var y = 0; y < 3; y++)
                    {
                        Console.WriteLine($"Checking {x + i}, {y + j} => {board[x + i][y + j]}");
                        var number = board[x + i][y + j];
                        if (number != '.')
                        {
                            var index = number - '0' - 1;
                            if (boxCheck[index])
                                return false;
                            else
                                boxCheck[index] = true;
                        }
                    }
                }
            }
        }

        return true;
    }
}
