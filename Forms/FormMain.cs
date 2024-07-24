using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using GlobalInput;
using mouseutil.Properties;

namespace mouseutil
{
    public partial class FormMain : Form
    {
        private readonly bool initialized = false;
        public static Task Task;
        public MouseAnimationDVD dvd;
        public FormMain()
        {
            InitializeComponent();

            PickShortcutRunDVD();
            PickShortcutAddWhitelist();
            Program.formWhiteList.PickWhiteList();
            dvd = new MouseAnimationDVD();

            boxWidth.Value = Math.Max(boxWidth.Minimum, Math.Min(boxWidth.Maximum, Settings.Default.BoxWidth));
            boxHeight.Value = Math.Max(boxHeight.Minimum, Math.Min(boxHeight.Maximum, Settings.Default.BoxHeight));
            speedX.Value = Math.Max(speedX.Minimum, Math.Min(speedX.Maximum, Settings.Default.SpeedHor));
            speedY.Value = Math.Max(speedY.Minimum, Math.Min(speedY.Maximum, Settings.Default.SpeedVer));
            speedRandomMin.Value = Math.Max(speedRandomMin.Minimum, Math.Min(speedRandomMin.Maximum, (decimal)Settings.Default.SpeedRandomMin));
            speedRandomMax.Value = Math.Max(speedRandomMax.Minimum, Math.Min(speedRandomMax.Maximum, (decimal)Settings.Default.SpeedRandomMax));
            framerateNumeric.Value = Math.Max(framerateNumeric.Minimum, Math.Min(framerateNumeric.Maximum, Settings.Default.Framerate));
            clickWhen.DataSource = new BindingSource(MouseAnimationDVD.ClickingChoices.Values, null);
            clickWhen.SelectedItem = Settings.Default.ClickWhen;
            initialized = true;
            runDVDTogglerShortcut.Checked = Settings.Default.ShortcutRunDVDToggler;
        }
        ~FormMain()
        {
            Task.Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Task = Task.Factory.StartNew(() =>
            {
                dvd.Start();
            });
        }

        public void PickShortcutRunDVD()
        {
            if (!GlobalShortcut.TryParse(Settings.Default.ShortcutRunDVD, out Program.ShortcutRunDVD))
            {
                MessageBox.Show("Got invalid config value for the shortcut: '" + Settings.Default.ShortcutRunDVD + "'. Using default.");
                Program.ShortcutRunDVD = new GlobalShortcut(new Key[] { Key.LeftCtrl, Key.LeftShift, Key.A });

                Settings.Default.Save();
            }
            runDVDSetShortcut.Text = Program.ShortcutRunDVD.ToReadableString();
        }

        public void PickShortcutAddWhitelist()
        {
            if (!GlobalShortcut.TryParse(Settings.Default.ShortcutAddWhitelist, out Program.ShortcutAddWhitelist))
            {
                MessageBox.Show("Got invalid config value for the shortcut: '" + Settings.Default.ShortcutAddWhitelist + "'. Using default.");
                Program.ShortcutAddWhitelist = new GlobalShortcut(new Key[] { Key.D });

                Settings.Default.Save();
            }
            addWhitelistSetShortcut.Text = Program.ShortcutAddWhitelist.ToReadableString();
        }

        public GlobalInput.GlobalShortcut PromptShortcut(GlobalInput.GlobalShortcut current)
        {
            var form = new FormGetShortcut(current);
            var ok = form.ShowDialog() == DialogResult.OK;
            if (!ok)
            {
                return null;
            }

            return form.Shortcut;
        }

        private void RunDVDSetShortcut_Click(object sender, EventArgs e)
        {
            var sc = PromptShortcut(Program.ShortcutRunDVD);
            if (sc == null)
            {
                return;
            }
            Settings.Default.ShortcutRunDVD = sc.ToString();
            Settings.Default.Save();
            Program.ShortcutRunDVD = sc;
            runDVDSetShortcut.Text = sc.ToReadableString();
        }

        private void AddWhitelistSetShortcut_Click(object sender, EventArgs e)
        {
            var sc = PromptShortcut(Program.ShortcutAddWhitelist);
            if (sc == null)
            {
                return;
            }
            Settings.Default.ShortcutAddWhitelist = sc.ToString();
            Settings.Default.Save();
            Program.ShortcutAddWhitelist = sc;
            addWhitelistSetShortcut.Text = sc.ToReadableString();
        }

        private void BoxWidth_ValueChanged(object sender, EventArgs e)
        {
            Settings.Default.BoxWidth = (int)boxWidth.Value;
            Settings.Default.Save();
        }

        private void BoxHeight_ValueChanged(object sender, EventArgs e)
        {
            Settings.Default.BoxHeight = (int)boxHeight.Value;
            Settings.Default.Save();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void WhitelistOpen_Click(object sender, EventArgs e)
        {
            Program.formWhiteList.ShowDialog();
        }

        private void SpeedX_ValueChanged(object sender, EventArgs e)
        {
            Settings.Default.SpeedHor = (int)speedX.Value;
            Settings.Default.Save();
        }

        private void SpeedY_ValueChanged(object sender, EventArgs e)
        {
            Settings.Default.SpeedVer = (int)speedY.Value;
            Settings.Default.Save();
        }

        private void FramerateNumeric_ValueChanged(object sender, EventArgs e)
        {
            Settings.Default.Framerate = (int)framerateNumeric.Value;
            Settings.Default.Save();
        }

        private void SpeedRandomMin_ValueChanged(object sender, EventArgs e)
        {
            Settings.Default.SpeedRandomMin = (double)speedRandomMin.Value;
            Settings.Default.Save();
        }

        private void SpeedRandomMax_ValueChanged(object sender, EventArgs e)
        {
            Settings.Default.SpeedRandomMax = (double)speedRandomMax.Value;
            Settings.Default.Save();
        }

        private void GitHubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Mopsgamer/animouse");
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Version version = Assembly.GetEntryAssembly().GetName().Version;
            MessageBox.Show($"Version: {version}");
        }

        private void ClickWhen_Changed(object sender, EventArgs e)
        {
            if (!initialized)
            {
                return;
            }
            Settings.Default.ClickWhen = clickWhen.SelectedItem as string;
            Settings.Default.Save();
        }

        private void RunDVDTogglerShortcut_CheckedChanged(object sender, EventArgs e)
        {
            if(dvd.Running)
            {
                runDVDTogglerShortcut.Checked = !runDVDTogglerShortcut.Checked;
                return;
            }
            Settings.Default.ShortcutRunDVDToggler = runDVDTogglerShortcut.Checked;
            Settings.Default.Save();
        }
    }
}