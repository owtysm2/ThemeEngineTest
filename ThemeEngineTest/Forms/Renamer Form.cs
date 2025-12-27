using System;
using System.Windows.Forms;

namespace ThemeEngineTest.Forms
{
    public partial class Renamer_Form : Form
    {
        public string NewName;

        public Renamer_Form(string oldName)
        {
            InitializeComponent();
            oldTextbox.Text = oldName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewName = newTextbox.Text;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
