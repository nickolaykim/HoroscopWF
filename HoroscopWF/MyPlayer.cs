using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HoroscopWF
{
    class MyPlayer
    {
        [DllImport("winmm.dll")]
        static extern Int32 mciSendString(string command, StringBuilder buffer, int bufferSize, IntPtr hwndCallback);
        public static void Play(string FileName)
        {
            StringBuilder sb = new StringBuilder();
            mciSendString("open \"" + FileName + "\" alias media", sb, 0, IntPtr.Zero);
            mciSendString("play media", sb, 0, IntPtr.Zero);
        }
    }
}
