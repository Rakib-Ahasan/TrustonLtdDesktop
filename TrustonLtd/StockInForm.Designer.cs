namespace TrustonLtd
{
    partial class StockInForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockInForm));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pieceTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.rateTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.label10 = new System.Windows.Forms.Label();
            this.ResetButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SaveButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.BackButton = new System.Windows.Forms.Button();
            this.typeOfProductComboBox = new MetroFramework.Controls.MetroComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.productNameComboBox = new MetroFramework.Controls.MetroComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(290, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 32);
            this.label1.TabIndex = 36;
            this.label1.Text = "Stock In";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(320, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // pieceTextBox
            // 
            this.pieceTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pieceTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(31)))), ((int)(((byte)(40)))));
            this.pieceTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pieceTextBox.ForeColor = System.Drawing.SystemColors.Info;
            this.pieceTextBox.Location = new System.Drawing.Point(230, 558);
            this.pieceTextBox.MaxLength = 4;
            this.pieceTextBox.Name = "pieceTextBox";
            this.pieceTextBox.Size = new System.Drawing.Size(262, 27);
            this.pieceTextBox.TabIndex = 2;
            this.pieceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pieceTextBox_KeyPress);
            this.pieceTextBox.Leave += new System.EventHandler(this.pieceTextBox_Leave);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Silver;
            this.label9.Location = new System.Drawing.Point(226, 522);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 19);
            this.label9.TabIndex = 53;
            this.label9.Text = "Piece";
            // 
            // rateTextBox
            // 
            this.rateTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rateTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(31)))), ((int)(((byte)(40)))));
            this.rateTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rateTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rateTextBox.ForeColor = System.Drawing.SystemColors.Info;
            this.rateTextBox.Location = new System.Drawing.Point(230, 466);
            this.rateTextBox.MaxLength = 3;
            this.rateTextBox.Name = "rateTextBox";
            this.rateTextBox.ReadOnly = true;
            this.rateTextBox.Size = new System.Drawing.Size(262, 27);
            this.rateTextBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(226, 430);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 19);
            this.label3.TabIndex = 55;
            this.label3.Text = "Rate";
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroDateTime1.CalendarFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroDateTime1.CalendarForeColor = System.Drawing.SystemColors.Info;
            this.metroDateTime1.CalendarTitleForeColor = System.Drawing.SystemColors.Info;
            this.metroDateTime1.CalendarTrailingForeColor = System.Drawing.SystemColors.Info;
            this.metroDateTime1.FontWeight = MetroFramework.MetroDateTimeWeight.Bold;
            this.metroDateTime1.Location = new System.Drawing.Point(230, 197);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(262, 29);
            this.metroDateTime1.TabIndex = 57;
            this.metroDateTime1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Silver;
            this.label10.Location = new System.Drawing.Point(226, 159);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 19);
            this.label10.TabIndex = 56;
            this.label10.Text = "Date Time";
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
            this.ResetButton.Location = new System.Drawing.Point(214, 609);
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
            this.SaveButton.Location = new System.Drawing.Point(372, 609);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(130, 46);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // BackButton
            // 
            this.BackButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Image = ((System.Drawing.Image)(resources.GetObject("BackButton.Image")));
            this.BackButton.Location = new System.Drawing.Point(-5, 43);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 39);
            this.BackButton.TabIndex = 80;
            this.BackButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // typeOfProductComboBox
            // 
            this.typeOfProductComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.typeOfProductComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.typeOfProductComboBox.BackColor = System.Drawing.Color.Gray;
            this.typeOfProductComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.typeOfProductComboBox.FontWeight = MetroFramework.MetroComboBoxWeight.Bold;
            this.typeOfProductComboBox.ForeColor = System.Drawing.SystemColors.Desktop;
            this.typeOfProductComboBox.FormattingEnabled = true;
            this.typeOfProductComboBox.ItemHeight = 23;
            this.typeOfProductComboBox.Location = new System.Drawing.Point(227, 288);
            this.typeOfProductComboBox.Name = "typeOfProductComboBox";
            this.typeOfProductComboBox.Size = new System.Drawing.Size(275, 29);
            this.typeOfProductComboBox.Style = MetroFramework.MetroColorStyle.Black;
            this.typeOfProductComboBox.TabIndex = 0;
            this.typeOfProductComboBox.UseCustomBackColor = true;
            this.typeOfProductComboBox.UseCustomForeColor = true;
            this.typeOfProductComboBox.UseSelectable = true;
            this.typeOfProductComboBox.SelectedIndexChanged += new System.EventHandler(this.typeOfProductComboBox_SelectedIndexChanged);
            this.typeOfProductComboBox.Leave += new System.EventHandler(this.typeOfProductComboBox_Leave);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(226, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 19);
            this.label4.TabIndex = 99;
            this.label4.Text = "Type  of Product";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(226, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 19);
            this.label2.TabIndex = 99;
            this.label2.Text = "Product Name";
            // 
            // productNameComboBox
            // 
            this.productNameComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.productNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.productNameComboBox.BackColor = System.Drawing.Color.Gray;
            this.productNameComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productNameComboBox.FontWeight = MetroFramework.MetroComboBoxWeight.Bold;
            this.productNameComboBox.ForeColor = System.Drawing.SystemColors.Desktop;
            this.productNameComboBox.FormattingEnabled = true;
            this.productNameComboBox.ItemHeight = 23;
            this.productNameComboBox.Location = new System.Drawing.Point(227, 376);
            this.productNameComboBox.Name = "productNameComboBox";
            this.productNameComboBox.Size = new System.Drawing.Size(275, 29);
            this.productNameComboBox.Style = MetroFramework.MetroColorStyle.Black;
            this.productNameComboBox.TabIndex = 1;
            this.productNameComboBox.UseCustomBackColor = true;
            this.productNameComboBox.UseCustomForeColor = true;
            this.productNameComboBox.UseSelectable = true;
            this.productNameComboBox.SelectedIndexChanged += new System.EventHandler(this.productNameComboBox_SelectedIndexChanged);
            this.productNameComboBox.Leave += new System.EventHandler(this.productNameComboBox_Leave);
            // 
            // StockInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(31)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(790, 717);
            this.Controls.Add(this.productNameComboBox);
            this.Controls.Add(this.typeOfProductComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.metroDateTime1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.rateTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pieceTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StockInForm";
            this.Text = "StockInForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox pieceTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox rateTextBox;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        private System.Windows.Forms.Label label10;
        private Bunifu.Framework.UI.BunifuThinButton2 ResetButton;
        private Bunifu.Framework.UI.BunifuThinButton2 SaveButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.Button BackButton;
        private MetroFramework.Controls.MetroComboBox productNameComboBox;
        private MetroFramework.Controls.MetroComboBox typeOfProductComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}