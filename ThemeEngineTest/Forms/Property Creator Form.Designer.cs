namespace ThemeEngineTest.Forms
{
    partial class Property_Creator_Form
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
            this.propertyValueTextbox = new System.Windows.Forms.TextBox();
            this.propertyValueCheckbox = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.propertyTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.propertyNameTextbox = new System.Windows.Forms.TextBox();
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
            this.cuiPanel2 = new CuoreUI.Controls.cuiPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.cuiPanel1 = new CuoreUI.Controls.cuiPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.propertyColorPickerPanel.SuspendLayout();
            this.cuiPanel2.SuspendLayout();
            this.cuiPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // propertyValueTextbox
            // 
            this.propertyValueTextbox.Location = new System.Drawing.Point(119, 28);
            this.propertyValueTextbox.Name = "propertyValueTextbox";
            this.propertyValueTextbox.Size = new System.Drawing.Size(175, 20);
            this.propertyValueTextbox.TabIndex = 25;
            // 
            // propertyValueCheckbox
            // 
            this.propertyValueCheckbox.AutoSize = true;
            this.propertyValueCheckbox.Location = new System.Drawing.Point(119, 54);
            this.propertyValueCheckbox.Name = "propertyValueCheckbox";
            this.propertyValueCheckbox.Size = new System.Drawing.Size(15, 14);
            this.propertyValueCheckbox.TabIndex = 29;
            this.propertyValueCheckbox.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Property Type";
            // 
            // propertyTypeComboBox
            // 
            this.propertyTypeComboBox.DisplayMember = "String";
            this.propertyTypeComboBox.FormattingEnabled = true;
            this.propertyTypeComboBox.Items.AddRange(new object[] {
            "String",
            "Color",
            "Bool"});
            this.propertyTypeComboBox.Location = new System.Drawing.Point(15, 71);
            this.propertyTypeComboBox.Name = "propertyTypeComboBox";
            this.propertyTypeComboBox.Size = new System.Drawing.Size(98, 21);
            this.propertyTypeComboBox.TabIndex = 27;
            this.propertyTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.propertyTypeComboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(116, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Property Value";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Property Name";
            // 
            // propertyNameTextbox
            // 
            this.propertyNameTextbox.Location = new System.Drawing.Point(15, 28);
            this.propertyNameTextbox.Name = "propertyNameTextbox";
            this.propertyNameTextbox.Size = new System.Drawing.Size(98, 20);
            this.propertyNameTextbox.TabIndex = 23;
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
            this.propertyColorPickerPanel.Location = new System.Drawing.Point(119, 28);
            this.propertyColorPickerPanel.Name = "propertyColorPickerPanel";
            this.propertyColorPickerPanel.Size = new System.Drawing.Size(175, 111);
            this.propertyColorPickerPanel.TabIndex = 22;
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
            // cuiPanel2
            // 
            this.cuiPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cuiPanel2.Controls.Add(this.button2);
            this.cuiPanel2.Location = new System.Drawing.Point(154, 151);
            this.cuiPanel2.Name = "cuiPanel2";
            this.cuiPanel2.OutlineThickness = 1F;
            this.cuiPanel2.PanelColor = System.Drawing.Color.White;
            this.cuiPanel2.PanelOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiPanel2.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiPanel2.Size = new System.Drawing.Size(67, 33);
            this.cuiPanel2.TabIndex = 31;
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
            // cuiPanel1
            // 
            this.cuiPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cuiPanel1.Controls.Add(this.button1);
            this.cuiPanel1.Location = new System.Drawing.Point(227, 151);
            this.cuiPanel1.Name = "cuiPanel1";
            this.cuiPanel1.OutlineThickness = 1F;
            this.cuiPanel1.PanelColor = System.Drawing.Color.White;
            this.cuiPanel1.PanelOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiPanel1.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiPanel1.Size = new System.Drawing.Size(67, 33);
            this.cuiPanel1.TabIndex = 30;
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
            // Property_Creator_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 196);
            this.Controls.Add(this.cuiPanel2);
            this.Controls.Add(this.cuiPanel1);
            this.Controls.Add(this.propertyValueTextbox);
            this.Controls.Add(this.propertyValueCheckbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.propertyTypeComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.propertyNameTextbox);
            this.Controls.Add(this.propertyColorPickerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Property_Creator_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Property Creator";
            this.propertyColorPickerPanel.ResumeLayout(false);
            this.propertyColorPickerPanel.PerformLayout();
            this.cuiPanel2.ResumeLayout(false);
            this.cuiPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox propertyValueTextbox;
        private System.Windows.Forms.CheckBox propertyValueCheckbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox propertyTypeComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox propertyNameTextbox;
        private System.Windows.Forms.Panel propertyColorPickerPanel;
        private CuoreUI.Controls.cuiColorPickerWheel propertyValueColorPicker;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox rTextbox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox gTextbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox bTextbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox aTextbox;
        private CuoreUI.Controls.cuiPanel cuiPanel2;
        private System.Windows.Forms.Button button2;
        private CuoreUI.Controls.cuiPanel cuiPanel1;
        private System.Windows.Forms.Button button1;
    }
}