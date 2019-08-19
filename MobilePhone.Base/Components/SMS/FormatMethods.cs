using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.Base.Components.SMS
{
    public delegate IMessage FormatDelegate(IMessage message);

    public enum StandartFormats
    {
        None = 1,
        StartWithDateTime,
        EndWithDateTime,
        Custom,
        Lowercase,
        Uppercase
    }

    public static class FormatMethods
    {
        private static IMessage None(IMessage message)
        {
            message.Text = $"{message.Text}";
            return message;
        }
        private static IMessage StartWithDateTime(IMessage message)
        {
            message.Text = $"[{message.ReceivingTime}] {message.Text}";
            return message;
        }
        private static IMessage EndWithDateTime(IMessage message)
        {
            message.Text = $"{message.Text} [{message.ReceivingTime}]";
            return message;
        }
        private static IMessage Custom(IMessage message)
        {
            message.Text = $"@@@{message.Text} [{message.ReceivingTime}]@@@";
            return message;
        }
        private static IMessage Lowercase(IMessage message)
        {
            message.Text = $"{message.Text.ToLower()}";
            return message;
        }
        private static IMessage Uppercase(IMessage message)
        {
            message.Text = $"{message.Text.ToUpper()}";
            return message;
        }

        private static FormatDelegate GetFormatMethod(StandartFormats format)
        {
            FormatDelegate del;
            switch (format)
            {
                case StandartFormats.None:
                    del = None;
                    break;
                case StandartFormats.StartWithDateTime:
                    del = StartWithDateTime;
                    break;
                case StandartFormats.EndWithDateTime:
                    del = EndWithDateTime;
                    break;
                case StandartFormats.Custom:
                    del = Custom;
                    break;
                case StandartFormats.Lowercase:
                    del = Lowercase;
                    break;
                case StandartFormats.Uppercase:
                    del = Uppercase;
                    break;
                default:
                    del = None;
                    break;
            }
            return del;
        }
        public static FormatDelegate GetFormatMethod(string format)
        {
            StandartFormats currentFormat;
            FormatDelegate del;
            if (StandartFormats.TryParse(format.Replace(" ", ""), true, out currentFormat))
            {
                del = GetFormatMethod(currentFormat);
            }
            else
            {
                del = None;
            }
            return del;
        }
    }
}
