using System.Globalization;

namespace Pracownia.ViewHelpers
{
    public static class CarDisplayHelper
    {
        public static string FormatAsCurrency(this int value)
        {
            return value.ToString("C", CultureInfo.CreateSpecificCulture("pl-PL"));
        }

        public static string FormatAsFuelType(this char type)
        {
            switch (type)
            {
                case 'B':
                    return "Benzyna";
                case 'D':
                    return "Diesel";
                default:
                    return "Elektryczny";
            };
        }

        public static string FormatAsPower(this int power)
        {
            return string.Format("{0}KM", power);
        }

        public static string FormatAsCapacity(this int capacity)
        {
            return string.Format("{0}ccm", capacity);
        }

        public static string FormatAsGearbox(this char gearbox)
        {
            switch(gearbox)
            {
                case 'A':
                    return "Automatyczna";
                case 'M':
                    return "Manualna";
                default:
                    return "Bezstopniowa";
            };
        }
    }
}