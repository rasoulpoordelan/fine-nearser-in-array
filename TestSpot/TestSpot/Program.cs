using Infrastructor;
using Infrastructor.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSpot
{
    class Program
    {
        static void Main(string[] args)
        {
            Generator gen = new Generator();
            Finder finder = new Finder();
            //---- problem space
            int x = 6;
             int y = 6;
             int hc = 35;
             int xTileSize = 2;
             int yTileSize = 2;
             int n = 2;

             int myX = 2;
             int myY = 4;


           /* int x = 100;
            int y = 100;
            int hc = 5000;
            int xTileSize = 5;
            int yTileSize = 5;
            int n = 20;

            int myX = 40;
            int myY = 25;*/

            //-------------------

            var data = gen.Generate(x, y, xTileSize, yTileSize, hc);

            List<HotelTilePoint> result = finder.Find(myX, myY, n, x, y, xTileSize, yTileSize, data);


            Console.WriteLine($" my current x {myX} my current y {myY} ");

            foreach (HotelTilePoint t in result)
            {
                Console.WriteLine(t);
            }

            /*  TileIdClaculator t = new TileIdClaculator();

             List<int> nears= t.findNears(0, x, y, xTileSize, yTileSize);
              nears.Sort();
              foreach (int near in nears)
              {
                  Console.WriteLine(near);
              }
              */

            // Console.WriteLine(i);

            Console.ReadKey();
        }
    }
}
