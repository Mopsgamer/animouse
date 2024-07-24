using System.Windows.Forms;

namespace mouseutil
{
    public partial class FormGetText : Form
    {
        public FormGetText()
        {
            InitializeComponent();
        }

        public FormGetText(string note)
        {
            InitializeComponent();
            noteLabel.Text = note;
        }

        private void Input_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode != Keys.Enter)
            {
                return;
            }
            okButton.PerformClick();
        }
    }
}
