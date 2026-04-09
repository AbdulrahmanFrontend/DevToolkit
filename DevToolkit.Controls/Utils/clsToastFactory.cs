using BaseUI.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseUI.Utils
{
    public static class clsToastFactory
    {
        public static clsToastData Success(string msg)
        {
            return new clsToastData
            {
                Message = msg,
                BackColor = Color.SeaGreen,
                Icon = Resources.icons8_checkmark_36,
            };
        }

        public static clsToastData Error(string msg)
        {
            return new clsToastData
            {
                Message = msg,
                BackColor = Color.DarkRed,
                Icon = Resources.icons8_close_36,
            };
        }

        public static clsToastData Warning(string msg)
        {
            return new clsToastData
            {
                Message = msg,
                BackColor = Color.DarkOrange,
                Icon = Resources.icons8_brake_warning_36,
            };
        }

        public static clsToastData Info(string msg)
        {
            return new clsToastData
            {
                Message = msg,
                BackColor = Color.RoyalBlue,
                Icon = Resources.icons8_information_50,
            };
        }
    }
}
