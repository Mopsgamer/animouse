using mouseutil.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mouseutil
{
    public partial class FormSetupWhiteList : Form
    {
        private readonly List<string> runningList = new List<string> { };
        public GlobalInput.GlobalShortcut Shortcut;
        public GlobalInput.GlobalShortcut ShortcutOwn;
        public FormSetupWhiteList()
        {
            InitializeComponent();
            RefreshRunningList();
            PickUseProcWhitelist();
        }

        public static void PickToListBox(ListBox listBox, object[] list)
        {
            if (listBox.InvokeRequired)
            {
                listBox.Invoke(new MethodInvoker(delegate ()
                {
                    PickToListBox(listBox, list);
                }));
                return;
            }
            var itemList = listBox.Items.Cast<object>().ToArray();
            foreach (var item in itemList)
            {
                if (!list.Contains(item))
                {
                    listBox.Items.Remove(item);
                }
            }
            foreach (var item in list)
            {
                if (!listBox.Items.Contains(item))
                {
                    listBox.Items.Add(item);
                }
            }
        }

        public void PickUseProcWhitelist()
        {
            useProcWhitelist.Checked = Settings.Default.UseProcWhitelist;
            tableMain3Cols.Enabled = Settings.Default.UseProcWhitelist;
        }

        public void PickWhiteList(string[] whiteList)
        {
            Settings.Default.WhiteList.Clear();
            Settings.Default.WhiteList.AddRange(whiteList);

            PickWhiteList();
        }

        public void PickWhiteList()
        {
            PickToListBox(whiteListBox, Settings.Default.WhiteList.Cast<string>().ToArray());
            Settings.Default.Save();
        }

        private void PickRunningList()
        {
            PickToListBox(runningListBox, runningList.ToArray());
        }

        public void RefreshRunningList()
        {
            Task task = Task.Factory.StartNew(() =>
            {
                foreach (var item in Program.GetAllProcesses().ToArray())
                {
                    if (!runningList.Contains(item))
                    {
                        runningList.Add(item);
                    }
                }
                PickRunningList();
            });
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selectedItems = whiteListBox.SelectedItems.Cast<string>().ToArray();
            var leaveItems = new List<string>(whiteListBox.Items.Cast<string>())
            .Except(selectedItems).ToArray();
            PickWhiteList(leaveItems);
        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormGetText("Add new whitelist item:");
            var ok = form.ShowDialog() == DialogResult.OK;
            if (!ok)
            {
                return;
            }

            var newItem = form.input.Text;
            if (!Settings.Default.WhiteList.Contains(newItem))
            {
                Settings.Default.WhiteList.Add(newItem);
            }
            PickWhiteList();
        }

        private void AllowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (string item in runningListBox.SelectedItems)
            {
                if (!Settings.Default.WhiteList.Contains(item))
                {
                    Settings.Default.WhiteList.Add(item);
                }
            }
            PickWhiteList();
        }

        private void RejectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (string item in runningListBox.SelectedItems)
            {
                if (Settings.Default.WhiteList.Contains(item))
                {
                    Settings.Default.WhiteList.Remove(item);
                }
            }
            PickWhiteList();
        }

        private void RefreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshRunningList();
        }

        private void UseProcWhitelist_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.UseProcWhitelist = useProcWhitelist.Checked;
            Settings.Default.Save();
            PickUseProcWhitelist();
        }
    }
}
