using System;
using System.Collections.Generic;
using System.Text;

namespace ChromaCs
{
    public class Color 
    {
        public Color()
        {
            
        }

        public Color(int r, int g, int b, int a = 1)
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

        public override string ToString()
        {
            return Chroma.RgbToHex(this);
        }

        public Color Alpha(float a)
        {
            return null;
        }

        public float Alpha()
        {
            return 0f;
        }

        public Color Darken(float value = 1)
        {
            return null;
        }

        public Color Brighten(float value = 1)
        {
            return null;
        }

        public Color Saturate(float value = 1)
        {
            return null;
        }

        public Color Desaturate(float value = 1)
        {
            return null;
        }

        public Color Set(string channel, float value)
        {
            return null;
        }

        public float Get(string channel)
        {
            return 0f;
        }

        public float Luminance(float lum, ColorMode mode = ColorMode.Rgb)
        {
            return 0f;
        }

        public string Hex()
        {
            return Chroma.RgbToHex(this); 
        }

        public string Name()
        {
            return null;
        }

        public string Rgb(bool round = true)
        {
            return null;
        }

        public string Rgba(bool round = true)
        {
            return null;
        }

        public HslColor Hsl()
        {
            return null;
        }

        public HsvColor Hsv()
        {
            return null;
        }

        public HsiColor Hsi()
        {
            return null;
        }

        public LabColor Lab()
        {
            return null;
        }

        public LchColor Lch()
        {
            return null;
        }

        //?
        public LchColor Hcl()
        {
            return null;
        }

        public int Temperature()
        {
            return -1;
        }

        public int Gl()
        {
            return -1;
        }

        public int Clipped()
        {
            return -1;
        }
    }
}
