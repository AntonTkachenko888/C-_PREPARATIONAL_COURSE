using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using MobilePhone.Base.GeneralInterfaces;
using System.Windows.Forms;
namespace MobilePhone.WindowsFormsApp
{
    public class  FormOutput: IOutput
    {
        private RichTextBox richTextBox;
        public FormOutput(RichTextBox richTextBox)
        {
            this.richTextBox = richTextBox;
        }
        public void Write(string text)
        {
            richTextBox.Text = richTextBox.Text + text;
        }

        public void WriteLine(string text)
        {
            richTextBox.Text = richTextBox.Text +"\n"+ text;
        }
    }
}
