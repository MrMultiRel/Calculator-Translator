
namespace Project
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.nameLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MinimizeButton = new System.Windows.Forms.PictureBox();
            this.CloseButton = new System.Windows.Forms.PictureBox();
            this.FirstNumberBox = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.SecondNumberBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ResultBox = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.translatorButton = new System.Windows.Forms.PictureBox();
            this.CalculateButton = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FirstFromBox = new System.Windows.Forms.ComboBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SecondFromBox = new System.Windows.Forms.ComboBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ResultFormBox = new System.Windows.Forms.ComboBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.OperationBox = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.YourNumber = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.translatorButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CalculateButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(19, 10);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(628, 33);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Переводчик и калькулятор систем счисления";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.nameLabel);
            this.groupBox1.Controls.Add(this.MinimizeButton);
            this.groupBox1.Controls.Add(this.CloseButton);
            this.groupBox1.Location = new System.Drawing.Point(-7, -7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1168, 49);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.Image = ((System.Drawing.Image)(resources.GetObject("MinimizeButton.Image")));
            this.MinimizeButton.Location = new System.Drawing.Point(1066, 19);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(53, 17);
            this.MinimizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.MinimizeButton.TabIndex = 1;
            this.MinimizeButton.TabStop = false;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Image = ((System.Drawing.Image)(resources.GetObject("CloseButton.Image")));
            this.CloseButton.Location = new System.Drawing.Point(1125, 10);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(37, 37);
            this.CloseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.CloseButton.TabIndex = 1;
            this.CloseButton.TabStop = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // FirstNumberBox
            // 
            this.FirstNumberBox.AllowDrop = true;
            this.FirstNumberBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FirstNumberBox.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstNumberBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(215)))), ((int)(((byte)(76)))));
            this.FirstNumberBox.Location = new System.Drawing.Point(19, 140);
            this.FirstNumberBox.Name = "FirstNumberBox";
            this.FirstNumberBox.Size = new System.Drawing.Size(441, 34);
            this.FirstNumberBox.TabIndex = 6;
            this.FirstNumberBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(14, 106);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(450, 100);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // SecondNumberBox
            // 
            this.SecondNumberBox.AllowDrop = true;
            this.SecondNumberBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SecondNumberBox.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecondNumberBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(215)))), ((int)(((byte)(76)))));
            this.SecondNumberBox.Location = new System.Drawing.Point(701, 140);
            this.SecondNumberBox.Name = "SecondNumberBox";
            this.SecondNumberBox.Size = new System.Drawing.Size(441, 34);
            this.SecondNumberBox.TabIndex = 8;
            this.SecondNumberBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(696, 106);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(450, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // ResultBox
            // 
            this.ResultBox.AllowDrop = true;
            this.ResultBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ResultBox.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(215)))), ((int)(((byte)(76)))));
            this.ResultBox.Location = new System.Drawing.Point(484, 393);
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.Size = new System.Drawing.Size(460, 34);
            this.ResultBox.TabIndex = 11;
            this.ResultBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(481, 359);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(466, 106);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Font = new System.Drawing.Font("Century Gothic", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(215)))), ((int)(((byte)(76)))));
            this.ResultLabel.Location = new System.Drawing.Point(252, 378);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(233, 52);
            this.ResultLabel.TabIndex = 9;
            this.ResultLabel.Text = "Результат:";
            // 
            // translatorButton
            // 
            this.translatorButton.Image = ((System.Drawing.Image)(resources.GetObject("translatorButton.Image")));
            this.translatorButton.Location = new System.Drawing.Point(12, 568);
            this.translatorButton.Name = "translatorButton";
            this.translatorButton.Size = new System.Drawing.Size(275, 82);
            this.translatorButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.translatorButton.TabIndex = 12;
            this.translatorButton.TabStop = false;
            this.translatorButton.Click += new System.EventHandler(this.translatorButton_Click);
            // 
            // CalculateButton
            // 
            this.CalculateButton.Image = ((System.Drawing.Image)(resources.GetObject("CalculateButton.Image")));
            this.CalculateButton.Location = new System.Drawing.Point(872, 568);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(275, 82);
            this.CalculateButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CalculateButton.TabIndex = 13;
            this.CalculateButton.TabStop = false;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(215)))), ((int)(((byte)(76)))));
            this.label1.Location = new System.Drawing.Point(149, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 39);
            this.label1.TabIndex = 14;
            this.label1.Text = "в:";
            // 
            // FirstFromBox
            // 
            this.FirstFromBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FirstFromBox.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstFromBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(215)))), ((int)(((byte)(76)))));
            this.FirstFromBox.FormattingEnabled = true;
            this.FirstFromBox.Items.AddRange(new object[] {
            "Двоичной",
            "Восьмеричной",
            "Десятичной",
            "Шестнадцатиричной"});
            this.FirstFromBox.Location = new System.Drawing.Point(208, 234);
            this.FirstFromBox.Name = "FirstFromBox";
            this.FirstFromBox.Size = new System.Drawing.Size(360, 47);
            this.FirstFromBox.TabIndex = 15;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Enabled = false;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(196, 220);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(383, 72);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 16;
            this.pictureBox6.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(215)))), ((int)(((byte)(76)))));
            this.label2.Location = new System.Drawing.Point(622, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 39);
            this.label2.TabIndex = 17;
            this.label2.Text = "и";
            // 
            // SecondFromBox
            // 
            this.SecondFromBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SecondFromBox.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecondFromBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(215)))), ((int)(((byte)(76)))));
            this.SecondFromBox.FormattingEnabled = true;
            this.SecondFromBox.Items.AddRange(new object[] {
            "Двоичной",
            "Восьмеричной",
            "Десятичной",
            "Шестнадцатиричной"});
            this.SecondFromBox.Location = new System.Drawing.Point(721, 234);
            this.SecondFromBox.Name = "SecondFromBox";
            this.SecondFromBox.Size = new System.Drawing.Size(360, 47);
            this.SecondFromBox.TabIndex = 18;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Enabled = false;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(709, 220);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(383, 72);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 19;
            this.pictureBox7.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(215)))), ((int)(((byte)(76)))));
            this.label3.Location = new System.Drawing.Point(298, 501);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 39);
            this.label3.TabIndex = 20;
            this.label3.Text = "перевести в:";
            // 
            // ResultFormBox
            // 
            this.ResultFormBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResultFormBox.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultFormBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(215)))), ((int)(((byte)(76)))));
            this.ResultFormBox.FormattingEnabled = true;
            this.ResultFormBox.Items.AddRange(new object[] {
            "Двоичную",
            "Восьмеричную",
            "Десятичную",
            "Шестнадцатиричную"});
            this.ResultFormBox.Location = new System.Drawing.Point(526, 493);
            this.ResultFormBox.Name = "ResultFormBox";
            this.ResultFormBox.Size = new System.Drawing.Size(360, 47);
            this.ResultFormBox.TabIndex = 21;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Enabled = false;
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(514, 479);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(383, 72);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 22;
            this.pictureBox8.TabStop = false;
            // 
            // OperationBox
            // 
            this.OperationBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OperationBox.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OperationBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(215)))), ((int)(((byte)(76)))));
            this.OperationBox.FormattingEnabled = true;
            this.OperationBox.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            ":"});
            this.OperationBox.Location = new System.Drawing.Point(545, 133);
            this.OperationBox.Name = "OperationBox";
            this.OperationBox.Size = new System.Drawing.Size(108, 47);
            this.OperationBox.TabIndex = 23;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Enabled = false;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(532, 127);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(127, 57);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // YourNumber
            // 
            this.YourNumber.AutoSize = true;
            this.YourNumber.Font = new System.Drawing.Font("Century Gothic", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.YourNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(215)))), ((int)(((byte)(76)))));
            this.YourNumber.Location = new System.Drawing.Point(435, 51);
            this.YourNumber.Name = "YourNumber";
            this.YourNumber.Size = new System.Drawing.Size(294, 52);
            this.YourNumber.TabIndex = 25;
            this.YourNumber.Text = "Ваши числа:";
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(111)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1158, 662);
            this.ControlBox = false;
            this.Controls.Add(this.YourNumber);
            this.Controls.Add(this.OperationBox);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.ResultFormBox);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SecondFromBox);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FirstFromBox);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.translatorButton);
            this.Controls.Add(this.ResultBox);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.SecondNumberBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.FirstNumberBox);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.translatorButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CalculateButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox MinimizeButton;
        private System.Windows.Forms.PictureBox CloseButton;
        private System.Windows.Forms.TextBox FirstNumberBox;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox SecondNumberBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox ResultBox;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.PictureBox translatorButton;
        private System.Windows.Forms.PictureBox CalculateButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox FirstFromBox;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox SecondFromBox;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ResultFormBox;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.ComboBox OperationBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label YourNumber;
    }
}