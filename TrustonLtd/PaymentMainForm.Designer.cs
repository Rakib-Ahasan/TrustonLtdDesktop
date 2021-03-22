namespace TrustonLtd
{
    partial class PaymentMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentMainForm));
            this.workerPaymentTile = new MetroFramework.Controls.MetroTile();
            this.customerPaymentTile = new MetroFramework.Controls.MetroTile();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BackButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // workerPaymentTile
            // 
            this.workerPaymentTile.ActiveControl = null;
            this.workerPaymentTile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.workerPaymentTile.Location = new System.Drawing.Point(160, 197);
            this.workerPaymentTile.Name = "workerPaymentTile";
            this.workerPaymentTile.Size = new System.Drawing.Size(394, 150);
            this.workerPaymentTile.TabIndex = 5;
            this.workerPaymentTile.Text = "Worker Payment";
            this.workerPaymentTile.TileImage = ((System.Drawing.Image)(resources.GetObject("workerPaymentTile.TileImage")));
            this.workerPaymentTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.workerPaymentTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.workerPaymentTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.workerPaymentTile.UseSelectable = true;
            this.workerPaymentTile.UseTileImage = true;
            this.workerPaymentTile.Click += new System.EventHandler(this.workerPaymentTile_Click);
            // 
            // customerPaymentTile
            // 
            this.customerPaymentTile.ActiveControl = null;
            this.customerPaymentTile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customerPaymentTile.Location = new System.Drawing.Point(160, 369);
            this.customerPaymentTile.Name = "customerPaymentTile";
            this.customerPaymentTile.Size = new System.Drawing.Size(394, 150);
            this.customerPaymentTile.TabIndex = 5;
            this.customerPaymentTile.Text = "Customer Payment";
            this.customerPaymentTile.TileImage = ((System.Drawing.Image)(resources.GetObject("customerPaymentTile.TileImage")));
            this.customerPaymentTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.customerPaymentTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.customerPaymentTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.customerPaymentTile.UseSelectable = true;
            this.customerPaymentTile.UseTileImage = true;
            this.customerPaymentTile.Click += new System.EventHandler(this.customerPaymentTile_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(230, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Main Payment";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(300, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // BackButton
            // 
            this.BackButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Image = ((System.Drawing.Image)(resources.GetObject("BackButton.Image")));
            this.BackButton.Location = new System.Drawing.Point(67, 96);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 39);
            this.BackButton.TabIndex = 80;
            this.BackButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // PaymentMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(31)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(774, 616);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.customerPaymentTile);
            this.Controls.Add(this.workerPaymentTile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PaymentMainForm";
            this.Text = "PaymentMainForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile workerPaymentTile;
        private MetroFramework.Controls.MetroTile customerPaymentTile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BackButton;
    }
}