using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ThemeEngineTest.Components;

namespace ThemeEngineTest.Forms
{
    public partial class Theme_Editor_Form : Form
    {
        public Theme_Editor_Form()
        {
            InitializeComponent();
        }

        internal Form referenceToFormOpenedInDesigner = null;
        private Random rnd = new Random();

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public Custom_Definitions.Theme EditedTheme { get; set; } = new Custom_Definitions.Theme();

        private Custom_Definitions.ChangingControl GetSelectedChangingControl() => EditedTheme.GetChangingControlByName((string)controlsNamesListbox.SelectedItem);
        private Custom_Definitions.ChangingProperty GetSelectedChangingProperty() => SafeGetSelectedChangingProperty();
        private Custom_Definitions.ChangingProperty SafeGetSelectedChangingProperty()
        {
            Custom_Definitions.ChangingControl currentChangingControl = GetSelectedChangingControl();
            return currentChangingControl == null ? null : currentChangingControl.GetChangingPropertyByName((string)propertiesListbox.SelectedItem);
        }

        internal void LoadTheme(Theme_Definer themeDefiner)
        {
            EditedTheme = themeDefiner.ThemeObject.Clone(addCopyToName: false);
            string themeName = EditedTheme.Name.Trim();

            if (themeName == string.Empty)
            {
                EditedTheme.Name = "Theme " + rnd.Next().ToString("x");
            }

            // Set-up CONTROL section

            // show theme name in the textbox
            themeNameTextbox.Text = EditedTheme.Name;

            // load controls list into the controls listbox
            if (EditedTheme.ChangingControls != null)
            {
                controlsNamesListbox.Items.Clear();
                foreach (Custom_Definitions.ChangingControl changingControl in EditedTheme.ChangingControls)
                {
                    controlsNamesListbox.Items.Add(changingControl.ControlName);
                }
            }

            // Set-up PROPERTIES section

            // set the property type combo
            propertyTypeComboBox.SelectedItem = "Color";

            setupPropertyColorPicker();
            propertyValueColorPicker.Content = Color.White;

            setupPropertyNameTextbox();
            setupPropertyValueTextbox();
            setupPropertyValueCheckbox();

            void setupPropertyValueCheckbox()
            {
                propertyValueCheckbox.CheckedChanged += (e, s) =>
                {
                    if (preventPropertyUpdates)
                    {
                        return;
                    }

                    // update current selected property's value to the newly selected color
                    Custom_Definitions.ChangingProperty currentChangingProperty = GetSelectedChangingProperty();
                    if (currentChangingProperty != null)
                    {
                        currentChangingProperty.PropertyValue = propertyValueCheckbox.Checked;
                    }
                };
            }

            void setupPropertyValueTextbox()
            {
                propertyValueTextbox.TextChanged += (e, s) =>
                {
                    if (preventPropertyUpdates)
                    {
                        return;
                    }

                    // update current selected property's value to the newly selected color
                    Custom_Definitions.ChangingProperty currentChangingProperty = GetSelectedChangingProperty();
                    if (currentChangingProperty != null)
                    {
                        string newStringValue = propertyValueTextbox.Text.Trim();
                        if (newStringValue != string.Empty)
                        {
                            currentChangingProperty.PropertyValue = propertyValueTextbox.Text;
                        }
                    }
                };
            }

            void setupPropertyNameTextbox()
            {
                propertyNameTextbox.TextChanged += (e, s) =>
                {
                    // update current selected property's value to the newly typed in text value
                    Custom_Definitions.ChangingProperty currentChangingProperty = GetSelectedChangingProperty();
                    if (currentChangingProperty != null)
                    {
                        string newName = propertyNameTextbox.Text.Trim();
                        if (newName != string.Empty)
                        {
                            propertiesListbox.SuspendLayout();

                            // remove old name from the listbox
                            int listboxIndex = propertiesListbox.Items.IndexOf(currentChangingProperty.PropertyName);
                            propertiesListbox.Items.RemoveAt(listboxIndex);

                            // update selected property's PropertyName
                            currentChangingProperty.PropertyName = propertyNameTextbox.Text;

                            // update listbox with the new name at the index of the old name
                            propertiesListbox.Items.Insert(listboxIndex, currentChangingProperty.PropertyName);

                            // re-select the now-renamed property
                            propertiesListbox.SelectedItem = currentChangingProperty.PropertyName;

                            // re-focus on the textbox
                            propertyNameTextbox.Focus();
                            // also remove selection as re-focusing selects all text
                            propertyNameTextbox.SelectionLength = 0;
                            // .. and move the selection to the front
                            propertyNameTextbox.SelectionStart = propertyNameTextbox.Text.Length;
                        }
                    }
                };
            }

            void setupPropertyColorPicker()
            {
                setupTextbox(aTextbox, 0);
                setupTextbox(rTextbox, 1);
                setupTextbox(gTextbox, 2);
                setupTextbox(bTextbox, 3);

                propertyValueColorPicker.ContentChanged += (e, s) =>
                {
                    if (preventPropertyUpdates)
                    {
                        return;
                    }

                    void updateTextbox(TextBox tb, string newValue)
                    {
                        if (tb.Text != newValue)
                        {
                            tb.Text = newValue;
                        }
                    }

                    // update current selected property's value to the newly selected color
                    Custom_Definitions.ChangingProperty currentChangingProperty = GetSelectedChangingProperty();
                    if (currentChangingProperty != null)
                    {
                        updateTextbox(aTextbox, propertyValueColorPicker.Content.A.ToString());
                        updateTextbox(rTextbox, propertyValueColorPicker.Content.R.ToString());
                        updateTextbox(gTextbox, propertyValueColorPicker.Content.G.ToString());
                        updateTextbox(bTextbox, propertyValueColorPicker.Content.B.ToString());

                        currentChangingProperty.PropertyValue = Color.FromArgb(int.Parse(aTextbox.Text), propertyValueColorPicker.Content);
                    }
                };

                void setupTextbox(TextBox tb, byte num)
                {
                    string previousText = "255";

                    tb.TextChanged += (e, s) =>
                    {
                        // true means that the text was not a number
                        if (!int.TryParse(tb.Text, out int newValue))
                        {
                            tb.Text = previousText;
                            return;
                        }
                        else
                        {
                            previousText = tb.Text;
                            Color c = propertyValueColorPicker.Content;
                            switch (num)
                            {
                                case 0: // A
                                    c = Color.FromArgb(newValue, c);
                                    break;
                                case 1: // R
                                    c = Color.FromArgb(c.A, newValue, c.G, c.B);
                                    break;
                                case 2: // G
                                    c = Color.FromArgb(c.A, c.R, newValue, c.B);
                                    break;
                                case 3: // B
                                    c = Color.FromArgb(c.A, c.R, c.G, newValue);
                                    break;
                            }
                            propertyValueColorPicker.Content = c;
                        }
                    };
                }
            }
        }

