namespace TrustonLtd
{
    partial class StatusForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatusForm));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.BusinessStatusTile = new MetroFramework.Controls.MetroTile();
            this.workerStatusTile = new MetroFramework.Controls.MetroTile();
            this.stockStatusTile = new MetroFramework.Controls.MetroTile();
            this.customerStatusTile = new MetroFramework.Controls.MetroTile();
            this.workerListTile = new MetroFramework.Controls.MetroTile();
            this.damageTile = new MetroFramework.Controls.MetroTile();
            this.customerListTile = new MetroFramework.Controls.MetroTile();
            this.BackButton = new System.Windows.Forms.Button();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(0, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(113, 25);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Status Form";
            // 
            // BusinessStatusTile
            // 
            this.BusinessStatusTile.ActiveControl = null;
            this.BusinessStatusTile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BusinessStatusTile.Location = new System.Drawing.Point(119, 104);
            this.BusinessStatusTile.Name = "BusinessStatusTile";
            this.BusinessStatusTile.Size = new System.Drawing.Size(280, 150);
            this.BusinessStatusTile.Style = MetroFramework.MetroColorStyle.Teal;
            this.BusinessStatusTile.TabIndex = 1;
            this.BusinessStatusTile.Text = "Business Status";
            this.BusinessStatusTile.TileImage = ((System.Drawing.Image)(resources.GetObject("BusinessStatusTile.TileImage")));
            this.BusinessStatusTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BusinessStatusTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.BusinessStatusTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.BusinessStatusTile.UseSelectable = true;
            this.BusinessStatusTile.UseTileImage = true;
            this.BusinessStatusTile.Click += new System.EventHandler(this.BusinessStatusTile_Click);
            // 
            // workerStatusTile
            // 
            this.workerStatusTile.ActiveControl = null;
            this.workerStatusTile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.workerStatusTile.Location = new System.Drawing.Point(119, 272);
            this.workerStatusTile.Name = "workerStatusTile";
            this.workerStatusTile.Size = new System.Drawing.Size(190, 150);
            this.workerStatusTile.Style = MetroFramework.MetroColorStyle.Green;
            this.workerStatusTile.TabIndex = 2;
            this.workerStatusTile.Text = "Worker Status";
            this.workerStatusTile.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.workerStatusTile.TileImage = ((System.Drawing.Image)(resources.GetObject("workerStatusTile.TileImage")));
            this.workerStatusTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.workerStatusTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.workerStatusTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.workerStatusTile.UseSelectable = true;
            this.workerStatusTile.UseTileImage = true;
            this.workerStatusTile.Click += new System.EventHandler(this.workerStatusTile_Click);
            // 
            // stockStatusTile
            // 
            this.stockStatusTile.ActiveControl = null;
            this.stockStatusTile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.stockStatusTile.Location = new System.Drawing.Point(424, 104);
            this.stockStatusTile.Name = "stockStatusTile";
            this.stockStatusTile.Size = new System.Drawing.Size(190, 150);
            this.stockStatusTile.Style = MetroFramework.MetroColorStyle.Brown;
            this.stockStatusTile.TabIndex = 3;
            this.stockStatusTile.Text = "Stock Status";
            this.stockStatusTile.TileImage = ((System.Drawing.Image)(resources.GetObject("stockStatusTile.TileImage")));
            this.stockStatusTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.stockStatusTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.stockStatusTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.stockStatusTile.UseSelectable = true;
            this.stockStatusTile.UseTileImage = true;
            this.stockStatusTile.Click += new System.EventHandler(this.stockStatusTile_Click);
            // 
            // customerStatusTile
            // 
            this.customerStatusTile.ActiveControl = null;
            this.customerStatusTile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customerStatusTile.Location = new System.Drawing.Point(334, 272);
            this.customerStatusTile.Name = "customerStatusTile";
            this.customerStatusTile.Size = new System.Drawing.Size(280, 150);
            this.customerStatusTile.Style = MetroFramework.MetroColorStyle.Lime;
            this.customerStatusTile.TabIndex = 4;
            this.customerStatusTile.Text = "Customer Status";
            this.customerStatusTile.TileImage = ((System.Drawing.Image)(resources.GetObject("customerStatusTile.TileImage")));
            this.customerStatusTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.customerStatusTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.customerStatusTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.customerStatusTile.UseSelectable = true;
            this.customerStatusTile.UseTileImage = true;
            this.customerStatusTile.Click += new System.EventHandler(this.customerStatusTile_Click);
            // 
            // workerListTile
            // 
            this.workerListTile.ActiveControl = null;
            this.workerListTile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.workerListTile.Location = new System.Drawing.Point(119, 441);
            this.workerListTile.Name = "workerListTile";
            this.workerListTile.Size = new System.Drawing.Size(150, 150);
            this.workerListTile.Style = MetroFramework.MetroColorStyle.Green;
            this.workerListTile.TabIndex = 3;
            this.workerListTile.Text = "Worker List";
            this.workerListTile.TileImage = ((System.Drawing.Image)(resources.GetObject("workerListTile.TileImage")));
            this.workerListTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.workerListTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.workerListTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.workerListTile.UseSelectable = true;
            this.workerListTile.UseTileImage = true;
            this.workerListTile.Click += new System.EventHandler(this.workerListTile_Click);
            // 
            // damageTile
            // 
            this.damageTile.ActiveControl = null;
            this.damageTile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.damageTile.BackColor = System.Drawing.Color.DarkRed;
            this.damageTile.Location = new System.Drawing.Point(464, 441);
            this.damageTile.Name = "damageTile";
            this.damageTile.Size = new System.Drawing.Size(150, 150);
            this.damageTile.TabIndex = 3;
            this.damageTile.Text = "Damages";
            this.damageTile.TileImage = ((System.Drawing.Image)(resources.GetObject("damageTile.TileImage")));
            this.damageTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.damageTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.damageTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.damageTile.UseCustomBackColor = true;
            this.damageTile.UseSelectable = true;
            this.damageTile.UseTileImage = true;
            // 
            // customerListTile
            // 
            this.customerListTile.ActiveControl = null;
            this.customerListTile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customerListTile.Location = new System.Drawing.Point(291, 441);
            this.customerListTile.Name = "customerListTile";
            this.customerListTile.Size = new System.Drawing.Size(150, 150);
            this.customerListTile.Style = MetroFramework.MetroColorStyle.Lime;
            this.customerListTile.TabIndex = 3;
            this.customerListTile.Text = "Customer List";
            this.customerListTile.TileImage = ((System.Drawing.Image)(resources.GetObject("customerListTile.TileImage")));
            this.customerListTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.customerListTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.customerListTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.customerListTile.UseSelectable = true;
            this.customerListTile.UseTileImage = true;
            this.customerListTile.Click += new System.EventHandler(this.customerListTile_Click);
            // 
            // BackButton
            // 
            this.BackButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Image = ((System.Drawing.Image)(resources.GetObject("BackButton.Image")));
            this.BackButton.Location = new System.Drawing.Point(-1, 67);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 39);
            this.BackButton.TabIndex = 82;
            this.BackButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroTile1.Location = new System.Drawing.Point(637, 104);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(190, 487);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTile1.TabIndex = 83;
            this.metroTile1.Text = "Remainder";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile1.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile1.TileImage")));
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseTileImage = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // StatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(31)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(939, 655);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.customerStatusTile);
            this.Controls.Add(this.damageTile);
            this.Controls.Add(this.customerListTile);
            this.Controls.Add(this.workerListTile);
            this.Controls.Add(this.stockStatusTile);
            this.Controls.Add(this.workerStatusTile);
            this.Controls.Add(this.BusinessStatusTile);
            this.Controls.Add(this.metroLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StatusForm";
            this.Text = "StatusForm";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTile BusinessStatusTile;
        private MetroFramework.Controls.MetroTile workerStatusTile;
        private MetroFramework.Controls.MetroTile stockStatusTile;
        private MetroFramework.Controls.MetroTile customerStatusTile;
        private MetroFramework.Controls.MetroTile workerListTile;
        private MetroFramework.Controls.MetroTile damageTile;
        private MetroFramework.Controls.MetroTile customerListTile;
        private System.Windows.Forms.Button BackButton;
        private MetroFramework.Controls.MetroTile metroTile1;
    }
}