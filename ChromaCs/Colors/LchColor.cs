using System;
using System.Collections.Generic;
using System.Text;

namespace ChromaCs
{
    public class LchColor
    {
        public LchColor() { }

        public LchColor(double lightness, double chroma, double hue, int alpha = 1) //TODO: Check alpha
        {
            L = lightness;
            C = chroma;
            H = hue;
            Alpha = alpha;
        }

        public double L { get; set; }
        public double C { get; set; }
        public double H { get; set; }
        public int Alpha { get; set; }
    }
}
