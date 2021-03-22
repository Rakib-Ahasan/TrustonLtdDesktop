namespace TrustonLtd
{
    partial class StockStatusForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockStatusForm));
            this.BackButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.totalStoredRemainTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.totalStockOutTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.totalPendingTextBox = new System.Windows.Forms.TextBox();
            this.rateTextBox = new System.Windows.Forms.TextBox();
            this.pieceTextBox = new System.Windows.Forms.TextBox();
            this.OkButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.productNameComboBox = new MetroFramework.Controls.MetroComboBox();
            this.typeOfProductComboBox = new MetroFramework.Controls.MetroComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Image = ((System.Drawing.Image)(resources.GetObject("BackButton.Image")));
            this.BackButton.Location = new System.Drawing.Point(44, 72);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 39);
            this.BackButton.TabIndex = 93;
            this.BackButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(76, 400);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 19);
            this.label3.TabIndex = 90;
            this.label3.Text = "Rate";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Silver;
            this.label9.Location = new System.Drawing.Point(76, 318);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 19);
            this.label9.TabIndex = 89;
            this.label9.Text = "Piece";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(315, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 32);
            this.label1.TabIndex = 87;
            this.label1.Text = "Stock Status";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(363, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 86;
            this.pictureBox1.TabStop = false;
            // 
            // totalStoredRemainTextBox
            // 
            this.totalStoredRemainTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.totalStoredRemainTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(31)))), ((int)(((byte)(40)))));
            this.totalStoredRemainTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalStoredRemainTextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalStoredRemainTextBox.ForeColor = System.Drawing.Color.Lime;
            this.totalStoredRemainTextBox.Location = new System.Drawing.Point(430, 361);
            this.totalStoredRemainTextBox.MaxLength = 4;
            this.totalStoredRemainTextBox.Name = "totalStoredRemainTextBox";
            this.totalStoredRemainTextBox.ReadOnly = true;
            this.totalStoredRemainTextBox.Size = new System.Drawing.Size(262, 31);
            this.totalStoredRemainTextBox.TabIndex = 109;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(426, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 19);
            this.label4.TabIndex = 110;
            this.label4.Text = "Total Stored Remain";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(426, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 19);
            this.label5.TabIndex = 110;
            this.label5.Text = "Total Stock Out";
            // 
            // totalStockOutTextBox
            // 
            this.totalStockOutTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.totalStockOutTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(31)))), ((int)(((byte)(40)))));
            this.totalStockOutTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalStockOutTextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalStockOutTextBox.ForeColor = System.Drawing.Color.Lime;
            this.totalStockOutTextBox.Location = new System.Drawing.Point(430, 194);
            this.totalStockOutTextBox.MaxLength = 4;
            this.totalStockOutTextBox.Name = "totalStockOutTextBox";
            this.totalStockOutTextBox.ReadOnly = true;
            this.totalStockOutTextBox.Size = new System.Drawing.Size(262, 31);
            this.totalStockOutTextBox.TabIndex = 109;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(426, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 19);
            this.label6.TabIndex = 110;
            this.label6.Text = "Total Pending";
            // 
            // totalPendingTextBox
            // 
            this.totalPendingTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.totalPendingTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(31)))), ((int)(((byte)(40)))));
            this.totalPendingTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalPendingTextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPendingTextBox.ForeColor = System.Drawing.Color.Lime;
            this.totalPendingTextBox.Location = new System.Drawing.Point(430, 276);
            this.totalPendingTextBox.MaxLength = 4;
            this.totalPendingTextBox.Name = "totalPendingTextBox";
            this.totalPendingTextBox.ReadOnly = true;
            this.totalPendingTextBox.Size = new System.Drawing.Size(262, 31);
            this.totalPendingTextBox.TabIndex = 109;
            // 
            // rateTextBox
            // 
            this.rateTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rateTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(31)))), ((int)(((byte)(40)))));
            this.rateTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rateTextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rateTextBox.ForeColor = System.Drawing.Color.Lime;
            this.rateTextBox.Location = new System.Drawing.Point(80, 435);
            this.rateTextBox.MaxLength = 4;
            this.rateTextBox.Name = "rateTextBox";
            this.rateTextBox.ReadOnly = true;
            this.rateTextBox.Size = new System.Drawing.Size(262, 31);
            this.rateTextBox.TabIndex = 111;
            // 
            // pieceTextBox
            // 
            this.pieceTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pieceTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(31)))), ((int)(((byte)(40)))));
            this.pieceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pieceTextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pieceTextBox.ForeColor = System.Drawing.Color.Lime;
            this.pieceTextBox.Location = new System.Drawing.Point(80, 353);
            this.pieceTextBox.MaxLength = 4;
            this.pieceTextBox.Name = "pieceTextBox";
            this.pieceTextBox.ReadOnly = true;
            this.pieceTextBox.Size = new System.Drawing.Size(262, 31);
            this.pieceTextBox.TabIndex = 111;
            // 
            // OkButton
            // 
            this.OkButton.ActiveBorderThickness = 1;
            this.OkButton.ActiveCornerRadius = 20;
            this.OkButton.ActiveFillColor = System.Drawing.Color.Teal;
            this.OkButton.ActiveForecolor = System.Drawing.Color.White;
            this.OkButton.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.OkButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OkButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(31)))), ((int)(((byte)(40)))));
            this.OkButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("OkButton.BackgroundImage")));
            this.OkButton.ButtonText = "OK";
            this.OkButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OkButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OkButton.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.OkButton.IdleBorderThickness = 1;
            this.OkButton.IdleCornerRadius = 20;
            this.OkButton.IdleFillColor = System.Drawing.Color.DarkSlateGray;
            this.OkButton.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.OkButton.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.OkButton.Location = new System.Drawing.Point(430, 410);
            this.OkButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(262, 46);
            this.OkButton.TabIndex = 112;
            this.OkButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
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
            this.productNameComboBox.Items.AddRange(new object[] {
            "---Select Item---",
            "Handicraft Orna",
            "Embroidery Orna",
            "Three Piece",
            "Others "});
            this.productNameComboBox.Location = new System.Drawing.Point(77, 283);
            this.productNameComboBox.Name = "productNameComboBox";
            this.productNameComboBox.Size = new System.Drawing.Size(265, 29);
            this.productNameComboBox.Style = MetroFramework.MetroColorStyle.Black;
            this.productNameComboBox.TabIndex = 113;
            this.productNameComboBox.UseCustomBackColor = true;
            this.productNameComboBox.UseCustomForeColor = true;
            this.productNameComboBox.UseSelectable = true;
            this.productNameComboBox.SelectedIndexChanged += new System.EventHandler(this.productNameComboBox_SelectedIndexChanged);
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
            this.typeOfProductComboBox.Items.AddRange(new object[] {
            "---Select Item---",
            "Handicraft Orna",
            "Embroidery Orna",
            "Three Piece",
            "Others "});
            this.typeOfProductComboBox.Location = new System.Drawing.Point(80, 200);
            this.typeOfProductComboBox.Name = "typeOfProductComboBox";
            this.typeOfProductComboBox.Size = new System.Drawing.Size(262, 29);
            this.typeOfProductComboBox.Style = MetroFramework.MetroColorStyle.Black;
            this.typeOfProductComboBox.TabIndex = 114;
            this.typeOfProductComboBox.UseCustomBackColor = true;
            this.typeOfProductComboBox.UseCustomForeColor = true;
            this.typeOfProductComboBox.UseSelectable = true;
            this.typeOfProductComboBox.SelectedIndexChanged += new System.EventHandler(this.typeOfProductComboBox_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Silver;
            this.label15.Location = new System.Drawing.Point(76, 247);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(121, 19);
            this.label15.TabIndex = 115;
            this.label15.Text = "Product Name";
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Silver;
            this.label21.Location = new System.Drawing.Point(76, 159);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(131, 19);
            this.label21.TabIndex = 116;
            this.label21.Text = "Type  of Product";
            // 
            // StockStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(31)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(892, 565);
            this.Controls.Add(this.productNameComboBox);
            this.Controls.Add(this.typeOfProductComboBox);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.pieceTextBox);
            this.Controls.Add(this.rateTextBox);
            this.Controls.Add(this.totalPendingTextBox);
            this.Controls.Add(this.totalStockOutTextBox);
            this.Controls.Add(this.totalStoredRemainTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StockStatusForm";
            this.Text = "StockStatusForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox totalStoredRemainTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox totalStockOutTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox totalPendingTextBox;
        private System.Windows.Forms.TextBox rateTextBox;
        private System.Windows.Forms.TextBox pieceTextBox;
        private Bunifu.Framework.UI.BunifuThinButton2 OkButton;
        private MetroFramework.Controls.MetroComboBox productNameComboBox;
        private MetroFramework.Controls.MetroComboBox typeOfProductComboBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label21;
    }
}