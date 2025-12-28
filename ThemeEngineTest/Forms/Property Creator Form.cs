using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ThemeEngineTest.Forms
{
    public partial class Property_Creator_Form : Form
    {
        public Custom_Definitions.ChangingProperty CreatedProperty;
        private int alpha = 255;

        public Property_Creator_Form()
        {
            InitializeComponent();
            propertyTypeComboBox.SelectedItem = "Color";

            setupPropertyColorPicker();
            propertyValueColorPicker.Content = Color.White;

            void setupPropertyColorPicker()
            {
                setupTextbox(aTextbox, 0);
                setupTextbox(rTextbox, 1);
                setupTextbox(gTextbox, 2);
                setupTextbox(bTextbox, 3);

                propertyValueColorPicker.ContentChanged += (e, s) =>
                {
                    void updateTextbox(TextBox tb, string newValue)
                    {
                        if (tb.Text != newValue)
                        {
                            tb.Text = newValue;
                        }
                    }

                    updateTextbox(aTextbox, alpha.ToString());
                    updateTextbox(rTextbox, propertyValueColorPicker.Content.R.ToString());
                    updateTextbox(gTextbox, propertyValueColorPicker.Content.G.ToString());
                    updateTextbox(bTextbox, propertyValueColorPicker.Content.B.ToString());
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
                                    alpha = newValue;
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

        private void propertyTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((string)propertyTypeComboBox.SelectedItem)
            {
                case "String":
                    propertyValueTextbox.Visible = true;
                    propertyColorPickerPanel.Visible = false;
                    propertyValueCheckbox.Visible = false;
                    break;
                case "Color":
                    propertyColorPickerPanel.Visible = true;
                    propertyValueCheckbox.Visible = false;
                    propertyValueTextbox.Visible = false;
                    break;
                case "Bool":
                    propertyValueCheckbox.Visible = true;
                    propertyValueTextbox.Visible = false;
                    propertyColorPickerPanel.Visible = false;
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = propertyNameTextbox.Text.Trim();
            if (name == string.Empty)
            {
                // avoid blank names
                return;
            }

            Custom_Definitions.PropertyType type = Custom_Definitions.PropertyTypeFromString((string)propertyTypeComboBox.SelectedItem);
            object value = Custom_Definitions.PropertyType.String;
            switch (type)
            {
                case Custom_Definitions.PropertyType.String:
                    value = propertyValueTextbox.Text;
                    break;
                case Custom_Definitions.PropertyType.Color:
                    value = Color.FromArgb(alpha, propertyValueColorPicker.Content);
                    break;
                case Custom_Definitions.PropertyType.Bool:
                    value = propertyValueCheckbox.Checked;
                    break;
            }

            CreatedProperty = new Custom_Definitions.ChangingProperty()
            {
                PropertyName = name,
                PropertyValue = value,
                PropertyType = type
            };

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
