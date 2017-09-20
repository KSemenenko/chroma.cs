using System;
using System.Collections.Generic;
using System.Text;

namespace ChromaCs
{
    public class CmykColor
    {
        public CmykColor() { }

        public CmykColor(int c, int m, int y, int k, int alpha = 1) //TODO: Check alpha
        {
            C = c;
            M = m;
            Y = y;
            K = k;
            Alpha = alpha;
        }

        public int C { get; set; }
        public int M { get; set; }
        public int Y { get; set; }
        public int K { get; set; }
        public int Alpha { get; set; }
    }
}
