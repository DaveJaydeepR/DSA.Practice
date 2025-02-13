using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Practice
{
    internal class LC286aWallAndGates
    {
        //For Test This ins I/P and  expected O/P
        //int inf = 2147483647;
        //int[][] ip = [[inf, -1, 0, inf], [inf, inf, inf, -1], [inf, -1, inf, -1], [0, -1, inf, inf]];

        //int[][] op = [[3, -1, 0, 1], [2, 2, 1, -1], [1, -1, 2, -1], [0, -1, 3, 4]];

        int wall = -1;
        int Gate = 0;
        int empty = 2147483647;
        int[][] direction = [[-1, 0],[0, 1],[1, 0],[0, -1]];

        public int[][] WallAndGates(int[][] rooms)
        {
            
            for (int i = 0; i < rooms.Length; i++)
            {
                for(int j = 0; j < rooms[i].Length; j++)
                {
                    if (rooms[i][j] == Gate)
                    {
                        DFS(rooms, i, j, 0);
                    }
                }
            }

            return rooms;
        }

        private void DFS(int[][] rooms,int row, int col,int currentPosition) 
        { 
        
            if(row < 0|| row >= rooms.Length|| col < 0|| col >= rooms[0].Length|| currentPosition > rooms[row][col])
            {
                return;
            }
            rooms[row][col] = currentPosition;
            for (int i = 0; i < direction.Length; i++)
            {
                int[] currentDir = direction[i];
                DFS(rooms,row + currentDir[0], col + currentDir[1], currentPosition+1);
            }

        }
    }
}
