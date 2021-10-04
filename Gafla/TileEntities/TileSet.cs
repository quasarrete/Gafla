using Gafla.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Gafla.TileEntities
{
    public class TileSet
    {
        public Stack<Tile> Tiles { get; set; }
        private static readonly Random rng = new Random();
        public TileSet()
        {
            Tiles = new Stack<Tile>();
            CreateSet();
        }

        private void CreateSet()
        {
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    var tile = new Tile
                    {
                        EndOne = (Dots)i,
                        EndTwo = (Dots)j
                    };
                    if (!SetHasDuplicates(tile))
                    {
                        Tiles.Push(tile);
                    }
                }
            }

        }

        private bool SetHasDuplicates(Tile newTile)
        {
            var endOne = newTile.EndOne;
            var endTwo = newTile.EndTwo;
            foreach (var _ in Tiles.Where(tile => tile.EndOne == endOne && tile.EndTwo == endTwo || tile.EndOne == endTwo && tile.EndTwo == tile.EndOne).Select(tile => new { }))
            {
                return true;
            }

            return false;
        }
        public void ShuffleSet()
        {
            var stackAsList = Tiles.ToList();
            var listShuffled = stackAsList.OrderBy(a => rng.Next()).ToList();
            Tiles = new Stack<Tile>(listShuffled);
        }

    }

}
