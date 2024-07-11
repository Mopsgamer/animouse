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
        }

        void UpdateShortcutLabel(object sender, EventArgs e)
        {
            if (GlobalKeyboard.IsDown(Key.Enter))
            {
                return;
            }
            Shortcut = GlobalKeyboard.lastShortcut ?? Shortcut;
            shortcutValue.Text = Shortcut.ToReadableString();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            UpdateShortcutLabel(sender, e);
        }
    }
}
