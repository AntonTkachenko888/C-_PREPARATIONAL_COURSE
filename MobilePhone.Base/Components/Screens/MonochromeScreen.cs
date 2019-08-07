using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.Base.Components.Screens
{
    public class MonochromeScreen : ScreenBase
    {
        public MonochromeScreen(int highth, int width, int dpi) : base(highth, width, dpi) { }

        public override string ToString()
        {
            return $"MonochromeScreen, highth = {Hight}, width = {Width}, DPI = {DPI}";
        }


        public override string Show(IScreenImage screenImage)
        {
            return "MonochromeScreen -> " + screenImage.Image;
        }

        public override string Show(IScreenImage screenImage, int brightness)
        {
            return $"MonochromeScreen with brightness {brightness} -> {screenImage.Image}";
        }
    }
}
