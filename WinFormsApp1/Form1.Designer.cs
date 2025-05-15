namespace CaptchaGenerator
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageText = new System.Windows.Forms.TabPage();
            this.labelTextResult = new System.Windows.Forms.Label();
            this.btnRefreshTextCaptcha = new System.Windows.Forms.Button();
            this.btnVerifyTextCaptcha = new System.Windows.Forms.Button();
            this.textBoxTextCaptcha = new System.Windows.Forms.TextBox();
            this.labelTextInstructions = new System.Windows.Forms.Label();
            this.pictureBoxTextCaptcha = new System.Windows.Forms.PictureBox();
            this.tabPageImage = new System.Windows.Forms.TabPage();
            this.labelImageResult = new System.Windows.Forms.Label();
            this.btnRefreshImageCaptcha = new System.Windows.Forms.Button();
            this.labelImageInstruction = new System.Windows.Forms.Label();
            this.pictureBoxImageCaptcha = new System.Windows.Forms.PictureBox();
            this.tabPageMath = new System.Windows.Forms.TabPage();
            this.labelMathResult = new System.Windows.Forms.Label();
            this.btnRefreshMathCaptcha = new System.Windows.Forms.Button();
            this.btnVerifyMathCaptcha = new System.Windows.Forms.Button();
            this.textBoxMathCaptcha = new System.Windows.Forms.TextBox();
            this.labelMathInstructions = new System.Windows.Forms.Label();
            this.pictureBoxMathCaptcha = new System.Windows.Forms.PictureBox();
            this.tabPageCheckbox = new System.Windows.Forms.TabPage();
            this.labelCheckboxResult = new System.Windows.Forms.Label();
            this.btnRefreshCheckboxCaptcha = new System.Windows.Forms.Button();
            this.btnVerifyCheckboxCaptcha = new System.Windows.Forms.Button();
            this.checkBoxCaptcha = new System.Windows.Forms.CheckBox();
            this.labelCheckboxInstructions = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPageText.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTextCaptcha)).BeginInit();
            this.tabPageImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageCaptcha)).BeginInit();
            this.tabPageMath.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMathCaptcha)).BeginInit();
            this.tabPageCheckbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageText);
            this.tabControl1.Controls.Add(this.tabPageImage);
            this.tabControl1.Controls.Add(this.tabPageMath);
            this.tabControl1.Controls.Add(this.tabPageCheckbox);
            this.tabControl1.Location = new System.Drawing.Point(12, 62);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(560, 387);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageText
            // 
            this.tabPageText.Controls.Add(this.labelTextResult);
            this.tabPageText.Controls.Add(this.btnRefreshTextCaptcha);
            this.tabPageText.Controls.Add(this.btnVerifyTextCaptcha);
            this.tabPageText.Controls.Add(this.textBoxTextCaptcha);
            this.tabPageText.Controls.Add(this.labelTextInstructions);
            this.tabPageText.Controls.Add(this.pictureBoxTextCaptcha);
            this.tabPageText.Location = new System.Drawing.Point(4, 25);
            this.tabPageText.Name = "tabPageText";
            this.tabPageText.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageText.Size = new System.Drawing.Size(552, 358);
            this.tabPageText.TabIndex = 0;
            this.tabPageText.Text = "Text CAPTCHA";
            this.tabPageText.UseVisualStyleBackColor = true;
            // 
            // labelTextResult
            // 
            this.labelTextResult.AutoSize = true;
            this.labelTextResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTextResult.Location = new System.Drawing.Point(31, 286);
            this.labelTextResult.Name = "labelTextResult";
            this.labelTextResult.Size = new System.Drawing.Size(0, 20);
            this.labelTextResult.TabIndex = 5;
            // 
            // btnRefreshTextCaptcha
            // 
            this.btnRefreshTextCaptcha.Location = new System.Drawing.Point(308, 227);
            this.btnRefreshTextCaptcha.Name = "btnRefreshTextCaptcha";
            this.btnRefreshTextCaptcha.Size = new System.Drawing.Size(166, 35);
            this.btnRefreshTextCaptcha.TabIndex = 4;
            this.btnRefreshTextCaptcha.Text = "Refresh CAPTCHA";
            this.btnRefreshTextCaptcha.UseVisualStyleBackColor = true;
            this.btnRefreshTextCaptcha.Click += new System.EventHandler(this.btnRefreshTextCaptcha_Click);
            // 
            // btnVerifyTextCaptcha
            // 
            this.btnVerifyTextCaptcha.Location = new System.Drawing.Point(308, 173);
            this.btnVerifyTextCaptcha.Name = "btnVerifyTextCaptcha";
            this.btnVerifyTextCaptcha.Size = new System.Drawing.Size(166, 35);
            this.btnVerifyTextCaptcha.TabIndex = 3;
            this.btnVerifyTextCaptcha.Text = "Verify CAPTCHA";
            this.btnVerifyTextCaptcha.UseVisualStyleBackColor = true;
            this.btnVerifyTextCaptcha.Click += new System.EventHandler(this.btnVerifyTextCaptcha_Click);
            // 
            // textBoxTextCaptcha
            // 
            this.textBoxTextCaptcha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTextCaptcha.Location = new System.Drawing.Point(35, 223);
            this.textBoxTextCaptcha.Name = "textBoxTextCaptcha";
            this.textBoxTextCaptcha.Size = new System.Drawing.Size(218, 30);
            this.textBoxTextCaptcha.TabIndex = 2;
            // 
            // labelTextInstructions
            // 
            this.labelTextInstructions.AutoSize = true;
            this.labelTextInstructions.Location = new System.Drawing.Point(32, 173);
            this.labelTextInstructions.Name = "labelTextInstructions";
            this.labelTextInstructions.Size = new System.Drawing.Size(221, 16);
            this.labelTextInstructions.TabIndex = 1;
            this.labelTextInstructions.Text = "Please enter the text you see above:";
            // 
            // pictureBoxTextCaptcha
            // 
            this.pictureBoxTextCaptcha.BackColor = System.Drawing.Color.White;
            this.pictureBoxTextCaptcha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxTextCaptcha.Location = new System.Drawing.Point(35, 31);
            this.pictureBoxTextCaptcha.Name = "pictureBoxTextCaptcha";
            this.pictureBoxTextCaptcha.Size = new System.Drawing.Size(439, 120);
            this.pictureBoxTextCaptcha.TabIndex = 0;
            this.pictureBoxTextCaptcha.TabStop = false;
            // 
            // tabPageImage
            // 
            this.tabPageImage.Controls.Add(this.labelImageResult);
            this.tabPageImage.Controls.Add(this.btnRefreshImageCaptcha);
            this.tabPageImage.Controls.Add(this.labelImageInstruction);
            this.tabPageImage.Controls.Add(this.pictureBoxImageCaptcha);
            this.tabPageImage.Location = new System.Drawing.Point(4, 25);
            this.tabPageImage.Name = "tabPageImage";
            this.tabPageImage.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageImage.Size = new System.Drawing.Size(552, 358);
            this.tabPageImage.TabIndex = 1;
            this.tabPageImage.Text = "Image CAPTCHA";
            this.tabPageImage.UseVisualStyleBackColor = true;
            // 
            // labelImageResult
            // 
            this.labelImageResult.AutoSize = true;
            this.labelImageResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImageResult.Location = new System.Drawing.Point(35, 303);
            this.labelImageResult.Name = "labelImageResult";
            this.labelImageResult.Size = new System.Drawing.Size(0, 20);
            this.labelImageResult.TabIndex = 3;
            // 
            // btnRefreshImageCaptcha
            // 
            this.btnRefreshImageCaptcha.Location = new System.Drawing.Point(178, 303);
            this.btnRefreshImageCaptcha.Name = "btnRefreshImageCaptcha";
            this.btnRefreshImageCaptcha.Size = new System.Drawing.Size(166, 35);
            this.btnRefreshImageCaptcha.TabIndex = 2;
            this.btnRefreshImageCaptcha.Text = "Refresh CAPTCHA";
            this.btnRefreshImageCaptcha.UseVisualStyleBackColor = true;
            this.btnRefreshImageCaptcha.Click += new System.EventHandler(this.btnRefreshImageCaptcha_Click);
            // 
            // labelImageInstruction
            // 
            this.labelImageInstruction.AutoSize = true;
            this.labelImageInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImageInstruction.Location = new System.Drawing.Point(35, 24);
            this.labelImageInstruction.Name = "labelImageInstruction";
            this.labelImageInstruction.Size = new System.Drawing.Size(173, 20);
            this.labelImageInstruction.TabIndex = 1;
            this.labelImageInstruction.Text = "Click the shape to verify";
            // 
            // pictureBoxImageCaptcha
            // 
            this.pictureBoxImageCaptcha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxImageCaptcha.Location = new System.Drawing.Point(39, 57);
            this.pictureBoxImageCaptcha.Name = "pictureBoxImageCaptcha";
            this.pictureBoxImageCaptcha.Size = new System.Drawing.Size(350, 230);
            this.pictureBoxImageCaptcha.TabIndex = 0;
            this.pictureBoxImageCaptcha.TabStop = false;
            this.pictureBoxImageCaptcha.Click += new System.EventHandler(this.pictureBoxImageCaptcha_Click);
            // 
            // tabPageMath
            // 
            this.tabPageMath.Controls.Add(this.labelMathResult);
            this.tabPageMath.Controls.Add(this.btnRefreshMathCaptcha);
            this.tabPageMath.Controls.Add(this.btnVerifyMathCaptcha);
            this.tabPageMath.Controls.Add(this.textBoxMathCaptcha);
            this.tabPageMath.Controls.Add(this.labelMathInstructions);
            this.tabPageMath.Controls.Add(this.pictureBoxMathCaptcha);
            this.tabPageMath.Location = new System.Drawing.Point(4, 25);
            this.tabPageMath.Name = "tabPageMath";
            this.tabPageMath.Size = new System.Drawing.Size(552, 358);
            this.tabPageMath.TabIndex = 2;
            this.tabPageMath.Text = "Math CAPTCHA";
            this.tabPageMath.UseVisualStyleBackColor = true;
            // 
            // labelMathResult
            // 
            this.labelMathResult.AutoSize = true;
            this.labelMathResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMathResult.Location = new System.Drawing.Point(28, 289);
            this.labelMathResult.Name = "labelMathResult";
            this.labelMathResult.Size = new System.Drawing.Size(0, 20);
            this.labelMathResult.TabIndex = 11;
            // 
            // btnRefreshMathCaptcha
            // 
            this.btnRefreshMathCaptcha.Location = new System.Drawing.Point(305, 230);
            this.btnRefreshMathCaptcha.Name = "btnRefreshMathCaptcha";
            this.btnRefreshMathCaptcha.Size = new System.Drawing.Size(166, 35);
            this.btnRefreshMathCaptcha.TabIndex = 10;
            this.btnRefreshMathCaptcha.Text = "Refresh CAPTCHA";
            this.btnRefreshMathCaptcha.UseVisualStyleBackColor = true;
            this.btnRefreshMathCaptcha.Click += new System.EventHandler(this.btnRefreshMathCaptcha_Click);
            // 
            // btnVerifyMathCaptcha
            // 
            this.btnVerifyMathCaptcha.Location = new System.Drawing.Point(305, 176);
            this.btnVerifyMathCaptcha.Name = "btnVerifyMathCaptcha";
            this.btnVerifyMathCaptcha.Size = new System.Drawing.Size(166, 35);
            this.btnVerifyMathCaptcha.TabIndex = 9;
            this.btnVerifyMathCaptcha.Text = "Verify CAPTCHA";
            this.btnVerifyMathCaptcha.UseVisualStyleBackColor = true;
            this.btnVerifyMathCaptcha.Click += new System.EventHandler(this.btnVerifyMathCaptcha_Click);
            // 
            // textBoxMathCaptcha
            // 
            this.textBoxMathCaptcha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMathCaptcha.Location = new System.Drawing.Point(32, 226);
            this.textBoxMathCaptcha.Name = "textBoxMathCaptcha";
            this.textBoxMathCaptcha.Size = new System.Drawing.Size(215, 30);
            this.textBoxMathCaptcha.TabIndex = 8;
            // 
            // labelMathInstructions
            // 
            this.labelMathInstructions.AutoSize = true;
            this.labelMathInstructions.Location = new System.Drawing.Point(29, 176);
            this.labelMathInstructions.Name = "labelMathInstructions";
            this.labelMathInstructions.Size = new System.Drawing.Size(230, 16);
            this.labelMathInstructions.TabIndex = 7;
            this.labelMathInstructions.Text = "Please solve the math problem above:";
            // 
            // pictureBoxMathCaptcha
            // 
            this.pictureBoxMathCaptcha.BackColor = System.Drawing.Color.White;
            this.pictureBoxMathCaptcha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxMathCaptcha.Location = new System.Drawing.Point(32, 27);
            this.pictureBoxMathCaptcha.Name = "pictureBoxMathCaptcha";
            this.pictureBoxMathCaptcha.Size = new System.Drawing.Size(439, 120);
            this.pictureBoxMathCaptcha.TabIndex = 6;
            this.pictureBoxMathCaptcha.TabStop = false;
            // 
            // tabPageCheckbox
            // 
            this.tabPageCheckbox.Controls.Add(this.labelCheckboxResult);
            this.tabPageCheckbox.Controls.Add(this.btnRefreshCheckboxCaptcha);
            this.tabPageCheckbox.Controls.Add(this.btnVerifyCheckboxCaptcha);
            this.tabPageCheckbox.Controls.Add(this.checkBoxCaptcha);
            this.tabPageCheckbox.Controls.Add(this.labelCheckboxInstructions);
            this.tabPageCheckbox.Location = new System.Drawing.Point(4, 25);
            this.tabPageCheckbox.Name = "tabPageCheckbox";
            this.tabPageCheckbox.Size = new System.Drawing.Size(552, 358);
            this.tabPageCheckbox.TabIndex = 3;
            this.tabPageCheckbox.Text = "Checkbox CAPTCHA";
            this.tabPageCheckbox.UseVisualStyleBackColor = true;
            // 
            // labelCheckboxResult
            // 
            this.labelCheckboxResult.AutoSize = true;
            this.labelCheckboxResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCheckboxResult.Location = new System.Drawing.Point(37, 226);
            this.labelCheckboxResult.Name = "labelCheckboxResult";
            this.labelCheckboxResult.Size = new System.Drawing.Size(0, 20);
            this.labelCheckboxResult.TabIndex = 4;
            // 
            // btnRefreshCheckboxCaptcha
            // 
            this.btnRefreshCheckboxCaptcha.Location = new System.Drawing.Point(263, 161);
            this.btnRefreshCheckboxCaptcha.Name = "btnRefreshCheckboxCaptcha";
            this.btnRefreshCheckboxCaptcha.Size = new System.Drawing.Size(166, 35);
            this.btnRefreshCheckboxCaptcha.TabIndex = 3;
            this.btnRefreshCheckboxCaptcha.Text = "Reset CAPTCHA";
            this.btnRefreshCheckboxCaptcha.UseVisualStyleBackColor = true;
            this.btnRefreshCheckboxCaptcha.Click += new System.EventHandler(this.btnRefreshCheckboxCaptcha_Click);
            // 
            // btnVerifyCheckboxCaptcha
            // 
            this.btnVerifyCheckboxCaptcha.Location = new System.Drawing.Point(75, 161);
            this.btnVerifyCheckboxCaptcha.Name = "btnVerifyCheckboxCaptcha";
            this.btnVerifyCheckboxCaptcha.Size = new System.Drawing.Size(166, 35);
            this.btnVerifyCheckboxCaptcha.TabIndex = 2;
            this.btnVerifyCheckboxCaptcha.Text = "Verify CAPTCHA";
            this.btnVerifyCheckboxCaptcha.UseVisualStyleBackColor = true;
            this.btnVerifyCheckboxCaptcha.Click += new System.EventHandler(this.btnVerifyCheckboxCaptcha_Click);
            // 
            // checkBoxCaptcha
            // 
            this.checkBoxCaptcha.AutoSize = true;
            this.checkBoxCaptcha.Location = new System.Drawing.Point(40, 107);
            this.checkBoxCaptcha.Name = "checkBoxCaptcha";
            this.checkBoxCaptcha.Size = new System.Drawing.Size(121, 20);
            this.checkBoxCaptcha.TabIndex = 1;
            this.checkBoxCaptcha.Text = "I am not a robot";
            this.checkBoxCaptcha.UseVisualStyleBackColor = true;
            // 
            // labelCheckboxInstructions
            // 
            this.labelCheckboxInstructions.AutoSize = true;
            this.labelCheckboxInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCheckboxInstructions.Location = new System.Drawing.Point(36, 53);
            this.labelCheckboxInstructions.Name = "labelCheckboxInstructions";
            this.labelCheckboxInstructions.Size = new System.Drawing.Size(330, 20);
            this.labelCheckboxInstructions.TabIndex = 0;
            this.labelCheckboxInstructions.Text = "Please check the box to verify you are human:";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(142, 19);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(304, 32);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "CAPTCHA Generator";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CAPTCHA Generator";
            this.tabControl1.ResumeLayout(false);
            this.tabPageText.ResumeLayout(false);
            this.tabPageText.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTextCaptcha)).EndInit();
            this.tabPageImage.ResumeLayout(false);
            this.tabPageImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageCaptcha)).EndInit();
            this.tabPageMath.ResumeLayout(false);
            this.tabPageMath.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMathCaptcha)).EndInit();
            this.tabPageCheckbox.ResumeLayout(false);
            this.tabPageCheckbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageText;
        private System.Windows.Forms.TabPage tabPageImage;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.PictureBox pictureBoxTextCaptcha;
        private System.Windows.Forms.Label labelTextInstructions;
        private System.Windows.Forms.TextBox textBoxTextCaptcha;
        private System.Windows.Forms.Button btnVerifyTextCaptcha;
        private System.Windows.Forms.Button btnRefreshTextCaptcha;
        private System.Windows.Forms.Label labelTextResult;
        private System.Windows.Forms.PictureBox pictureBoxImageCaptcha;
        private System.Windows.Forms.Label labelImageInstruction;
        private System.Windows.Forms.Button btnRefreshImageCaptcha;
        private System.Windows.Forms.Label labelImageResult;
        private System.Windows.Forms.TabPage tabPageMath;
        private System.Windows.Forms.TabPage tabPageCheckbox;
        private System.Windows.Forms.Label labelMathResult;
        private System.Windows.Forms.Button btnRefreshMathCaptcha;
        private System.Windows.Forms.Button btnVerifyMathCaptcha;
        private System.Windows.Forms.TextBox textBoxMathCaptcha;
        private System.Windows.Forms.Label labelMathInstructions;
        private System.Windows.Forms.PictureBox pictureBoxMathCaptcha;
        private System.Windows.Forms.Label labelCheckboxInstructions;
        private System.Windows.Forms.CheckBox checkBoxCaptcha;
        private System.Windows.Forms.Button btnVerifyCheckboxCaptcha;
        private System.Windows.Forms.Button btnRefreshCheckboxCaptcha;
        private System.Windows.Forms.Label labelCheckboxResult;
    }
}