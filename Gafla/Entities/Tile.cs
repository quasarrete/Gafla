using System;
using System.Collections.Generic;
using System.Text;

namespace Gafla.Entities
{
    public class Tile
    {
        public Dots endOne { get; set; }
        public Dots endTwo { get; set; }

        public override string ToString()
        {
            var displayText = "";
            displayText += endOne;
            displayText += "\n";
            displayText += endTwo;
            return displayText;

        }
    }
}
