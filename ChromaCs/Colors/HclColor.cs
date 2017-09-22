using System;
using System.Collections.Generic;
using System.Text;

namespace ChromaCs
{
    public class HclColor
    {
        public HclColor() { }

        public HclColor(double hue, double chroma, double lightness, int alpha = 1) //TODO: Check alpha
        {
            H = hue;
            C = chroma;
            L = lightness;
            Alpha = alpha;
        }

        public double H { get; set; }
        public double C { get; set; }
        public double L { get; set; }
        public int Alpha { get; set; }
    }
}
