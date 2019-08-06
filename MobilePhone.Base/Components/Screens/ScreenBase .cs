using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.Base.Components.Screens
{
    public abstract class ScreenBase
    {
        private int vHight;
        public int Hight
        {
            get { return vHight; }
            set
            {
                if (value >= 1)
                {
                    vHight = value;
                }
                else
                {
                    throw new Exception("Value can't be less than 1");
                }
            }
        }

        private int vWidth;
        public int Width
        {
            get { return vWidth; }
            set
            {
                if (value >= 1)
                {
                    vWidth = value;
                }
                else
                {
                    throw new Exception("Value can't be less than 1");
                }
            }
        }

        private int vHightPX;
        public int HightPX
        {
            get { return vHightPX; }
            set
            {
                if (value >= 1)
                {
                    vHightPX = value;
                }
                else
                {
                    throw new Exception("Value can't be less than 1");
                }
            }
        }

        private int vWidthPX;
        public int WidthPX
        {
            get { return vWidthPX; }
            set
            {
                if (value >= 1)
                {
                    vWidthPX = value;
                }
                else
                {
                    throw new Exception("Value can't be less than 1");
                }
            }
        }

        protected ScreenBase(int highth, int width, int hightPX, int widthPX)
        {
            Hight = highth;
            Width = width;
            HightPX = hightPX;
            WidthPX = widthPX;
        }
        public abstract string Show(IScreenImage screenImage);
        public abstract string Show(IScreenImage screenImage, int brightness);

    }
}
