using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.Base.Components.Screens
{
    public class OLEDScreen: ColorfulTouchScreen
    {
        public OLEDScreen(int highth, int width, int hightPX, int widthPX):base(highth, width, hightPX, widthPX){ }
        public override string ToString()
        {
            return $"OLEDScreen, highth = {Hight}, width = {Width}, hightPX = {HightPX}, widthPX = {WidthPX}";
        }
        public override string Show(IScreenImage screenImage)
        {
            return "OLEDScreen image -> " + screenImage.Image;
        }

        public override string Show(IScreenImage screenImage, int brightness)
        {
            return $"OLEDScreen image with brightness {brightness} -> {screenImage.Image}";
        }
    }
}
