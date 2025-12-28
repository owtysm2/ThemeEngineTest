using System;
using System.Windows.Forms;

namespace ThemeEngineTest.Forms
{
    public partial class Control_Editor_Form : Form
    {
        public string NewName;
        public bool IsTypeTemplate => changingControlTypeRadio.Checked;

        public Control_Editor_Form(string oldName, bool oldIsTypeTemplate)
        {
            InitializeComponent();

            oldTextbox.Text = oldName;
            newTextbox.Text = oldName;

            changingControlTypeRadio.Checked = oldIsTypeTemplate;
            changingControlNameRadio.Checked = !oldIsTypeTemplate;
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
