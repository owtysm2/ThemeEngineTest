using System;
using System.ComponentModel;
using System.Linq;

namespace ThemeEngineTest
{
    public static class Custom_Definitions
    {
        public enum PropertyType
        {
            String,
            Color,
            Bool
        }

        public static PropertyType PropertyTypeFromString(string inputString)
        {
            switch (inputString)
            {
                case "String":
                    return PropertyType.String;
                case "Bool":
                    return PropertyType.Bool;
                case "Color":
                    return PropertyType.Color;
            }

            // fallback
            return PropertyType.String;
        }

        [Serializable]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        public class ChangingProperty
        {
            public string PropertyName { get; set; }
            public object PropertyValue { get; set; }
            public PropertyType PropertyType { get; set; } = PropertyType.Color;

            public override string ToString() => PropertyName;

        }

        [Serializable]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        public class ChangingControl
        {
            public bool IsTypeTemplate { get; set; } = false;

            public string ControlName { get; set; }

            [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
            public BindingList<ChangingProperty> ChangingProperties { get; set; } = new BindingList<ChangingProperty>();

            public ChangingProperty GetChangingPropertyByName(string searchedName)
            {
                if (ChangingProperties.Count() == 0)
                {
                    return null;
                }

                var filteredList = ChangingProperties.Where(p => p.PropertyName == searchedName);

                if (filteredList.Count() == 0)
                {
                    return null;
                }

                return filteredList.First();
            }

            public override string ToString() => ControlName;
        }

        [TypeConverter(typeof(ExpandableObjectConverter))]
        public class Theme
        {
            public string Name { get; set; } = string.Empty;

            [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
            public BindingList<ChangingControl> ChangingControls { get; set; } = new BindingList<ChangingControl>();

            public ChangingControl GetChangingControlByName(string searchedName)
            {
                if (ChangingControls.Count() == 0)
                {
                    return null;
                }

                var filteredList = ChangingControls.Where(p => p.ControlName == searchedName);

                if (filteredList.Count() == 0)
                {
                    return null;
                }

                return filteredList.First();
            }

            public override string ToString()
            {
                return Name;
            }

            internal Theme Clone(bool addCopyToName = true)
            {
                Theme newThemeObject = new Theme();
                newThemeObject.DeepCloneAnotherTheme(this);

                if (addCopyToName)
                {
                    newThemeObject.Name += " (Copy)";
                }

                return newThemeObject;
            }

            internal void DeepCloneAnotherTheme(Theme editedTheme)
            {
                ChangingControls.Clear();
                foreach (var ctrl in editedTheme.ChangingControls)
                {
                    ChangingControl newChangingControl = new ChangingControl();
                    newChangingControl.ControlName = ctrl.ControlName;

                    foreach (var prop in ctrl.ChangingProperties)
                    {
                        ChangingProperty newChangingProperty = new ChangingProperty();
                        newChangingProperty.PropertyName = prop.PropertyName;
                        newChangingProperty.PropertyType = prop.PropertyType;
                        newChangingProperty.PropertyValue = prop.PropertyValue;

                        newChangingControl.ChangingProperties.Add(newChangingProperty);
                    }

                    ChangingControls.Add(newChangingControl);
                }
                Name = editedTheme.Name;
            }
        }
    }
}
