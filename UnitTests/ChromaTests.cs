using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChromaCs;
using FluentAssertions;

namespace UnitTests
{
    [TestFixture]
    public class ChromaTests
    {
        //http://gka.github.io/chroma.js/#chroma-lab

        [Test]
        public void Сhroma()
        {
            var color = "#FF69B4";

            Chroma.Color("hotpink").ToString().ShouldBeEquivalentTo(color);

            Chroma.Color("#FF3399").ToString().ShouldBeEquivalentTo(color);
            Chroma.Color("F39").ToString().ShouldBeEquivalentTo(color);
            Chroma.Color(0xff3399).ToString().ShouldBeEquivalentTo(color);

            Chroma.Color(0xff, 0x33, 0x99).ToString().ShouldBeEquivalentTo(color);
            Chroma.Color(255, 51, 153).ToString().ShouldBeEquivalentTo(color);


            //Chroma.Color(new[] {255, 51, 153 }).ToString().ShouldBeEquivalentTo(color);
            //Chroma.Color(330, 1, 0.6, 'hsl').ToString().ShouldBeEquivalentTo(color);

        }

        [Test]
        public void ChromaHsl()
        {
            var color = "#FF69B4";

            Chroma.Hsl(330, 1, 0.6f).ToString().ShouldBeEquivalentTo(color);
        }

        [Test]
        public void ChromaHsv()
        {
            var color = "#FF69B4";

            Chroma.Hsv(330, 1, 0.6f).ToString().ShouldBeEquivalentTo(color);
        }

        [Test]
        public void ChromaLab()
        {
            var color = "#FF69B4";

            Chroma.Lab(330, 1, 0.6f).ToString().ShouldBeEquivalentTo(color);
        }

        [Test]
        public void ChromaLch()
        {
            Assert.Fail("Check range string");
            //The range for lightness and chroma depend on the hue, but go roughly from 0..100 - 150.The range for hue is 0..360.
            var color = "#AAD28C";

            Chroma.Lch(80, 40, 130).ToString().ShouldBeEquivalentTo(color);
            Chroma.Color(255, 51, 153, ColorMode.Lch).ToString().ShouldBeEquivalentTo(color);
        }

        [Test]
        public void ChromaHcl()
        {
            var color = "#aad28c";

            Chroma.Hcl(130, 40, 80).ToString().ShouldBeEquivalentTo(color);
            Chroma.Color(130, 40, 80, ColorMode.Hcl).ToString().ShouldBeEquivalentTo(color);
        }

        [Test]
        public void ChromaCmyk()
        {

            //Each between 0 and 1.
            var color = "#CC33FF";

            Chroma.Cmyk(0.2f, 0.8f, 0f, 0f).ToString().ShouldBeEquivalentTo(color);
            Chroma.Color(0.2f, 0.8f, 0f, 0f, ColorMode.Cmyk).ToString().ShouldBeEquivalentTo(color);
        }

        [Test]
        public void ChromaGl()
        {
            var color = "#9900CC";
            Assert.Fail("Check range string");
            //GL is a variant of RGB(A), with the only difference that the components are normalized to the range of 0..1.

            Chroma.Gl(0.6f, 0f, 0.8f).ToString().ShouldBeEquivalentTo(color); 
            Chroma.Gl(0.6f, 0f, 0.8f, 0.5f).ToString().ShouldBeEquivalentTo(color);
            Chroma.Color(0.6f, 0f, 0.8f, ColorMode.Gl).ToString().ShouldBeEquivalentTo(color);
        }

        [Test]
        public void ChromaTemperature()
        {
            Chroma.Temperature(2000).ToString().ShouldBeEquivalentTo("#FF8B14"); // candle light // #ff8b14
            Chroma.Temperature(3500).Hex().ShouldBeEquivalentTo("#FFC38A"); // sunset //ffc38a
            Chroma.Temperature(6500).ToString().ShouldBeEquivalentTo("#FFFAFE");// daylight //fffafe
        }

