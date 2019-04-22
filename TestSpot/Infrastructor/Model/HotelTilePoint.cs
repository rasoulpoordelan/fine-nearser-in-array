using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructor
{
   public  class HotelTilePoint
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Tile { get; set; }

        public HotelTilePoint(int x, int y,int tile)
        {
            this.X = x;
            this.Y = y;
            this.Tile = tile;
        }

        public override string ToString()
        {
            return "hotel: x " + this.X + " y : " +this.Y+" tile :" +this.Tile;
        }
    }
}
