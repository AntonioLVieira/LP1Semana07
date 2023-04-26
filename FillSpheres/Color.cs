using System;

namespace FillSpheres
{
    class Color
    {
        private int red  {get; set;} = 255;
        private int green  {get; set;} = 255;
        private int alpha  {get; set;} = 255;
        private int blue {get; set;} = 255;
        
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
        public int GetRed()
        {
         return red;
        }
        public int GetGreen()
        {
         return green;
        }
        public int GetBlue()
        {
         return blue;
        }
        public void SetRed(int newRed)
        {
         red = newRed;
        }
        public void SetGreen(int newGreen)
        {
         green = newGreen;
        }
        public void SetBlue(int newBlue)
        {
         blue = newBlue;
        }
        public int GetGrey()
        {
         return (GetRed() + GetGreen() + GetBlue())/3; 
        }
    }
}