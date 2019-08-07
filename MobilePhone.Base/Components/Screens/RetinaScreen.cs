using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.Base.Components.Screens
{
    public class RetinaScreen: ColorfulTouchScreen
    {
        public RetinaScreen(int highth, int width, int dpi):base(highth, width, dpi){ }

        public override int DPI
        {
            get { return vDPI; }
            set
            {
                if (value >= 300)
                {
                    vDPI = value;
                }
                else
                {
                    throw new Exception("Value can't be less than 100 for retina screen");
                }
            }
        }

        public override string ToString()
        {
            return $"RetinaScreen, highth = {Hight}, width = {Width}, DPI = {DPI}";
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
