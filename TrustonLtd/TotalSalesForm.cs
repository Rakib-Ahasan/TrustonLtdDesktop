using System;
using System.Linq;
using System.Windows.Forms;

namespace TrustonLtd
{
    public partial class TotalSalesForm : Form
    {
        TrustonEntities db = new TrustonEntities();
        public TotalSalesForm(Panel containerPanel)
        {
            ContainerPanel = containerPanel;
            InitializeComponent();
            
        }
        private void viewReportButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TotalSalesReportForm());
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

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            totalSalesTextBox.Text =
                (db.Sales.Where(m =>
                         db.Sales.Any(ss => m.DateTime >= fromDateTime.Value && m.DateTime <= toDateTime.Value))
                     .Sum(m => (int?)m.TotalBill) ?? 0).ToString();
        }
    }
}
