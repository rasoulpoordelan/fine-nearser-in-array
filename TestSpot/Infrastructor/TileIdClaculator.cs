using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructor
{
   public  class TileIdClaculator
    {
        public int GenerateTileId(int xSize, int ySize, int xTileSize, int yTileSize, int xCurrent, int yCurrent)
        {
            int colCount = xSize / xTileSize;
            int rowcount = ySize / yTileSize;

            int myCol = xCurrent / xTileSize;
            int myRow = yCurrent / yTileSize;

            int myTile = myRow * rowcount + myCol;

            return myTile;
        }

        public List<int> findNears(int tileId, int xSize, int ySize, int xTileSize, int yTileSize)
        {
            List<int> result = new List<int>();
            int colCount = xSize / xTileSize;
            int rowcount = ySize / yTileSize;

            int myCol = tileId % colCount;
            int myRow = tileId / rowcount;

      
            int startX = myCol-1 <= 0? 0:myCol-1 ;
            int startY = myRow-1 <= 0 ?0 :myRow-1;

            int endX = (myCol + 1 < colCount-1 ? myCol + 1 : colCount-1);
            int endY = (myRow + 1 < rowcount-1 ? myRow + 1 : rowcount-1);

            for (int i = startX; i <= endX; i++)
            {
                for(int j = startY; j <= endY; j++)
                {   
                    int neartile = ((j * rowcount) + i);

                    if (i==2 && j == 2)
                    {
                        String d = "";
                    }

                    if (neartile != tileId)
                    {
                        result.Add(neartile);
                    }
                }
            }

            return result;
        }

    }
}
