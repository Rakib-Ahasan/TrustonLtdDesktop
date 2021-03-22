using System;
using System.Linq;
using System.Windows.Forms;

namespace TrustonLtd
{
    public partial class TotalCostForm : Form
    {
        TrustonEntities db = new TrustonEntities();
        public TotalCostForm(Panel containerPanel)
        {
            ContainerPanel = containerPanel;
            InitializeComponent();
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

        private void viewReportButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TotalCostReportForm());
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            var totalCost =
                db.Costs.Where(s => db.Costs.Any(ss => s.Date >= fromDateTime.Value && s.Date <= toDateTime.Value)).Sum(
                    m => (int?)m.CostAmount
                ) ?? 0;
            totalCostTextBox.Text = totalCost.ToString();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
