using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Practice
{
    internal class LC994RottingOranges
    {
        public int OrangesRotting(int[][] grid)
        {
            Queue<List<int>> queue = new Queue<List<int>>();

            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    if (grid[i][j] == 2)
                    {
                        queue.Enqueue(new List<int> { i, j, 0 });
                    }
                }
            }

            int time = 0;

            while (queue.Count > 0)
            {
                List<int> orange = queue.Dequeue();
                int i = orange[0];
                int j = orange[1];
                if (grid[i][j] == 2)
                {
                    time = Math.Max(time, orange[2]);
                    int t = orange[2] + 1;

                    // add 4 adjacent oranges in the queue if they are fresh
                    if (i - 1 > -1 && grid[i - 1][j] == 1)
                    {
                        grid[i - 1][j] = 2;
                        queue.Enqueue(new List<int> { i - 1, j, t });
                    }
                    if (i + 1 < grid.Length && grid[i + 1][j] == 1)
                    {
                        grid[i + 1][j] = 2;
                        queue.Enqueue(new List<int> { i + 1, j, t });
                    }
                    if (j - 1 > -1 && grid[i][j - 1] == 1)
                    {
                        grid[i][j - 1] = 2;
                        queue.Enqueue(new List<int> { i, j - 1, t });
                    }
                    if (j + 1 < grid[0].Length && grid[i][j + 1] == 1)
                    {
                        grid[i][j + 1] = 2;
                        queue.Enqueue(new List<int> { i, j + 1, t });
                    }
                }
            }

            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        return -1;
                    }
                }
            }

            return time;
        }
    }
}
