using System;
using System.Windows.Forms;

namespace TrustonLtd
{
    public partial class BusinessStatusForm : Form
    {
        public BusinessStatusForm(Panel containerPanel)
        {
            ContainerPanel = containerPanel;
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void totalCostTile_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TotalCostForm(ContainerPanel));
        }

        private Panel ContainerPanel;

        private Form _activeForm;

        private void OpenChildForm(Form childForm)
        {
            if (_activeForm != null)
                _activeForm.Close();
            _activeForm = childForm;
            _activeForm.TopLevel = false;
            _activeForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            ContainerPanel.Controls.Add(childForm);
            ContainerPanel.Tag = childForm;

            //childForm.Visible = true;
            childForm.BringToFront();
            childForm.Show();
        }

        private void totalSalesTile_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TotalSalesForm(ContainerPanel));
        }

        private void totalBuyTile_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TotalBuyEmbroideryOrnaOrThreePieceForm(ContainerPanel));
        }

        private void totalStockInTile_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TotalStockInReportForm());
        }

        private void totalBuyPrideOrYearnTile_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TotalBuyPrideOrYearnForm(ContainerPanel));
        }
    }
}
