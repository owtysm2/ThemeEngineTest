using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing.Design;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace ThemeEngineTest.Components
{
    public partial class Theme_Definer : Component
    {
        // unexposed to the designer, a custom form will handle editing this object
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Browsable(false)]
        public Custom_Definitions.Theme ThemeObject { get; set; } = new Custom_Definitions.Theme();

        [Browsable(true)]
        [DisplayName("Theme's Name")]
        public string ThemeName => ThemeObject.Name;

        [Editor(typeof(ThemeEditor), typeof(UITypeEditor))]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [DisplayName("Click to Edit Theme")]
        public EmptyClass Edit { get; }

        [Editor(typeof(ClassCloner), typeof(UITypeEditor))]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [DisplayName("Click to Clone Theme")]
        public EmptyClass Clone { get; }

        public void ApplyToForm(Form targetForm)
        {
            InternalThemeManager.ApplyThemeToChildren(ThemeObject, targetForm);
        }

        public Theme_Definer()
        {
            InitializeComponent();

            InternalThemeManager.RegisterTheme(this);
        }
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public sealed class EmptyClass
    {
        public override string ToString() => "Edit";
    }

    public sealed class ThemeEditor : UITypeEditor
    {
        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
        {
            return UITypeEditorEditStyle.Modal;
        }

        public override object EditValue(
            ITypeDescriptorContext context,
            IServiceProvider provider,
            object value)
        {
            if (provider == null)
                return value;

            var editorService =
                provider.GetService(typeof(IWindowsFormsEditorService))
                as IWindowsFormsEditorService;

            if (editorService == null)
                return value;

            Theme_Definer themeDefiner = context.Instance as Theme_Definer;
            if (themeDefiner == null)
                return value;

            // get container which holds other components
            var designerHost = provider.GetService(typeof(IDesignerHost)) as IDesignerHost;
            IContainer container = designerHost?.Container;

            // get reference to the form opened in the designer
            // (in case the developer wants to import controls from their form quickly)
            Form formOpenedInDesigner = designerHost.RootComponent as Form;

            using (var themeEditorForm = new Forms.Theme_Editor_Form())
            {
                themeEditorForm.referenceToFormOpenedInDesigner = formOpenedInDesigner;
                themeEditorForm.LoadTheme(themeDefiner);

                if (editorService.ShowDialog(themeEditorForm) == DialogResult.OK
                    && themeEditorForm.DialogResult == DialogResult.OK)
                {
                    // themeEditorForm exposes the new modified theme as a variable
                    var changeService =
             provider.GetService(typeof(IComponentChangeService))
             as IComponentChangeService;

                    changeService?.OnComponentChanging(themeDefiner, null);

                    themeDefiner.ThemeObject.DeepCloneAnotherTheme(themeEditorForm.EditedTheme);

                    changeService?.OnComponentChanged(themeDefiner, null, null, null);
                }
            }

            return value;
        }
    }

    public sealed class ClassCloner : UITypeEditor
    {
        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
        {
            return UITypeEditorEditStyle.Modal;
        }

        public override object EditValue(
            ITypeDescriptorContext context,
            IServiceProvider provider,
            object value)
        {
            if (provider == null)
                return value;

            var editorService =
                provider.GetService(typeof(IWindowsFormsEditorService))
                as IWindowsFormsEditorService;

            if (editorService == null)
                return value;

            Theme_Definer thisThemeDefiner = context.Instance as Theme_Definer;
            if (thisThemeDefiner == null)
                return value;

            // get container which holds other components
            var designerHost = provider.GetService(typeof(IDesignerHost)) as IDesignerHost;
            IContainer container = designerHost?.Container;

            Theme_Definer clonedThemeDefiner = new Theme_Definer();
            clonedThemeDefiner.ThemeObject.DeepCloneAnotherTheme(thisThemeDefiner.ThemeObject);
            container.Add(clonedThemeDefiner);

            return value;
        }
    }
}
