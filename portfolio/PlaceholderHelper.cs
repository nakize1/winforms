using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace portfolio
{
    public static class PlaceholderHelper
    {
        private const int EM_SETCUEBANNER = 0x1501;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);

        public static void SetPlaceholder(TextBox control, string text)
        {
            // TRUE (1) for wParam shows the placeholder even when the control has focus
            SendMessage(control.Handle, EM_SETCUEBANNER, 1, text);
        }
    }
}
