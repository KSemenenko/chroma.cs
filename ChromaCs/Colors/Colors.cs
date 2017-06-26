using System;
using System.Collections.Generic;
using System.Text;

namespace ChromaCs
{
    public class RgbColor
    {
        public RgbColor() {}

        public RgbColor(int r, int g, int b, int a = 1)
        {
            A = a;
            R = r;
            G = g;
            B = b;
        }

        public int A { get; set; }
        public int R { get; set; }
        public int G { get; set; }
        public int B { get; set; }
    }

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
