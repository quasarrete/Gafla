using System;
using System.Collections.Generic;
using System.Text;

namespace Gafla.Entities
{
    public class TileSet
    {
        public List<Tile> Tiles{ get; set; }
        public TileSet()
        {

        }

        private static void CreateSet()
        {
            //Will go from 0 to 6, for now will have 36 tile, will need to implement check to remove duplicates.
            for(int i=0; i<6; i++)
            {
                for(int j=0; j<6; j++)
                {
                    var tile = new Tile
                    {
                        endOne = (Dots)i,
                        endTwo = (Dots)j
                    };
                }
            }
           
        }

        private bool CheckDuplicates(Tile oldTile, Tile newTile)
        {

            return false;
        }
    }
}
