using System;
using System.Collections.Generic;
using System.Text;

namespace ChromaCs
{
    public class HsiColor
    {
        public HsiColor() { }

        public HsiColor(double h, double s, double i, int alpha = 1) //TODO: Check alpha
        {
            H = h;
            S = s;
            I = i;
            Alpha = alpha;
        }

        public double H { get; set; }
        public double S { get; set; }
        public double I { get; set; }
        public int Alpha { get; set; }
    }
}