        private void addControlNameButton_Click(object sender, EventArgs e)
        {
            string controlName = controlNameTextbox.Text.Trim();
            if (controlName != string.Empty && !controlsNamesListbox.Items.Contains(controlName))
            {
                controlsNamesListbox.Items.Add(controlName);
                EditedTheme.ChangingControls.Add(
                    new Custom_Definitions.ChangingControl()
                    {
                        ControlName = controlName,
                        IsTypeTemplate = changingControlTypeRadio.Checked

                    }
                );
            }
        }

        private void controlsNamesListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // only show the properties editor if theres any control name selected
            propertiesGroupBox.Visible = controlsNamesListbox.SelectedIndex > -1;

            // a changing control is selected in the listbox
            if (propertiesGroupBox.Visible)
            {
                Custom_Definitions.ChangingControl currentChangingControl = GetSelectedChangingControl();
                if (currentChangingControl != null)
                {
                    changingControlPropertiesTypeRadio.Checked = currentChangingControl.IsTypeTemplate;
                    changingControlPropertiesNameRadio.Checked = !currentChangingControl.IsTypeTemplate;
                    changingControlPropertiesNameTextbox.Text = currentChangingControl.ControlName;

                    // populate the properties listbox based on the selected control's properties
                    propertiesListbox.Items.Clear();
                    foreach (Custom_Definitions.ChangingProperty changingProperty in currentChangingControl.ChangingProperties)
                    {
                        if (changingProperty != null && changingProperty.PropertyName != null)
                        {
                            propertiesListbox.Items.Add(changingProperty.PropertyName);
                        }
                    }
                }
            }
        }

