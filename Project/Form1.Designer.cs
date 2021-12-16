
namespace Project
{
    partial class Translator
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Translator));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.MinimizeButton = new System.Windows.Forms.PictureBox();
            this.CloseButton = new System.Windows.Forms.PictureBox();
            this.calculatorButton = new System.Windows.Forms.PictureBox();
            this.translateButton = new System.Windows.Forms.PictureBox();
            this.YourNumber = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.NumberBox = new System.Windows.Forms.TextBox();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.ResultBox = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.FromLabel = new System.Windows.Forms.Label();
            this.ToLabel = new System.Windows.Forms.Label();
            this.FromBox = new System.Windows.Forms.ComboBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.ToBox = new System.Windows.Forms.ComboBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calculatorButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.translateButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
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
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
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
            // calculatorButton
            // 
            this.calculatorButton.ErrorImage = null;
            this.calculatorButton.Image = ((System.Drawing.Image)(resources.GetObject("calculatorButton.Image")));
            this.calculatorButton.Location = new System.Drawing.Point(12, 568);
            this.calculatorButton.Name = "calculatorButton";
            this.calculatorButton.Size = new System.Drawing.Size(275, 82);
            this.calculatorButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.calculatorButton.TabIndex = 1;
            this.calculatorButton.TabStop = false;
            this.calculatorButton.Click += new System.EventHandler(this.calculatorButton_Click);
            // 
            // translateButton
            // 
            this.translateButton.ErrorImage = null;
            this.translateButton.Image = ((System.Drawing.Image)(resources.GetObject("translateButton.Image")));
            this.translateButton.Location = new System.Drawing.Point(872, 568);
            this.translateButton.Name = "translateButton";
            this.translateButton.Size = new System.Drawing.Size(274, 82);
            this.translateButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.translateButton.TabIndex = 2;
            this.translateButton.TabStop = false;
            this.translateButton.Click += new System.EventHandler(this.translateButton_Click);
            // 
            // YourNumber
            // 
            this.YourNumber.AutoSize = true;
            this.YourNumber.Font = new System.Drawing.Font("Century Gothic", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.YourNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(215)))), ((int)(((byte)(76)))));
            this.YourNumber.Location = new System.Drawing.Point(210, 123);
            this.YourNumber.Name = "YourNumber";
            this.YourNumber.Size = new System.Drawing.Size(295, 52);
            this.YourNumber.TabIndex = 2;
            this.YourNumber.Text = "Ваше число:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(511, 102);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(466, 106);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // NumberBox
            // 
            this.NumberBox.AllowDrop = true;
            this.NumberBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NumberBox.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumberBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(215)))), ((int)(((byte)(76)))));
            this.NumberBox.Location = new System.Drawing.Point(514, 136);
            this.NumberBox.Name = "NumberBox";
            this.NumberBox.Size = new System.Drawing.Size(460, 34);
            this.NumberBox.TabIndex = 4;
            this.NumberBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Font = new System.Drawing.Font("Century Gothic", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(215)))), ((int)(((byte)(76)))));
            this.ResultLabel.Location = new System.Drawing.Point(256, 432);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(233, 52);
            this.ResultLabel.TabIndex = 5;
            this.ResultLabel.Text = "Результат:";
            // 
            // ResultBox
            // 
            this.ResultBox.AllowDrop = true;
            this.ResultBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ResultBox.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(215)))), ((int)(((byte)(76)))));
            this.ResultBox.Location = new System.Drawing.Point(488, 447);
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.Size = new System.Drawing.Size(460, 34);
            this.ResultBox.TabIndex = 7;
            this.ResultBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(485, 413);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(466, 106);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // FromLabel
            // 
            this.FromLabel.AutoSize = true;
            this.FromLabel.Font = new System.Drawing.Font("Century Gothic", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FromLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(215)))), ((int)(((byte)(76)))));
            this.FromLabel.Location = new System.Drawing.Point(29, 280);
            this.FromLabel.Name = "FromLabel";
            this.FromLabel.Size = new System.Drawing.Size(73, 52);
            this.FromLabel.TabIndex = 8;
            this.FromLabel.Text = "Из";
            // 
            // ToLabel
            // 
            this.ToLabel.AutoSize = true;
            this.ToLabel.Font = new System.Drawing.Font("Century Gothic", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(215)))), ((int)(((byte)(76)))));
            this.ToLabel.Location = new System.Drawing.Point(597, 280);
            this.ToLabel.Name = "ToLabel";
            this.ToLabel.Size = new System.Drawing.Size(43, 52);
            this.ToLabel.TabIndex = 9;
            this.ToLabel.Text = "в";
            // 
            // FromBox
            // 
            this.FromBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FromBox.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FromBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(215)))), ((int)(((byte)(76)))));
            this.FromBox.FormattingEnabled = true;
            this.FromBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.FromBox.Items.AddRange(new object[] {
            "Двоичной",
            "Восьмеричной",
            "Десятичной",
            "Шестнадцатиричной"});
            this.FromBox.Location = new System.Drawing.Point(138, 280);
            this.FromBox.Name = "FromBox";
            this.FromBox.Size = new System.Drawing.Size(426, 57);
            this.FromBox.TabIndex = 10;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Enabled = false;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(115, 232);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(476, 152);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 11;
            this.pictureBox5.TabStop = false;
            // 
            // ToBox
            // 
            this.ToBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToBox.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(215)))), ((int)(((byte)(76)))));
            this.ToBox.FormattingEnabled = true;
            this.ToBox.Items.AddRange(new object[] {
            "Двоичную",
            "Восьмеричную",
            "Десятичную",
            "Шестнадцатиричную"});
            this.ToBox.Location = new System.Drawing.Point(670, 280);
            this.ToBox.Name = "ToBox";
            this.ToBox.Size = new System.Drawing.Size(426, 57);
            this.ToBox.TabIndex = 12;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Enabled = false;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(647, 232);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(476, 152);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 13;
            this.pictureBox6.TabStop = false;
            // 
            // Translator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(111)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1158, 662);
            this.ControlBox = false;
            this.Controls.Add(this.ToBox);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.FromBox);
            this.Controls.Add(this.ToLabel);
            this.Controls.Add(this.FromLabel);
            this.Controls.Add(this.ResultBox);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.NumberBox);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.YourNumber);
            this.Controls.Add(this.translateButton);
            this.Controls.Add(this.calculatorButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "Translator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calculatorButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.translateButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox CloseButton;
        private System.Windows.Forms.PictureBox MinimizeButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.PictureBox calculatorButton;
        private System.Windows.Forms.PictureBox translateButton;
        private System.Windows.Forms.Label YourNumber;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox NumberBox;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.TextBox ResultBox;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label FromLabel;
        private System.Windows.Forms.Label ToLabel;
        private System.Windows.Forms.ComboBox FromBox;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.ComboBox ToBox;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}

