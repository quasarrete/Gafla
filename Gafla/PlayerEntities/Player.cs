using Gafla.Entities;
using Gafla.Rules;
using System.Collections.Generic;

namespace Gafla.PlayerEntities
{
    public class Player
    {
        public string Name { get; set; }
        public int Points { get; set; }
        public List<Tile> PlayerHand { get; set; }
        public TileCount TileCount { get; set; }

        public Player()
        {
            PlayerHand = new List<Tile>();
            TileCount = new TileCount();
        }
        public Tile PlayTile(int index)
        {
            var tile = PlayerHand[index];
            AdjustTileCount(tile.EndOne, false);
            AdjustTileCount(tile.EndTwo, false);
            PlayerHand.RemoveAt(index);
            return tile;
        }

        public void AddTile(Tile tile) 
        {
            AdjustTileCount(tile.EndOne);
            AdjustTileCount(tile.EndTwo);
            PlayerHand.Add(tile);
        }
        public void AdjustTileCount(Dots dot, bool doAdd = true)
        {
            var count = 1;
            if (!doAdd)
            {
                count *=-1;
            }
            switch (dot)
            {
                case Dots.Zero:
                    TileCount.ZERO_COUNT += count;
                    break;
                case Dots.One:
                    TileCount.ONE_COUNT += count;
                    break;
                case Dots.Two:
                    TileCount.TWO_COUNT += count;
                    break;
                case Dots.Three:
                    TileCount.THREE_COUNT += count;
                    break;
                case Dots.Four:
                    TileCount.FOUR_COUNT += count;
                    break;
                case Dots.Five:
                    TileCount.FIVE_COUNT += count;
                    break;
                case Dots.Six:
                    TileCount.SIX_COUNT += count;
                    break;
            }
        }

        public void TallyPoints()
        {
            var points = 0;
            foreach(var tileDots in PlayerHand)
            {
                points += (int)tileDots.EndOne + (int)tileDots.EndTwo;
            }
            Points += points;
        }
    }
}