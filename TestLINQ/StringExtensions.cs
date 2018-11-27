using System.Globalization;
using System.Threading;

namespace TestLINQ
{
    public static class StringExtensions
    {
        public static string ConvertToTitleCase(this string source)
        {
            CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cultureInfo.TextInfo;

            return textInfo.ToTitleCase(source);
        }
    }
}
