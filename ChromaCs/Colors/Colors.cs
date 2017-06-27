using System;
using System.Collections.Generic;
using System.Text;

namespace ChromaCs
{
    public class RgbColor
    {
        public RgbColor() { }

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

    public class LabColor
    {
        public LabColor() { }
        public LabColor(double l, double a, double b, int alpha = 1)
        {
            L = l;
            A = a;
            B = b;
            Alpha = alpha;
        }

        public int Alpha { get; set; }
        public double L { get; set; }
        public double A { get; set; }
        public double B { get; set; }

        public static class LabConstants
        {
            //Corresponds roughly to RGB brighter/darker
            public const int Kn = 18;

            // D65 standard referent
            public const double Xn = 0.950470;
            public const double Yn = 1;
            public const double Zn = 1.088830;
            public const double T0 = 0.137931034;  // 4 / 29
            public const double T1 = 0.206896552;  // 6 / 29
            public const double T2 = 0.12841855;   // 3 * t1 * t1
            public const double T3 = 0.008856452;  // t1 * t1 * t1
        }
    }

    public class LchColor
    {
        public LchColor() { }

        public LchColor(double l, double c, double h, int alpha = 1) //TODO: Check alpha
        {
            L = l;
            C = c;
            H = h;
            Alpha = alpha;
        }

        public double L { get; set; }
        public double C { get; set; }
        public double H { get; set; }
        public int Alpha { get; set; }
    }

    public class HslColor
    {
        public HslColor() { }

        public HslColor(double h, double s, double l, int alpha = 1) //TODO: Check alpha
        {
            H = h;
            S = s;
            L = l;
            Alpha = alpha;
        }

        public double H { get; set; }
        public double S { get; set; }
        public double L { get; set; }
        public int Alpha { get; set; }
    }

    public class HsvColor
    {
        public HsvColor() { }

        public HsvColor(double h, double s, double v, int alpha = 1) //TODO: Check alpha
        {
            H = h;
            S = s;
            V = v;
            Alpha = alpha;
        }

        public double H { get; set; }
        public double S { get; set; }
        public double V { get; set; }
        public int Alpha { get; set; }
    }

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
