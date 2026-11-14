using System;
using System.Collections.Generic;
using System.Text;

namespace ChapterThree
{
    public class ShapeTwo
    {
        public virtual void Draw()
        {
            Console.WriteLine("Drawing a shape");
        }
    }

    public class CircleOne : ShapeTwo
    {
        //sealed here provents further overriding

        public sealed override void Draw()
        {
            Console.WriteLine("Drawing a circle");
        }
    }
    internal class SealedMethodExample
    {
    }
}