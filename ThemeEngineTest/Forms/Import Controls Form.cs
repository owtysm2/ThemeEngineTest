using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ThemeEngineTest.Forms
{
    public partial class Import_Controls_Form : Form
    {
        internal List<Custom_Definitions.ChangingControl> ChangingControlsToImportResult = new List<Custom_Definitions.ChangingControl>();
        internal List<Control> ImportableControlsList = new List<Control>();

        private enum NameOrTypeEnum
        { 
            Names,
            Types,
        }

        void PopulateListboxWith(NameOrTypeEnum namesOrTypes)
        {
            importedControlsListbox.Items.Clear();
            switch (namesOrTypes)
            {
                case NameOrTypeEnum.Names:
                    foreach (Control control in ImportableControlsList)
                    {
                        importedControlsListbox.Items.Add(control.Site?.Name ?? control.Name);
                    }
                    break;
                case NameOrTypeEnum.Types:
                    foreach (Control control in ImportableControlsList)
                    {
                        string typeName = control.GetType().Name;
                        if (importedControlsListbox.Items.Contains(typeName))
                        {
                            continue;
                        }

                        importedControlsListbox.Items.Add(typeName);
                    }
                    break;
            }
        }

        public Import_Controls_Form(Control.ControlCollection importableControls)
        {
            InitializeComponent();
            RecursiveAddToImportableList(importableControls);

            void RecursiveAddToImportableList(Control.ControlCollection parentControlCollection)
            {
                foreach (Control control in parentControlCollection)
                {
                    ImportableControlsList.Add(control);

                    if (control.Controls.Count > 0)
                    {
                        RecursiveAddToImportableList(control.Controls);
                    }
                }
            }

            PopulateListboxWith(NameOrTypeEnum.Types);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var item in importedControlsListbox.CheckedItems)
            {
                ChangingControlsToImportResult.Add(
                    new Custom_Definitions.ChangingControl()
                    {
                        ControlName = item.ToString(),
                        IsTypeTemplate = changingControlTypeRadio.Checked
                    });
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

        private void changingControlNameRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (changingControlNameRadio.Checked)
            {
                PopulateListboxWith(NameOrTypeEnum.Names);
            }
        }

        private void changingControlTypeRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (changingControlTypeRadio.Checked)
            {
                PopulateListboxWith(NameOrTypeEnum.Types);
            }
        }
    }
}
