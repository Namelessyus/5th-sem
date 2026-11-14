using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter_Three
{
    public sealed class CircleClassOne
    {

        public double Radius { get; set; }

        public CircleClassOne(double radius)
        {
            Radius = radius;
        }
        public double GetAre()
        {
            return Math.PI = Radius * Radius;
        }
    }

    //// X This will cause a complie error
    //public class BigCircleOne : CircleClassOne { }//ERROR: cannot derive from sealed class
    internal class SealedExample
    {

    }
}