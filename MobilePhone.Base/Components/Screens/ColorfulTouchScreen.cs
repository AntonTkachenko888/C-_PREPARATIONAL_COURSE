using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.Base.Components.Screens
{
    public class ColorfulTouchScreen : ColorfulScreen
    {
        private int vTouches=1;
        
        public int Touches
        {
            get { return vTouches; }
            set
            {
                if (value >= 1)
                {
                    vTouches = value;
                }
                else
                {
                    throw new Exception("Value can't be less than 1");
                }
            }
        }

        public ColorfulTouchScreen(int highth, int width, int dpi) : base(highth, width, dpi) { }
        
        public override string ToString()
        {
            return $"ColorfulTouchScreen, highth = {Hight}, width = {Width}, DPI = {DPI}";
        }
        public override string Show(IScreenImage screenImage)
        {
            return "ColorfulTouchScreen image -> " + screenImage.Image;
        }

        public override string Show(IScreenImage screenImage, int brightness)
        {
            return $"ColorfulTouchScreen image with brightness {brightness} -> {screenImage.Image}";
        }
    }
}
