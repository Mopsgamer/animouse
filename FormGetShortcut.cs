using System;
using System.Windows.Forms;
using System.Windows.Input;

namespace animouse
{
    public partial class FormGetShortcut : Form
    {
        public Shortcut Shortcut;

        public FormGetShortcut(Shortcut shortcut)
        {
            InitializeComponent();
            Shortcut = shortcut;
            shortcutValue.Text = shortcut.ToString();
            GlobalKeyboard.Key += UpdateShortcutLabel;
        }

        void UpdateShortcutLabel(object sender, EventArgs e)
        {
            Shortcut = GlobalKeyboard.lastShortcut ?? Shortcut;
            shortcutValue.Text = Shortcut.ToReadableString();
        }
    }
}
