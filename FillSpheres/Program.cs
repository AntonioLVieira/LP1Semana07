using System;

namespace FillSpheres
{
    class Program
    {
        static void Main(string[] args)
        {
            Color purple = new Color (138,43,226);
            Color blue = new Color (0,191,255);
            Color orange = new Color (255,99,71);
            Sphere s = new Sphere (purple, 10);
            Sphere r = new Sphere (blue, 3.333);
            Sphere a = new Sphere (orange, 17.14);
            s.Throw();
            r.Pop();
            s.Throw();
            Console.WriteLine(purple.GetRed() + "," + purple.GetGreen() + "," + purple.GetBlue());
            Console.WriteLine(s.GetTimesThrown());
        }
    }
}
