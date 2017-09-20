using System;
using System.Collections.Generic;
using System.Text;

namespace ChromaCs
{
    public class HcgColor
    {
        public HcgColor() { }

        public HcgColor(int h, int c, int g, int alpha = 1) //TODO: Check alpha
        {
            H = h;
            C = c;
            G = g;
            Alpha = alpha;
        }

        public int H { get; set; }
        public int C { get; set; }
        public int G { get; set; }
        public int Alpha { get; set; }
    }
}
