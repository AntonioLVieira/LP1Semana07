using System;

namespace FillSpheres
{
    class Sphere
    {
        private Color color;
        private double raio;
        private int sphere;

        public Sphere (Color color, double raio)
        {
         this.color = color;
         this.raio = raio;
         this.sphere = 0;
        }
        public void Pop()
        {
         raio = 0;
        }
        public void Throw()
        {
         if (raio > 0)
         {
          sphere++;
         }
        }
        public int GetTimesThrown()
        {
         return sphere;
        }
    }
}