﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDMR.Temperatura
{
    public class CalculadoraTemperatura
    {
        public double CelsiusAFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        public double FahrenheitACelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
    }
}
