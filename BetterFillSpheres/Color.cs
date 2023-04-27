using System;

namespace BetterFillSpheres
{
    class Color
    {
        public int red  {get; set;} = 255;
        public int green  {get; set;} = 255;
        public int alpha  {get; set;} = 255;
        public int blue {get; set;} = 255;
        
        public Color (int red, int green, int blue, int alpha)
        {
         this.red = red;
         this.green = green;
         this.blue = blue;
         this.alpha = alpha;
        }
        public Color (int red, int green, int blue)
        {
         this.red = red;
         this.green = green;
         this.blue = blue;
         this.alpha = 255;
        }
        public int GetGrey()
        {
         return (red + green + blue)/3; 
        }
    }
}