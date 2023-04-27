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
        public string Name
        {
            get
            {
                switch (this)
                {
                    case Color c when c.red == 255 && c.green == 0 && c.blue == 0:
                        return "Red 100%";
                    case Color c when c.red == 0 && c.green == 255 && c.blue == 0:
                        return "Green 100%";
                    case Color c when c.red == 0 && c.green == 0 && c.blue == 255:
                        return "Blue 100%";
                    default:
                        return "Mixed";
                }
            }
        } 
    }
}