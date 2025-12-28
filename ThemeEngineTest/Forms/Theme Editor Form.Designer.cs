namespace ThemeEngineTest.Forms
{
    partial class Theme_Editor_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.themeGroupBox = new System.Windows.Forms.GroupBox();
            this.importControlsFromCurrentFormButton = new System.Windows.Forms.Button();
            this.renameControlButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.propertiesGroupBox = new System.Windows.Forms.GroupBox();
            this.propertiesListbox = new System.Windows.Forms.ListBox();
            this.addPropertyButton = new System.Windows.Forms.Button();
            this.removeSelectedPropertyButton = new System.Windows.Forms.Button();
            this.propertyEditorPanel = new System.Windows.Forms.Panel();
            this.propertyTypeComboBox = new System.Windows.Forms.ComboBox();
            this.propertyNameTextbox = new System.Windows.Forms.TextBox();
            this.propertyValueCheckbox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.propertyValueTextbox = new System.Windows.Forms.TextBox();
            this.propertyColorPickerPanel = new System.Windows.Forms.Panel();
            this.propertyValueColorPicker = new CuoreUI.Controls.cuiColorPickerWheel();
            this.label8 = new System.Windows.Forms.Label();
            this.rTextbox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.gTextbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.bTextbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.aTextbox = new System.Windows.Forms.TextBox();
            this.controlNameTextbox = new System.Windows.Forms.TextBox();
            this.removeSelectedControlButton = new System.Windows.Forms.Button();
            this.addControlNameButton = new System.Windows.Forms.Button();
            this.controlsNamesListbox = new System.Windows.Forms.ListBox();
            this.themeNameTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cuiPanel1 = new CuoreUI.Controls.cuiPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.cuiPanel2 = new CuoreUI.Controls.cuiPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.themeGroupBox.SuspendLayout();
            this.propertiesGroupBox.SuspendLayout();
            this.propertyEditorPanel.SuspendLayout();
            this.propertyColorPickerPanel.SuspendLayout();
            this.cuiPanel1.SuspendLayout();
            this.cuiPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // themeGroupBox
            // 
            this.themeGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.themeGroupBox.Controls.Add(this.importControlsFromCurrentFormButton);
            this.themeGroupBox.Controls.Add(this.renameControlButton);
            this.themeGroupBox.Controls.Add(this.label1);
            this.themeGroupBox.Controls.Add(this.propertiesGroupBox);
            this.themeGroupBox.Controls.Add(this.controlNameTextbox);
            this.themeGroupBox.Controls.Add(this.removeSelectedControlButton);
            this.themeGroupBox.Controls.Add(this.addControlNameButton);
            this.themeGroupBox.Controls.Add(this.controlsNamesListbox);
            this.themeGroupBox.Location = new System.Drawing.Point(12, 55);
            this.themeGroupBox.Name = "themeGroupBox";
            this.themeGroupBox.Size = new System.Drawing.Size(630, 507);
            this.themeGroupBox.TabIndex = 4;
            this.themeGroupBox.TabStop = false;
            this.themeGroupBox.Text = "Edit Controls";
            // 
            // importControlsFromCurrentFormButton
            // 
            this.importControlsFromCurrentFormButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.importControlsFromCurrentFormButton.Location = new System.Drawing.Point(6, 455);
            this.importControlsFromCurrentFormButton.Name = "importControlsFromCurrentFormButton";
            this.importControlsFromCurrentFormButton.Size = new System.Drawing.Size(214, 31);
            this.importControlsFromCurrentFormButton.TabIndex = 13;
            this.importControlsFromCurrentFormButton.Text = "Import Controls from Current Form";
            this.importControlsFromCurrentFormButton.UseVisualStyleBackColor = true;
            this.importControlsFromCurrentFormButton.Click += new System.EventHandler(this.importControlsFromCurrentFormButton_Click);
            // 
            // renameControlButton
            // 
            this.renameControlButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.renameControlButton.Location = new System.Drawing.Point(158, 421);
            this.renameControlButton.Name = "renameControlButton";
            this.renameControlButton.Size = new System.Drawing.Size(62, 28);
            this.renameControlButton.TabIndex = 12;
            this.renameControlButton.Text = "Rename";
            this.renameControlButton.UseVisualStyleBackColor = true;
            this.renameControlButton.Click += new System.EventHandler(this.renameControlButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Target Control\'s Name";
            // 
            // propertiesGroupBox
            // 
            this.propertiesGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.propertiesGroupBox.Controls.Add(this.propertiesListbox);
            this.propertiesGroupBox.Controls.Add(this.addPropertyButton);
            this.propertiesGroupBox.Controls.Add(this.removeSelectedPropertyButton);
            this.propertiesGroupBox.Controls.Add(this.propertyEditorPanel);
            this.propertiesGroupBox.Location = new System.Drawing.Point(226, 19);
            this.propertiesGroupBox.Name = "propertiesGroupBox";
            this.propertiesGroupBox.Size = new System.Drawing.Size(384, 467);
            this.propertiesGroupBox.TabIndex = 10;
            this.propertiesGroupBox.TabStop = false;
            this.propertiesGroupBox.Text = "Edit Properties";
            this.propertiesGroupBox.Visible = false;
            // 
            // propertiesListbox
            // 
            this.propertiesListbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.propertiesListbox.FormattingEnabled = true;
            this.propertiesListbox.Location = new System.Drawing.Point(35, 177);
            this.propertiesListbox.Name = "propertiesListbox";
            this.propertiesListbox.Size = new System.Drawing.Size(321, 238);
            this.propertiesListbox.TabIndex = 12;
            this.propertiesListbox.SelectedIndexChanged += new System.EventHandler(this.propertiesListbox_SelectedIndexChanged);
            // 
            // addPropertyButton
            // 
            this.addPropertyButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.addPropertyButton.Location = new System.Drawing.Point(291, 421);
            this.addPropertyButton.Name = "addPropertyButton";
            this.addPropertyButton.Size = new System.Drawing.Size(65, 28);
            this.addPropertyButton.TabIndex = 12;
            this.addPropertyButton.Text = "Add New";
            this.addPropertyButton.UseVisualStyleBackColor = true;
            this.addPropertyButton.Click += new System.EventHandler(this.addPropertyButton_Click);
            // 
            // removeSelectedPropertyButton
            // 
            this.removeSelectedPropertyButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.removeSelectedPropertyButton.Location = new System.Drawing.Point(35, 421);
            this.removeSelectedPropertyButton.Name = "removeSelectedPropertyButton";
            this.removeSelectedPropertyButton.Size = new System.Drawing.Size(112, 28);
            this.removeSelectedPropertyButton.TabIndex = 14;
            this.removeSelectedPropertyButton.Text = "Remove Selected";
            this.removeSelectedPropertyButton.UseVisualStyleBackColor = true;
            this.removeSelectedPropertyButton.Click += new System.EventHandler(this.removeSelectedPropertyButton_Click);
            // 
            // propertyEditorPanel
            // 
            this.propertyEditorPanel.Controls.Add(this.propertyTypeComboBox);
            this.propertyEditorPanel.Controls.Add(this.propertyNameTextbox);
            this.propertyEditorPanel.Controls.Add(this.propertyValueCheckbox);
            this.propertyEditorPanel.Controls.Add(this.label3);
            this.propertyEditorPanel.Controls.Add(this.label4);
            this.propertyEditorPanel.Controls.Add(this.label5);
            this.propertyEditorPanel.Controls.Add(this.propertyValueTextbox);
            this.propertyEditorPanel.Controls.Add(this.propertyColorPickerPanel);
            this.propertyEditorPanel.Location = new System.Drawing.Point(21, 31);
            this.propertyEditorPanel.Name = "propertyEditorPanel";
            this.propertyEditorPanel.Size = new System.Drawing.Size(357, 157);
            this.propertyEditorPanel.TabIndex = 22;
            this.propertyEditorPanel.Visible = false;
            // 
            // propertyTypeComboBox
            // 
            this.propertyTypeComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.propertyTypeComboBox.DisplayMember = "String";
            this.propertyTypeComboBox.FormattingEnabled = true;
            this.propertyTypeComboBox.Items.AddRange(new object[] {
            "String",
            "Color",
            "Bool"});
            this.propertyTypeComboBox.Location = new System.Drawing.Point(14, 76);
            this.propertyTypeComboBox.Name = "propertyTypeComboBox";
            this.propertyTypeComboBox.Size = new System.Drawing.Size(140, 21);
            this.propertyTypeComboBox.TabIndex = 19;
            this.propertyTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.propertyTypeComboBox_SelectedIndexChanged);
            // 
            // propertyNameTextbox
            // 
            this.propertyNameTextbox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.propertyNameTextbox.Location = new System.Drawing.Point(14, 33);
            this.propertyNameTextbox.Name = "propertyNameTextbox";
            this.propertyNameTextbox.Size = new System.Drawing.Size(140, 20);
            this.propertyNameTextbox.TabIndex = 15;
            // 
            // propertyValueCheckbox
            // 
            this.propertyValueCheckbox.AutoSize = true;
            this.propertyValueCheckbox.Location = new System.Drawing.Point(160, 36);
            this.propertyValueCheckbox.Name = "propertyValueCheckbox";
            this.propertyValueCheckbox.Size = new System.Drawing.Size(15, 14);
            this.propertyValueCheckbox.TabIndex = 21;
            this.propertyValueCheckbox.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Property Name";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(157, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Property Value";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Property Type";
            // 
            // propertyValueTextbox
            // 
            this.propertyValueTextbox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.propertyValueTextbox.Location = new System.Drawing.Point(160, 33);
            this.propertyValueTextbox.Name = "propertyValueTextbox";
            this.propertyValueTextbox.Size = new System.Drawing.Size(175, 20);
            this.propertyValueTextbox.TabIndex = 17;
            // 
            // propertyColorPickerPanel
            // 
            this.propertyColorPickerPanel.Controls.Add(this.propertyValueColorPicker);
            this.propertyColorPickerPanel.Controls.Add(this.label8);
            this.propertyColorPickerPanel.Controls.Add(this.rTextbox);
            this.propertyColorPickerPanel.Controls.Add(this.label9);
            this.propertyColorPickerPanel.Controls.Add(this.gTextbox);
            this.propertyColorPickerPanel.Controls.Add(this.label7);
            this.propertyColorPickerPanel.Controls.Add(this.bTextbox);
            this.propertyColorPickerPanel.Controls.Add(this.label6);
            this.propertyColorPickerPanel.Controls.Add(this.aTextbox);
            this.propertyColorPickerPanel.Location = new System.Drawing.Point(160, 33);
            this.propertyColorPickerPanel.Name = "propertyColorPickerPanel";
            this.propertyColorPickerPanel.Size = new System.Drawing.Size(175, 111);
            this.propertyColorPickerPanel.TabIndex = 12;
            // 
            // propertyValueColorPicker
            // 
            this.propertyValueColorPicker.Content = System.Drawing.Color.Red;
            this.propertyValueColorPicker.Location = new System.Drawing.Point(3, 3);
            this.propertyValueColorPicker.MinimumSize = new System.Drawing.Size(38, 38);
            this.propertyValueColorPicker.Name = "propertyValueColorPicker";
            this.propertyValueColorPicker.Size = new System.Drawing.Size(104, 104);
            this.propertyValueColorPicker.TabIndex = 22;
            this.propertyValueColorPicker.WheelThickness = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(114, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "B";
            // 
            // rTextbox
            // 
            this.rTextbox.Location = new System.Drawing.Point(127, 33);
            this.rTextbox.Name = "rTextbox";
            this.rTextbox.Size = new System.Drawing.Size(39, 20);
            this.rTextbox.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(114, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "G";
            // 
            // gTextbox
            // 
            this.gTextbox.Location = new System.Drawing.Point(127, 56);
            this.gTextbox.Name = "gTextbox";
            this.gTextbox.Size = new System.Drawing.Size(39, 20);
            this.gTextbox.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(114, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "R";
            // 
            // bTextbox
            // 
            this.bTextbox.Location = new System.Drawing.Point(127, 79);
            this.bTextbox.Name = "bTextbox";
            this.bTextbox.Size = new System.Drawing.Size(39, 20);
            this.bTextbox.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(114, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "A";
            // 
            // aTextbox
            // 
            this.aTextbox.Location = new System.Drawing.Point(127, 10);
            this.aTextbox.Name = "aTextbox";
            this.aTextbox.Size = new System.Drawing.Size(39, 20);
            this.aTextbox.TabIndex = 23;
            // 
            // controlNameTextbox
            // 
            this.controlNameTextbox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.controlNameTextbox.Location = new System.Drawing.Point(6, 99);
            this.controlNameTextbox.Name = "controlNameTextbox";
            this.controlNameTextbox.Size = new System.Drawing.Size(160, 20);
            this.controlNameTextbox.TabIndex = 9;
            // 
            // removeSelectedControlButton
            // 
            this.removeSelectedControlButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.removeSelectedControlButton.Location = new System.Drawing.Point(6, 421);
            this.removeSelectedControlButton.Name = "removeSelectedControlButton";
            this.removeSelectedControlButton.Size = new System.Drawing.Size(112, 28);
            this.removeSelectedControlButton.TabIndex = 7;
            this.removeSelectedControlButton.Text = "Remove Selected";
            this.removeSelectedControlButton.UseVisualStyleBackColor = true;
            this.removeSelectedControlButton.Click += new System.EventHandler(this.removeSelectedControlButton_Click);
            // 
            // addControlNameButton
            // 
            this.addControlNameButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.addControlNameButton.Location = new System.Drawing.Point(172, 94);
            this.addControlNameButton.Name = "addControlNameButton";
            this.addControlNameButton.Size = new System.Drawing.Size(48, 28);
            this.addControlNameButton.TabIndex = 6;
            this.addControlNameButton.Text = "Add";
            this.addControlNameButton.UseVisualStyleBackColor = true;
            this.addControlNameButton.Click += new System.EventHandler(this.addControlNameButton_Click);
            // 
            // controlsNamesListbox
            // 
            this.controlsNamesListbox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.controlsNamesListbox.FormattingEnabled = true;
            this.controlsNamesListbox.Location = new System.Drawing.Point(6, 125);
            this.controlsNamesListbox.Name = "controlsNamesListbox";
            this.controlsNamesListbox.Size = new System.Drawing.Size(214, 290);
            this.controlsNamesListbox.TabIndex = 5;
            this.controlsNamesListbox.SelectedIndexChanged += new System.EventHandler(this.controlsNamesListbox_SelectedIndexChanged);
            // 
            // themeNameTextbox
            // 
            this.themeNameTextbox.Location = new System.Drawing.Point(15, 25);
            this.themeNameTextbox.Name = "themeNameTextbox";
            this.themeNameTextbox.Size = new System.Drawing.Size(156, 20);
            this.themeNameTextbox.TabIndex = 0;
            this.themeNameTextbox.TextChanged += new System.EventHandler(this.themeNameTextbox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Theme Name";
            // 
            // cuiPanel1
            // 
            this.cuiPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cuiPanel1.Controls.Add(this.button1);
            this.cuiPanel1.Location = new System.Drawing.Point(575, 12);
            this.cuiPanel1.Name = "cuiPanel1";
            this.cuiPanel1.OutlineThickness = 1F;
            this.cuiPanel1.PanelColor = System.Drawing.Color.White;
            this.cuiPanel1.PanelOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiPanel1.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiPanel1.Size = new System.Drawing.Size(67, 33);
            this.cuiPanel1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 24);
            this.button1.TabIndex = 23;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cuiPanel2
            // 
            this.cuiPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cuiPanel2.Controls.Add(this.button2);
            this.cuiPanel2.Location = new System.Drawing.Point(502, 12);
            this.cuiPanel2.Name = "cuiPanel2";
            this.cuiPanel2.OutlineThickness = 1F;
            this.cuiPanel2.PanelColor = System.Drawing.Color.White;
            this.cuiPanel2.PanelOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiPanel2.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiPanel2.Size = new System.Drawing.Size(67, 33);
            this.cuiPanel2.TabIndex = 24;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(59, 24);
            this.button2.TabIndex = 23;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Theme_Editor_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 574);
            this.Controls.Add(this.cuiPanel2);
            this.Controls.Add(this.cuiPanel1);
            this.Controls.Add(this.themeGroupBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.themeNameTextbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Theme_Editor_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Theme Editor";
            this.themeGroupBox.ResumeLayout(false);
            this.themeGroupBox.PerformLayout();
            this.propertiesGroupBox.ResumeLayout(false);
            this.propertyEditorPanel.ResumeLayout(false);
            this.propertyEditorPanel.PerformLayout();
            this.propertyColorPickerPanel.ResumeLayout(false);
            this.propertyColorPickerPanel.PerformLayout();
            this.cuiPanel1.ResumeLayout(false);
            this.cuiPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox themeGroupBox;
        private System.Windows.Forms.TextBox themeNameTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button removeSelectedControlButton;
        private System.Windows.Forms.Button addControlNameButton;
        private System.Windows.Forms.ListBox controlsNamesListbox;
        private System.Windows.Forms.TextBox controlNameTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox propertiesGroupBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox propertiesListbox;
        private System.Windows.Forms.TextBox propertyNameTextbox;
        private System.Windows.Forms.Button removeSelectedPropertyButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox propertyValueTextbox;
        private System.Windows.Forms.Button addPropertyButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox propertyTypeComboBox;
        private System.Windows.Forms.CheckBox propertyValueCheckbox;
        private CuoreUI.Controls.cuiColorPickerWheel propertyValueColorPicker;
        private CuoreUI.Controls.cuiPanel cuiPanel1;
        private System.Windows.Forms.Button button1;
        private CuoreUI.Controls.cuiPanel cuiPanel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox aTextbox;
        private System.Windows.Forms.TextBox bTextbox;
        private System.Windows.Forms.TextBox gTextbox;
        private System.Windows.Forms.TextBox rTextbox;
        private System.Windows.Forms.Panel propertyColorPickerPanel;
        private System.Windows.Forms.Button renameControlButton;
        private System.Windows.Forms.Panel propertyEditorPanel;
        private System.Windows.Forms.Button importControlsFromCurrentFormButton;
    }
}