using System;
using System.Collections.Generic;
using System.Text;

namespace ChromaCs
{
    public class CmykColor
    {
        public CmykColor() { }

        public CmykColor(float cyan, float magenta, float yellow, float black, int alpha = 1) //TODO: Check alpha
        {
            C = cyan;
            M = magenta;
            Y = yellow;
            K = black;
            Alpha = alpha;
        }

        public float C { get; set; }
        public float M { get; set; }
        public float Y { get; set; }
        public float K { get; set; }
        public int Alpha { get; set; }
    }
}
