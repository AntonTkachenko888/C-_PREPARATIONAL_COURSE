using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobilePhone.Base.GeneralInterfaces;
using System.Windows.Forms;

namespace MobilePhone.WindowsFormsApp
{
    public class FormOutputTextBox:IOutput
    {
        private TextBox textBox;
        public FormOutputTextBox(TextBox textBox)
        {
            this.textBox = textBox;
        }
        public void Write(string text="")
        {
            textBox.Text = text;
        }

        public void WriteLine(string text="")
        {
            textBox.Text = text;
        }
    }
}
