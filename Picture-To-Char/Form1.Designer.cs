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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WebCamSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.WebCamResolutionMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.WebCamResolutionDropDown = new System.Windows.Forms.ToolStripComboBox();
            this.WebcamSelectMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.webcamSelectDropDown = new System.Windows.Forms.ToolStripComboBox();
            this.videoDownScale = new System.Windows.Forms.ToolStripMenuItem();
            this.videoScaleSelectorTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.pictureQualityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureScale_TextBox = new System.Windows.Forms.ToolStripTextBox();
            this.ManuStrip1 = new System.Windows.Forms.MenuStrip();
            this.SettingsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.WebcamMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectWebcamMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectWebCamComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.ResolutionMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ResolutionComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.videoDownscaleMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.videoDownScaleTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.PictureMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.PictureDownScaleTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.ManuStrip1.SuspendLayout();
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
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.WebCamSettings,
            this.pictureQualityToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.DropDownOpening += new System.EventHandler(this.settingsToolStripMenuItem_DropDownOpening);
            // 
            // WebCamSettings
            // 
            this.WebCamSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.WebCamResolutionMenu,
            this.WebcamSelectMenu,
            this.videoDownScale});
            this.WebCamSettings.Name = "WebCamSettings";
            this.WebCamSettings.Size = new System.Drawing.Size(124, 22);
            this.WebCamSettings.Text = "Webcam ";
            // 
            // WebCamResolutionMenu
            // 
            this.WebCamResolutionMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.WebCamResolutionDropDown});
            this.WebCamResolutionMenu.Name = "WebCamResolutionMenu";
            this.WebCamResolutionMenu.Size = new System.Drawing.Size(163, 22);
            this.WebCamResolutionMenu.Text = "Resolution";
            // 
            // WebCamResolutionDropDown
            // 
            this.WebCamResolutionDropDown.Name = "WebCamResolutionDropDown";
            this.WebCamResolutionDropDown.Size = new System.Drawing.Size(121, 23);
            this.WebCamResolutionDropDown.SelectedIndexChanged += new System.EventHandler(this.WebCamResolutionDropDown_SelectedIndexChanged);
            // 
            // WebcamSelectMenu
            // 
            this.WebcamSelectMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.webcamSelectDropDown});
            this.WebcamSelectMenu.Name = "WebcamSelectMenu";
            this.WebcamSelectMenu.Size = new System.Drawing.Size(163, 22);
            this.WebcamSelectMenu.Text = "SelectWebcam";
            // 
            // webcamSelectDropDown
            // 
            this.webcamSelectDropDown.Name = "webcamSelectDropDown";
            this.webcamSelectDropDown.Size = new System.Drawing.Size(121, 23);
            this.webcamSelectDropDown.SelectedIndexChanged += new System.EventHandler(this.webcamSelectDropDown_SelectedIndexChanged);
            // 
            // videoDownScale
            // 
            this.videoDownScale.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.videoScaleSelectorTextBox});
            this.videoDownScale.Name = "videoDownScale";
            this.videoDownScale.Size = new System.Drawing.Size(163, 22);
            this.videoDownScale.Text = "Video downscale";
            // 
            // videoScaleSelectorTextBox
            // 
            this.videoScaleSelectorTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.videoScaleSelectorTextBox.Name = "videoScaleSelectorTextBox";
            this.videoScaleSelectorTextBox.Size = new System.Drawing.Size(100, 23);
            this.videoScaleSelectorTextBox.TextChanged += new System.EventHandler(this.videoScaleSelectorTextBox_TextChanged);
            // 
            // pictureQualityToolStripMenuItem
            // 
            this.pictureQualityToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pictureScale_TextBox});
            this.pictureQualityToolStripMenuItem.Name = "pictureQualityToolStripMenuItem";
            this.pictureQualityToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.pictureQualityToolStripMenuItem.Text = "Picture";
            // 
            // pictureScale_TextBox
            // 
            this.pictureScale_TextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.pictureScale_TextBox.Name = "pictureScale_TextBox";
            this.pictureScale_TextBox.Size = new System.Drawing.Size(100, 23);
            this.pictureScale_TextBox.TextChanged += new System.EventHandler(this.pictureScale_TextBox_TextChanged);
            // 
            // ManuStrip1
            // 
            this.ManuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SettingsMenu});
            this.ManuStrip1.Location = new System.Drawing.Point(0, 0);
            this.ManuStrip1.Name = "ManuStrip1";
            this.ManuStrip1.Size = new System.Drawing.Size(311, 24);
            this.ManuStrip1.TabIndex = 3;
            this.ManuStrip1.Text = "menuStrip1";
            // 
            // SettingsMenu
            // 
            this.SettingsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.WebcamMenu,
            this.PictureMenu});
            this.SettingsMenu.Name = "SettingsMenu";
            this.SettingsMenu.Size = new System.Drawing.Size(61, 20);
            this.SettingsMenu.Text = "Settings";
            // 
            // WebcamMenu
            // 
            this.WebcamMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SelectWebcamMenu,
            this.ResolutionMenu,
            this.videoDownscaleMenu});
            this.WebcamMenu.Name = "WebcamMenu";
            this.WebcamMenu.Size = new System.Drawing.Size(180, 22);
            this.WebcamMenu.Text = "Webcam";
            // 
            // SelectWebcamMenu
            // 
            this.SelectWebcamMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SelectWebCamComboBox});
            this.SelectWebcamMenu.Name = "SelectWebcamMenu";
            this.SelectWebcamMenu.Size = new System.Drawing.Size(180, 22);
            this.SelectWebcamMenu.Text = "Select webcam";
            // 
            // SelectWebCamComboBox
            // 
            this.SelectWebCamComboBox.Name = "SelectWebCamComboBox";
            this.SelectWebCamComboBox.Size = new System.Drawing.Size(121, 23);
            // 
            // ResolutionMenu
            // 
            this.ResolutionMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ResolutionComboBox});
            this.ResolutionMenu.Name = "ResolutionMenu";
            this.ResolutionMenu.Size = new System.Drawing.Size(180, 22);
            this.ResolutionMenu.Text = "Resolution";
            // 
            // ResolutionComboBox
            // 
            this.ResolutionComboBox.Name = "ResolutionComboBox";
            this.ResolutionComboBox.Size = new System.Drawing.Size(121, 23);
            // 
            // videoDownscaleMenu
            // 
            this.videoDownscaleMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.videoDownScaleTextBox});
            this.videoDownscaleMenu.Name = "videoDownscaleMenu";
            this.videoDownscaleMenu.Size = new System.Drawing.Size(180, 22);
            this.videoDownscaleMenu.Text = "Video downscale";
            // 
            // videoDownScaleTextBox
            // 
            this.videoDownScaleTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.videoDownScaleTextBox.Name = "videoDownScaleTextBox";
            this.videoDownScaleTextBox.Size = new System.Drawing.Size(100, 23);
            // 
            // PictureMenu
            // 
            this.PictureMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PictureDownScaleTextBox});
            this.PictureMenu.Name = "PictureMenu";
            this.PictureMenu.Size = new System.Drawing.Size(180, 22);
            this.PictureMenu.Text = "Picture downscale";
            // 
            // PictureDownScaleTextBox
            // 
            this.PictureDownScaleTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PictureDownScaleTextBox.Name = "PictureDownScaleTextBox";
            this.PictureDownScaleTextBox.Size = new System.Drawing.Size(100, 23);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 101);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ManuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ManuStrip1.ResumeLayout(false);
            this.ManuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WebCamSettings;
        private System.Windows.Forms.ToolStripMenuItem pictureQualityToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox pictureScale_TextBox;
        private System.Windows.Forms.ToolStripMenuItem WebCamResolutionMenu;
        private System.Windows.Forms.ToolStripMenuItem WebcamSelectMenu;
        private System.Windows.Forms.ToolStripComboBox webcamSelectDropDown;
        private System.Windows.Forms.ToolStripMenuItem videoDownScale;
        private System.Windows.Forms.ToolStripTextBox videoScaleSelectorTextBox;
        private System.Windows.Forms.ToolStripComboBox WebCamResolutionDropDown;
        private System.Windows.Forms.MenuStrip ManuStrip1;
        private System.Windows.Forms.ToolStripMenuItem SettingsMenu;
        private System.Windows.Forms.ToolStripMenuItem WebcamMenu;
        private System.Windows.Forms.ToolStripMenuItem SelectWebcamMenu;
        private System.Windows.Forms.ToolStripMenuItem ResolutionMenu;
        private System.Windows.Forms.ToolStripMenuItem videoDownscaleMenu;
        private System.Windows.Forms.ToolStripTextBox videoDownScaleTextBox;
        private System.Windows.Forms.ToolStripMenuItem PictureMenu;
        private System.Windows.Forms.ToolStripComboBox SelectWebCamComboBox;
        private System.Windows.Forms.ToolStripComboBox ResolutionComboBox;
        private System.Windows.Forms.ToolStripTextBox PictureDownScaleTextBox;
    }
}

