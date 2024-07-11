using System.Windows.Forms;

namespace animouse
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

        private void input_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode != Keys.Enter)
            {
                return;
            }
            okButton.PerformClick();
        }
    }
}
