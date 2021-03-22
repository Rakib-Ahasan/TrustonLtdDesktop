using System;
using System.Linq;
using System.Windows.Forms;

namespace TrustonLtd
{
    public partial class TotalBuyEmbroideryOrnaOrThreePieceForm : Form
    {
        TrustonEntities db = new TrustonEntities();
        public TotalBuyEmbroideryOrnaOrThreePieceForm(Panel containerPanel)
        {
            ContainerPanel = containerPanel;
            InitializeComponent();
            LoadData();
        }

        //Methods
        private void LoadData()
        {
            typeOfProductComboBox.DataSource =
                db.BuyEmbroideryOrnaOrThreePieces.Select(m => m.Product.TypeOfProduct).Distinct().ToList();
        }
        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
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
            OpenChildForm(new TotalBuyEmbroideryOrnaOrThreePieceReportForm(DateTimeFrom.Value, dateTimeTo.Value, typeOfProductComboBox.Text, productNameComboBox.Text, Convert.ToInt32(totalAmountTextBox.Text)));
        }

        private void typeOfProductComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(typeOfProductComboBox.Text))
            {
                productNameComboBox.DataSource = db.BuyEmbroideryOrnaOrThreePieces
                    .Where(m => m.Product.TypeOfProduct == (string)typeOfProductComboBox.SelectedItem)
                    .Select(m => m.Product.ProductName).Distinct().ToList();
            }
        }

        private void productNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            rateTextBox.Clear();
            pieceTextBox.Clear();
            totalAmountTextBox.Clear();
            if (productNameComboBox.SelectedItem != null)
            {
                var product = db.StockIns.Where(model =>
                    model.Product.ProductName == productNameComboBox.SelectedItem.ToString());

                foreach (var item in product)
                {
                    rateTextBox.Text = item.Product.RateOfAmount.ToString();
                }

                pieceTextBox.Text = (db.BuyEmbroideryOrnaOrThreePieces
                                         .Where(m => m.Product.ProductName == (string)productNameComboBox.SelectedItem && db.BuyEmbroideryOrnaOrThreePieces.Any(ss => m.DateTime >= DateTimeFrom.Value && m.DateTime <= dateTimeTo.Value)).Sum(m => (int?)m.Piece) ?? 0).ToString();


                int totalAmount = db.BuyEmbroideryOrnaOrThreePieces.Where(s => db.BuyEmbroideryOrnaOrThreePieces.Any(ss => s.DateTime >= DateTimeFrom.Value && s.DateTime <= dateTimeTo.Value) && (s.Product.ProductName == (string)productNameComboBox.SelectedItem)).Sum(m => (int?)m.TotalAmount) ?? 0;
                totalAmountTextBox.Text = totalAmount.ToString();
            }

        }
    }
}
