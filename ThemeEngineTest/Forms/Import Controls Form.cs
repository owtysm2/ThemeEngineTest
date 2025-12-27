using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ThemeEngineTest.Forms
{
    public partial class Import_Controls_Form : Form
    {
        internal List<string> ControlsToImportNamesResult = new List<string>();

        public Import_Controls_Form(Control.ControlCollection importableControls)
        {
            InitializeComponent();
            RecursiveAddToListbox(importableControls);

            void RecursiveAddToListbox(Control.ControlCollection parentControlCollection)
            {
                foreach (Control control in parentControlCollection)
                {
                    importedControlsListbox.Items.Add(
                        control.Site?.Name ?? control.Name,
                        true
                    );


                    if (control.Controls.Count > 0)
                    {
                        RecursiveAddToListbox(control.Controls);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var item in importedControlsListbox.CheckedItems)
            {
                ControlsToImportNamesResult.Add(item.ToString());
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void selectAllButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < importedControlsListbox.Items.Count; i++)
            {
                importedControlsListbox.SetItemChecked(i, true);
            }
        }

        private void deselectAllButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < importedControlsListbox.Items.Count; i++)
            {
                importedControlsListbox.SetItemChecked(i, false);
            }
        }
    }
}
