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

        protected int vDPI;
        public virtual int DPI
        {
            get { return vDPI; }
            set
            {
                if (value >= 100)
                {
                    vDPI = value;
                }
                else
                {
                    throw new Exception("Value can't be less than 100");
                }
            }
        }

        protected ScreenBase(int hiight, int width,int dpi)
        {
            Hight = hiight;
            Width = width;
            DPI = dpi;
        }
        public abstract string Show(IScreenImage screenImage);
        public abstract string Show(IScreenImage screenImage, int brightness);

    }
}
