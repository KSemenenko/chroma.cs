using System;
using System.Collections.Generic;
using System.Text;

namespace ChromaCs
{
    public class HslColor
    {
        public HslColor() { }

        public HslColor(double hue, double saturation, double lightness, int alpha = 1) //TODO: Check alpha
        {
            H = hue;
            S = saturation;
            L = lightness;
            Alpha = alpha;
        }

        public double H { get; set; }
        public double S { get; set; }
        public double L { get; set; }
        public int Alpha { get; set; }
    }
}
