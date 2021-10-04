using Gafla.Entities;
using System.Collections.Generic;

namespace Gafla.PlayerEntities
{
    public class Player
    {
        public string Name { get; set; }
        public int Points { get; set; }
        public List<Tile> PlayerHand { get; set; }
    }
}