        [Test]
        public void ChromaMix()
        {
            Assert.Fail("Compile Error");
            //Chroma.Mix("red", "blue", 0.5f, ColorMode.Rgb).ToString().ShouldBeEquivalentTo("#800080");
            //Chroma.Mix("red", "blue", 0.5f, ColorMode.Hsl).ToString().ShouldBeEquivalentTo("#ff00ff");
            //Chroma.Mix("red", "blue", 0.5f, ColorMode.Lab).ToString().ShouldBeEquivalentTo("#ca0088");
            //Chroma.Mix("red", "blue", 0.5f, ColorMode.Lch).ToString().ShouldBeEquivalentTo("#fa0080");
        }

        [Test]
        public void ChromaAverage()
        {
            Assert.Fail("Compile Error");
            var colors = new[]
            {
                Chroma.Color("#ddd"),
                Chroma.Color("#yellow"),
                Chroma.Color("#red"),
                Chroma.Color("#teal"),
            };

            //Chroma.Average(colors).ToString().ShouldBeEquivalentTo("#b79757");
            //Chroma.Average(colors, ColorMode.Lab).ToString().ShouldBeEquivalentTo("#d3a96a");
            //Chroma.Average(colors, ColorMode.Lch).ToString().ShouldBeEquivalentTo("#fe955c");
            //Chroma.Average("red", 'rgba(0,0,0,0.5)']).css();   //"rgba(128,0,0,0.75)"
        }

        [Test]
        public void Blend()
        {
            Assert.Fail("Compile Error");
            //Chroma.Blend("4CBBFC", "EEEE22", "multiply").ToString().ShouldBeEquivalentTo("#47af22");
            //Chroma.Blend("4CBBFC", "EEEE22", "darken").ToString().ShouldBeEquivalentTo("#4cbb22");
            //Chroma.Blend("4CBBFC", "EEEE22", "lighten").ToString().ShouldBeEquivalentTo("#eeeefc");
        }

        [Test]
        public void Random()
        {
            Assert.NotNull(Chroma.Random());
            Assert.NotNull(Chroma.Random());
            Assert.NotNull(Chroma.Random());
        }

        [Test]
        public void Contrast()
        {
            Assert.Fail("Compile Error");

            //// contrast smaller than 4.5 = too low
            //Chroma.Contrast("pink", "hotpink").ShouldBeEquivalentTo(1.721);
            //// contrast greater than 4.5 = high enough
            //Chroma.Contrast("pink", "purple").ShouldBeEquivalentTo(6.124);
        }

        [Test]
        public void Distance()
        {
            Assert.Fail("Compile Error");

            //Chroma.Distance("#fff", "#ff0", ColorMode.Rgb).ShouldBeEquivalentTo(255);
            //Chroma.Distance("#fff", "#f0f", ColorMode.Rgb).ShouldBeEquivalentTo(255);
            //Chroma.Distance("#fff", "#ff0").ShouldBeEquivalentTo(96.948);
            //Chroma.Distance("#fff", "#f0f").ShouldBeEquivalentTo(122.163);

        }


        [Test]
        public void DeltaE()
        {
            Chroma.DeltaE("#ededee", "#edeeed").ShouldBeEquivalentTo(1.64);
            Chroma.DeltaE("#ececee", "#eceeec").ShouldBeEquivalentTo(3.157);
            Chroma.DeltaE("#e9e9ee", "#e9eee9").ShouldBeEquivalentTo(7.362);
            Chroma.DeltaE("#e4e4ee", "#e4eee4").ShouldBeEquivalentTo(14.84);
            Chroma.DeltaE("#e0e0ee", "#e0eee0").ShouldBeEquivalentTo(21.325);
        }

        [Test]
        public void Limits()
        {
            Assert.Fail("Compile Error");
        }


    }
}
