namespace TrustonLtd
{
    partial class CustomerPaymentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerPaymentForm));
            this.DateTimePicker = new MetroFramework.Controls.MetroDateTime();
            this.previousDueTextBox = new System.Windows.Forms.TextBox();
            this.dueTextBox = new System.Windows.Forms.TextBox();
            this.confirmPaymentTextBox = new System.Windows.Forms.TextBox();
            this.paymentTextBox = new System.Windows.Forms.TextBox();
            this.P = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.refContactTextBox = new System.Windows.Forms.TextBox();
            this.referenceNameTextBox = new System.Windows.Forms.TextBox();
            this.contactTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.customerNameComboBox = new MetroFramework.Controls.MetroComboBox();
            this.ResetButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SaveButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DateTimePicker.CalendarFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimePicker.CalendarForeColor = System.Drawing.SystemColors.Info;
            this.DateTimePicker.CalendarTitleForeColor = System.Drawing.SystemColors.Info;
            this.DateTimePicker.CalendarTrailingForeColor = System.Drawing.SystemColors.Info;
            this.DateTimePicker.FontWeight = MetroFramework.MetroDateTimeWeight.Bold;
            this.DateTimePicker.Location = new System.Drawing.Point(424, 201);
            this.DateTimePicker.MinimumSize = new System.Drawing.Size(0, 29);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(262, 29);
            this.DateTimePicker.TabIndex = 78;
            this.DateTimePicker.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // previousDueTextBox
            // 
            this.previousDueTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.previousDueTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(31)))), ((int)(((byte)(40)))));
            this.previousDueTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.previousDueTextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previousDueTextBox.ForeColor = System.Drawing.Color.Lime;
            this.previousDueTextBox.Location = new System.Drawing.Point(83, 587);
            this.previousDueTextBox.Name = "previousDueTextBox";
            this.previousDueTextBox.ReadOnly = true;
            this.previousDueTextBox.Size = new System.Drawing.Size(262, 31);
            this.previousDueTextBox.TabIndex = 77;
            // 
            // dueTextBox
            // 
            this.dueTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dueTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(31)))), ((int)(((byte)(40)))));
            this.dueTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dueTextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dueTextBox.ForeColor = System.Drawing.Color.Lime;
            this.dueTextBox.Location = new System.Drawing.Point(424, 432);
            this.dueTextBox.MaxLength = 3;
            this.dueTextBox.Name = "dueTextBox";
            this.dueTextBox.ReadOnly = true;
            this.dueTextBox.Size = new System.Drawing.Size(262, 31);
            this.dueTextBox.TabIndex = 60;
            // 
            // confirmPaymentTextBox
            // 
            this.confirmPaymentTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.confirmPaymentTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(31)))), ((int)(((byte)(40)))));
            this.confirmPaymentTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPaymentTextBox.ForeColor = System.Drawing.SystemColors.Info;
            this.confirmPaymentTextBox.Location = new System.Drawing.Point(424, 353);
            this.confirmPaymentTextBox.MaxLength = 3;
            this.confirmPaymentTextBox.Name = "confirmPaymentTextBox";
            this.confirmPaymentTextBox.Size = new System.Drawing.Size(262, 27);
            this.confirmPaymentTextBox.TabIndex = 2;
            this.confirmPaymentTextBox.TextChanged += new System.EventHandler(this.confirmPaymentTextBox_TextChanged);
            this.confirmPaymentTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.confirmPaymentTextBox_KeyPress);
            this.confirmPaymentTextBox.Leave += new System.EventHandler(this.confirmPaymentTextBox_Leave);
            // 
            // paymentTextBox
            // 
            this.paymentTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.paymentTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(31)))), ((int)(((byte)(40)))));
            this.paymentTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentTextBox.ForeColor = System.Drawing.SystemColors.Info;
            this.paymentTextBox.Location = new System.Drawing.Point(424, 276);
            this.paymentTextBox.Name = "paymentTextBox";
            this.paymentTextBox.Size = new System.Drawing.Size(262, 27);
            this.paymentTextBox.TabIndex = 1;
            this.paymentTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.paymentTextBox_KeyPress);
            this.paymentTextBox.Leave += new System.EventHandler(this.paymentTextBox_Leave);
            // 
            // P
            // 
            this.P.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.P.AutoSize = true;
            this.P.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P.ForeColor = System.Drawing.Color.Silver;
            this.P.Location = new System.Drawing.Point(79, 551);
            this.P.Name = "P";
            this.P.Size = new System.Drawing.Size(107, 19);
            this.P.TabIndex = 73;
            this.P.Text = "Previous Due";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Silver;
            this.label7.Location = new System.Drawing.Point(420, 396);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 19);
            this.label7.TabIndex = 72;
            this.label7.Text = "Due";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Silver;
            this.label8.Location = new System.Drawing.Point(420, 318);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 19);
            this.label8.TabIndex = 74;
            this.label8.Text = "Confirm Payment";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Silver;
            this.label9.Location = new System.Drawing.Point(420, 240);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 19);
            this.label9.TabIndex = 75;
            this.label9.Text = "Payment";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Silver;
            this.label10.Location = new System.Drawing.Point(420, 163);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 19);
            this.label10.TabIndex = 76;
            this.label10.Text = "Date Time";
            // 
            // refContactTextBox
            // 
            this.refContactTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.refContactTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(31)))), ((int)(((byte)(40)))));
            this.refContactTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.refContactTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refContactTextBox.ForeColor = System.Drawing.SystemColors.Info;
            this.refContactTextBox.Location = new System.Drawing.Point(83, 509);
            this.refContactTextBox.Name = "refContactTextBox";
            this.refContactTextBox.ReadOnly = true;
            this.refContactTextBox.Size = new System.Drawing.Size(262, 27);
            this.refContactTextBox.TabIndex = 70;
            // 
            // referenceNameTextBox
            // 
            this.referenceNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.referenceNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(31)))), ((int)(((byte)(40)))));
            this.referenceNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.referenceNameTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.referenceNameTextBox.ForeColor = System.Drawing.SystemColors.Info;
            this.referenceNameTextBox.Location = new System.Drawing.Point(83, 431);
            this.referenceNameTextBox.Name = "referenceNameTextBox";
            this.referenceNameTextBox.ReadOnly = true;
            this.referenceNameTextBox.Size = new System.Drawing.Size(262, 27);
            this.referenceNameTextBox.TabIndex = 68;
            // 
            // contactTextBox
            // 
            this.contactTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.contactTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(31)))), ((int)(((byte)(40)))));
            this.contactTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contactTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactTextBox.ForeColor = System.Drawing.SystemColors.Info;
            this.contactTextBox.Location = new System.Drawing.Point(83, 354);
            this.contactTextBox.Name = "contactTextBox";
            this.contactTextBox.ReadOnly = true;
            this.contactTextBox.Size = new System.Drawing.Size(262, 27);
            this.contactTextBox.TabIndex = 69;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addressTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(31)))), ((int)(((byte)(40)))));
            this.addressTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addressTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressTextBox.ForeColor = System.Drawing.SystemColors.Info;
            this.addressTextBox.Location = new System.Drawing.Point(83, 278);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.ReadOnly = true;
            this.addressTextBox.Size = new System.Drawing.Size(262, 27);
            this.addressTextBox.TabIndex = 71;
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
            this.customerNameComboBox.Location = new System.Drawing.Point(83, 201);
            this.customerNameComboBox.Name = "customerNameComboBox";
            this.customerNameComboBox.Size = new System.Drawing.Size(262, 29);
            this.customerNameComboBox.TabIndex = 0;
            this.customerNameComboBox.UseCustomBackColor = true;
            this.customerNameComboBox.UseCustomForeColor = true;
            this.customerNameComboBox.UseSelectable = true;
            this.customerNameComboBox.SelectedIndexChanged += new System.EventHandler(this.customerNameComboBox_SelectedIndexChanged);
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
            this.ResetButton.Location = new System.Drawing.Point(424, 509);
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
            this.SaveButton.Location = new System.Drawing.Point(582, 509);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(130, 46);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(79, 473);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 19);
            this.label6.TabIndex = 63;
            this.label6.Text = "Reference Contact";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(79, 396);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 19);
            this.label5.TabIndex = 64;
            this.label5.Text = "Reference Name";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(79, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 19);
            this.label4.TabIndex = 65;
            this.label4.Text = "Contact";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(79, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 19);
            this.label3.TabIndex = 66;
            this.label3.Text = "Address";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(79, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 19);
            this.label2.TabIndex = 67;
            this.label2.Text = "Customer Name";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(226, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 32);
            this.label1.TabIndex = 58;
            this.label1.Text = "Customer Payment";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(325, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            // 
            // BackButton
            // 
            this.BackButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Image = ((System.Drawing.Image)(resources.GetObject("BackButton.Image")));
            this.BackButton.Location = new System.Drawing.Point(35, 101);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 39);
            this.BackButton.TabIndex = 79;
            this.BackButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // CustomerPaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(31)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(790, 655);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.DateTimePicker);
            this.Controls.Add(this.previousDueTextBox);
            this.Controls.Add(this.dueTextBox);
            this.Controls.Add(this.confirmPaymentTextBox);
            this.Controls.Add(this.paymentTextBox);
            this.Controls.Add(this.P);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.refContactTextBox);
            this.Controls.Add(this.referenceNameTextBox);
            this.Controls.Add(this.contactTextBox);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.customerNameComboBox);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerPaymentForm";
            this.Text = "CustomerPaymentForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroDateTime DateTimePicker;
        private System.Windows.Forms.TextBox previousDueTextBox;
        private System.Windows.Forms.TextBox dueTextBox;
        private System.Windows.Forms.TextBox confirmPaymentTextBox;
        private System.Windows.Forms.TextBox paymentTextBox;
        private System.Windows.Forms.Label P;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox refContactTextBox;
        private System.Windows.Forms.TextBox referenceNameTextBox;
        private System.Windows.Forms.TextBox contactTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private MetroFramework.Controls.MetroComboBox customerNameComboBox;
        private Bunifu.Framework.UI.BunifuThinButton2 ResetButton;
        private Bunifu.Framework.UI.BunifuThinButton2 SaveButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}