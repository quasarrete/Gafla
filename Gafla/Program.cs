using Gafla.Entities;
using System;
using System.Collections.Generic;

namespace Gafla
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            CreateSet();
        }

        private static void CreateSet()
        {
            var set = new List<Tile>();

            foreach(var data in set)
            {
                Console.WriteLine(data.ToString());
            }

        }

        private static IList<Tile> CreateTileSet()
        {
            var tileSet = new List<Tile>();

            return tileSet;
        }
    }
}
