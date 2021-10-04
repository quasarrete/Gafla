using Gafla.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gafla.Rules
{
    public class Board
    {
        public TileCount TileCount { get; set; }
        public LinkedList<Tile> BoardTile { get; set; }
    }
}
