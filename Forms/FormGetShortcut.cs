using System;
using System.Windows.Forms;
using GlobalInput;

namespace mouseutil
{
    public partial class FormGetShortcut : Form
    {
        public GlobalInput.GlobalShortcut Shortcut;

        public FormGetShortcut(GlobalInput.GlobalShortcut shortcut)
        {
            InitializeComponent();
            Shortcut = shortcut;
            shortcutValue.Text = shortcut.ToString();
            GlobalKeyboard.OnKey += UpdateShortcutLabel;
        }

        ~FormGetShortcut()
        {
            GlobalKeyboard.OnKey -= UpdateShortcutLabel;
        }

        void UpdateShortcutLabel(object sender, EventArgs e)
        {
            Shortcut = GlobalKeyboard.lastShortcut ?? Shortcut;
            shortcutValue.Text = Shortcut.ToReadableString();
        }
    }
}
