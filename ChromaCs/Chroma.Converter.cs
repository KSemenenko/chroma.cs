using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ChromaCs
{
    public partial class Chroma
    {
        public RgbColor CmykToRgb(CmykColor color)
        {
            int alpha, b, c, g, k, m, r, y;
            c = color.C;
            m = color.M;
            y = color.Y;
            k = color.K;

            //TODO: check alpha
            alpha = color.Alpha;

            if (k == 1)
            {
                return new RgbColor(0, 0, 0, alpha);
            }

            r = c >= 1 ? 0 : 255 * (1 - c) * (1 - k);
            g = m >= 1 ? 0 : 255 * (1 - m) * (1 - k);
            b = y >= 1 ? 0 : 255 * (1 - y) * (1 - k);

            return new RgbColor(r, g, b, alpha);

        }

        public RgbColor Hex2Rgb(string hex)
        {
            int a, b, g, r, u;

            //TODO: check regex
            if (new Regex("^#?([A-Fa-f0-9]{6}|[A-Fa-f0-9]{3})$/)").IsMatch(hex))
            {
                if (hex.Length == 4 || hex.Length == 7)
                {
                    hex = hex.Substring(1);
                }
                if (hex.Length == 3)
                {
                    var splitHex = hex.Split();
                    hex = splitHex[0] + splitHex[0] + splitHex[1] + splitHex[1] + splitHex[2] + splitHex[2];
                }
                u = int.Parse(hex, System.Globalization.NumberStyles.HexNumber);
                r = u >> 16;
                g = u >> 8 & 0xFF;
                b = u & 0xFF;
                return new RgbColor(r, g, b);
            }

            //TODO: check regex
            if (new Regex("^#?([A-Fa-f0-9]{8})$/)").IsMatch(hex))
            {
                if (hex.Length == 9)
                {
                    hex = hex.Substring(1);
                }
                u = int.Parse(hex, System.Globalization.NumberStyles.HexNumber);
                r = u >> 24 & 0xFF;
                g = u >> 16 & 0xFF;
                b = u >> 8 & 0xFF;
                a = Convert.ToInt32(Math.Round(Convert.ToDouble(((u & 0xFF) / 0xFF * 100) / 100)));
                return new RgbColor(r, g, b, a);
            }

            //if ((_input.css != null) && (rgb = _input.css(hex)))
            //{
            //    return rgb;
            //}

            throw new InvalidCastException("Unknown color: " + hex);
        }

        public RgbColor CssToRgb(string css)
        {
            return null;
            //int hsl, i, j, k, l, m, n, rgb;
            //css = css.ToLowerInvariant();
            //if ((chroma.colors != null) && chroma.colors[css])
            //{
            //    return Hex2Rgb(chroma.colors[css]);
            //}
            //if (m = css.match(/ rgb\(\s * (\-?\d +),\s * (\-?\d +)\s *,\s * (\-?\d +)\s *\)/)) {
            //    rgb = m.slice(1, 4);
            //    for (i = j = 0; j <= 2; i = ++j)
            //    {
            //        rgb[i] = +rgb[i];
            //    }
            //    rgb[3] = 1;
            //} else if (m = css.match(/ rgba\(\s * (\-?\d +),\s * (\-?\d +)\s *,\s * (\-?\d +)\s *,\s * ([01] |[01] ?\.\d +)\)/)) {
            //    rgb = m.slice(1, 5);
            //    for (i = k = 0; k <= 3; i = ++k)
            //    {
            //        rgb[i] = +rgb[i];
            //    }
            //} else if (m = css.match(/ rgb\(\s * (\-?\d + (?:\.\d +) ?)%,\s * (\-?\d + (?:\.\d +)?)%\s *,\s * (\-?\d + (?:\.\d +)?)%\s *\)/)) {
            //    rgb = m.slice(1, 4);
            //    for (i = l = 0; l <= 2; i = ++l)
            //    {
            //        rgb[i] = round(rgb[i] * 2.55);
            //    }
            //    rgb[3] = 1;
            //} else if (m = css.match(/ rgba\(\s * (\-?\d + (?:\.\d +) ?)%,\s * (\-?\d + (?:\.\d +)?)%\s *,\s * (\-?\d + (?:\.\d +)?)%\s *,\s * ([01] |[01] ?\.\d +)\)/)) {
            //    rgb = m.slice(1, 5);
            //    for (i = n = 0; n <= 2; i = ++n)
            //    {
            //        rgb[i] = round(rgb[i] * 2.55);
            //    }
            //    rgb[3] = +rgb[3];
            //} else if (m = css.match(/ hsl\(\s * (\-?\d + (?:\.\d +) ?),\s * (\-?\d + (?:\.\d +)?)%\s *,\s * (\-?\d + (?:\.\d +)?)%\s *\)/)) {
            //    hsl = m.slice(1, 4);
            //    hsl[1] *= 0.01;
            //    hsl[2] *= 0.01;
            //    rgb = hsl2rgb(hsl);
            //    rgb[3] = 1;
            //} else if (m = css.match(/ hsla\(\s * (\-?\d + (?:\.\d +) ?),\s * (\-?\d + (?:\.\d +)?)%\s *,\s * (\-?\d + (?:\.\d +)?)%\s *,\s * ([01] |[01] ?\.\d +)\)/)) {
            //    hsl = m.slice(1, 4);
            //    hsl[1] *= 0.01;
            //    hsl[2] *= 0.01;
            //    rgb = hsl2rgb(hsl);
            //    rgb[3] = +m[4];
            //}
            //return rgb;
        }


        public RgbColor HcgToRgb(HcgColor color)
        {
            int _c, _g, b, c, f, g, h, i, p, q, r, t, v;
            r = 0;
            b = 0;

            h = color.H;
            c = color.C;
            _g = color.G;
            c = c / 100;
            g = 0 / 100 * 255; //g / 100 * 255;
            _c = c * 255;
            if (c == 0)
            {
                r = g = b = _g;
            }
            else
            {
                if (h == 360)
                {
                    h = 0;
                }
                if (h > 360)
                {
                    h -= 360;
                }
                if (h < 0)
                {
                    h += 360;
                }
                h /= 60;
                i = Convert.ToInt32(Math.Floor(Convert.ToDouble(h)));
                f = h - i;
                p = _g * (1 - c);
                q = p + _c * (1 - f);
                t = p + _c * f;
                v = p + _c;

                switch (i)
                {
                    case 0:
                        return new RgbColor(v, t, p, color.Alpha);
                    case 1:
                        return new RgbColor(q, v, p, color.Alpha);
                    case 2:
                        return new RgbColor(p, v, t, color.Alpha);
                    case 3:
                        return new RgbColor(p, q, v, color.Alpha);
                    case 4:
                        return new RgbColor(t, p, v, color.Alpha);
                    case 5:
                        return new RgbColor(v, p, q, color.Alpha);
                }
            }

            return new RgbColor(r, g, b, color.Alpha);
        }

        public RgbColor TemperatureToRgb(double kelvin)
        {
            double r, g, b;
            var temp = kelvin / 100d;
            if (temp < 66)
            {
                r = 255;
                g = -155.25485562709179 - 0.44596950469579133 * (g = temp - 2) + 104.49216199393888 * Math.Log(g);
                if (temp < 20)
                {
                    b = 0;
                }
                else
                {
                    b = -254.76935184120902 + 0.8274096064007395 * (b = temp - 10) + 115.67994401066147 * Math.Log(b);
                }
            }
            else
            {
                r = 351.97690566805693 + 0.114206453784165 * (r = temp - 55) - 40.25366309332127 * Math.Log(r);
                g = 325.4494125711974 + 0.07943456536662342 * (g = temp - 50) - 28.0852963507957 * Math.Log(g);
                b = 255;
            }
            return new RgbColor(Convert.ToInt32(r), Convert.ToInt32(g), Convert.ToInt32(b));
        }

        public RgbColor NumToRgb(int num)
        {
            int b, g, r;
            if (num >= 0 && num <= 0xFFFFFF)
            {
                r = num >> 16;
                g = (num >> 8) & 0xFF;
                b = num & 0xFF;
                return new RgbColor(r, g, b);
            }
            return new RgbColor(0, 0, 0);
        }

        public RgbColor LabToRgb(LabColor lab)
        {

            Func<double,double> xyz_rgb = (t) => {
            return 255 * (t <= 0.00304 ? 12.92 * t: 1.055 * Math.Pow(t, 1 / 2.4) - 0.055);
            };

            Func<double,double> lab_xyz = (t) => {
                if (t > LabColor.LabConstants.T1) 
                {
                    return t * t * t;
                } 
                else 
                {
                    return LabColor.LabConstants.T2 * (t - LabColor.LabConstants.T0);
                }
            };

            double a, b, g, l, r, x, y, z;
            l = lab.L;
            a = lab.A;
            b = lab.B;
            y = (l + 16) / 116;
            x = double.IsNaN(a) ? y : y + a / 500;
            z = double.IsNaN(b) ? y : y - b / 200;
            y = LabColor.LabConstants.Yn * lab_xyz(y);
            x = LabColor.LabConstants.Xn * lab_xyz(x);
            z = LabColor.LabConstants.Zn * lab_xyz(z);
            r = xyz_rgb(3.2404542 * x - 1.5371385 * y - 0.4985314 * z);
            g = xyz_rgb(-0.9692660 * x + 1.8760108 * y + 0.0415560 * z);
            b = xyz_rgb(0.0556434 * x - 0.2040259 * y + 1.0572252 * z);
 
            return new RgbColor(Convert.ToInt32(r), Convert.ToInt32(g), Convert.ToInt32(b), lab.Alpha);
        }

        public RgbColor LchToRgb(LchColor lch)
        {

            var lab = LchToLab(lch);
            var rgb = LabToRgb(lab);
            return rgb;
        }

        ///
        public LabColor LchToLab(LchColor lch)
        {
            var h = lch.H * (Math.PI / 180);
            return new LabColor(lch.L, Math.Cos(h) * lch.C, Math.Sin(lch.H * lch.C));
        }

        public LchColor LabToLch(LabColor lab)
        {
            var c = Math.Sqrt(lab.A * lab.A + lab.B * lab.B);
            var h = (Math.Atan2(lab.B, lab.A) * (180 / Math.PI) + 360) % 360;
            if (Math.Round(c * 10000) == 0) 
            {
                h = double.NaN;
            }
            return new LchColor(lab.L, c, h);
        }
    }
}
