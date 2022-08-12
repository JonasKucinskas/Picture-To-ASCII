namespace Picture_To_Char
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectWebcamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsWebcamDropDown = new System.Windows.Forms.ToolStripComboBox();
            this.videoQualityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.videoScaleSelectorTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.pictureQualityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureScale_TextBox = new System.Windows.Forms.ToolStripTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(159, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 61);
            this.button2.TabIndex = 1;
            this.button2.Text = "Picture";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 61);
            this.button1.TabIndex = 2;
            this.button1.Text = "Video";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(69, 24);
            this.menuStrip2.TabIndex = 4;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectWebcamToolStripMenuItem,
            this.videoQualityToolStripMenuItem,
            this.pictureQualityToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.DropDownOpening += new System.EventHandler(this.settingsToolStripMenuItem_DropDownOpening);
            // 
            // selectWebcamToolStripMenuItem
            // 
            this.selectWebcamToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SettingsWebcamDropDown});
            this.selectWebcamToolStripMenuItem.Name = "selectWebcamToolStripMenuItem";
            this.selectWebcamToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.selectWebcamToolStripMenuItem.Text = "Select webcam";
            // 
            // SettingsWebcamDropDown
            // 
            this.SettingsWebcamDropDown.Name = "SettingsWebcamDropDown";
            this.SettingsWebcamDropDown.Size = new System.Drawing.Size(121, 23);
            this.SettingsWebcamDropDown.SelectedIndexChanged += new System.EventHandler(this.SettingsWebcamDropDown_SelectedIndexChanged);
            // 
            // videoQualityToolStripMenuItem
            // 
            this.videoQualityToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.videoScaleSelectorTextBox});
            this.videoQualityToolStripMenuItem.Name = "videoQualityToolStripMenuItem";
            this.videoQualityToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.videoQualityToolStripMenuItem.Text = "Video Quality";
            // 
            // videoScaleSelectorTextBox
            // 
            this.videoScaleSelectorTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.videoScaleSelectorTextBox.Name = "videoScaleSelectorTextBox";
            this.videoScaleSelectorTextBox.Size = new System.Drawing.Size(100, 23);
            this.videoScaleSelectorTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.webcamScaleSelected_keydown);
            // 
            // pictureQualityToolStripMenuItem
            // 
            this.pictureQualityToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pictureScale_TextBox});
            this.pictureQualityToolStripMenuItem.Name = "pictureQualityToolStripMenuItem";
            this.pictureQualityToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pictureQualityToolStripMenuItem.Text = "Picture Quality";
            // 
            // pictureScale_TextBox
            // 
            this.pictureScale_TextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.pictureScale_TextBox.Name = "pictureScale_TextBox";
            this.pictureScale_TextBox.Size = new System.Drawing.Size(100, 23);
            this.pictureScale_TextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pictureScale_TextBox_KeyDown);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 101);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.menuStrip2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectWebcamToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox SettingsWebcamDropDown;
        private System.Windows.Forms.ToolStripMenuItem videoQualityToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox videoScaleSelectorTextBox;
        private System.Windows.Forms.ToolStripMenuItem pictureQualityToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox pictureScale_TextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

