public class Solution {
    public int OrangesRotting(int[][] grid) 
    {
        Queue<int[]> q = new Queue<int[]>();
        int fresh = 0;
        int time = 0;

        for (int r = 0; r < grid.Length; r++)
        {
            for (int c = 0; c < grid[0].Length; c++)
            {
                if (grid[r][c] == 1)
                    fresh++;

                if (grid[r][c] == 2)
                {
                    q.Enqueue(new int[] { r, c });
                }
            }
        }

        int[][] directions = 
        {
            new[] {0, 1},
            new[] {0, -1},
            new[] {1, 0},
            new[] {-1,0}
        };

        while (fresh > 0 && q.Count > 0)
        {
            int length = q.Count;
            for (var i = 0; i < length; i++)
            {
                int[] curr = q.Dequeue();
                int r = curr[0];
                int c = curr[1];

                foreach (var dir in directions)
                {
                    var row = r + dir[0];
                    var col = c + dir[1];

                    if (row >= 0 && row < grid.Length 
                        && col >= 0 && col < grid[0].Length)
                    {
                        if (grid[row][col] == 1)
                        {
                            grid[row][col] = 2;
                            q.Enqueue(new int[] { row, col });

                            fresh--;
                        }
                    }
                }
            }

            time++;
        }

        return fresh == 0 ? time : -1;

        // first pass is to do a 2d traversal 
        // to collect all the good and rotten oranges at time 0

        // then do a BFS for all of these at same time
        // now at time 1, new oranges found

        // we need to continue this until there is no neighbour orange

        // if there is a good orange remaining, then return -1
        // else returnt the stored time
    }
}
