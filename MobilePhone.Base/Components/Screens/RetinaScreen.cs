using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.Base.Components.Screens
{
    public class RetinaScreen: ColorfulTouchScreen
    {
        public RetinaScreen(int highth, int width, int hightPX, int widthPX):base(highth, width, hightPX, widthPX){ }

        public override string ToString()
        {
            return $"RetinaScreen, highth = {Hight}, width = {Width}, hightPX = {HightPX}, widthPX = {WidthPX}";
        }
        public override string Show(IScreenImage screenImage)
        {
            return "RetinaScreen image -> " + screenImage.Image;
        }

        public override string Show(IScreenImage screenImage, int brightness)
        {
            return $"RetinaScreen image with brightness {brightness} -> {screenImage.Image}";
        }
    }
}