        private void removeSelectedControlButton_Click(object sender, EventArgs e)
        {
            // returns true if the removal succeeded
            bool TryRemoveControlFromListbox(Custom_Definitions.ChangingControl controlToRemove)
            {
                if (controlToRemove != null && controlsNamesListbox.Items.Contains(controlToRemove.ControlName))
                {
                    controlsNamesListbox.Items.Remove(controlToRemove.ControlName);
                    return true;
                }

                return false;
            }

            if (propertiesGroupBox.Visible)
            {
                Custom_Definitions.ChangingControl currentChangingControl = GetSelectedChangingControl();
                if (TryRemoveControlFromListbox(currentChangingControl))
                {
                    EditedTheme.ChangingControls.Remove(currentChangingControl);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }


        BindingList<Type> typesInFormOpenedInDesigner = null;
        private void addPropertyButton_Click(object sender, EventArgs e)
        {
            Custom_Definitions.ChangingControl currentChangingControl = GetSelectedChangingControl();

            Type typeWhichCanBeUsedToGetPropertiesAutomatically = null;
            void CheckIfPropertiesCanBeRetrievedAutomatically()
            {
                if (referenceToFormOpenedInDesigner != null)
                {
                    if (typesInFormOpenedInDesigner == null)
                    {
                        void RecursiveAddToTypesList(Control.ControlCollection parentControlCollection)
                        {
                            foreach (Control control in parentControlCollection)
                            {
                                typesInFormOpenedInDesigner.Add(control.GetType());

                                if (control.Controls.Count > 0)
                                {
                                    RecursiveAddToTypesList(control.Controls);
                                }
                            }
                        }

                        // populate list with available types in the form opened in the designer
                        typesInFormOpenedInDesigner = new BindingList<Type>();
                        RecursiveAddToTypesList(referenceToFormOpenedInDesigner.Controls);
                    }

                    if (currentChangingControl != null && currentChangingControl.IsTypeTemplate && typesInFormOpenedInDesigner != null)
                    {
                        foreach (Type type in typesInFormOpenedInDesigner)
                        {
                            if (type.Name == currentChangingControl.ControlName)
                            {
                                typeWhichCanBeUsedToGetPropertiesAutomatically = type;
                            }
                        }
                    }
                }
            }

            if (currentChangingControl != null)
            {
                CheckIfPropertiesCanBeRetrievedAutomatically();
                bool canAutoRetrieveProperties = typeWhichCanBeUsedToGetPropertiesAutomatically != null;
                if (canAutoRetrieveProperties)
                {
                    using (Import_Properties_From_Type_Form propertiesImporterForm = new Import_Properties_From_Type_Form(propertiesListbox.Items, typeWhichCanBeUsedToGetPropertiesAutomatically))
                    {
                        if (propertiesImporterForm.ShowDialog() == DialogResult.OK)
                        {
                            // clone, since currentChangingControl is not the owner of propertiesImporterForm.CreatedChangingProperties
                            // and adding them directly could cause problems
                            foreach (Custom_Definitions.ChangingProperty changingProperty in propertiesImporterForm.SelectedChangingProperties)
                            {
                                // "propertiesImporterForm"'s constructor makes sure there are
                                // no duplicates, so no need to do the listbox items check here
                                currentChangingControl.ChangingProperties.Add(
                                    new Custom_Definitions.ChangingProperty()
                                    {
                                        PropertyName = changingProperty.PropertyName,
                                        PropertyType = changingProperty.PropertyType,
                                        PropertyValue = changingProperty.PropertyValue
                                    });
                                propertiesListbox.Items.Add(changingProperty.PropertyName);
                            }
                        }
                    }

                    // dont show the property creator if the easier-to-use picker form had been shown
                    return;
                }

                Property_Creator_Form propertyCreatorForm = new Property_Creator_Form();

                if (propertyCreatorForm.ShowDialog() == DialogResult.OK)
                {
                    currentChangingControl.ChangingProperties.Add(propertyCreatorForm.CreatedProperty);
                    propertiesListbox.Items.Add(propertyCreatorForm.CreatedProperty.PropertyName);
                }
            }
        }

        private void propertyTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Custom_Definitions.ChangingProperty currentChangingProperty = GetSelectedChangingProperty();
            bool canEditChangingPropertyObject = currentChangingProperty != null && !preventPropertyUpdates;

            preventPropertyUpdates = true;
            switch ((string)propertyTypeComboBox.SelectedItem)
            {
                case "String":
                    propertyValueTextbox.Visible = true;
                    propertyColorPickerPanel.Visible = false;
                    propertyValueCheckbox.Visible = false;
                    if (canEditChangingPropertyObject)
                    {
                        currentChangingProperty.PropertyType = Custom_Definitions.PropertyType.String;
                        currentChangingProperty.PropertyValue = "";
                        propertyValueTextbox.Text = "";
                    }

                    break;
                case "Color":
                    propertyColorPickerPanel.Visible = true;
                    propertyValueCheckbox.Visible = false;
                    propertyValueTextbox.Visible = false;
                    if (canEditChangingPropertyObject)
                    {
                        currentChangingProperty.PropertyType = Custom_Definitions.PropertyType.Color;
                        currentChangingProperty.PropertyValue = Color.White;
                        propertyValueColorPicker.Content = Color.White;
                        aTextbox.Text = 255.ToString();
                        rTextbox.Text = 255.ToString();
                        gTextbox.Text = 255.ToString();
                        bTextbox.Text = 255.ToString();
                    }
                    break;
                case "Bool":
                    propertyValueCheckbox.Visible = true;
                    propertyValueTextbox.Visible = false;
                    propertyColorPickerPanel.Visible = false;
                    if (canEditChangingPropertyObject)
                    {
                        currentChangingProperty.PropertyType = Custom_Definitions.PropertyType.Bool;
                        currentChangingProperty.PropertyValue = false;
                        propertyValueCheckbox.Checked = false;
                    }
                    break;
            }
            preventPropertyUpdates = false;
        }

        private void themeNameTextbox_TextChanged(object sender, EventArgs e)
        {
            EditedTheme.Name = themeNameTextbox.Text;
        }

        bool preventPropertyUpdates = false;

        private void propertiesListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            propertyEditorPanel.Visible = propertiesListbox.SelectedIndex > -1;

            Custom_Definitions.ChangingProperty currentChangingProperty = GetSelectedChangingProperty();
            if (currentChangingProperty != null)
            {
                propertyNameTextbox.Text = currentChangingProperty.PropertyName;
                preventPropertyUpdates = true;
                propertyTypeComboBox.SelectedItem = currentChangingProperty.PropertyType.ToString();
                preventPropertyUpdates = false;

                preventPropertyUpdates = true;
                try
                {
                    switch (currentChangingProperty.PropertyType)
                    {
                        case Custom_Definitions.PropertyType.String:
                            propertyValueTextbox.Text = (string)currentChangingProperty.PropertyValue;
                            break;
                        case Custom_Definitions.PropertyType.Color:
                            Color c = (Color)currentChangingProperty.PropertyValue;
                            aTextbox.Text = c.A.ToString();
                            rTextbox.Text = c.R.ToString();
                            gTextbox.Text = c.G.ToString();
                            bTextbox.Text = c.B.ToString();
                            propertyValueColorPicker.Content = c;
                            break;
                        case Custom_Definitions.PropertyType.Bool:
                            propertyValueCheckbox.Checked = (bool)currentChangingProperty.PropertyValue;
                            break;
                    }
                }
                catch
                {
                    // cast not succeeded
                    // this means the developer selected another type from the combobox
                    // but didnt modify the value

                    // this set the value to a default one
                    switch (currentChangingProperty.PropertyType)
                    {
                        case Custom_Definitions.PropertyType.String:
                            currentChangingProperty.PropertyValue = "";
                            propertyValueTextbox.Text = "";
                            break;
                        case Custom_Definitions.PropertyType.Color:
                            currentChangingProperty.PropertyValue = Color.White;
                            propertyValueColorPicker.Content = Color.White;
                            aTextbox.Text = 255.ToString();
                            rTextbox.Text = 255.ToString();
                            gTextbox.Text = 255.ToString();
                            bTextbox.Text = 255.ToString();
                            break;
                        case Custom_Definitions.PropertyType.Bool:
                            currentChangingProperty.PropertyValue = false;
                            propertyValueCheckbox.Checked = false;
                            break;
                    }
                }
                preventPropertyUpdates = false;
            }
        }

