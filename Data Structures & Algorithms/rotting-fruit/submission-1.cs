public class Solution {
    public int OrangesRotting(int[][] grid) 
    {
        // first we need to loop through the grid and 
        // record fresh and rotten oranges
        // we put all rotten into queue and keep count of fresh
        // each iteration takes time 1

        // at each time, we check all neighbours of the queue
        // if it is fresh, mark it as rotten, decreemnt fresh and add them to queue

        // we repeat this until fresh is 0 and queue has oranges

        //  [1,1,0]
        //  [0,1,1]
        //  [0,1,2]

        // 

        var fresh = 0;
        var time = 0;

        var rottenQ = new Queue<int[]>();

        for (var r = 0; r < grid.Length; r++)
        {
            for (var c = 0; c < grid[0].Length; c++)
            {
                if (grid[r][c] == 1)
                    fresh++;

                if (grid[r][c] == 2)
                    rottenQ.Enqueue(new[] { r, c });
            }
        }

        var directions = new int[][]
        {
            new[]{-1, 0},
            new[]{ 0, 1},
            new[]{ 1, 0},
            new[]{ 0,-1}
        };

                
        while (fresh > 0 && rottenQ.Count > 0)
        {
            var length = rottenQ.Count;
            for (int i = 0; i < length; i++)
            {
                var pos = rottenQ.Dequeue();
                var r = pos[0];
                var c = pos[1];

                foreach (var dir in directions)
                {
                    var row = r + dir[0];
                    if (row < 0 || row >= grid.Length)
                        continue;

                    var col = c + dir[1];                    
                    if (col < 0|| col >= grid[0].Length)
                        continue;

                    if (grid[row][col] == 1)
                    {
                        grid[row][col] = 2;
                        fresh--;
                        rottenQ.Enqueue(new [] { row, col });
                    }
                }
            }

            time++;
        }

        return fresh == 0 ? time : -1;
    }
}
