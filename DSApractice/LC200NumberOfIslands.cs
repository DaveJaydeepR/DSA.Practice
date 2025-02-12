using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Practice
{
    internal class LC200NumberOfIslands
    {
        public int NumIslands(char[][] grid)
        {

            var islands = 0;

            //traverse the grid one by one
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    //if grid value is '1', increment the count, and do DFS on the adjacent 4 cells
                    if (grid[i][j] == '1')
                    {
                        DFS(grid, i, j);
                        islands++;
                    }
                }
            }
            //return the island count
            return islands;
        }

        private void DFS(char[][] grid, int i, int j)
        {
            //include the cases where the traversal should be stopped
            if (i < 0 || i >= grid.Length || j < 0 || j >= grid[0].Length || grid[i][j] == '0')
            {
                return;
            }

            //mark the element as visited, so that if it visited again due to DFS we won't take it to account
            grid[i][j] = '0';

            //DFS for up element
            DFS(grid, i - 1, j);
            //DFS for down element
            DFS(grid, i + 1, j);
            //DFS for left element
            DFS(grid, i, j - 1);
            //DFS for right element
            DFS(grid, i, j + 1);
        }
    }
}