        private void removeSelectedPropertyButton_Click(object sender, EventArgs e)
        {
            Custom_Definitions.ChangingProperty currentChangingProperty = GetSelectedChangingProperty();
            if (currentChangingProperty != null)
            {
                GetSelectedChangingControl().ChangingProperties.Remove(currentChangingProperty);
                propertiesListbox.Items.Remove(currentChangingProperty.PropertyName);
            }
        }

        private void renameControlButton_Click(object sender, EventArgs e)
        {
            Custom_Definitions.ChangingControl currentChangingControl = GetSelectedChangingControl();
            if (currentChangingControl != null)
            {
                Control_Editor_Form controlEditorForm = new Control_Editor_Form(oldName: currentChangingControl.ControlName, oldIsTypeTemplate: currentChangingControl.IsTypeTemplate);
                if (controlEditorForm.ShowDialog() == DialogResult.OK)
                {
                    // remove old name from the listbox
                    int listboxIndex = controlsNamesListbox.Items.IndexOf(currentChangingControl.ControlName);
                    controlsNamesListbox.Items.RemoveAt(listboxIndex);

                    // update selected control's ControlName property
                    currentChangingControl.ControlName = controlEditorForm.NewName;
                    currentChangingControl.IsTypeTemplate = controlEditorForm.IsTypeTemplate;

                    // update listbox with the new name at the index of the old name
                    controlsNamesListbox.Items.Insert(listboxIndex, currentChangingControl.ControlName);

                    // re-select the now-renamed control
                    controlsNamesListbox.SelectedItem = currentChangingControl.ControlName;
                }
            }
        }

