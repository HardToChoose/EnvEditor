using System;
using System.Runtime.InteropServices;

namespace EnvEditor
{
    static class Native
    {
        [DllImport("user32.dll")]
        public static extern bool ShowScrollBar(IntPtr hWnd, int wBar, bool bShow);
    }
}
