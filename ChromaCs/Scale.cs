using System;
using System.Collections.Generic;
using System.Text;

namespace ChromaCs
{
    public class Scale
    {
        protected string mode = "rgb";
        //_nacol = chroma '#ccc'
        //_spread = 0
        //_fixed = false
        protected List<float> domain = new List<float>(); 
        protected List<float> pos = new List<float>();
        protected List<float> padding = new List<float>();
        //_classes = false
        protected List<string> colors = new List<string>();
        //_out = false
        protected float min = 0;
        protected float max = 1;
        protected bool correctLightness = false;
        //_colorCache = {}
        protected bool useCache = true;


        protected Func<int,int> tmap;

        public Scale(params Color[] colors)
        {

        }

        public Scale(params string[] colors)
        {

        }


        public Scale Domain(params float[] domain)
        {
            if(domain.Length < 2)
            {
                throw new Exception("wrong parameters");
            }
              
            this.min = domain[0];
            this.max = domain[domain.Length-1];
            this.pos.Clear();

            int k = this.colors.Count;

            if(domain.Length == k && this.min != this.max)
            {
                //update positions
                foreach (float d in domain)
                {
                    this.pos.Add((d - this.min) / (this.max - this.min));
                }
            }
            else
            {
                for(int c = 0; c < k-1; c++)
                {
                    this.pos.Add(c/(k-1));
                }
            }
            return this;
        }

        public Scale Mode(string mode)
        {
            this.mode = mode;
            return this;
        }

        public Scale CorrectLightness(bool v)
        {
            this.correctLightness = v;
            //resetCache()
            if (this.correctLightness)
            {
                tmap = (t) =>
                {
                    L0 = getColor(0, true).lab()[0]
                    L1 = getColor(1, true).lab()[0]
                    pol = L0 > L1
                    L_actual = getColor(t, true).lab()[0]
                    L_ideal = L0 + (L1 - L0) * t
                    L_diff = L_actual - L_ideal
                    t0 = 0
                    t1 = 1
                    max_iter = 20
                    while Math.abs(L_diff) > 1e-2 and max_iter-- > 0
                    do () ->
                    L_diff *= -1 if pol
                    if L_diff < 0
                    t0 = t
                    t += (t1 - t) * 0.5
                    else
                    t1 = t
                    t += (t0 - t) * 0.5
                    L_actual = getColor(t, true).lab()[0]
                    L_diff = L_actual - L_ideal
                    return t;
                };
            }
            else
            {
                this.tmap = (t) => t;
            }
            
            return this;
        }

        public Scale Cache(bool cache)
        {
            this.useCache = cache;
            return this;
        }

        public Scale Padding(List<float> pad)
        {
            this.padding = pad;
            return this;
        }

        public float Colors(float num, string format = "hex")
        {
            return -1;
        }

        public float Classes(int numOrArray)
        {
            
            /*d = chroma.analyze _domain
            if numOrArray == 0
                _classes = [d.min, d.max]
            else
                _classes = chroma.limits d, 'e', classes
            return f*/
        }
    }
}
