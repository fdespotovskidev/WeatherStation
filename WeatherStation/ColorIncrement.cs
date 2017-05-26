using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation
{
    class ColorIncrement
    {
        public int R { get; set; }
        public int G { get; set; }
        public int B { get; set; }

        public ColorIncrement(int r, int g, int b)
        {
            R = r;
            G = g;
            B = b;
        }
    }
}
