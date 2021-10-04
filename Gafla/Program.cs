using Gafla.Entities;
using System;
using System.Collections.Generic;

namespace Gafla
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateSet();
        }

        private static void CreateSet()
        {
            var set = new TileSet();
            set.ShuffleSet();

            Console.WriteLine("There are {0} tiles in this set",set.Tiles.Count);

            foreach(var data in set.Tiles)
            {
                Console.WriteLine(data.ToString());
            }

        }

    }
}
