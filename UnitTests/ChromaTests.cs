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
        public void ChromaLch()
        {
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
            var color = "#CC33FF";

            Chroma.Cmyk(0.2f, 0.8f, 0f, 0f).ToString().ShouldBeEquivalentTo(color);
            Chroma.Color(0.2f, 0.8f, 0f, 0f, ColorMode.Cmyk).ToString().ShouldBeEquivalentTo(color);
        }

        [Test]
        public void ChromaGl()
        {
            var color = "#9900CC";

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

    }
}
