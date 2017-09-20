using System;
using System.Collections.Generic;
using System.Text;

namespace ChromaCs
{
    public class HsvColor
    {
        public HsvColor() { }

        public HsvColor(double hue, double saturation, double value, int alpha = 1) //TODO: Check alpha
        {
            H = hue;
            S = saturation;
            V = value;
            Alpha = alpha;
        }

        public double H { get; set; }
        public double S { get; set; }
        public double V { get; set; }
        public int Alpha { get; set; }
    }
}
