using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K2Lin_Crypto
{
    public static class ThemeColor
    {
        public static Color PrimaryColor { get; set; }
        public static Color SecondaryColor { get; set; }
        public static List<string> ColorList = new List<string>() { "#3F51B5",
                                                                    "#497CD0",
                                                                    "#FFC1C1",
                                                                    "#8594F2",
                                                                    "#007FC5",
                                                                    "#25B7D3",
                                                                    "#1E92A9",
                                                                    "#F79CD6",
                                                                    "#4A8AF4",
                                                                    "#DD5145",
                                                                    "#009688",
                                                                    "#FF5722",
                                                                    "#A1C7DE",
                                                                    "#FF9200",
                                                                    "#FF9825",
                                                                    "#607D8B",
                                                                    "#FF9800",
                                                                    "#F3A4FF",
                                                                    "#2196F3",
                                                                    "#EA676C",
                                                                    "#E41A4A",
                                                                    "#FFF200",
                                                                    "#2FD9E5",
                                                                    "#B3C8EA",
                                                                    "#00B0AD",
                                                                    "#F59FCA",
                                                                    "#FFBDF3",
                                                                    "#EF937E",
                                                                    "#87FFC8",
                                                                    "#F57AAF",
                                                                    "#F7BEF0",
                                                                    "#7BC9F6",
                                                                    "#92CAEF",
                                                                    "#00CCCC",
                                                                    "#FFCCCC",
                                                                    "#E4126B",
                                                                    "#43B76E",
                                                                    "#7BCFE9",
                                                                    "#FFC1CC"};
        public static Color ChangeColorBrightness(Color color, double correctionFactor)
        {
            double red = color.R;
            double green = color.G;
            double blue = color.B;

            //If correction factor is less than 0, darken color.
            if (correctionFactor < 0)
            {
                correctionFactor = 1 + correctionFactor;
                red *= correctionFactor;
                green *= correctionFactor;
                blue *= correctionFactor;
            }
            //If correction factor is greater than zero, lighten color.
            else
            {
                red = (255 - red) * correctionFactor + red;
                green = (255 - green) * correctionFactor + green;
                blue = (255 - blue) * correctionFactor + blue;
            }

            return Color.FromArgb(color.A, (byte)red, (byte)green, (byte)blue);
        }
    }
}
