using mouseutil;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace GlobalInput
{
    public class GlobalCursor
    {
        public static Point Position
        {
            get { return Cursor.Position; }
            set { mouse_event(0x0001, value.X, value.Y, 0, 0); }
        }

        public static void ClickLeft(Point pos)
        {
            mouse_event(0x02 | 0x04, pos.X, pos.Y, 0, 0);
        }

        public static void ClickRight(Point pos)
        {
            mouse_event(0x08 | 0x10, pos.X, pos.Y, 0, 0);
        }

        [DllImport("user32.dll")]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

    }
}
