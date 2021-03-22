using System;
using System.Linq;
using System.Windows.Forms;

namespace TrustonLtd
{
    public partial class StockStatusForm : Form
    {
        TrustonEntities db = new TrustonEntities();
        public StockStatusForm()
        {
            InitializeComponent();
            LoadData();
        }

        //Methods
        private void LoadData()
        {
            typeOfProductComboBox.DataSource = db.StockIns.Select(m => m.Product.TypeOfProduct).Distinct().ToList();
        }
        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void typeOfProductComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (typeOfProductComboBox.SelectedItem == null ||
                    (string)typeOfProductComboBox.SelectedItem == "---Select Type of Product---")
                {
                    typeOfProductComboBox.Focus();
                }
                else
                {
                    var productData = db.Products.Where(model =>
                        model.TypeOfProduct == typeOfProductComboBox.SelectedItem.ToString());
                    productNameComboBox.Items.Clear();
                    rateTextBox.Clear();
                    pieceTextBox.Clear();
                    totalStockOutTextBox.Clear();
                    totalPendingTextBox.Clear();
                    totalStoredRemainTextBox.Clear();
                    foreach (var item in productData)
                    {
                        productNameComboBox.Items.Add(item.ProductName);


                    }
                }
            }
            catch (Exception)
            {
                //ignored
            }
        }

        private void productNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                rateTextBox.Clear();
                pieceTextBox.Clear();
                totalStockOutTextBox.Clear();
                totalPendingTextBox.Clear();
                totalStoredRemainTextBox.Clear();
                if (productNameComboBox.SelectedItem != null)
                {
                    var product = db.StockIns.Where(model =>
                        model.Product.ProductName == productNameComboBox.SelectedItem.ToString());

                    //var totalDistributed = db.Distributions.Where(m => m.Product.ProductName == (string)productNameComboBox.SelectedItem).Sum(m => (int?)m.Piece) ?? 0 + db.Collections.Where(m => m.Product.ProductName == (string)productNameComboBox.SelectedItem).Sum(m => (int?)m.Return) ?? 0;
                    var totalStockIn = db.StockIns.Where(m => m.Product.ProductName == (string)productNameComboBox.SelectedItem).Sum(m => (int?)m.Piece) ?? 0;

                    var totalStockOut = db.Sales.Where(m => m.Product.ProductName == (string)productNameComboBox.SelectedItem).Sum(m => (int?)m.Piece) ?? 0 - db.Sales.Where(m => m.Product.ProductName == (string)productNameComboBox.SelectedItem).Sum(m => (int?)m.ReturnPiece) ?? 0;

                    //var totalPending = totalDistributed - db.Collections.Where(m => m.Product.ProductName == (string)productNameComboBox.SelectedItem).Sum(m => (int?)m.Piece) ?? 0;
                    var totalPending = totalStockIn - totalStockOut;

                    var totalStoredRemain = totalStockIn - (totalStockOut + totalPending);
                    foreach (var item in product)
                    {
                        rateTextBox.Text = item.Product.RateOfAmount.ToString();
                        pieceTextBox.Text = totalStockIn.ToString();
                        totalStockOutTextBox.Text = totalStockOut.ToString();
                        totalPendingTextBox.Text = totalPending.ToString();
                        totalStoredRemainTextBox.Text = totalStoredRemain.ToString();
                    }
                }
            }
            catch (Exception)
            {
                //ignored
            }
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
