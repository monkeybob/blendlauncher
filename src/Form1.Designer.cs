namespace blendlauncher
{
    partial class uiMain
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
            this.uiTabControl = new System.Windows.Forms.TabControl();
            this.uiTab1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.fileToLoad = new System.Windows.Forms.TextBox();
            this.uiHeight = new System.Windows.Forms.Label();
            this.uiWidth = new System.Windows.Forms.Label();
            this.uiFile = new System.Windows.Forms.Label();
            this.uiTab2 = new System.Windows.Forms.TabPage();
            this.uiCredits = new System.Windows.Forms.Label();
            this.heightVar = new System.Windows.Forms.Label();
            this.widthVar = new System.Windows.Forms.Label();
            this.windowVar = new System.Windows.Forms.Label();
            this.headerImage = new System.Windows.Forms.PictureBox();
            this.uiArgs = new System.Windows.Forms.Label();
            this.uiTabControl.SuspendLayout();
            this.uiTab1.SuspendLayout();
            this.uiTab2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.headerImage)).BeginInit();
            this.SuspendLayout();
            // 
            // uiTabControl
            // 
            this.uiTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiTabControl.Controls.Add(this.uiTab1);
            this.uiTabControl.Controls.Add(this.uiTab2);
            this.uiTabControl.Location = new System.Drawing.Point(0, 170);
            this.uiTabControl.Name = "uiTabControl";
            this.uiTabControl.SelectedIndex = 0;
            this.uiTabControl.Size = new System.Drawing.Size(305, 211);
            this.uiTabControl.TabIndex = 0;
            // 
            // uiTab1
            // 
            this.uiTab1.Controls.Add(this.button1);
            this.uiTab1.Controls.Add(this.radioButton3);
            this.uiTab1.Controls.Add(this.radioButton4);
            this.uiTab1.Controls.Add(this.txtHeight);
            this.uiTab1.Controls.Add(this.txtWidth);
            this.uiTab1.Controls.Add(this.fileToLoad);
            this.uiTab1.Controls.Add(this.uiHeight);
            this.uiTab1.Controls.Add(this.uiWidth);
            this.uiTab1.Controls.Add(this.uiFile);
            this.uiTab1.Location = new System.Drawing.Point(4, 22);
            this.uiTab1.Name = "uiTab1";
            this.uiTab1.Padding = new System.Windows.Forms.Padding(3);
            this.uiTab1.Size = new System.Drawing.Size(297, 185);
            this.uiTab1.TabIndex = 0;
            this.uiTab1.Text = "Launcher";
            this.uiTab1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(213, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Launch";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(213, 107);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(73, 17);
            this.radioButton3.TabIndex = 15;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Fullscreen";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.Click += new System.EventHandler(this.radioButton3_Click);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Checked = true;
            this.radioButton4.Location = new System.Drawing.Point(114, 107);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(76, 17);
            this.radioButton4.TabIndex = 14;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Windowed";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.Click += new System.EventHandler(this.radioButton4_Click);
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(89, 81);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(199, 20);
            this.txtHeight.TabIndex = 13;
            this.txtHeight.Text = "720";
            this.txtHeight.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(89, 55);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(199, 20);
            this.txtWidth.TabIndex = 12;
            this.txtWidth.Text = "1280";
            this.txtWidth.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // fileToLoad
            // 
            this.fileToLoad.Enabled = false;
            this.fileToLoad.Location = new System.Drawing.Point(79, 11);
            this.fileToLoad.Name = "fileToLoad";
            this.fileToLoad.Size = new System.Drawing.Size(209, 20);
            this.fileToLoad.TabIndex = 11;
            this.fileToLoad.Text = "example.blend";
            // 
            // uiHeight
            // 
            this.uiHeight.AutoSize = true;
            this.uiHeight.Location = new System.Drawing.Point(8, 84);
            this.uiHeight.Name = "uiHeight";
            this.uiHeight.Size = new System.Drawing.Size(78, 13);
            this.uiHeight.TabIndex = 10;
            this.uiHeight.Text = "Screen Height:";
            // 
            // uiWidth
            // 
            this.uiWidth.AutoSize = true;
            this.uiWidth.Location = new System.Drawing.Point(8, 58);
            this.uiWidth.Name = "uiWidth";
            this.uiWidth.Size = new System.Drawing.Size(75, 13);
            this.uiWidth.TabIndex = 9;
            this.uiWidth.Text = "Screen Width:";
            // 
            // uiFile
            // 
            this.uiFile.AutoSize = true;
            this.uiFile.Location = new System.Drawing.Point(8, 14);
            this.uiFile.Name = "uiFile";
            this.uiFile.Size = new System.Drawing.Size(65, 13);
            this.uiFile.TabIndex = 8;
            this.uiFile.Text = "File to open:";
            // 
            // uiTab2
            // 
            this.uiTab2.Controls.Add(this.uiArgs);
            this.uiTab2.Controls.Add(this.uiCredits);
            this.uiTab2.Controls.Add(this.heightVar);
            this.uiTab2.Controls.Add(this.widthVar);
            this.uiTab2.Controls.Add(this.windowVar);
            this.uiTab2.Location = new System.Drawing.Point(4, 22);
            this.uiTab2.Name = "uiTab2";
            this.uiTab2.Padding = new System.Windows.Forms.Padding(3);
            this.uiTab2.Size = new System.Drawing.Size(297, 185);
            this.uiTab2.TabIndex = 1;
            this.uiTab2.Text = "About";
            this.uiTab2.UseVisualStyleBackColor = true;
            // 
            // uiCredits
            // 
            this.uiCredits.AutoSize = true;
            this.uiCredits.Location = new System.Drawing.Point(4, 7);
            this.uiCredits.Name = "uiCredits";
            this.uiCredits.Size = new System.Drawing.Size(164, 13);
            this.uiCredits.TabIndex = 3;
            this.uiCredits.Text = "Blendlauncher code by Kiera Ash";
            // 
            // heightVar
            // 
            this.heightVar.AutoSize = true;
            this.heightVar.Location = new System.Drawing.Point(89, 167);
            this.heightVar.Name = "heightVar";
            this.heightVar.Size = new System.Drawing.Size(25, 13);
            this.heightVar.TabIndex = 2;
            this.heightVar.Text = "720";
            // 
            // widthVar
            // 
            this.widthVar.AutoSize = true;
            this.widthVar.Location = new System.Drawing.Point(48, 167);
            this.widthVar.Name = "widthVar";
            this.widthVar.Size = new System.Drawing.Size(31, 13);
            this.widthVar.TabIndex = 1;
            this.widthVar.Text = "1280";
            // 
            // windowVar
            // 
            this.windowVar.AutoSize = true;
            this.windowVar.Location = new System.Drawing.Point(7, 167);
            this.windowVar.Name = "windowVar";
            this.windowVar.Size = new System.Drawing.Size(18, 13);
            this.windowVar.TabIndex = 0;
            this.windowVar.Text = "-w";
            // 
            // headerImage
            // 
            this.headerImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.headerImage.Location = new System.Drawing.Point(0, -3);
            this.headerImage.Name = "headerImage";
            this.headerImage.Size = new System.Drawing.Size(305, 167);
            this.headerImage.TabIndex = 1;
            this.headerImage.TabStop = false;
            // 
            // uiArgs
            // 
            this.uiArgs.AutoSize = true;
            this.uiArgs.Location = new System.Drawing.Point(8, 142);
            this.uiArgs.Name = "uiArgs";
            this.uiArgs.Size = new System.Drawing.Size(57, 13);
            this.uiArgs.TabIndex = 4;
            this.uiArgs.Text = "Arguments";
            // 
            // uiMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 381);
            this.Controls.Add(this.headerImage);
            this.Controls.Add(this.uiTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "uiMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Blendlauncher Alpha 3-2018";
            this.uiTabControl.ResumeLayout(false);
            this.uiTab1.ResumeLayout(false);
            this.uiTab1.PerformLayout();
            this.uiTab2.ResumeLayout(false);
            this.uiTab2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.headerImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl uiTabControl;
        private System.Windows.Forms.TabPage uiTab1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.TextBox fileToLoad;
        private System.Windows.Forms.Label uiHeight;
        private System.Windows.Forms.Label uiWidth;
        private System.Windows.Forms.Label uiFile;
        private System.Windows.Forms.TabPage uiTab2;
        private System.Windows.Forms.Label heightVar;
        private System.Windows.Forms.Label widthVar;
        private System.Windows.Forms.Label windowVar;
        private System.Windows.Forms.PictureBox headerImage;
        private System.Windows.Forms.Label uiCredits;
        private System.Windows.Forms.Label uiArgs;
    }
}

