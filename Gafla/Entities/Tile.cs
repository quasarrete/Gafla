using System;
using System.Collections.Generic;
using System.Text;

namespace Gafla.Entities
{
    public class Tile
    {
        public Dots EndOne { get; set; }
        public Dots EndTwo { get; set; }

        public override string ToString()
        {
           return $@"|{EndOne}:{EndTwo}|";

        }
    }
}
