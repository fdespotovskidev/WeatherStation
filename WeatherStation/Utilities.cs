using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation
{

    static class Utilities
    {
        public static float ToCelsius(float fahrenheitValue)
        {
            return (fahrenheitValue - 32.0f) * 5.0f / 9.0f;
        }

        public static float ToFahrenheit(float celsiusValue)
        {
            return celsiusValue * 9.0f / 5.0f + 32.0f;
        }
    }
}
