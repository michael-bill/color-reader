using System;
using System.Runtime.InteropServices;

namespace ColorReader
{
    class MainController
    {

        [DllImport("user32.dll")]
        public static extern short GetAsyncKeyState(int key);

        public static string GetRGBText(byte[] rgb)
        {
            return rgb[0] + ", " + rgb[1] + ", " + rgb[2];
        }

        public static string GetHEXText(byte[] rgb)
        {
            string t1, t2, t3;
            if (rgb[0] < 16) t1 = "0" + Convert.ToString(rgb[0], 16);
            else t1 = Convert.ToString(rgb[0], 16);
            if (rgb[1] < 16) t2 = "0" + Convert.ToString(rgb[1], 16);
            else t2 = Convert.ToString(rgb[1], 16);
            if (rgb[2] < 16) t3 = "0" + Convert.ToString(rgb[2], 16);
            else t3 = Convert.ToString(rgb[2], 16);
            return (t1 + t2 + t3).ToUpper();
        }
    }
}
