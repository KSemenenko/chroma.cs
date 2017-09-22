using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ChromaCs
{
    public partial class Chroma
    {
        //http://gka.github.io/chroma.js/

        #region Color

        public static Color Color(string color)
        {
            if(color.Contains("#"))
            {
                return Hex2Rgb(color);
            }
            return CssToRgb(color);
        }

        public static Color Color(int color)
        {
            return NumToRgb(color);
        }

        public static Color Color(int r, int g, int b, ColorMode mode = ColorMode.Rgb)
        {
            return new Color(r, g, b);
        }

        public static Color Color(float r, float g, float b, ColorMode mode = ColorMode.Rgb)
        {
            return null;
        }

        public static Color Color(int r, int g, int b, int a, ColorMode mode = ColorMode.Rgb)
        {
            return new Color(r, g, b, a);
        }

        public static Color Color(float r, float g, float b, float a, ColorMode mode = ColorMode.Rgb)
        {
            return null;
        }

        public static HslColor Hsl(double hue, double saturation, double lightness, int alpha = 1)
        {
            return new HslColor(hue, saturation, lightness, alpha);
        }

        public static HsvColor Hsv(double hue, double saturation, double value, int alpha = 1)
        {
            return new HsvColor(hue, saturation, value, alpha);
        }

        public static LabColor Lab(double lightness, double a, double b, int alpha = 1)
        {
            return new LabColor(lightness, a, b, alpha);
        }

        //The range for lightness and chroma depend on the hue, but go roughly from 0..100-150. The range for hue is 0..360.
        public static LchColor Lch(double lightness, double chroma, double hue)
        {
            return new LchColor(lightness, chroma, hue);
        }

        public static HclColor Hcl(double hue, double chroma, double lightness)
        {
            return new HclColor(hue, chroma, lightness);
        }

        public static CmykColor Cmyk(float cyan, float magenta, float yellow, float black)
        {
            return new CmykColor(cyan, magenta, yellow, black);
        }

        public static Color Gl(float red, float green, float blue, float alpha = 0f)
        {
            return null;
        }

        public static Color Temperature(int k)
        {
            return TemperatureToRgb(k);
        }

        public static Color Mix(Color color1, Color color2, float ratio = 0.5f, ColorMode mode = ColorMode.Rgb)
        {
            return null;
        }

        public static Color Average(string mode, params Color[] colors)
        {
            return null;
        }

        public static Color Blend(Color color1, Color color2, string mode)
        {
            return null;
        }

        public static Color Random()
        {
            var rnd = new Random(Environment.TickCount);
            var digits = "0123456789abcdef";
            var code = "#";
            for (int i = 0; i <= 6; i++)
            {
                code += digits[rnd.Next(0, 15)];
            }
            return Hex2Rgb(code);
        }

        public static Color Contrast(Color color1, Color color2)
        {
            return null;
        }

        public static Color Distance(Color color1, Color color2, ColorMode mode = ColorMode.Lab)
        {
            return null;
        }

        public static Color DeltaE(string reference, string sample, int l = 1, int c = 1)
        {
            return null;
        }

        #endregion

        #region Scale

        public Scale Scale(params Color[] colors)
        {
            return null;
        }

        public Scale Scale(params string[] colors)
        {
            return null;
        }

        #endregion

        #region Bezier

        public Color Bezier(params Color[] colors)
        {
            return null;
        }

        public Color Bezier(params string[] colors)
        {
            return null;
        }

        #endregion

        public ColorBrewer Brewer()
        {
            return new ColorBrewer();
        }

        public int[] Limits(int[] data, string mode, int n)
        {
            return null;
        }

        public Cubehelix Cubehelix(int start, float rotations, int hue, int gamma, int[] lightness)
        {
            return null;
        }
    }
}