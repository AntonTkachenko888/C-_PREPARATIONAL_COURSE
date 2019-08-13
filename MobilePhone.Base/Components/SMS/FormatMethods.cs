using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.Base.Components.SMS
{
    public delegate string FormatDelegate(string message);

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
        private static string None(string message)
        {
            return $"{message}";
        }
        private static string StartWithDateTime(string message)
        {
            return $"[{DateTime.Now}] {message}";
        }
        private static string EndWithDateTime(string message)
        {
            return $"{message} [{DateTime.Now}]";
        }
        private static string Custom(string message)
        {
            return $"@@@{message} [{DateTime.Now}]@@@";
        }
        private static string Lowercase(string message)
        {
            return $"{message.ToLower()}";
        }
        private static string Uppercase(string message)
        {
            return $"{message.ToUpper()}";
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
