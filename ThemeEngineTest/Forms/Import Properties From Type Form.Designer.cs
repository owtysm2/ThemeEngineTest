namespace ThemeEngineTest.Forms
{
    partial class Import_Properties_From_Type_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Import_Properties_From_Type_Form));
            this.filterButton = new CuoreUI.Controls.cuiButton();
            this.selectAllButton = new System.Windows.Forms.Button();
            this.deselectAllButton = new System.Windows.Forms.Button();
            this.cuiPanel2 = new CuoreUI.Controls.cuiPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.cuiPanel1 = new CuoreUI.Controls.cuiPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.propertiesWhichCanBeImportedListbox = new System.Windows.Forms.CheckedListBox();
            this.cuiPanel2.SuspendLayout();
            this.cuiPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // filterButton
            // 
            this.filterButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.filterButton.CheckButton = false;
            this.filterButton.Checked = false;
            this.filterButton.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.filterButton.CheckedForeColor = System.Drawing.Color.White;
            this.filterButton.CheckedImageTint = System.Drawing.Color.White;
            this.filterButton.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.filterButton.Content = "";
            this.filterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.filterButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.filterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.filterButton.ForeColor = System.Drawing.Color.Black;
            this.filterButton.HoverBackground = System.Drawing.Color.White;
            this.filterButton.HoverForeColor = System.Drawing.Color.Black;
            this.filterButton.HoverImageTint = System.Drawing.Color.Black;
            this.filterButton.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.filterButton.Image = ((System.Drawing.Image)(resources.GetObject("filterButton.Image")));
            this.filterButton.ImageAutoCenter = true;
            this.filterButton.ImageExpand = new System.Drawing.Point(0, 0);
            this.filterButton.ImageOffset = new System.Drawing.Point(0, 0);
            this.filterButton.Location = new System.Drawing.Point(239, 16);
            this.filterButton.Name = "filterButton";
            this.filterButton.NormalBackground = System.Drawing.Color.White;
            this.filterButton.NormalForeColor = System.Drawing.Color.Black;
            this.filterButton.NormalImageTint = System.Drawing.Color.Black;
            this.filterButton.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.filterButton.OutlineThickness = 1F;
            this.filterButton.PressedBackground = System.Drawing.Color.WhiteSmoke;
            this.filterButton.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.filterButton.PressedImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.filterButton.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.filterButton.Rounding = new System.Windows.Forms.Padding(4);
            this.filterButton.Size = new System.Drawing.Size(36, 22);
            this.filterButton.TabIndex = 46;
            this.filterButton.TextAlignment = System.Drawing.StringAlignment.Center;
            this.filterButton.TextOffset = new System.Drawing.Point(0, 0);
            this.filterButton.Visible = false;
            // 
            // selectAllButton
            // 
            this.selectAllButton.BackColor = System.Drawing.Color.White;
            this.selectAllButton.Location = new System.Drawing.Point(100, 15);
            this.selectAllButton.Name = "selectAllButton";
            this.selectAllButton.Size = new System.Drawing.Size(66, 24);
            this.selectAllButton.TabIndex = 45;
            this.selectAllButton.Text = "Select All";
            this.selectAllButton.UseVisualStyleBackColor = false;
            this.selectAllButton.Click += new System.EventHandler(this.selectAllButton_Click);
            // 
            // deselectAllButton
            // 
            this.deselectAllButton.BackColor = System.Drawing.Color.White;
            this.deselectAllButton.Location = new System.Drawing.Point(13, 15);
            this.deselectAllButton.Name = "deselectAllButton";
            this.deselectAllButton.Size = new System.Drawing.Size(81, 24);
            this.deselectAllButton.TabIndex = 42;
            this.deselectAllButton.Text = "De-select All";
            this.deselectAllButton.UseVisualStyleBackColor = false;
            this.deselectAllButton.Click += new System.EventHandler(this.deselectAllButton_Click);
            // 
            // cuiPanel2
            // 
            this.cuiPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cuiPanel2.Controls.Add(this.button2);
            this.cuiPanel2.Location = new System.Drawing.Point(135, 406);
            this.cuiPanel2.Name = "cuiPanel2";
            this.cuiPanel2.OutlineThickness = 1F;
            this.cuiPanel2.PanelColor = System.Drawing.Color.White;
            this.cuiPanel2.PanelOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiPanel2.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiPanel2.Size = new System.Drawing.Size(67, 33);
            this.cuiPanel2.TabIndex = 44;
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
            this.cuiPanel1.Location = new System.Drawing.Point(208, 406);
            this.cuiPanel1.Name = "cuiPanel1";
            this.cuiPanel1.OutlineThickness = 1F;
            this.cuiPanel1.PanelColor = System.Drawing.Color.White;
            this.cuiPanel1.PanelOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiPanel1.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiPanel1.Size = new System.Drawing.Size(67, 33);
            this.cuiPanel1.TabIndex = 43;
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
            // propertiesWhichCanBeImportedListbox
            // 
            this.propertiesWhichCanBeImportedListbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.propertiesWhichCanBeImportedListbox.FormattingEnabled = true;
            this.propertiesWhichCanBeImportedListbox.Location = new System.Drawing.Point(13, 45);
            this.propertiesWhichCanBeImportedListbox.Name = "propertiesWhichCanBeImportedListbox";
            this.propertiesWhichCanBeImportedListbox.Size = new System.Drawing.Size(262, 349);
            this.propertiesWhichCanBeImportedListbox.TabIndex = 41;
            // 
            // Import_Properties_From_Type_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 453);
            this.Controls.Add(this.filterButton);
            this.Controls.Add(this.selectAllButton);
            this.Controls.Add(this.deselectAllButton);
            this.Controls.Add(this.cuiPanel2);
            this.Controls.Add(this.cuiPanel1);
            this.Controls.Add(this.propertiesWhichCanBeImportedListbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Import_Properties_From_Type_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Import Properties From Type";
            this.cuiPanel2.ResumeLayout(false);
            this.cuiPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private CuoreUI.Controls.cuiButton filterButton;
        private System.Windows.Forms.Button selectAllButton;
        private System.Windows.Forms.Button deselectAllButton;
        private CuoreUI.Controls.cuiPanel cuiPanel2;
        private System.Windows.Forms.Button button2;
        private CuoreUI.Controls.cuiPanel cuiPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckedListBox propertiesWhichCanBeImportedListbox;
    }
}