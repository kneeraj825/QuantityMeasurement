using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurementProblem
{
    public class Converstion
    {
        public int measure(int feet)
        {
            int inch;


            return inch = feet * 12;

        }
        public int measure1(int inch)
        {
            int feet;
            return feet = inch / 12;
        }
        public double measure3(double inch)
        {
            double feet;
            return feet = 12 * inch;
        }
        public double measure4(double feet)
        {
            double inch;
            return inch = feet / 12;
        }
    }
}
