namespace TrustonLtd
{
    partial class BuyPrideForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuyPrideForm));
            this.pieceTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.ResetButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SaveButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.totalAmountTextBox = new System.Windows.Forms.TextBox();
            this.rateTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.DateTime = new MetroFramework.Controls.MetroDateTime();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.typeOfProductTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // pieceTextBox
            // 
            this.pieceTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pieceTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(31)))), ((int)(((byte)(40)))));
            this.pieceTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pieceTextBox.ForeColor = System.Drawing.SystemColors.Info;
            this.pieceTextBox.Location = new System.Drawing.Point(269, 417);
            this.pieceTextBox.MaxLength = 3;
            this.pieceTextBox.Name = "pieceTextBox";
            this.pieceTextBox.Size = new System.Drawing.Size(262, 27);
            this.pieceTextBox.TabIndex = 0;
            this.pieceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pieceTextBox_KeyPress);
            this.pieceTextBox.Leave += new System.EventHandler(this.pieceTextBox_Leave);
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Silver;
            this.label13.Location = new System.Drawing.Point(265, 381);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 19);
            this.label13.TabIndex = 101;
            this.label13.Text = "piece";
            // 
            // BackButton
            // 
            this.BackButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Image = ((System.Drawing.Image)(resources.GetObject("BackButton.Image")));
            this.BackButton.Location = new System.Drawing.Point(37, 117);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 39);
            this.BackButton.TabIndex = 99;
            this.BackButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.ActiveBorderThickness = 1;
            this.ResetButton.ActiveCornerRadius = 20;
            this.ResetButton.ActiveFillColor = System.Drawing.Color.Crimson;
            this.ResetButton.ActiveForecolor = System.Drawing.Color.White;
            this.ResetButton.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.ResetButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ResetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(31)))), ((int)(((byte)(40)))));
            this.ResetButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ResetButton.BackgroundImage")));
            this.ResetButton.ButtonText = "Reset";
            this.ResetButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ResetButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.ResetButton.IdleBorderThickness = 1;
            this.ResetButton.IdleCornerRadius = 20;
            this.ResetButton.IdleFillColor = System.Drawing.Color.White;
            this.ResetButton.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.ResetButton.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.ResetButton.Location = new System.Drawing.Point(269, 633);
            this.ResetButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(130, 46);
            this.ResetButton.TabIndex = 4;
            this.ResetButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.ActiveBorderThickness = 1;
            this.SaveButton.ActiveCornerRadius = 20;
            this.SaveButton.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.SaveButton.ActiveForecolor = System.Drawing.Color.White;
            this.SaveButton.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.SaveButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(31)))), ((int)(((byte)(40)))));
            this.SaveButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SaveButton.BackgroundImage")));
            this.SaveButton.ButtonText = "Save";
            this.SaveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.SaveButton.IdleBorderThickness = 1;
            this.SaveButton.IdleCornerRadius = 20;
            this.SaveButton.IdleFillColor = System.Drawing.Color.White;
            this.SaveButton.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.SaveButton.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.SaveButton.Location = new System.Drawing.Point(407, 633);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(130, 46);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // totalAmountTextBox
            // 
            this.totalAmountTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.totalAmountTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(31)))), ((int)(((byte)(40)))));
            this.totalAmountTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalAmountTextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalAmountTextBox.ForeColor = System.Drawing.Color.Lime;
            this.totalAmountTextBox.Location = new System.Drawing.Point(269, 581);
            this.totalAmountTextBox.MaxLength = 4;
            this.totalAmountTextBox.Name = "totalAmountTextBox";
            this.totalAmountTextBox.ReadOnly = true;
            this.totalAmountTextBox.Size = new System.Drawing.Size(262, 31);
            this.totalAmountTextBox.TabIndex = 94;
            // 
            // rateTextBox
            // 
            this.rateTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rateTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(31)))), ((int)(((byte)(40)))));
            this.rateTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rateTextBox.ForeColor = System.Drawing.SystemColors.Info;
            this.rateTextBox.Location = new System.Drawing.Point(269, 495);
            this.rateTextBox.Name = "rateTextBox";
            this.rateTextBox.Size = new System.Drawing.Size(262, 27);
            this.rateTextBox.TabIndex = 1;
            this.rateTextBox.TextChanged += new System.EventHandler(this.rateTextBox_TextChanged);
            this.rateTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rateTextBox_KeyPress);
            this.rateTextBox.Leave += new System.EventHandler(this.rateTextBox_Leave);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Silver;
            this.label8.Location = new System.Drawing.Point(265, 546);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 19);
            this.label8.TabIndex = 95;
            this.label8.Text = "Total Amount";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Silver;
            this.label9.Location = new System.Drawing.Point(265, 459);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 19);
            this.label9.TabIndex = 96;
            this.label9.Text = "Rate";
            // 
            // DateTime
            // 
            this.DateTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DateTime.CalendarFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTime.CalendarForeColor = System.Drawing.SystemColors.Info;
            this.DateTime.CalendarTitleForeColor = System.Drawing.SystemColors.Info;
            this.DateTime.CalendarTrailingForeColor = System.Drawing.SystemColors.Info;
            this.DateTime.FontWeight = MetroFramework.MetroDateTimeWeight.Bold;
            this.DateTime.Location = new System.Drawing.Point(269, 245);
            this.DateTime.MinimumSize = new System.Drawing.Size(0, 29);
            this.DateTime.Name = "DateTime";
            this.DateTime.Size = new System.Drawing.Size(262, 29);
            this.DateTime.TabIndex = 92;
            this.DateTime.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Silver;
            this.label10.Location = new System.Drawing.Point(265, 207);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 19);
            this.label10.TabIndex = 91;
            this.label10.Text = "Date Time";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(328, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 32);
            this.label1.TabIndex = 90;
            this.label1.Text = "Buy Pride";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(355, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 89;
            this.pictureBox1.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // typeOfProductTextBox
            // 
            this.typeOfProductTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.typeOfProductTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(31)))), ((int)(((byte)(40)))));
            this.typeOfProductTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.typeOfProductTextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeOfProductTextBox.ForeColor = System.Drawing.Color.Lime;
            this.typeOfProductTextBox.Location = new System.Drawing.Point(269, 328);
            this.typeOfProductTextBox.MaxLength = 4;
            this.typeOfProductTextBox.Name = "typeOfProductTextBox";
            this.typeOfProductTextBox.ReadOnly = true;
            this.typeOfProductTextBox.Size = new System.Drawing.Size(262, 31);
            this.typeOfProductTextBox.TabIndex = 102;
            this.typeOfProductTextBox.Text = "Pride";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(265, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 19);
            this.label2.TabIndex = 103;
            this.label2.Text = "Type of Product";
            // 
            // BuyPrideForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(31)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(857, 771);
            this.Controls.Add(this.typeOfProductTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pieceTextBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.totalAmountTextBox);
            this.Controls.Add(this.rateTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.DateTime);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BuyPrideForm";
            this.Text = "BuyPrideForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pieceTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button BackButton;
        private Bunifu.Framework.UI.BunifuThinButton2 ResetButton;
        private Bunifu.Framework.UI.BunifuThinButton2 SaveButton;
        private System.Windows.Forms.TextBox totalAmountTextBox;
        private System.Windows.Forms.TextBox rateTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private MetroFramework.Controls.MetroDateTime DateTime;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.TextBox typeOfProductTextBox;
        private System.Windows.Forms.Label label2;
    }
}