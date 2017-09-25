using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ChromaCs
{
    public partial class Chroma
    {
        //In

        internal static Color CmykToRgb(CmykColor color)
        {
            //TODO: Fix it, int is not correct
            int alpha, b, c, g, k, m, r, y;
            c = (int)color.C;
            m = (int)color.M;
            y = (int)color.Y;
            k = (int)color.K;

            //TODO: check alpha
            alpha = color.Alpha;

            if (k == 1)
            {
                return new Color(0, 0, 0, alpha);
            }

            r = c >= 1 ? 0 : 255 * (1 - c) * (1 - k);
            g = m >= 1 ? 0 : 255 * (1 - m) * (1 - k);
            b = y >= 1 ? 0 : 255 * (1 - y) * (1 - k);

            return new Color(r, g, b, alpha);

        }

        internal static Color CssToRgb(string css)
        {

            int hsl, i, j, k, l, m, n, rgb;
            css = css.ToLowerInvariant();


            // if ((chroma.colors != null) && chroma.colors[css])
            // {
            //    return Hex2Rgb(chroma.colors[css]);
            // }

            //if (m = Regex.Match(/rgb\(\s*(\-?\d+),\s*(\-?\d+)\s*,\s*(\-?\d+)\s*\)/)) {
            //  rgb = m.slice(1, 4);
            //  for (i = j = 0; j <= 2; i = ++j) {
            //    rgb[i] = +rgb[i];
            //  }
            //  rgb[3] = 1;
            //} else if (m = css.match(/rgba\(\s*(\-?\d+),\s*(\-?\d+)\s*,\s*(\-?\d+)\s*,\s*([01]|[01]?\.\d+)\)/)) {
            //  rgb = m.slice(1, 5);
            //  for (i = k = 0; k <= 3; i = ++k) {
            //    rgb[i] = +rgb[i];
            //  }
            //} else if (m = css.match(/rgb\(\s*(\-?\d+(?:\.\d+)?)%,\s*(\-?\d+(?:\.\d+)?)%\s*,\s*(\-?\d+(?:\.\d+)?)%\s*\)/)) {
            //  rgb = m.slice(1, 4);
            //  for (i = l = 0; l <= 2; i = ++l) {
            //    rgb[i] = round(rgb[i] * 2.55);
            //  }
            //  rgb[3] = 1;
            //} else if (m = css.match(/rgba\(\s*(\-?\d+(?:\.\d+)?)%,\s*(\-?\d+(?:\.\d+)?)%\s*,\s*(\-?\d+(?:\.\d+)?)%\s*,\s*([01]|[01]?\.\d+)\)/)) {
            //  rgb = m.slice(1, 5);
            //  for (i = n = 0; n <= 2; i = ++n) {
            //    rgb[i] = round(rgb[i] * 2.55);
            //  }
            //  rgb[3] = +rgb[3];
            //} else if (m = css.match(/hsl\(\s*(\-?\d+(?:\.\d+)?),\s*(\-?\d+(?:\.\d+)?)%\s*,\s*(\-?\d+(?:\.\d+)?)%\s*\)/)) {
            //  hsl = m.slice(1, 4);
            //  hsl[1] *= 0.01;
            //  hsl[2] *= 0.01;
            //  rgb = hsl2rgb(hsl);
            //  rgb[3] = 1;
            //} else if (m = css.match(/hsla\(\s*(\-?\d+(?:\.\d+)?),\s*(\-?\d+(?:\.\d+)?)%\s*,\s*(\-?\d+(?:\.\d+)?)%\s*,\s*([01]|[01]?\.\d+)\)/)) {
            //  hsl = m.slice(1, 4);
            //  hsl[1] *= 0.01;
            //  hsl[2] *= 0.01;
            //  rgb = hsl2rgb(hsl);
            //  rgb[3] = +m[4];
            //}
            return new Color();
        }

        internal static Color HcgToRgb(HcgColor color)
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
                        return new Color(v, t, p, color.Alpha);
                    case 1:
                        return new Color(q, v, p, color.Alpha);
                    case 2:
                        return new Color(p, v, t, color.Alpha);
                    case 3:
                        return new Color(p, q, v, color.Alpha);
                    case 4:
                        return new Color(t, p, v, color.Alpha);
                    case 5:
                        return new Color(v, p, q, color.Alpha);
                }
            }

            return new Color(r, g, b, color.Alpha);
        }

        internal static Color Hex2Rgb(string hex)
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
                return new Color(r, g, b);
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
                return new Color(r, g, b, a);
            }

            //if ((_input.css != null) && (rgb = _input.css(hex)))
            //{
            //    return rgb;
            //}

            throw new InvalidCastException("Unknown color: " + hex);
        }

        internal static Color HsiToRgb(HsiColor hsi)
        {

            var PITHIRD = Math.PI / 3;
            var TWOPI = Math.PI * 2;

            Func<double, double> limit = (x) =>
            {
                var min = 0;
                var max = 1;
                if (x < min)
                {
                    x = min;
                }
                if (x > max)
                {
                    x = max;
                }
                return x;
            };

            double b, g, r;
            var h = hsi.H;
            var s = hsi.S;
            var i = hsi.I;
            if (double.IsNaN(h))
            {
                h = 0;
            }
            h /= 360;
            if (h < 1 / 3)
            {
                b = (1 - s) / 3;
                r = (1 + s * Math.Cos(TWOPI * h) / Math.Cos(PITHIRD - TWOPI * h)) / 3;
                g = 1 - (b + r);
            }
            else if (h < 2 / 3)
            {
                h -= 1 / 3;
                r = (1 - s) / 3;
                g = (1 + s * Math.Cos(TWOPI * h) / Math.Cos(PITHIRD - TWOPI * h)) / 3;
                b = 1 - (r + g);
            }
            else
            {
                h -= 2 / 3;
                g = (1 - s) / 3;
                b = (1 + s * Math.Cos(TWOPI * h) / Math.Cos(PITHIRD - TWOPI * h)) / 3;
                r = 1 - (g + b);
            }
            r = limit(i * r * 3);
            g = limit(i * g * 3);
            b = limit(i * b * 3);

            return new Color(Convert.ToInt32(r * 255), Convert.ToInt32(g * 255), Convert.ToInt32(b * 255), hsi.Alpha);
        }

        internal static Color HslToRgb(HslColor hsl)
        {
            double b, g, h, l, r, s;
            h = hsl.H;
            s = hsl.S;
            l = hsl.L;
            if (s == 0)
            {
                r = g = b = l * 255;
            }
            else
            {
                var t3 = new double[] { 0D, 0D, 0D };
                var c = new double[] { 0, 0, 0 };
                var t2 = l < 0.5 ? l * (1 + s) : l + s - l * s;
                var t1 = 2 * l - t2;
                h /= 360;
                t3[0] = h + 1 / 3;
                t3[1] = h;
                t3[2] = h - 1 / 3;
                for (int i = 0; i <= 2; i++)
                {
                    if (t3[i] < 0)
                    {
                        t3[i] += 1;
                    }
                    if (t3[i] > 1)
                    {
                        t3[i] -= 1;
                    }
                    if (6 * t3[i] < 1)
                    {
                        c[i] = t1 + (t2 - t1) * 6 * t3[i];
                    }
                    else if (2 * t3[i] < 1)
                    {
                        c[i] = t2;
                    }
                    else if (3 * t3[i] < 2)
                    {
                        c[i] = t1 + (t2 - t1) * ((2 / 3) - t3[i]) * 6;
                    }
                    else
                    {
                        c[i] = t1;
                    }
                }

                return new Color(Convert.ToInt32(c[0] * 255), Convert.ToInt32(c[1] * 255), Convert.ToInt32(c[2] * 255), hsl.Alpha);
            }

            return new Color(Convert.ToInt32(r), Convert.ToInt32(g), Convert.ToInt32(b), hsl.Alpha);

        }

        internal static Color HsvToRgb(HsvColor hsv)
        {
            double b, f, g, h, i, p, q, r, s, t, v;

            h = hsv.H;
            s = hsv.S;
            v = hsv.V;
            v *= 255;
            if (s == 0)
            {
                r = g = b = v;
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
                i = Math.Floor(h);
                f = h - i;
                p = v * (1 - s);
                q = v * (1 - s * f);
                t = v * (1 - s * (1 - f));
                switch (i)
                {
                    case 0:
                        return new Color(Convert.ToInt32(v), Convert.ToInt32(t), Convert.ToInt32(p), hsv.Alpha);
                    case 1:
                        return new Color(Convert.ToInt32(q), Convert.ToInt32(v), Convert.ToInt32(p), hsv.Alpha);
                    case 2:
                        return new Color(Convert.ToInt32(p), Convert.ToInt32(v), Convert.ToInt32(t), hsv.Alpha);
                    case 3:
                        return new Color(Convert.ToInt32(p), Convert.ToInt32(q), Convert.ToInt32(v), hsv.Alpha);
                    case 4:
                        return new Color(Convert.ToInt32(t), Convert.ToInt32(p), Convert.ToInt32(v), hsv.Alpha);
                    case 5:
                        return new Color(Convert.ToInt32(v), Convert.ToInt32(p), Convert.ToInt32(q), hsv.Alpha);
                }
            }
            return new Color();
        }

        internal static Color LabToRgb(LabColor lab)
        {

            Func<double, double> xyz_rgb = (t) =>
            {
                return 255 * (t <= 0.00304 ? 12.92 * t : 1.055 * Math.Pow(t, 1 / 2.4) - 0.055);
            };

            Func<double, double> lab_xyz = (t) =>
            {
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

            return new Color(Convert.ToInt32(r), Convert.ToInt32(g), Convert.ToInt32(b), lab.Alpha);
        }

        internal static Color LchToRgb(LchColor lch)
        {

            var lab = LchToLab(lch);
            var rgb = LabToRgb(lab);
            return rgb;
        }

        internal static Color NumToRgb(int num)
        {
            int b, g, r;
            if (num >= 0 && num <= 0xFFFFFF)
            {
                r = num >> 16;
                g = (num >> 8) & 0xFF;
                b = num & 0xFF;
                return new Color(r, g, b);
            }
            return new Color(0, 0, 0);
        }

        internal static Color TemperatureToRgb(double kelvin)
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
            return new Color(Convert.ToInt32(r), Convert.ToInt32(g), Convert.ToInt32(b));
        }

        //out

        internal static string HslToCss(HslColor hsl)
        {
            Func<double, string> rnd = (a) =>
            {
                return (Math.Round(a * 100) / 100).ToString();
            };

            var mode = hsl.Alpha < 1 ? "hsla" : "hsl";

            var h = rnd(hsl.H);
            var s = rnd(hsl.S * 100) + '%';
            var l = rnd(hsl.L * 100) + '%';
            if (mode == "hsla")
            {
                return $"{mode}({h},{s},{l},{hsl.Alpha})";
            }
            return $"{mode}({h},{s},{l})";
        }

        internal static CmykColor RgbToCmyk(Color rgb)
        {
            var r = rgb.R / 255;
            var g = rgb.G / 255;
            var b = rgb.B / 255;
            var k = 1 - Math.Max(r, Math.Max(g, b));

            var f = k < 1 ? 1 / (1 - k) : 0;
            var c = (1 - r - k) * f;
            var m = (1 - g - k) * f;
            var y = (1 - b - k) * f;

            return new CmykColor(c, m, y, k);
        }

        internal static string RgbToCss(Color rgb)
        {
            var mode = rgb.A < 1 ? "rgba" : "rgb";
            if (mode == "rgb")
            {
                return $"{mode}({rgb.R},{rgb.G},{rgb.B})";
            }
            else //if (mode == "rgba")
            {
                return $"{mode}({rgb.R},{rgb.G},{rgb.B},{rgb.A})";
            }
        }

        internal static HcgColor RgbToHcg(Color rgb)
        {

            var min = (new int[] { rgb.R, rgb.G, rgb.B }).Min();
            var max = (new int[] { rgb.R, rgb.G, rgb.B }).Max();
            var delta = max - min;
            var c = delta * 100 / 255;
            var _g = min / (255 - delta) * 100;
            var h = 0;


            if (delta == 0)
            {
                h = 0;
            }
            else
            {
                if (rgb.R == max)
                {
                    h = (rgb.G - rgb.B) / delta;
                }
                if (rgb.G == max)
                {
                    h = 2 + (rgb.B - rgb.R) / delta;
                }
                if (rgb.B == max)
                {
                    h = 4 + (rgb.R - rgb.G) / delta;
                }
                h *= 60;
                if (h < 0)
                {
                    h += 360;
                }
            }

            return new HcgColor(h, c, _g);
        }

        internal static string RgbToHex(Color rgb)
        {
            var mode = rgb.A < 1 ? "rgba" : "rgb";

            var u = rgb.R << 16 | rgb.G << 8 | rgb.B;
            var str = "000000" + u.ToString("X4");
            str = str.Substring(str.Length - 6);
            var hxa = "0" + (rgb.A * 255).ToString("X4");
            hxa = hxa.Substring(hxa.Length - 2);

            switch (mode.ToLowerInvariant())
            {
                case "rgba":
                    return "#" + str + hxa;
                case "argb":
                    return "#" + hxa + str;
                default:
                    return "#" + str;
            }

        }

        internal static HsiColor RgbToHsi(Color rgb)
        {
            var TWOPI = Math.PI * 2;
            var r = rgb.R / 255;
            var g = rgb.G / 255;
            var b = rgb.B / 255;
            var min = (new int[] { rgb.R, rgb.G, rgb.B }).Min();
            var i = (r + g + b) / 3d;
            var s = 1d - min / i;
            double h;

            if (s == 0d)
            {
                h = 0;
            }
            else
            {
                h = ((r - g) + (r - b)) / 2;
                h /= Math.Sqrt((r - g) * (r - g) + (r - b) * (g - b));
                h = Math.Acos(h);
                if (b > g)
                {
                    h = TWOPI - h;
                }
                h /= TWOPI;
            }
            return new HsiColor(h * 360, s, i);
        }

        internal static HslColor RgbToHsl(Color rgb)
        {

            var r = rgb.R / 255d;
            var g = rgb.G / 255d;
            var b = rgb.B / 255d;
            var min = (new int[] { rgb.R, rgb.G, rgb.B }).Min();
            var max = (new int[] { rgb.R, rgb.G, rgb.B }).Max();
            var l = (max + min) / 2d;
            var s = 0d;
            var h = 0d;

            if (max == min)
            {
                s = 0d;
                h = double.NaN;
            }
            else
            {
                s = l < 0.5 ? (max - min) / (max + min) : (max - min) / (2 - max - min);
            }
            if (r == max)
            {
                h = (g - b) / (max - min);
            }
            else if (g == max)
            {
                h = 2 + (b - r) / (max - min);
            }
            else if (b == max)
            {
                h = 4 + (r - g) / (max - min);
            }

            h *= 60;

            if (h < 0)
            {
                h += 360;
            }

            return new HslColor(h, s, l);
        }

        internal static HsvColor RgbToHsv(Color rgb)
        {
            double b, delta, g, h, r, s, v;

            var min = (new int[] { rgb.R, rgb.G, rgb.B }).Min();
            var max = (new int[] { rgb.R, rgb.G, rgb.B }).Max();

            h = 0;

            delta = max - min;
            v = max / 255.0;
            if (max == 0)
            {
                h = double.NaN;
                s = 0;
            }
            else
            {
                s = delta / max;
                if (rgb.R == max)
                {
                    h = (rgb.G - rgb.B) / delta;
                }
                if (rgb.G == max)
                {
                    h = 2 + (rgb.B - rgb.R) / delta;
                }
                if (rgb.B == max)
                {
                    h = 4 + (rgb.R - rgb.G) / delta;
                }

                h *= 60d;

                if (h < 0)
                {
                    h += 360;
                }
            }
            return new HsvColor(h, s, v);
        }

        internal static LabColor RgbToLab(Color rgb)
        {
            Func<double, double> rgb_xyz = (r) =>
            {
                if ((r /= 255) <= 0.04045)
                {
                    return r / 12.92;
                }
                else
                {
                    return Math.Pow((r + 0.055) / 1.055, 2.4);
                }
            };

            Func<double, double> xyz_lab = (t) =>
            {
                if (t > LabColor.LabConstants.T3)
                {
                    return Math.Pow(t, 1 / 3);
                }
                else
                {
                    return t / LabColor.LabConstants.T2 + LabColor.LabConstants.T0;
                }
            };

            Func<Color, Tuple<double, double, double>> rgb2xyz = (Color) =>
            {
                var r = rgb_xyz(Color.R);
                var g = rgb_xyz(Color.G);
                var b = rgb_xyz(Color.B);
                var lx = xyz_lab((0.4124564 * r + 0.3575761 * g + 0.1804375 * b) / LabColor.LabConstants.Xn);
                var ly = xyz_lab((0.2126729 * r + 0.7151522 * g + 0.0721750 * b) / LabColor.LabConstants.Yn);
                var lz = xyz_lab((0.0193339 * r + 0.1191920 * g + 0.9503041 * b) / LabColor.LabConstants.Zn);
                return new Tuple<double, double, double>(lx, ly, lz);
            };

            var rez = rgb2xyz(rgb);
            var x = rez.Item1;
            var y = rez.Item2;
            var z = rez.Item3;
            return new LabColor(116 * y - 16, 500 * (x - y), 200 * (y - z));
        }

        internal static LchColor RgbToLch(Color rgb)
        {
            var lab = RgbToLab(rgb);
            return LabToLch(lab);
        }

        internal static double RgbToLuminance(Color rgb)
        {
            Func<double, double> luminance_x = (x) =>
             {
                 x /= 255;
                 if (x <= 0.03928)
                 {
                     return x / 12.92;
                 }
                 else
                 {
                     return Math.Pow((x + 0.055) / 1.055, 2.4);
                 }
             };

            var r = luminance_x(rgb.R);
            var g = luminance_x(rgb.G);
            var b = luminance_x(rgb.B);
            return 0.2126 * r + 0.7152 * g + 0.0722 * b;
        }

        internal static int RgbToNum(Color rgb)
        {
            return (rgb.R << 16) + (rgb.G << 8) + rgb.B;
        }

        internal static double RgbToTemperature(Color rgb)
        {
            double  eps,  maxTemp, minTemp, temp;
            temp = 0;
            minTemp = 1000;
            maxTemp = 40000;
            eps = 0.4;
            while (maxTemp - minTemp > eps)
            {
                temp = (maxTemp + minTemp) * 0.5;
                var localRgb = TemperatureToRgb(temp);
                if ((localRgb.B / localRgb.R) >= (rgb.B / rgb.R))
                {
                    maxTemp = temp;
                }
                else
                {
                    minTemp = temp;
                }
            }
            return Math.Round(temp);
        }

        ///
        internal static LabColor LchToLab(LchColor lch)
        {
            var h = lch.H * (Math.PI / 180);
            return new LabColor(lch.L, Math.Cos(h) * lch.C, Math.Sin(lch.H * lch.C));
        }

        internal static LchColor LabToLch(LabColor lab)
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
