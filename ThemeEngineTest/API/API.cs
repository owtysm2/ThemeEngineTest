using System.Windows.Forms;

namespace ThemeEngineTest
{
    public static class API
    {
        /// <summary>
        /// Applies the specified targetTheme to the provided target control or form.
        /// </summary>
        /// <param name="targetControlOrForm"></param>
        /// <param name="targetTheme"></param>
        public static void ApplyThemeTo(Control targetControlOrForm, Custom_Definitions.Theme targetTheme)
        {
            InternalThemeManager.ApplyThemeToChildrenAndSelf(targetTheme, targetControlOrForm);
        }

        /// <summary>
        /// To use this method, make sure your theme is registered.
        /// </summary>
        /// <param name="targetControlOrForm"></param>
        /// <param name="themeName"></param>
        public static void ApplyThemeTo(Control targetControlOrForm, string themeName)
        {
            InternalThemeManager.ApplyThemeToChildrenAndSelf(themeName, targetControlOrForm);
        }
    }
}
