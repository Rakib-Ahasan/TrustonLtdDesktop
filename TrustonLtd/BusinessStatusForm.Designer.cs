namespace TrustonLtd
{
    partial class BusinessStatusForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BusinessStatusForm));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.totalStockInTile = new MetroFramework.Controls.MetroTile();
            this.totalSalesTile = new MetroFramework.Controls.MetroTile();
            this.totalCostTile = new MetroFramework.Controls.MetroTile();
            this.totalBuyTile = new MetroFramework.Controls.MetroTile();
            this.totalBuyPrideOrYearnTile = new MetroFramework.Controls.MetroTile();
            this.BackButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(308, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Business Status";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(374, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // totalStockInTile
            // 
            this.totalStockInTile.ActiveControl = null;
            this.totalStockInTile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.totalStockInTile.Location = new System.Drawing.Point(36, 170);
            this.totalStockInTile.Name = "totalStockInTile";
            this.totalStockInTile.Size = new System.Drawing.Size(220, 150);
            this.totalStockInTile.TabIndex = 4;
            this.totalStockInTile.Text = "Total Stock In";
            this.totalStockInTile.TileImage = ((System.Drawing.Image)(resources.GetObject("totalStockInTile.TileImage")));
            this.totalStockInTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.totalStockInTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.totalStockInTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.totalStockInTile.UseSelectable = true;
            this.totalStockInTile.UseTileImage = true;
            this.totalStockInTile.Click += new System.EventHandler(this.totalStockInTile_Click);
            // 
            // totalSalesTile
            // 
            this.totalSalesTile.ActiveControl = null;
            this.totalSalesTile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.totalSalesTile.Location = new System.Drawing.Point(616, 170);
            this.totalSalesTile.Name = "totalSalesTile";
            this.totalSalesTile.Size = new System.Drawing.Size(220, 328);
            this.totalSalesTile.Style = MetroFramework.MetroColorStyle.Brown;
            this.totalSalesTile.TabIndex = 4;
            this.totalSalesTile.Text = "Total Sales";
            this.totalSalesTile.TileImage = ((System.Drawing.Image)(resources.GetObject("totalSalesTile.TileImage")));
            this.totalSalesTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.totalSalesTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.totalSalesTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.totalSalesTile.UseSelectable = true;
            this.totalSalesTile.UseTileImage = true;
            this.totalSalesTile.Click += new System.EventHandler(this.totalSalesTile_Click);
            // 
            // totalCostTile
            // 
            this.totalCostTile.ActiveControl = null;
            this.totalCostTile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.totalCostTile.Location = new System.Drawing.Point(370, 348);
            this.totalCostTile.Name = "totalCostTile";
            this.totalCostTile.Size = new System.Drawing.Size(220, 150);
            this.totalCostTile.Style = MetroFramework.MetroColorStyle.Teal;
            this.totalCostTile.TabIndex = 4;
            this.totalCostTile.Text = "Total Cost";
            this.totalCostTile.TileImage = ((System.Drawing.Image)(resources.GetObject("totalCostTile.TileImage")));
            this.totalCostTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.totalCostTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.totalCostTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.totalCostTile.UseMnemonic = false;
            this.totalCostTile.UseSelectable = true;
            this.totalCostTile.UseTileImage = true;
            this.totalCostTile.Click += new System.EventHandler(this.totalCostTile_Click);
            // 
            // totalBuyTile
            // 
            this.totalBuyTile.ActiveControl = null;
            this.totalBuyTile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.totalBuyTile.Location = new System.Drawing.Point(36, 348);
            this.totalBuyTile.Name = "totalBuyTile";
            this.totalBuyTile.Size = new System.Drawing.Size(300, 150);
            this.totalBuyTile.Style = MetroFramework.MetroColorStyle.Pink;
            this.totalBuyTile.TabIndex = 4;
            this.totalBuyTile.Text = "Total Buy Embroidery Orna /Three Piece";
            this.totalBuyTile.TileImage = ((System.Drawing.Image)(resources.GetObject("totalBuyTile.TileImage")));
            this.totalBuyTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.totalBuyTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.totalBuyTile.UseMnemonic = false;
            this.totalBuyTile.UseSelectable = true;
            this.totalBuyTile.UseTileImage = true;
            this.totalBuyTile.Click += new System.EventHandler(this.totalBuyTile_Click);
            // 
            // totalBuyPrideOrYearnTile
            // 
            this.totalBuyPrideOrYearnTile.ActiveControl = null;
            this.totalBuyPrideOrYearnTile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.totalBuyPrideOrYearnTile.Location = new System.Drawing.Point(290, 170);
            this.totalBuyPrideOrYearnTile.Name = "totalBuyPrideOrYearnTile";
            this.totalBuyPrideOrYearnTile.Size = new System.Drawing.Size(300, 150);
            this.totalBuyPrideOrYearnTile.Style = MetroFramework.MetroColorStyle.Purple;
            this.totalBuyPrideOrYearnTile.TabIndex = 4;
            this.totalBuyPrideOrYearnTile.Text = "Total Buy Pride/Yearn";
            this.totalBuyPrideOrYearnTile.TileImage = ((System.Drawing.Image)(resources.GetObject("totalBuyPrideOrYearnTile.TileImage")));
            this.totalBuyPrideOrYearnTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.totalBuyPrideOrYearnTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.totalBuyPrideOrYearnTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.totalBuyPrideOrYearnTile.UseSelectable = true;
            this.totalBuyPrideOrYearnTile.UseTileImage = true;
            this.totalBuyPrideOrYearnTile.Click += new System.EventHandler(this.totalBuyPrideOrYearnTile_Click);
            // 
            // BackButton
            // 
            this.BackButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Image = ((System.Drawing.Image)(resources.GetObject("BackButton.Image")));
            this.BackButton.Location = new System.Drawing.Point(26, 76);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(64, 39);
            this.BackButton.TabIndex = 56;
            this.BackButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // BusinessStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(31)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(896, 655);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.totalSalesTile);
            this.Controls.Add(this.totalBuyPrideOrYearnTile);
            this.Controls.Add(this.totalCostTile);
            this.Controls.Add(this.totalBuyTile);
            this.Controls.Add(this.totalStockInTile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BusinessStatusForm";
            this.Text = "BusinessStatusForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTile totalStockInTile;
        private MetroFramework.Controls.MetroTile totalSalesTile;
        private MetroFramework.Controls.MetroTile totalCostTile;
        private MetroFramework.Controls.MetroTile totalBuyTile;
        private MetroFramework.Controls.MetroTile totalBuyPrideOrYearnTile;
        private System.Windows.Forms.Button BackButton;
    }
}