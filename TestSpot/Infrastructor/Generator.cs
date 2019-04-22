using Infrastructor.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructor
{
     public class Generator
    {
        private static readonly Random rnd = new Random();


        public Dictionary<int, List<HotelTilePoint>> Generate(int xSize, int ySize, int xTileSize, int yTileSize, int hc)
        {
            List<HotelTilePoint> mySpace = GenerateSpaceSec(xSize, ySize, xTileSize, yTileSize, hc);
            var data = MapToDicById(mySpace);

            return data;
        }

        public List<HotelTilePoint> GenerateSpaceSec(int xSize, int ySize,int xTileSize,int yTileSize, int hc)
        {
            List<HotelTilePoint> result = new List<HotelTilePoint>();

            TileIdClaculator tileIdGenerator = new TileIdClaculator();

            int addCount = 0;
            while (addCount < hc)
            {

                int x = rnd.Next(0, xSize);
                int y = rnd.Next(0, ySize);
                if (!result.Any(item => item.X == x && item.Y == y ))
                {
                    result.Add(new HotelTilePoint(x,y,tileIdGenerator.GenerateTileId(xSize, ySize, xTileSize, yTileSize, x, y)));
                    addCount++;
                }
            }

            return result;
        }

       


        public Dictionary<int, List<HotelTilePoint>> MapToDicById(List<HotelTilePoint> hotelTilePoints)
        {
            Dictionary<int, List<HotelTilePoint>> result = new Dictionary<int, List<HotelTilePoint>>();

            foreach (HotelTilePoint p in hotelTilePoints)
            {
                if (result.ContainsKey(p.Tile))
                {
                    result[p.Tile].Add(p);
                }
                else
                {
                    List<HotelTilePoint> newList = new List<HotelTilePoint>();
                    newList.Add(p);
                    result.Add(p.Tile, newList);
                }  
            }

            return result;

        }

    }
}
