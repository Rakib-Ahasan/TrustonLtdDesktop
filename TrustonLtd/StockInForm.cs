using System;
using System.Linq;
using System.Windows.Forms;
using TrustonLtd.Models;

namespace TrustonLtd
{
    public partial class StockInForm : Form
    {
        TrustonEntities db = new TrustonEntities();

        public StockInForm()
        {
            InitializeComponent();
            LoadData();
        }


        //TextBox leave Events...

        private void typeOfProductComboBox_Leave(object sender, EventArgs e)
        {

            if (typeOfProductComboBox.SelectedItem == null || (string)typeOfProductComboBox.SelectedItem == "---Select Type Of Product---")
            {
                errorProvider1.SetError(this.typeOfProductComboBox, "Please select an item for type of product!");
                typeOfProductComboBox.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void productNameComboBox_Leave(object sender, EventArgs e)
        {

            if (productNameComboBox.SelectedItem == null || (string)productNameComboBox.SelectedItem == "---Select Product Name---")
            {
                errorProvider2.SetError(this.productNameComboBox, "Please select an item for product name!");
                productNameComboBox.Focus();
            }
            else
            {
                errorProvider2.Clear();
            }
        }

        private void pieceTextBox_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(pieceTextBox.Text))
            {
                errorProvider3.SetError(this.pieceTextBox, "Please enter piece amount!");
                pieceTextBox.Focus();
            }
            else
            {
                errorProvider3.Clear();
            }
        }


        //TextBox Selected Changed Events...

        private void typeOfProductComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (typeOfProductComboBox.SelectedItem != null)
            {
                var productData = db.Products.Where(model =>
                    model.TypeOfProduct == typeOfProductComboBox.SelectedItem.ToString());
                productNameComboBox.Items.Clear();
                foreach (var item in productData)
                {
                    productNameComboBox.Items.Add(item.ProductName);
                }
            }
        }

        private void productNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (productNameComboBox.SelectedItem != null)
            {
                var productRate = db.Products.Where(model =>
                    model.ProductName == productNameComboBox.SelectedItem.ToString());
                foreach (var item in productRate)
                {
                    rateTextBox.Text = item.RateOfAmount.ToString();
                }
            }
        }

        //TextBox KeyPress Events...
        private void pieceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsDigit(ch))
            {
                e.Handled = false;
            }
            else if (ch == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        //Buttons operations
        private void ResetButton_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                StockIn stockIn = new StockIn();
                stockIn.Date = DateTime.Now;
                var productId = db.Products.FirstOrDefault(model => (string)productNameComboBox.SelectedItem == model.ProductName);
                if (productId != null) stockIn.ProductId = productId.ProductId;
                stockIn.Piece = Convert.ToInt32(pieceTextBox.Text);

                db.StockIns.Add(stockIn);
                int a = db.SaveChanges();

                if (a > 0)
                {
                    MessageBox.Show(@"StockIn record save successfully.", @"Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                    Clear();
                }
                else
                {
                    MessageBox.Show(@"StockIn record save failed.", @"Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show(@"Some information is missing please check again!", @"Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Methods...
        private void LoadData()
        {
            //var productData = db.Products.Distinct().ToList();
            var productData = db.Products.Select(model => model.TypeOfProduct).Distinct();
            typeOfProductComboBox.Items.Add("---Select Type Of Product---");
            productNameComboBox.Items.Add("---Select Product Name---");
            foreach (var item in productData)
            {
                typeOfProductComboBox.Items.Add(item);
            }
        }

        private void Clear()
        {

            typeOfProductComboBox.SelectedItem = @"---Select Type Of Product---";
            productNameComboBox.Items.Clear();
            pieceTextBox.Clear();
            rateTextBox.Clear();
            typeOfProductComboBox.Focus();
        }
    }
}
