using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.Base.Components.Screens
{
    public class ColorfulScreen : ScreenBase
    {
        private int vColors=2;
        public int Colors
        {
            get { return vColors; }
            set
            {
                if (value >= 2)
                {
                    vColors = value;
                }
                else
                {
                    throw new Exception("Value can't be less than 2");
                }
            }
        }

        public ColorfulScreen(int highth, int width, int hightPX, int widthPX):base(highth, width, hightPX, widthPX){}

        public override string ToString()
        {
            return $"ColorfulScreen, highth = {Hight}, width = {Width}, hightPX = {HightPX}, widthPX = {WidthPX}";
        }
        public override string Show(IScreenImage screenImage)
        {
            return "ColorfulScreen image -> " + screenImage.Image;
        } 

        public override string Show(IScreenImage screenImage, int brightness)
        {
            return $"ColorfulScreen image with brightness {brightness} -> {screenImage.Image}";
        }
    }
}
