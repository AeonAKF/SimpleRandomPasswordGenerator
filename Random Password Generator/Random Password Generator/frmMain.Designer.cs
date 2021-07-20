namespace Random_Password_Generator
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.cmoboCharCount = new System.Windows.Forms.ComboBox();
            this.grpMain = new System.Windows.Forms.GroupBox();
            this.grpComplexity = new System.Windows.Forms.GroupBox();
            this.trackComplexity = new System.Windows.Forms.TrackBar();
            this.lblCharCount = new System.Windows.Forms.Label();
            this.grpInclude = new System.Windows.Forms.GroupBox();
            this.chkSymbols = new System.Windows.Forms.CheckBox();
            this.chkUpper = new System.Windows.Forms.CheckBox();
            this.lblSymbols = new System.Windows.Forms.Label();
            this.chkLower = new System.Windows.Forms.CheckBox();
            this.lblUpper = new System.Windows.Forms.Label();
            this.lblLower = new System.Windows.Forms.Label();
            this.chkNumbers = new System.Windows.Forms.CheckBox();
            this.lblNumbers = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpPassword = new System.Windows.Forms.GroupBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.picBoxPassword = new System.Windows.Forms.PictureBox();
            this.btnCopyClipboard = new System.Windows.Forms.Button();
            this.grpMain.SuspendLayout();
            this.grpComplexity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackComplexity)).BeginInit();
            this.grpInclude.SuspendLayout();
            this.grpPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // cmoboCharCount
            // 
            this.cmoboCharCount.DropDownHeight = 132;
            this.cmoboCharCount.DropDownWidth = 30;
            this.cmoboCharCount.FormattingEnabled = true;
            this.cmoboCharCount.IntegralHeight = false;
            this.cmoboCharCount.Location = new System.Drawing.Point(189, 34);
            this.cmoboCharCount.Margin = new System.Windows.Forms.Padding(4);
            this.cmoboCharCount.MaxDropDownItems = 26;
            this.cmoboCharCount.Name = "cmoboCharCount";
            this.cmoboCharCount.Size = new System.Drawing.Size(60, 32);
            this.cmoboCharCount.TabIndex = 0;
            this.cmoboCharCount.SelectedIndexChanged += new System.EventHandler(this.cmoboCharCount_SelectedIndexChanged);
            // 
            // grpMain
            // 
            this.grpMain.BackColor = System.Drawing.SystemColors.Control;
            this.grpMain.Controls.Add(this.grpComplexity);
            this.grpMain.Controls.Add(this.lblCharCount);
            this.grpMain.Controls.Add(this.cmoboCharCount);
            this.grpMain.Controls.Add(this.grpInclude);
            this.grpMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMain.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grpMain.Location = new System.Drawing.Point(18, 7);
            this.grpMain.Margin = new System.Windows.Forms.Padding(4);
            this.grpMain.Name = "grpMain";
            this.grpMain.Padding = new System.Windows.Forms.Padding(4);
            this.grpMain.Size = new System.Drawing.Size(444, 179);
            this.grpMain.TabIndex = 1;
            this.grpMain.TabStop = false;
            this.grpMain.Text = "Password Complexity Options";
            // 
            // grpComplexity
            // 
            this.grpComplexity.Controls.Add(this.trackComplexity);
            this.grpComplexity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpComplexity.Location = new System.Drawing.Point(260, 15);
            this.grpComplexity.Name = "grpComplexity";
            this.grpComplexity.Size = new System.Drawing.Size(171, 62);
            this.grpComplexity.TabIndex = 11;
            this.grpComplexity.TabStop = false;
            this.grpComplexity.Text = "Compexity";
            // 
            // trackComplexity
            // 
            this.trackComplexity.AutoSize = false;
            this.trackComplexity.LargeChange = 1;
            this.trackComplexity.Location = new System.Drawing.Point(9, 25);
            this.trackComplexity.Maximum = 4;
            this.trackComplexity.Minimum = 1;
            this.trackComplexity.Name = "trackComplexity";
            this.trackComplexity.Size = new System.Drawing.Size(154, 30);
            this.trackComplexity.TabIndex = 0;
            this.trackComplexity.Value = 1;
            this.trackComplexity.Scroll += new System.EventHandler(this.trackComplexity_Scroll);
            // 
            // lblCharCount
            // 
            this.lblCharCount.AutoSize = true;
            this.lblCharCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharCount.Location = new System.Drawing.Point(10, 40);
            this.lblCharCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCharCount.Name = "lblCharCount";
            this.lblCharCount.Size = new System.Drawing.Size(174, 20);
            this.lblCharCount.TabIndex = 1;
            this.lblCharCount.Text = "Character Count: 6 - 32";
            // 
            // grpInclude
            // 
            this.grpInclude.Controls.Add(this.chkSymbols);
            this.grpInclude.Controls.Add(this.chkUpper);
            this.grpInclude.Controls.Add(this.lblSymbols);
            this.grpInclude.Controls.Add(this.chkLower);
            this.grpInclude.Controls.Add(this.lblUpper);
            this.grpInclude.Controls.Add(this.lblLower);
            this.grpInclude.Controls.Add(this.chkNumbers);
            this.grpInclude.Controls.Add(this.lblNumbers);
            this.grpInclude.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInclude.Location = new System.Drawing.Point(27, 74);
            this.grpInclude.Margin = new System.Windows.Forms.Padding(4);
            this.grpInclude.Name = "grpInclude";
            this.grpInclude.Padding = new System.Windows.Forms.Padding(4);
            this.grpInclude.Size = new System.Drawing.Size(393, 92);
            this.grpInclude.TabIndex = 10;
            this.grpInclude.TabStop = false;
            this.grpInclude.Text = "Characters to Include";
            // 
            // chkSymbols
            // 
            this.chkSymbols.AutoSize = true;
            this.chkSymbols.Location = new System.Drawing.Point(233, 66);
            this.chkSymbols.Margin = new System.Windows.Forms.Padding(4);
            this.chkSymbols.Name = "chkSymbols";
            this.chkSymbols.Size = new System.Drawing.Size(15, 14);
            this.chkSymbols.TabIndex = 8;
            this.chkSymbols.UseVisualStyleBackColor = true;
            this.chkSymbols.CheckedChanged += new System.EventHandler(this.chkSymbols_CheckedChanged);
            // 
            // chkUpper
            // 
            this.chkUpper.AutoSize = true;
            this.chkUpper.Location = new System.Drawing.Point(233, 40);
            this.chkUpper.Margin = new System.Windows.Forms.Padding(4);
            this.chkUpper.Name = "chkUpper";
            this.chkUpper.Size = new System.Drawing.Size(15, 14);
            this.chkUpper.TabIndex = 9;
            this.chkUpper.UseVisualStyleBackColor = true;
            this.chkUpper.CheckedChanged += new System.EventHandler(this.chkUpper_CheckedChanged);
            // 
            // lblSymbols
            // 
            this.lblSymbols.AutoSize = true;
            this.lblSymbols.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSymbols.Location = new System.Drawing.Point(264, 62);
            this.lblSymbols.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSymbols.Name = "lblSymbols";
            this.lblSymbols.Size = new System.Drawing.Size(69, 20);
            this.lblSymbols.TabIndex = 4;
            this.lblSymbols.Text = "Symbols";
            this.lblSymbols.Click += new System.EventHandler(this.lblSymbols_Click);
            // 
            // chkLower
            // 
            this.chkLower.AutoSize = true;
            this.chkLower.Checked = true;
            this.chkLower.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLower.Location = new System.Drawing.Point(15, 67);
            this.chkLower.Margin = new System.Windows.Forms.Padding(4);
            this.chkLower.Name = "chkLower";
            this.chkLower.Size = new System.Drawing.Size(15, 14);
            this.chkLower.TabIndex = 7;
            this.chkLower.UseVisualStyleBackColor = true;
            this.chkLower.CheckedChanged += new System.EventHandler(this.chkLower_CheckedChanged);
            // 
            // lblUpper
            // 
            this.lblUpper.AutoSize = true;
            this.lblUpper.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpper.Location = new System.Drawing.Point(264, 36);
            this.lblUpper.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUpper.Name = "lblUpper";
            this.lblUpper.Size = new System.Drawing.Size(108, 20);
            this.lblUpper.TabIndex = 3;
            this.lblUpper.Text = "UPPERCASE";
            this.lblUpper.Click += new System.EventHandler(this.lblUpper_Click);
            // 
            // lblLower
            // 
            this.lblLower.AutoSize = true;
            this.lblLower.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLower.Location = new System.Drawing.Point(46, 61);
            this.lblLower.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLower.Name = "lblLower";
            this.lblLower.Size = new System.Drawing.Size(80, 20);
            this.lblLower.TabIndex = 2;
            this.lblLower.Text = "lowercase";
            this.lblLower.Click += new System.EventHandler(this.lblLower_Click);
            // 
            // chkNumbers
            // 
            this.chkNumbers.AutoSize = true;
            this.chkNumbers.Checked = true;
            this.chkNumbers.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNumbers.Location = new System.Drawing.Point(15, 41);
            this.chkNumbers.Margin = new System.Windows.Forms.Padding(4);
            this.chkNumbers.Name = "chkNumbers";
            this.chkNumbers.Size = new System.Drawing.Size(15, 14);
            this.chkNumbers.TabIndex = 6;
            this.chkNumbers.UseVisualStyleBackColor = true;
            this.chkNumbers.CheckedChanged += new System.EventHandler(this.chkNumbers_CheckedChanged);
            // 
            // lblNumbers
            // 
            this.lblNumbers.AutoSize = true;
            this.lblNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumbers.Location = new System.Drawing.Point(46, 38);
            this.lblNumbers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumbers.Name = "lblNumbers";
            this.lblNumbers.Size = new System.Drawing.Size(32, 20);
            this.lblNumbers.TabIndex = 5;
            this.lblNumbers.Text = "0-9";
            this.lblNumbers.Click += new System.EventHandler(this.lblNumbers_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnGenerate.Location = new System.Drawing.Point(18, 276);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(210, 58);
            this.btnGenerate.TabIndex = 10;
            this.btnGenerate.Text = "Generate Password";
            this.btnGenerate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnExit.Location = new System.Drawing.Point(358, 276);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(104, 58);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // grpPassword
            // 
            this.grpPassword.BackColor = System.Drawing.SystemColors.Control;
            this.grpPassword.Controls.Add(this.lblPassword);
            this.grpPassword.Controls.Add(this.picBoxPassword);
            this.grpPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPassword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grpPassword.Location = new System.Drawing.Point(18, 194);
            this.grpPassword.Margin = new System.Windows.Forms.Padding(4);
            this.grpPassword.Name = "grpPassword";
            this.grpPassword.Padding = new System.Windows.Forms.Padding(4);
            this.grpPassword.Size = new System.Drawing.Size(444, 74);
            this.grpPassword.TabIndex = 11;
            this.grpPassword.TabStop = false;
            this.grpPassword.Text = "Password";
            // 
            // lblPassword
            // 
            this.lblPassword.BackColor = System.Drawing.Color.Black;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(11, 30);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(420, 24);
            this.lblPassword.TabIndex = 12;
            this.lblPassword.Text = "abcdefghijklmnopqrstuvwxyzabcdefghijklmno";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picBoxPassword
            // 
            this.picBoxPassword.BackColor = System.Drawing.Color.Black;
            this.picBoxPassword.Location = new System.Drawing.Point(7, 21);
            this.picBoxPassword.Name = "picBoxPassword";
            this.picBoxPassword.Size = new System.Drawing.Size(429, 46);
            this.picBoxPassword.TabIndex = 0;
            this.picBoxPassword.TabStop = false;
            // 
            // btnCopyClipboard
            // 
            this.btnCopyClipboard.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCopyClipboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopyClipboard.Location = new System.Drawing.Point(236, 276);
            this.btnCopyClipboard.Margin = new System.Windows.Forms.Padding(4);
            this.btnCopyClipboard.Name = "btnCopyClipboard";
            this.btnCopyClipboard.Size = new System.Drawing.Size(114, 58);
            this.btnCopyClipboard.TabIndex = 12;
            this.btnCopyClipboard.Text = "Copy to Clipboard";
            this.btnCopyClipboard.UseVisualStyleBackColor = true;
            this.btnCopyClipboard.Click += new System.EventHandler(this.btnFiresWhenPressGenerate);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 345);
            this.Controls.Add(this.btnCopyClipboard);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.grpMain);
            this.Controls.Add(this.grpPassword);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Random Password Generator";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.grpMain.ResumeLayout(false);
            this.grpMain.PerformLayout();
            this.grpComplexity.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackComplexity)).EndInit();
            this.grpInclude.ResumeLayout(false);
            this.grpInclude.PerformLayout();
            this.grpPassword.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPassword)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmoboCharCount;
        private System.Windows.Forms.GroupBox grpMain;
        private System.Windows.Forms.CheckBox chkUpper;
        private System.Windows.Forms.CheckBox chkSymbols;
        private System.Windows.Forms.CheckBox chkLower;
        private System.Windows.Forms.CheckBox chkNumbers;
        private System.Windows.Forms.Label lblNumbers;
        private System.Windows.Forms.Label lblSymbols;
        private System.Windows.Forms.Label lblUpper;
        private System.Windows.Forms.Label lblLower;
        private System.Windows.Forms.Label lblCharCount;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox grpInclude;
        private System.Windows.Forms.GroupBox grpPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.PictureBox picBoxPassword;
        private System.Windows.Forms.GroupBox grpComplexity;
        private System.Windows.Forms.TrackBar trackComplexity;
        private System.Windows.Forms.Button btnCopyClipboard;
    }
}

