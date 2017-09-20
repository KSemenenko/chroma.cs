using System;
using System.Collections.Generic;
using System.Text;

namespace ChromaCs
{
    public class LabColor
    {
        public LabColor() { }
        public LabColor(double lightness, double a, double b, int alpha = 1)
        {
            L = lightness;
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
}
