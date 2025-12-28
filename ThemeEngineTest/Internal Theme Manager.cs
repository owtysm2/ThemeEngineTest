using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using ThemeEngineTest.Components;

namespace ThemeEngineTest
{
    internal static class InternalThemeManager
    {
        internal static List<Custom_Definitions.Theme> ThemesList = new List<Custom_Definitions.Theme>();

        internal static void UnregisterTheme(Theme_Definer theme_Definer)
        {
            if (ThemesList.Contains(theme_Definer.ThemeObject))
            {
                ThemesList.Remove(theme_Definer.ThemeObject);
            }
        }

        internal static void RegisterTheme(Theme_Definer theme_Definer)
        {
            if (!ThemesList.Contains(theme_Definer.ThemeObject))
            {
                ThemesList.Add(theme_Definer.ThemeObject);
            }
        }

        internal static void RemoveNullEntries()
        {
            foreach (var theme in ThemesList)
            {
                if (theme == null)
                {
                    ThemesList.Remove(theme);
                }
            }
        }

        internal static Custom_Definitions.Theme GetThemeFromName(string searchedName)
        {
            RemoveNullEntries();

            foreach (var theme in ThemesList)
            {
                if (theme.Name == searchedName)
                {
                    return theme;
                }
            }

            return null;
        }

        public static void ApplyThemeToChildren(string themeName, Control targetControlOrForm)
        {
            Custom_Definitions.Theme foundTheme = GetThemeFromName(themeName);
            if (foundTheme != null)
            {
                ApplyThemeToChildren(foundTheme, targetControlOrForm);
            }
        }

        public static void ApplyThemeToChildren(Custom_Definitions.Theme theme, Control targetControlOrForm)
        {
            void SetPropertyValueWithReflection(Control targetControl, string propertyName, object newValue)
            {
                // discard nonsense data
                if (targetControl == null || string.IsNullOrWhiteSpace(propertyName))
                {
                    return;
                }

                PropertyInfo prop = targetControl.GetType().GetProperty(
                    propertyName,
                    BindingFlags.Instance | BindingFlags.Public
                );

                // not found or property is not writable
                if (prop == null || !prop.CanWrite)
                {
                    return;
                }

                try
                {
                    prop.SetValue(targetControl, newValue);
                }
                catch
                {
                    // eh
                }
            }

            void RecursiveApply(Control targetControl)
            {
                foreach (Control c in targetControl.Controls)
                {
                    IEnumerable<Custom_Definitions.ChangingControl> changingControlsMatchingName = theme.ChangingControls.Where(cc => (!cc.IsTypeTemplate && cc.ControlName == c.Name));
                    IEnumerable<Custom_Definitions.ChangingControl> changingControlsTemplated = theme.ChangingControls.Where(cc => cc.IsTypeTemplate && cc.ControlName == c.GetType().Name);

                    // template first, name matches will override the template later
                    if (changingControlsTemplated.Count() > 0)
                    {
                        Custom_Definitions.ChangingControl template = changingControlsTemplated.First();

                        foreach (Custom_Definitions.ChangingProperty prop in template.ChangingProperties)
                        {
                            SetPropertyValueWithReflection(c, prop.PropertyName, prop.PropertyValue);
                        }
                    }

                    if (changingControlsMatchingName.Count() > 0)
                    {
                        Custom_Definitions.ChangingControl retrievedChangingControl = changingControlsMatchingName.First();

                        foreach (Custom_Definitions.ChangingProperty prop in retrievedChangingControl.ChangingProperties)
                        {
                            SetPropertyValueWithReflection(c, prop.PropertyName, prop.PropertyValue);
                        }
                    }

                    if (c.Controls.Count == 0)
                    {
                        continue;
                    }

                    RecursiveApply(c);
                }
            }

            void applyToSelfIfForm()
            {
                IEnumerable<Custom_Definitions.ChangingControl> changingControlsMatchingName = theme.ChangingControls.Where(cc => (!cc.IsTypeTemplate && cc.ControlName == targetControlOrForm.Name));

                if (targetControlOrForm is Form)
                {
                    IEnumerable<Custom_Definitions.ChangingControl> changingControlsTemplated = theme.ChangingControls.Where(cc => cc.IsTypeTemplate && cc.ControlName == "Form");

                    // template first, name matches will override the template later
                    if (changingControlsTemplated.Count() > 0)
                    {
                        Custom_Definitions.ChangingControl template = changingControlsTemplated.First();

                        foreach (Custom_Definitions.ChangingProperty prop in template.ChangingProperties)
                        {
                            SetPropertyValueWithReflection(targetControlOrForm, prop.PropertyName, prop.PropertyValue);
                        }
                    }
                }

                if (changingControlsMatchingName.Count() > 0)
                {
                    Custom_Definitions.ChangingControl retrievedChangingControl = changingControlsMatchingName.First();

                    foreach (Custom_Definitions.ChangingProperty prop in retrievedChangingControl.ChangingProperties)
                    {
                        SetPropertyValueWithReflection(targetControlOrForm, prop.PropertyName, prop.PropertyValue);
                    }
                }
            }

            applyToSelfIfForm();
            RecursiveApply(targetControlOrForm);
        }
    }
}
