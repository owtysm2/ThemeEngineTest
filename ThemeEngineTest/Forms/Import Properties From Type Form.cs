using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace ThemeEngineTest.Forms
{
    public partial class Import_Properties_From_Type_Form : Form
    {
        private List<Custom_Definitions.ChangingProperty> AllChangingProperties = new List<Custom_Definitions.ChangingProperty>();
        internal List<Custom_Definitions.ChangingProperty> SelectedChangingProperties => GetSelectedChangingProperties();

        private List<Custom_Definitions.ChangingProperty> GetSelectedChangingProperties()
        {
            List<Custom_Definitions.ChangingProperty> checkedChangingProperties = new List<Custom_Definitions.ChangingProperty>();

            foreach (Custom_Definitions.ChangingProperty changingProperty in AllChangingProperties)
            {
                foreach (var item in propertiesWhichCanBeImportedListbox.CheckedItems)
                {
                    string itemString = item.ToString();
                    string stringToLookFor = $" {changingProperty.PropertyName}";

                    if (itemString.Contains(stringToLookFor))
                    {
                        checkedChangingProperties.Add(changingProperty);
                    }
                }
            }

            return checkedChangingProperties;
        }

        public Import_Properties_From_Type_Form(ListBox.ObjectCollection alreadyAddedProperties, Type fromType)
        {
            InitializeComponent();

            foreach (PropertyInfo property in GetPropertiesFromType(fromType))
            {
                if (alreadyAddedProperties.Contains(property.Name))
                {
                    continue;
                }

                bool canBeParsed =
                    property.PropertyType == typeof(bool)
                    || property.PropertyType == typeof(string)
                    || property.PropertyType == typeof(Color);

                if (canBeParsed)
                {
                    AllChangingProperties.Add(new Custom_Definitions.ChangingProperty()
                    {
                        PropertyName = property.Name,
                        PropertyType = Custom_Definitions.PropertyTypeFromType(property.PropertyType),
                        PropertyValue = null
                    });
                    propertiesWhichCanBeImportedListbox.Items.Add($"{property.Name} {property.PropertyType.Name}");
                }
            }

            List<string> sortedProperties = propertiesWhichCanBeImportedListbox.Items.Cast<string>().ToList();
            sortedProperties.Sort();
            propertiesWhichCanBeImportedListbox.Items.Clear();

            foreach (string item in sortedProperties)
            {
                string[] splitString = item.Split(' ');
                string nameString = splitString[0].Trim();
                string typeString = splitString[1].Trim();

                propertiesWhichCanBeImportedListbox.Items.Add($"({typeString}) {nameString}");
            }
        }

        public static PropertyInfo[] GetPropertiesFromType(Type type)
        {
            return type
                .GetProperties(BindingFlags.Instance | BindingFlags.Public)
                .Where(p => p.CanWrite && p.SetMethod != null && p.SetMethod.IsPublic)
                .ToArray();
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

        private void selectAllButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < propertiesWhichCanBeImportedListbox.Items.Count; i++)
            {
                propertiesWhichCanBeImportedListbox.SetItemChecked(i, true);
            }
        }

        private void deselectAllButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < propertiesWhichCanBeImportedListbox.Items.Count; i++)
            {
                propertiesWhichCanBeImportedListbox.SetItemChecked(i, false);
            }
        }
    }
}
