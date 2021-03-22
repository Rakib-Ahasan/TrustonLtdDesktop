using System;
using System.Linq;
using System.Windows.Forms;

namespace TrustonLtd
{
    public partial class TotalBuyPrideOrYearnForm : Form
    {
        TrustonEntities db = new TrustonEntities();
        public TotalBuyPrideOrYearnForm(Panel containerPanel)
        {
            _containerPanel = containerPanel;
            InitializeComponent();
            LoadData();
        }

        //Methods
        private void LoadData()
        {
            //typeOfProductComboBox.Items.Clear();
            typeOfProductComboBox.DataSource = db.BuyPrideOrYearns.Select(m => m.TypeOfProduct).Distinct().ToList();
        }
        private Panel _containerPanel;

        private Form _activeForm;

        private void OpenChildForm(Form childForm)
        {
            if (_activeForm != null)
                _activeForm.Close();
            _activeForm = childForm;
            _activeForm.TopLevel = false;
            _activeForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            _containerPanel.Controls.Add(childForm);
            _containerPanel.Tag = childForm;

            //childForm.Visible = true;
            childForm.BringToFront();
            childForm.Show();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void viewReportButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TotalBuyPrideOrYearnReportForm());
        }

        private void typeOfProductComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(typeOfProductComboBox.Text))
            {
                int totalAmount = db.BuyPrideOrYearns.Where(s => db.BuyPrideOrYearns.Any(ss => s.Date >= DateTimeFrom.Value && s.Date <= dateTimeTo.Value) && s.TypeOfProduct == (string)typeOfProductComboBox.SelectedItem).Sum(m => (int?)m.TotalAmount) ?? 0;
                totalAmountTextBox.Text = totalAmount.ToString();
            }
        }
    }
}
