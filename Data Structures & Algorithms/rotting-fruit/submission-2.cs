public class Solution {
    public int OrangesRotting(int[][] grid) 
    {
        var fresh = 0;
        var time = 0;

        // rotten positions
        var rotten = new Queue<int[]>();

        for (var r = 0; r < grid.Length; r++)
        {
            for (var c = 0; c < grid[0].Length; c++)
            {
                if (grid[r][c] == 1)
                    fresh++;

                if (grid[r][c] == 2)
                    rotten.Enqueue(new[] {r, c});
            }
        }

        int[][] directions = 
        {
            new[]{-1, 0},
            new[]{0, 1},
            new[]{1, 0},
            new[]{0, -1}
        };

        while(fresh > 0 && rotten.Count > 0)
        {
            int length = rotten.Count;

            for (int i = 0; i < length; i++)
            {
                var pos = rotten.Dequeue();

                foreach(var dir in directions)
                {
                    var row = pos[0] + dir[0];
                    var col = pos[1] + dir[1];

                    if (row >= 0 && col >= 0
                        && row < grid.Length && col < grid[0].Length)
                    {
                        if (grid[row][col] == 1)
                        {
                            grid[row][col] = 2;
                            fresh--;
                            rotten.Enqueue(new[] { row, col });
                        } 
                    }
                }
            }

            time++;
        }

        return fresh == 0 ? time : -1;
    }
}
