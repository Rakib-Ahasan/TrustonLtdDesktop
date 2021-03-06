namespace TrustonLtd
{
    partial class WorkerPaymentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkerPaymentForm));
            this.DateTimePicker = new MetroFramework.Controls.MetroDateTime();
            this.payableAmountTextBox = new System.Windows.Forms.TextBox();
            this.confirmPaymentTextBox = new System.Windows.Forms.TextBox();
            this.paymentTextBox = new System.Windows.Forms.TextBox();
            this.P = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.refContactTextBox = new System.Windows.Forms.TextBox();
            this.referenceNameTextBox = new System.Windows.Forms.TextBox();
            this.contactTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.workerNameComboBox = new MetroFramework.Controls.MetroComboBox();
            this.ResetButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SaveButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.repayableTextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.BackButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
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
            this.DateTimePicker.Location = new System.Drawing.Point(422, 180);
            this.DateTimePicker.MinimumSize = new System.Drawing.Size(0, 29);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(262, 29);
            this.DateTimePicker.TabIndex = 54;
            this.DateTimePicker.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // payableAmountTextBox
            // 
            this.payableAmountTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.payableAmountTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(31)))), ((int)(((byte)(40)))));
            this.payableAmountTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.payableAmountTextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payableAmountTextBox.ForeColor = System.Drawing.Color.Lime;
            this.payableAmountTextBox.Location = new System.Drawing.Point(81, 566);
            this.payableAmountTextBox.Name = "payableAmountTextBox";
            this.payableAmountTextBox.ReadOnly = true;
            this.payableAmountTextBox.Size = new System.Drawing.Size(262, 31);
            this.payableAmountTextBox.TabIndex = 53;
            // 
            // confirmPaymentTextBox
            // 
            this.confirmPaymentTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.confirmPaymentTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(31)))), ((int)(((byte)(40)))));
            this.confirmPaymentTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPaymentTextBox.ForeColor = System.Drawing.SystemColors.Info;
            this.confirmPaymentTextBox.Location = new System.Drawing.Point(422, 332);
            this.confirmPaymentTextBox.MaxLength = 3;
            this.confirmPaymentTextBox.Name = "confirmPaymentTextBox";
            this.confirmPaymentTextBox.Size = new System.Drawing.Size(262, 27);
            this.confirmPaymentTextBox.TabIndex = 35;
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
            this.paymentTextBox.Location = new System.Drawing.Point(422, 255);
            this.paymentTextBox.Name = "paymentTextBox";
            this.paymentTextBox.Size = new System.Drawing.Size(262, 27);
            this.paymentTextBox.TabIndex = 33;
            this.paymentTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.paymentTextBox_KeyPress);
            this.paymentTextBox.Leave += new System.EventHandler(this.paymentTextBox_Leave);
            // 
            // P
            // 
            this.P.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.P.AutoSize = true;
            this.P.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P.ForeColor = System.Drawing.Color.Silver;
            this.P.Location = new System.Drawing.Point(77, 530);
            this.P.Name = "P";
            this.P.Size = new System.Drawing.Size(194, 19);
            this.P.TabIndex = 49;
            this.P.Text = "Payable Amount (Taka)";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Silver;
            this.label8.Location = new System.Drawing.Point(418, 297);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 19);
            this.label8.TabIndex = 50;
            this.label8.Text = "Confirm Payment";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Silver;
            this.label9.Location = new System.Drawing.Point(418, 219);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 19);
            this.label9.TabIndex = 51;
            this.label9.Text = "Payment";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Silver;
            this.label10.Location = new System.Drawing.Point(418, 142);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 19);
            this.label10.TabIndex = 52;
            this.label10.Text = "Date Time";
            // 
            // refContactTextBox
            // 
            this.refContactTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.refContactTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(31)))), ((int)(((byte)(40)))));
            this.refContactTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.refContactTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refContactTextBox.ForeColor = System.Drawing.SystemColors.Info;
            this.refContactTextBox.Location = new System.Drawing.Point(81, 488);
            this.refContactTextBox.Name = "refContactTextBox";
            this.refContactTextBox.ReadOnly = true;
            this.refContactTextBox.Size = new System.Drawing.Size(262, 27);
            this.refContactTextBox.TabIndex = 46;
            // 
            // referenceNameTextBox
            // 
            this.referenceNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.referenceNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(31)))), ((int)(((byte)(40)))));
            this.referenceNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.referenceNameTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.referenceNameTextBox.ForeColor = System.Drawing.SystemColors.Info;
            this.referenceNameTextBox.Location = new System.Drawing.Point(81, 410);
            this.referenceNameTextBox.Name = "referenceNameTextBox";
            this.referenceNameTextBox.ReadOnly = true;
            this.referenceNameTextBox.Size = new System.Drawing.Size(262, 27);
            this.referenceNameTextBox.TabIndex = 44;
            // 
            // contactTextBox
            // 
            this.contactTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.contactTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(31)))), ((int)(((byte)(40)))));
            this.contactTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contactTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactTextBox.ForeColor = System.Drawing.SystemColors.Info;
            this.contactTextBox.Location = new System.Drawing.Point(81, 333);
            this.contactTextBox.Name = "contactTextBox";
            this.contactTextBox.ReadOnly = true;
            this.contactTextBox.Size = new System.Drawing.Size(262, 27);
            this.contactTextBox.TabIndex = 45;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addressTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(31)))), ((int)(((byte)(40)))));
            this.addressTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addressTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressTextBox.ForeColor = System.Drawing.SystemColors.Info;
            this.addressTextBox.Location = new System.Drawing.Point(81, 257);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.ReadOnly = true;
            this.addressTextBox.Size = new System.Drawing.Size(262, 27);
            this.addressTextBox.TabIndex = 47;
            // 
            // workerNameComboBox
            // 
            this.workerNameComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.workerNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.workerNameComboBox.BackColor = System.Drawing.Color.Gray;
            this.workerNameComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.workerNameComboBox.FontWeight = MetroFramework.MetroComboBoxWeight.Bold;
            this.workerNameComboBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.workerNameComboBox.FormattingEnabled = true;
            this.workerNameComboBox.ItemHeight = 23;
            this.workerNameComboBox.Location = new System.Drawing.Point(81, 180);
            this.workerNameComboBox.Name = "workerNameComboBox";
            this.workerNameComboBox.Size = new System.Drawing.Size(262, 29);
            this.workerNameComboBox.TabIndex = 32;
            this.workerNameComboBox.UseCustomBackColor = true;
            this.workerNameComboBox.UseCustomForeColor = true;
            this.workerNameComboBox.UseSelectable = true;
            this.workerNameComboBox.SelectedIndexChanged += new System.EventHandler(this.workerNameComboBox_SelectedIndexChanged);
            this.workerNameComboBox.Leave += new System.EventHandler(this.workerNameComboBox_Leave);
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
            this.ResetButton.Location = new System.Drawing.Point(422, 488);
            this.ResetButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(130, 46);
            this.ResetButton.TabIndex = 38;
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
            this.SaveButton.Location = new System.Drawing.Point(580, 488);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(130, 46);
            this.SaveButton.TabIndex = 37;
            this.SaveButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(77, 452);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 19);
            this.label6.TabIndex = 39;
            this.label6.Text = "Reference Contact";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(77, 375);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 19);
            this.label5.TabIndex = 40;
            this.label5.Text = "Reference Name";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(77, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 19);
            this.label4.TabIndex = 41;
            this.label4.Text = "Contact";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(77, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 19);
            this.label3.TabIndex = 42;
            this.label3.Text = "Address";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(77, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 19);
            this.label2.TabIndex = 43;
            this.label2.Text = "Worker Name";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(224, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 32);
            this.label1.TabIndex = 34;
            this.label1.Text = "Worker Payment";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(309, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Silver;
            this.label7.Location = new System.Drawing.Point(418, 395);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(215, 19);
            this.label7.TabIndex = 48;
            this.label7.Text = "Repayable Amount (Taka)";
            // 
            // repayableTextBox
            // 
            this.repayableTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.repayableTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(31)))), ((int)(((byte)(40)))));
            this.repayableTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.repayableTextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repayableTextBox.ForeColor = System.Drawing.Color.Lime;
            this.repayableTextBox.Location = new System.Drawing.Point(422, 431);
            this.repayableTextBox.MaxLength = 3;
            this.repayableTextBox.Name = "repayableTextBox";
            this.repayableTextBox.ReadOnly = true;
            this.repayableTextBox.Size = new System.Drawing.Size(262, 31);
            this.repayableTextBox.TabIndex = 36;
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
            this.BackButton.Location = new System.Drawing.Point(-2, 80);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(64, 39);
            this.BackButton.TabIndex = 55;
            this.BackButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // WorkerPaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(31)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(790, 655);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.DateTimePicker);
            this.Controls.Add(this.payableAmountTextBox);
            this.Controls.Add(this.repayableTextBox);
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
            this.Controls.Add(this.workerNameComboBox);
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
            this.Name = "WorkerPaymentForm";
            this.Text = "WorkerPaymentForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroDateTime DateTimePicker;
        private System.Windows.Forms.TextBox payableAmountTextBox;
        private System.Windows.Forms.TextBox confirmPaymentTextBox;
        private System.Windows.Forms.TextBox paymentTextBox;
        private System.Windows.Forms.Label P;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox refContactTextBox;
        private System.Windows.Forms.TextBox referenceNameTextBox;
        private System.Windows.Forms.TextBox contactTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private MetroFramework.Controls.MetroComboBox workerNameComboBox;
        private Bunifu.Framework.UI.BunifuThinButton2 ResetButton;
        private Bunifu.Framework.UI.BunifuThinButton2 SaveButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox repayableTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.Button BackButton;
    }
}