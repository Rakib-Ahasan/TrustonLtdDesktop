namespace TrustonLtd
{
    partial class CustomerStatusForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerStatusForm));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.ResetButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.UpdateButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.ViewReportButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.okButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.totalDueTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.refContactTextBox = new System.Windows.Forms.TextBox();
            this.referenceNameTextBox = new System.Windows.Forms.TextBox();
            this.contactTextBox = new System.Windows.Forms.TextBox();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.customerNameComboBox = new MetroFramework.Controls.MetroComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(241, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 32);
            this.label1.TabIndex = 80;
            this.label1.Text = "Customer Status";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(308, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 79;
            this.pictureBox1.TabStop = false;
            // 
            // BackButton
            // 
            this.BackButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Image = ((System.Drawing.Image)(resources.GetObject("BackButton.Image")));
            this.BackButton.Location = new System.Drawing.Point(71, 66);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 39);
            this.BackButton.TabIndex = 100;
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
            this.ResetButton.Location = new System.Drawing.Point(432, 261);
            this.ResetButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(130, 46);
            this.ResetButton.TabIndex = 105;
            this.ResetButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.ActiveBorderThickness = 1;
            this.UpdateButton.ActiveCornerRadius = 20;
            this.UpdateButton.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.UpdateButton.ActiveForecolor = System.Drawing.Color.White;
            this.UpdateButton.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.UpdateButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UpdateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(31)))), ((int)(((byte)(40)))));
            this.UpdateButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UpdateButton.BackgroundImage")));
            this.UpdateButton.ButtonText = "Update Information";
            this.UpdateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.UpdateButton.IdleBorderThickness = 1;
            this.UpdateButton.IdleCornerRadius = 20;
            this.UpdateButton.IdleFillColor = System.Drawing.Color.DarkSeaGreen;
            this.UpdateButton.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.UpdateButton.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.UpdateButton.Location = new System.Drawing.Point(432, 317);
            this.UpdateButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(262, 46);
            this.UpdateButton.TabIndex = 102;
            this.UpdateButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // ViewReportButton
            // 
            this.ViewReportButton.ActiveBorderThickness = 1;
            this.ViewReportButton.ActiveCornerRadius = 20;
            this.ViewReportButton.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.ViewReportButton.ActiveForecolor = System.Drawing.Color.White;
            this.ViewReportButton.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.ViewReportButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ViewReportButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(31)))), ((int)(((byte)(40)))));
            this.ViewReportButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ViewReportButton.BackgroundImage")));
            this.ViewReportButton.ButtonText = "View Report";
            this.ViewReportButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ViewReportButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewReportButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.ViewReportButton.IdleBorderThickness = 1;
            this.ViewReportButton.IdleCornerRadius = 20;
            this.ViewReportButton.IdleFillColor = System.Drawing.Color.Wheat;
            this.ViewReportButton.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.ViewReportButton.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.ViewReportButton.Location = new System.Drawing.Point(432, 373);
            this.ViewReportButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ViewReportButton.Name = "ViewReportButton";
            this.ViewReportButton.Size = new System.Drawing.Size(262, 46);
            this.ViewReportButton.TabIndex = 103;
            this.ViewReportButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ViewReportButton.Click += new System.EventHandler(this.ViewReportButton_Click_1);
            // 
            // okButton
            // 
            this.okButton.ActiveBorderThickness = 1;
            this.okButton.ActiveCornerRadius = 20;
            this.okButton.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.okButton.ActiveForecolor = System.Drawing.Color.White;
            this.okButton.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.okButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.okButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(31)))), ((int)(((byte)(40)))));
            this.okButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("okButton.BackgroundImage")));
            this.okButton.ButtonText = "OK";
            this.okButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.okButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.okButton.IdleBorderThickness = 1;
            this.okButton.IdleCornerRadius = 20;
            this.okButton.IdleFillColor = System.Drawing.Color.White;
            this.okButton.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.okButton.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.okButton.Location = new System.Drawing.Point(564, 261);
            this.okButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(130, 46);
            this.okButton.TabIndex = 104;
            this.okButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.okButton.Click += new System.EventHandler(this.okButton_Click_1);
            // 
            // totalDueTextBox
            // 
            this.totalDueTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.totalDueTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(31)))), ((int)(((byte)(40)))));
            this.totalDueTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalDueTextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalDueTextBox.ForeColor = System.Drawing.Color.Lime;
            this.totalDueTextBox.Location = new System.Drawing.Point(432, 194);
            this.totalDueTextBox.Name = "totalDueTextBox";
            this.totalDueTextBox.ReadOnly = true;
            this.totalDueTextBox.Size = new System.Drawing.Size(262, 31);
            this.totalDueTextBox.TabIndex = 120;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Silver;
            this.label11.Location = new System.Drawing.Point(428, 158);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 19);
            this.label11.TabIndex = 119;
            this.label11.Text = "Total Due";
            // 
            // refContactTextBox
            // 
            this.refContactTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.refContactTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(31)))), ((int)(((byte)(40)))));
            this.refContactTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refContactTextBox.ForeColor = System.Drawing.SystemColors.Info;
            this.refContactTextBox.Location = new System.Drawing.Point(71, 579);
            this.refContactTextBox.Name = "refContactTextBox";
            this.refContactTextBox.Size = new System.Drawing.Size(262, 27);
            this.refContactTextBox.TabIndex = 114;
            // 
            // referenceNameTextBox
            // 
            this.referenceNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.referenceNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(31)))), ((int)(((byte)(40)))));
            this.referenceNameTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.referenceNameTextBox.ForeColor = System.Drawing.SystemColors.Info;
            this.referenceNameTextBox.Location = new System.Drawing.Point(71, 501);
            this.referenceNameTextBox.Name = "referenceNameTextBox";
            this.referenceNameTextBox.Size = new System.Drawing.Size(262, 27);
            this.referenceNameTextBox.TabIndex = 112;
            // 
            // contactTextBox
            // 
            this.contactTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.contactTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(31)))), ((int)(((byte)(40)))));
            this.contactTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactTextBox.ForeColor = System.Drawing.SystemColors.Info;
            this.contactTextBox.Location = new System.Drawing.Point(71, 424);
            this.contactTextBox.Name = "contactTextBox";
            this.contactTextBox.Size = new System.Drawing.Size(262, 27);
            this.contactTextBox.TabIndex = 113;
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customerNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(31)))), ((int)(((byte)(40)))));
            this.customerNameTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameTextBox.ForeColor = System.Drawing.SystemColors.Info;
            this.customerNameTextBox.Location = new System.Drawing.Point(71, 270);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(262, 27);
            this.customerNameTextBox.TabIndex = 115;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addressTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(31)))), ((int)(((byte)(40)))));
            this.addressTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressTextBox.ForeColor = System.Drawing.SystemColors.Info;
            this.addressTextBox.Location = new System.Drawing.Point(71, 347);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(262, 27);
            this.addressTextBox.TabIndex = 116;
            // 
            // customerNameComboBox
            // 
            this.customerNameComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customerNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.customerNameComboBox.BackColor = System.Drawing.Color.Gray;
            this.customerNameComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customerNameComboBox.FontWeight = MetroFramework.MetroComboBoxWeight.Bold;
            this.customerNameComboBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.customerNameComboBox.FormattingEnabled = true;
            this.customerNameComboBox.ItemHeight = 23;
            this.customerNameComboBox.Location = new System.Drawing.Point(71, 194);
            this.customerNameComboBox.Name = "customerNameComboBox";
            this.customerNameComboBox.Size = new System.Drawing.Size(262, 29);
            this.customerNameComboBox.TabIndex = 101;
            this.customerNameComboBox.UseCustomBackColor = true;
            this.customerNameComboBox.UseCustomForeColor = true;
            this.customerNameComboBox.UseSelectable = true;
            this.customerNameComboBox.SelectedIndexChanged += new System.EventHandler(this.customerNameComboBox_SelectedIndexChanged);
            this.customerNameComboBox.Leave += new System.EventHandler(this.customerNameComboBox_Leave);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(67, 543);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 19);
            this.label6.TabIndex = 106;
            this.label6.Text = "Reference Contact";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(67, 466);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 19);
            this.label5.TabIndex = 107;
            this.label5.Text = "Reference Name";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(67, 388);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 19);
            this.label4.TabIndex = 108;
            this.label4.Text = "Contact";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Silver;
            this.label9.Location = new System.Drawing.Point(67, 233);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 19);
            this.label9.TabIndex = 109;
            this.label9.Text = "Customer Name";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(67, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 19);
            this.label3.TabIndex = 110;
            this.label3.Text = "Address";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(67, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 19);
            this.label2.TabIndex = 111;
            this.label2.Text = "Customer Name";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // CustomerStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(31)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(790, 655);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.ViewReportButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.totalDueTextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.refContactTextBox);
            this.Controls.Add(this.referenceNameTextBox);
            this.Controls.Add(this.contactTextBox);
            this.Controls.Add(this.customerNameTextBox);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.customerNameComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerStatusForm";
            this.Text = "CustomerForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BackButton;
        private Bunifu.Framework.UI.BunifuThinButton2 ResetButton;
        private Bunifu.Framework.UI.BunifuThinButton2 UpdateButton;
        private Bunifu.Framework.UI.BunifuThinButton2 ViewReportButton;
        private Bunifu.Framework.UI.BunifuThinButton2 okButton;
        private System.Windows.Forms.TextBox totalDueTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox refContactTextBox;
        private System.Windows.Forms.TextBox referenceNameTextBox;
        private System.Windows.Forms.TextBox contactTextBox;
        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private MetroFramework.Controls.MetroComboBox customerNameComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}