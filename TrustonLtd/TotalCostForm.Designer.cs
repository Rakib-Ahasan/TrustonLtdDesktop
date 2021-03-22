namespace TrustonLtd
{
    partial class TotalCostForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TotalCostForm));
            this.toDateTime = new MetroFramework.Controls.MetroDateTime();
            this.fromDateTime = new MetroFramework.Controls.MetroDateTime();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OkButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.totalCostTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.viewReportButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.BackButton = new System.Windows.Forms.Button();
            this.searchButton = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toDateTime
            // 
            this.toDateTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.toDateTime.CalendarFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toDateTime.CalendarForeColor = System.Drawing.SystemColors.Info;
            this.toDateTime.CalendarTitleForeColor = System.Drawing.SystemColors.Info;
            this.toDateTime.CalendarTrailingForeColor = System.Drawing.SystemColors.Info;
            this.toDateTime.FontWeight = MetroFramework.MetroDateTimeWeight.Bold;
            this.toDateTime.Location = new System.Drawing.Point(355, 249);
            this.toDateTime.MinimumSize = new System.Drawing.Size(0, 29);
            this.toDateTime.Name = "toDateTime";
            this.toDateTime.Size = new System.Drawing.Size(221, 29);
            this.toDateTime.TabIndex = 92;
            this.toDateTime.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // fromDateTime
            // 
            this.fromDateTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fromDateTime.CalendarFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromDateTime.CalendarForeColor = System.Drawing.SystemColors.Info;
            this.fromDateTime.CalendarTitleForeColor = System.Drawing.SystemColors.Info;
            this.fromDateTime.CalendarTrailingForeColor = System.Drawing.SystemColors.Info;
            this.fromDateTime.FontWeight = MetroFramework.MetroDateTimeWeight.Bold;
            this.fromDateTime.Location = new System.Drawing.Point(96, 249);
            this.fromDateTime.MinimumSize = new System.Drawing.Size(0, 29);
            this.fromDateTime.Name = "fromDateTime";
            this.fromDateTime.Size = new System.Drawing.Size(221, 29);
            this.fromDateTime.TabIndex = 93;
            this.fromDateTime.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(351, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 19);
            this.label3.TabIndex = 90;
            this.label3.Text = "Date Time To";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(92, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 19);
            this.label2.TabIndex = 91;
            this.label2.Text = "Date Time From";
            // 
            // OkButton
            // 
            this.OkButton.ActiveBorderThickness = 1;
            this.OkButton.ActiveCornerRadius = 20;
            this.OkButton.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.OkButton.ActiveForecolor = System.Drawing.Color.White;
            this.OkButton.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.OkButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OkButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(31)))), ((int)(((byte)(40)))));
            this.OkButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("OkButton.BackgroundImage")));
            this.OkButton.ButtonText = "Ok";
            this.OkButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OkButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OkButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.OkButton.IdleBorderThickness = 1;
            this.OkButton.IdleCornerRadius = 20;
            this.OkButton.IdleFillColor = System.Drawing.Color.White;
            this.OkButton.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.OkButton.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.OkButton.Location = new System.Drawing.Point(253, 416);
            this.OkButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(262, 46);
            this.OkButton.TabIndex = 89;
            this.OkButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // totalCostTextBox
            // 
            this.totalCostTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.totalCostTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(31)))), ((int)(((byte)(40)))));
            this.totalCostTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalCostTextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCostTextBox.ForeColor = System.Drawing.Color.Lime;
            this.totalCostTextBox.Location = new System.Drawing.Point(253, 370);
            this.totalCostTextBox.MaxLength = 4;
            this.totalCostTextBox.Name = "totalCostTextBox";
            this.totalCostTextBox.ReadOnly = true;
            this.totalCostTextBox.Size = new System.Drawing.Size(262, 31);
            this.totalCostTextBox.TabIndex = 86;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Silver;
            this.label7.Location = new System.Drawing.Point(249, 339);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 19);
            this.label7.TabIndex = 87;
            this.label7.Text = "Total Cost";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(268, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 32);
            this.label1.TabIndex = 95;
            this.label1.Text = "Total Cost";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(305, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 94;
            this.pictureBox1.TabStop = false;
            // 
            // viewReportButton
            // 
            this.viewReportButton.ActiveBorderThickness = 1;
            this.viewReportButton.ActiveCornerRadius = 20;
            this.viewReportButton.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.viewReportButton.ActiveForecolor = System.Drawing.Color.White;
            this.viewReportButton.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.viewReportButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.viewReportButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(31)))), ((int)(((byte)(40)))));
            this.viewReportButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("viewReportButton.BackgroundImage")));
            this.viewReportButton.ButtonText = "View Report";
            this.viewReportButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewReportButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewReportButton.ForeColor = System.Drawing.Color.Gold;
            this.viewReportButton.IdleBorderThickness = 1;
            this.viewReportButton.IdleCornerRadius = 20;
            this.viewReportButton.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.viewReportButton.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.viewReportButton.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.viewReportButton.Location = new System.Drawing.Point(253, 473);
            this.viewReportButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.viewReportButton.Name = "viewReportButton";
            this.viewReportButton.Size = new System.Drawing.Size(262, 52);
            this.viewReportButton.TabIndex = 126;
            this.viewReportButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.viewReportButton.Click += new System.EventHandler(this.viewReportButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Image = ((System.Drawing.Image)(resources.GetObject("BackButton.Image")));
            this.BackButton.Location = new System.Drawing.Point(96, 75);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 39);
            this.BackButton.TabIndex = 127;
            this.BackButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.ActiveBorderThickness = 1;
            this.searchButton.ActiveCornerRadius = 20;
            this.searchButton.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.searchButton.ActiveForecolor = System.Drawing.Color.White;
            this.searchButton.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.searchButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(31)))), ((int)(((byte)(40)))));
            this.searchButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchButton.BackgroundImage")));
            this.searchButton.ButtonText = "Search";
            this.searchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.ForeColor = System.Drawing.Color.Olive;
            this.searchButton.IdleBorderThickness = 1;
            this.searchButton.IdleCornerRadius = 20;
            this.searchButton.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.searchButton.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.searchButton.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.searchButton.Location = new System.Drawing.Point(597, 236);
            this.searchButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(84, 48);
            this.searchButton.TabIndex = 161;
            this.searchButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // TotalCostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(31)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(790, 655);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.viewReportButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toDateTime);
            this.Controls.Add(this.fromDateTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.totalCostTextBox);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TotalCostForm";
            this.Text = "TotalCostForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroDateTime toDateTime;
        private MetroFramework.Controls.MetroDateTime fromDateTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuThinButton2 OkButton;
        private System.Windows.Forms.TextBox totalCostTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 viewReportButton;
        private System.Windows.Forms.Button BackButton;
        private Bunifu.Framework.UI.BunifuThinButton2 searchButton;
    }
}