using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ChromaCs
{
    public partial class Chroma
    {
        public void Analyze()
        {
            //chroma.analyze = function(data) {
            //    var i, len, r, val;
            //    r = {
            //        min: Number.MAX_VALUE,
            //        max: Number.MAX_VALUE * -1,
            //        sum: 0,
            //        values: [],
            //        count: 0
            //    };
            //    for (i = 0, len = data.length; i < len; i++)
            //    {
            //        val = data[i];
            //        if ((val != null) && !isNaN(val))
            //        {
            //            r.values.push(val);
            //            r.sum += val;
            //            if (val < r.min)
            //            {
            //                r.min = val;
            //            }
            //            if (val > r.max)
            //            {
            //                r.max = val;
            //            }
            //            r.count += 1;
            //        }
            //    }
            //    r.domain = [r.min, r.max];
            //    r.limits = function(mode, num) {
            //        return chroma.limits(r, mode, num);
            //    };
            //    return r;
            //};
        }

        public void Limits()
        {
            //chroma.analyze = function(data, key, filter) {
            //    var add, k, l, len, r, val, visit;
            //    r = {
            //        min: Number.MAX_VALUE,
            //        max: Number.MAX_VALUE * -1,
            //        sum: 0,
            //        values: [],
            //        count: 0
            //    };
            //    if (filter == null)
            //    {
            //        filter = function() {
            //            return true;
            //        };
            //    }
            //    add = function(val) {
            //        if ((val != null) && !isNaN(val))
            //        {
            //            r.values.push(val);
            //            r.sum += val;
            //            if (val < r.min)
            //            {
            //                r.min = val;
            //            }
            //            if (val > r.max)
            //            {
            //                r.max = val;
            //            }
            //            r.count += 1;
            //        }
            //    };
            //    visit = function(val, k) {
            //        if (filter(val, k))
            //        {
            //            if ((key != null) && type(key) === 'function')
            //            {
            //                return add(key(val));
            //            }
            //            else if ((key != null) && type(key) === 'string' || type(key) === 'number')
            //            {
            //                return add(val[key]);
            //            }
            //            else
            //            {
            //                return add(val);
            //            }
            //        }
            //    };
            //    if (type(data) === 'array')
            //    {
            //        for (l = 0, len = data.length; l < len; l++)
            //        {
            //            val = data[l];
            //            visit(val);
            //        }
            //    }
            //    else
            //    {
            //        for (k in data)
            //        {
            //            val = data[k];
            //            visit(val, k);
            //        }
            //    }
            //    r.domain = [r.min, r.max];
            //    r.limits = function(mode, num) {
            //        return chroma.limits(r, mode, num);
            //    };
            //    return r;
            //};

            //chroma.limits = function(data, mode, num) {
            //    var assignments, best, centroids, cluster, clusterSizes, dist, i, i1, j, j1, k1, kClusters, l, l1, limits, m, max, max_log, min, min_log, mindist, n, nb_iters, newCentroids, o, p, pb, pr, q, ref, ref1, ref10, ref11, ref12, ref13, ref14, ref2, ref3, ref4, ref5, ref6, ref7, ref8, ref9, repeat, s, sum, t, tmpKMeansBreaks, u, v, value, values, w, x, y, z;
            //    if (mode == null)
            //    {
            //        mode = 'equal';
            //    }
            //    if (num == null)
            //    {
            //        num = 7;
            //    }
            //    if (type(data) === 'array')
            //    {
            //        data = chroma.analyze(data);
            //    }
            //    min = data.min;
            //    max = data.max;
            //    sum = data.sum;
            //    values = data.values.sort(function(a, b) {
            //        return a - b;
            //    });
            //    if (num === 1)
            //    {
            //        return [min, max];
            //    }
            //    limits = [];
            //    if (mode.substr(0, 1) === 'c')
            //    {
            //        limits.push(min);
            //        limits.push(max);
            //    }
            //    if (mode.substr(0, 1) === 'e')
            //    {
            //        limits.push(min);
            //        for (i = l = 1, ref = num - 1; 1 <= ref ? l <= ref : l >= ref; i = 1 <= ref ? ++l : --l) {
            //            limits.push(min + (i / num) * (max - min));
            //        }
            //        limits.push(max);
            //    }
            //    else if (mode.substr(0, 1) === 'l')
            //    {
            //        if (min <= 0)
            //        {
            //            throw 'Logarithmic scales are only possible for values > 0';
            //        }
            //        min_log = Math.LOG10E * log(min);
            //        max_log = Math.LOG10E * log(max);
            //        limits.push(min);
            //        for (i = m = 1, ref1 = num - 1; 1 <= ref1 ? m <= ref1 : m >= ref1; i = 1 <= ref1 ? ++m : --m)
            //        {
            //            limits.push(pow(10, min_log + (i / num) * (max_log - min_log)));
            //        }
            //        limits.push(max);
            //    }
            //    else if (mode.substr(0, 1) === 'q')
            //    {
            //        limits.push(min);
            //        for (i = o = 1, ref2 = num - 1; 1 <= ref2 ? o <= ref2 : o >= ref2; i = 1 <= ref2 ? ++o : --o)
            //        {
            //            p = (values.length - 1) * i / num;
            //            pb = floor(p);
            //            if (pb === p)
            //            {
            //                limits.push(values[pb]);
            //            }
            //            else
            //            {
            //                pr = p - pb;
            //                limits.push(values[pb] * (1 - pr) + values[pb + 1] * pr);
            //            }
            //        }
            //        limits.push(max);
            //    }
            //    else if (mode.substr(0, 1) === 'k')
            //    {

            //        /*
            //        implementation based on
            //        http://code.google.com/p/figue/source/browse/trunk/figue.js#336
            //        simplified for 1-d input values
            //         */
            //        n = values.length;
            //        assignments = new Array(n);
            //        clusterSizes = new Array(num);
            //        repeat = true;
            //        nb_iters = 0;
            //        centroids = null;
            //        centroids = [];
            //        centroids.push(min);
            //        for (i = q = 1, ref3 = num - 1; 1 <= ref3 ? q <= ref3 : q >= ref3; i = 1 <= ref3 ? ++q : --q)
            //        {
            //            centroids.push(min + (i / num) * (max - min));
            //        }
            //        centroids.push(max);
            //        while (repeat)
            //        {
            //            for (j = s = 0, ref4 = num - 1; 0 <= ref4 ? s <= ref4 : s >= ref4; j = 0 <= ref4 ? ++s : --s)
            //            {
            //                clusterSizes[j] = 0;
            //            }
            //            for (i = t = 0, ref5 = n - 1; 0 <= ref5 ? t <= ref5 : t >= ref5; i = 0 <= ref5 ? ++t : --t)
            //            {
            //                value = values[i];
            //                mindist = Number.MAX_VALUE;
            //                for (j = u = 0, ref6 = num - 1; 0 <= ref6 ? u <= ref6 : u >= ref6; j = 0 <= ref6 ? ++u : --u)
            //                {
            //                    dist = abs(centroids[j] - value);
            //                    if (dist < mindist)
            //                    {
            //                        mindist = dist;
            //                        best = j;
            //                    }
            //                }
            //                clusterSizes[best]++;
            //                assignments[i] = best;
            //            }
            //            newCentroids = new Array(num);
            //            for (j = w = 0, ref7 = num - 1; 0 <= ref7 ? w <= ref7 : w >= ref7; j = 0 <= ref7 ? ++w : --w)
            //            {
            //                newCentroids[j] = null;
            //            }
            //            for (i = x = 0, ref8 = n - 1; 0 <= ref8 ? x <= ref8 : x >= ref8; i = 0 <= ref8 ? ++x : --x)
            //            {
            //                cluster = assignments[i];
            //                if (newCentroids[cluster] === null)
            //                {
            //                    newCentroids[cluster] = values[i];
            //                }
            //                else
            //                {
            //                    newCentroids[cluster] += values[i];
            //                }
            //            }
            //            for (j = y = 0, ref9 = num - 1; 0 <= ref9 ? y <= ref9 : y >= ref9; j = 0 <= ref9 ? ++y : --y)
            //            {
            //                newCentroids[j] *= 1 / clusterSizes[j];
            //            }
            //            repeat = false;
            //            for (j = z = 0, ref10 = num - 1; 0 <= ref10 ? z <= ref10 : z >= ref10; j = 0 <= ref10 ? ++z : --z)
            //            {
            //                if (newCentroids[j] !== centroids[i])
            //                {
            //                    repeat = true;
            //                    break;
            //                }
            //            }
            //            centroids = newCentroids;
            //            nb_iters++;
            //            if (nb_iters > 200)
            //            {
            //                repeat = false;
            //            }
            //        }
            //        kClusters = { };
            //        for (j = i1 = 0, ref11 = num - 1; 0 <= ref11 ? i1 <= ref11 : i1 >= ref11; j = 0 <= ref11 ? ++i1 : --i1)
            //        {
            //            kClusters[j] = [];
            //        }
            //        for (i = j1 = 0, ref12 = n - 1; 0 <= ref12 ? j1 <= ref12 : j1 >= ref12; i = 0 <= ref12 ? ++j1 : --j1)
            //        {
            //            cluster = assignments[i];
            //            kClusters[cluster].push(values[i]);
            //        }
            //        tmpKMeansBreaks = [];
            //        for (j = k1 = 0, ref13 = num - 1; 0 <= ref13 ? k1 <= ref13 : k1 >= ref13; j = 0 <= ref13 ? ++k1 : --k1)
            //        {
            //            tmpKMeansBreaks.push(kClusters[j][0]);
            //            tmpKMeansBreaks.push(kClusters[j][kClusters[j].length - 1]);
            //        }
            //        tmpKMeansBreaks = tmpKMeansBreaks.sort(function(a, b) {
            //            return a - b;
            //        });
            //        limits.push(tmpKMeansBreaks[0]);
            //        for (i = l1 = 1, ref14 = tmpKMeansBreaks.length - 1; l1 <= ref14; i = l1 += 2)
            //        {
            //            v = tmpKMeansBreaks[i];
            //            if (!isNaN(v) && limits.indexOf(v) === -1)
            //            {
            //                limits.push(v);
            //            }
            //        }
            //    }
            //    return limits;
            //};
        }

        public void Scale()
        {
            //chroma.scale = function(colors, positions) {
            //    var _classes, _colorCache, _colors, _correctLightness, _domain, _fixed, _max, _min, _mode, _nacol, _out, _padding, _pos, _spread, _useCache, classifyValue, f, getClass, getColor, resetCache, setColors, tmap;
            //    _mode = 'rgb';
            //    _nacol = chroma('#ccc');
            //    _spread = 0;
            //    _fixed = false;
            //    _domain = [0, 1];
            //    _pos = [];
            //    _padding = [0, 0];
            //    _classes = false;
            //    _colors = [];
            //    _out = false;
            //    _min = 0;
            //    _max = 1;
            //    _correctLightness = false;
            //    _colorCache = { };
            //    _useCache = true;
            //    setColors = function(colors) {
            //        var c, col, j, l, ref, ref1;
            //        if (colors == null)
            //        {
            //            colors = ['#fff', '#000'];
            //        }
            //        if ((colors != null) && type(colors) === 'string' && (chroma.brewer != null))
            //        {
            //            colors = chroma.brewer[colors] || chroma.brewer[colors.toLowerCase()] || colors;
            //        }
            //        if (type(colors) === 'array')
            //        {
            //            colors = colors.slice(0);
            //            for (c = j = 0, ref = colors.length - 1; 0 <= ref ? j <= ref : j >= ref; c = 0 <= ref ? ++j : --j) {
            //                col = colors[c];
            //                if (type(col) === "string")
            //                {
            //                    colors[c] = chroma(col);
            //                }
            //            }
            //            _pos.length = 0;
            //            for (c = l = 0, ref1 = colors.length - 1; 0 <= ref1 ? l <= ref1 : l >= ref1; c = 0 <= ref1 ? ++l : --l)
            //            {
            //                _pos.push(c / (colors.length - 1));
            //            }
            //        }
            //        resetCache();
            //        return _colors = colors;
            //    };
            //    getClass = function(value) {
            //        var i, n;
            //        if (_classes != null)
            //        {
            //            n = _classes.length - 1;
            //            i = 0;
            //            while (i < n && value >= _classes[i])
            //            {
            //                i++;
            //            }
            //            return i - 1;
            //        }
            //        return 0;
            //    };
            //    tmap = function(t) {
            //        return t;
            //    };
            //    classifyValue = function(value) {
            //        var i, maxc, minc, n, val;
            //        val = value;
            //        if (_classes.length > 2)
            //        {
            //            n = _classes.length - 1;
            //            i = getClass(value);
            //            minc = _classes[0] + (_classes[1] - _classes[0]) * (0 + _spread * 0.5);
            //            maxc = _classes[n - 1] + (_classes[n] - _classes[n - 1]) * (1 - _spread * 0.5);
            //            val = _min + ((_classes[i] + (_classes[i + 1] - _classes[i]) * 0.5 - minc) / (maxc - minc)) * (_max - _min);
            //        }
            //        return val;
            //    };
            //    getColor = function(val, bypassMap) {
            //        var c, col, i, j, k, p, ref, t;
            //        if (bypassMap == null)
            //        {
            //            bypassMap = false;
            //        }
            //        if (isNaN(val))
            //        {
            //            return _nacol;
            //        }
            //        if (!bypassMap)
            //        {
            //            if (_classes && _classes.length > 2)
            //            {
            //                c = getClass(val);
            //                t = c / (_classes.length - 2);
            //                t = _padding[0] + (t * (1 - _padding[0] - _padding[1]));
            //            }
            //            else if (_max !== _min)
            //            {
            //                t = (val - _min) / (_max - _min);
            //                t = _padding[0] + (t * (1 - _padding[0] - _padding[1]));
            //                t = Math.min(1, Math.max(0, t));
            //            }
            //            else
            //            {
            //                t = 1;
            //            }
            //        }
            //        else
            //        {
            //            t = val;
            //        }
            //        if (!bypassMap)
            //        {
            //            t = tmap(t);
            //        }
            //        k = Math.floor(t * 10000);
            //        if (_useCache && _colorCache[k])
            //        {
            //            col = _colorCache[k];
            //        }
            //        else
            //        {
            //            if (type(_colors) === 'array')
            //            {
            //                for (i = j = 0, ref = _pos.length - 1; 0 <= ref ? j <= ref : j >= ref; i = 0 <= ref ? ++j : --j) {
            //                    p = _pos[i];
            //                    if (t <= p)
            //                    {
            //                        col = _colors[i];
            //                        break;
            //                    }
            //                    if (t >= p && i === _pos.length - 1)
            //                    {
            //                        col = _colors[i];
            //                        break;
            //                    }
            //                    if (t > p && t < _pos[i + 1])
            //                    {
            //                        t = (t - p) / (_pos[i + 1] - p);
            //                        col = chroma.interpolate(_colors[i], _colors[i + 1], t, _mode);
            //                        break;
            //                    }
            //                }
            //            }
            //            else if (type(_colors) === 'function')
            //            {
            //                col = _colors(t);
            //            }
            //            if (_useCache)
            //            {
            //                _colorCache[k] = col;
            //            }
            //        }
            //        return col;
            //    };
            //    resetCache = function() {
            //        return _colorCache = { };
            //    };
            //    setColors(colors);
            //    f = function(v) {
            //        var c;
            //        c = chroma(getColor(v));
            //        if (_out && c[_out])
            //        {
            //            return c[_out]();
            //        }
            //        else
            //        {
            //            return c;
            //        }
            //    };
            //    f.classes = function(classes) {
            //        var d;
            //        if (classes != null)
            //        {
            //            if (type(classes) === 'array')
            //            {
            //                _classes = classes;
            //                _domain = [classes[0], classes[classes.length - 1]];
            //            }
            //            else
            //            {
            //                d = chroma.analyze(_domain);
            //                if (classes === 0)
            //                {
            //                    _classes = [d.min, d.max];
            //                }
            //                else
            //                {
            //                    _classes = chroma.limits(d, 'e', classes);
            //                }
            //            }
            //            return f;
            //        }
            //        return _classes;
            //    };
            //    f.domain = function(domain) {
            //        var c, d, j, k, l, len, ref;
            //        if (!arguments.length)
            //        {
            //            return _domain;
            //        }
            //        _min = domain[0];
            //        _max = domain[domain.length - 1];
            //        _pos = [];
            //        k = _colors.length;
            //        if (domain.length === k && _min !== _max)
            //        {
            //            for (j = 0, len = domain.length; j < len; j++)
            //            {
            //                d = domain[j];
            //                _pos.push((d - _min) / (_max - _min));
            //            }
            //        }
            //        else
            //        {
            //            for (c = l = 0, ref = k - 1; 0 <= ref ? l <= ref : l >= ref; c = 0 <= ref ? ++l : --l) {
            //                _pos.push(c / (k - 1));
            //            }
            //        }
            //        _domain = [_min, _max];
            //        return f;
            //    };
            //    f.mode = function(_m) {
            //        if (!arguments.length)
            //        {
            //            return _mode;
            //        }
            //        _mode = _m;
            //        resetCache();
            //        return f;
            //    };
            //    f.range = function(colors, _pos) {
            //        setColors(colors, _pos);
            //        return f;
            //    };
            //    f.out = function(_o) {
            //        _out = _o;
            //        return f;
            //    };
            //    f.spread = function(val) {
            //        if (!arguments.length)
            //        {
            //            return _spread;
            //        }
            //        _spread = val;
            //        return f;
            //    };
            //    f.correctLightness = function(v) {
            //        if (v == null)
            //        {
            //            v = true;
            //        }
            //        _correctLightness = v;
            //        resetCache();
            //        if (_correctLightness)
            //        {
            //            tmap = function(t) {
            //                var L0, L1, L_actual, L_diff, L_ideal, max_iter, pol, t0, t1;
            //                L0 = getColor(0, true).lab()[0];
            //                L1 = getColor(1, true).lab()[0];
            //                pol = L0 > L1;
            //                L_actual = getColor(t, true).lab()[0];
            //                L_ideal = L0 + (L1 - L0) * t;
            //                L_diff = L_actual - L_ideal;
            //                t0 = 0;
            //                t1 = 1;
            //                max_iter = 20;
            //                while (Math.abs(L_diff) > 1e-2 && max_iter-- > 0)
            //                {
            //                    (function() {
            //                        if (pol)
            //                        {
            //                            L_diff *= -1;
            //                        }
            //                        if (L_diff < 0)
            //                        {
            //                            t0 = t;
            //                            t += (t1 - t) * 0.5;
            //                        }
            //                        else
            //                        {
            //                            t1 = t;
            //                            t += (t0 - t) * 0.5;
            //                        }
            //                        L_actual = getColor(t, true).lab()[0];
            //                        return L_diff = L_actual - L_ideal;
            //                    })();
            //                }
            //                return t;
            //            };
            //        }
            //        else
            //        {
            //            tmap = function(t) {
            //                return t;
            //            };
            //        }
            //        return f;
            //    };
            //    f.padding = function(p) {
            //        if (p != null)
            //        {
            //            if (type(p) === 'number')
            //            {
            //                p = [p, p];
            //            }
            //            _padding = p;
            //            return f;
            //        }
            //        else
            //        {
            //            return _padding;
            //        }
            //    };
            //    f.colors = function(numColors, out) {
            //        var dd, dm, i, j, l, ref, result, results, samples;
            //        if (arguments.length < 2)
            //        {
            //            out = 'hex';
            //        }
            //        result = [];
            //        if (arguments.length === 0)
            //        {
            //            result = _colors.slice(0);
            //        }
            //        else if (numColors === 1)
            //        {
            //            result = [f(0.5)];
            //        }
            //        else if (numColors > 1)
            //        {
            //            dm = _domain[0];
            //            dd = _domain[1] - dm;
            //            result = (function() {
            //                results = [];
            //                for (var j = 0; 0 <= numColors ? j < numColors : j > numColors; 0 <= numColors ? j++ : j--) { results.push(j); }
            //                return results;
            //            }).apply(this).map(function(i) {
            //                return f(dm + i / (numColors - 1) * dd);
            //            });
            //        }
            //        else
            //        {
            //            colors = [];
            //            samples = [];
            //            if (_classes && _classes.length > 2)
            //            {
            //                for (i = l = 1, ref = _classes.length; 1 <= ref ? l< ref : l > ref; i = 1 <= ref ? ++l : --l) {
            //                    samples.push((_classes[i - 1] + _classes[i]) * 0.5);
            //                }
            //            }
            //            else
            //            {
            //                samples = _domain;
            //            }
            //            result = samples.map(function(v) {
            //                return f(v);
            //            });
            //        }
            //        if (chroma[out])
            //        {
            //            result = result.map(function(c) {
            //                return c[out]();
            //            });
            //        }
            //        return result;
            //    };
            //    f.cache = function(c) {
            //        if (c != null)
            //        {
            //            return _useCache = c;
            //        }
            //        else
            //        {
            //            return _useCache;
            //        }
            //    };
            //    return f;
            //};

            //if (chroma.scales == null)
            //{
            //    chroma.scales = { };
            //}

            //chroma.scales.cool = function() {
            //    return chroma.scale([chroma.hsl(180, 1, .9), chroma.hsl(250, .7, .4)]);
            //};

            //chroma.scales.hot = function() {
            //    return chroma.scale(['#000', '#f00', '#ff0', '#fff'], [0, .25, .75, 1]).mode('rgb');
            //};
}

        private double DEG2RAD = Math.PI / 180;
        private double PI = Math.PI;
        private double PITHIRD = Math.PI / 3;
        private double RAD2DEG = 180 / Math.PI;
        private double TWOPI = Math.PI * 2;

        public double Limit(double x, double min, double max)
        {
            if (x < min)
            {
                x = min;
            }
            if (x > max)
            {
                x = max;
            }
            return x;
        }

        public float Limit(float x, float min, float max)
        {
            if (x < min)
            {
                x = min;
            }
            if (x > max)
            {
                x = max;
            }
            return x;
        }

        public int Limit(int x, int min, int max)
        {
            if (x < min)
            {
                x = min;
            }
            if (x > max)
            {
                x = max;
            }
            return x;
        }

    }
}