        private void importControlsFromCurrentFormButton_Click(object sender, EventArgs e)
        {
            if (referenceToFormOpenedInDesigner != null && !referenceToFormOpenedInDesigner.IsDisposed)
            {
                Control.ControlCollection controlsListFromFormOpenedInDesigner = referenceToFormOpenedInDesigner.Controls;
                using (Import_Controls_Form importControlsForm = new Import_Controls_Form(controlsListFromFormOpenedInDesigner))
                {
                    if (importControlsForm.ShowDialog() == DialogResult.OK)
                    {
                        void ProcessImportResult()
                        {
                            foreach (Custom_Definitions.ChangingControl newChangingControl in importControlsForm.ChangingControlsToImportResult)
                            {
                                // avoid duplicates
                                if (controlsNamesListbox.Items.Contains(newChangingControl))
                                {
                                    continue;
                                }

                                controlsNamesListbox.Items.Add(newChangingControl.ControlName);
                                EditedTheme.ChangingControls.Add(newChangingControl);
                            }
                        }

                        ProcessImportResult();
                    }
                }
            }
        }

        private void changingControlPropertiesTypeRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (changingControlPropertiesTypeRadio.Checked)
            {
                Custom_Definitions.ChangingControl currentChangingControl = GetSelectedChangingControl();
                if (currentChangingControl != null)
                {
                    currentChangingControl.IsTypeTemplate = true;
                }
            }
        }

        private void changingControlPropertiesNameRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (changingControlPropertiesNameRadio.Checked)
            {
                Custom_Definitions.ChangingControl currentChangingControl = GetSelectedChangingControl();
                if (currentChangingControl != null)
                {
                    currentChangingControl.IsTypeTemplate = false;
                }
            }
        }

        private void changingControlPropertiesNameTextbox_TextChanged(object sender, EventArgs e)
        {
            Custom_Definitions.ChangingControl currentChangingControl = GetSelectedChangingControl();
            if (currentChangingControl != null)
            {
                string targetText = changingControlPropertiesNameTextbox.Text.Trim();
                if (targetText == string.Empty)
                {
                    // if user input is empty,
                    // go back to the previous name (which was valid)
                    changingControlPropertiesNameTextbox.Text = currentChangingControl.ControlName;
                    return;
                }

                // remove old name from the listbox
                int listboxIndex = controlsNamesListbox.Items.IndexOf(currentChangingControl.ControlName);
                controlsNamesListbox.Items.RemoveAt(listboxIndex);

                // update changing control's name
                currentChangingControl.ControlName = targetText;

                // update listbox with the new name at the index of the old name
                controlsNamesListbox.Items.Insert(listboxIndex, currentChangingControl.ControlName);

                // re-select the now-renamed control
                controlsNamesListbox.SelectedItem = currentChangingControl.ControlName;

                // re-focus on the textbox
                changingControlPropertiesNameTextbox.Focus();
                // also remove selection as re-focusing selects all text
                changingControlPropertiesNameTextbox.SelectionLength = 0;
                // .. and move the selection to the front
                changingControlPropertiesNameTextbox.SelectionStart = changingControlPropertiesNameTextbox.Text.Length;
            }
        }
    }
}
