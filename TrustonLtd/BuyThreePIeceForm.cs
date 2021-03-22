using System;
using System.Linq;
using System.Windows.Forms;
using TrustonLtd.Models;

namespace TrustonLtd
{
    public partial class BuyThreePieceForm : Form
    {
        TrustonEntities db = new TrustonEntities();
        public BuyThreePieceForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        //Methods
        private void LoadData()
        {
            typeOfProductComboBox.DataSource = db.StockIns.Select(m => m.Product.TypeOfProduct).Distinct().ToList();

        }
        private void Clear()
        {
            typeOfProductComboBox.SelectedItem = null;
            productNameComboBox.SelectedItem = null;
            pieceTextBox.Clear();
            rateTextBox.Clear();
            totalAmountTextBox.Clear();
            typeOfProductComboBox.Focus();
        }
        private void pieceTextBox_Leave(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(pieceTextBox.Text))
            {
                errorProvider3.SetError(this.pieceTextBox, "Please enter product piece!");
                pieceTextBox.Focus();
            }
            else
            {
                errorProvider3.Clear();
            }
        }

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

        private void ResetButton_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void productNameComboBox_Leave(object sender, EventArgs e)
        {
            if (productNameComboBox.SelectedItem == null)
            {
                errorProvider2.SetError(this.productNameComboBox, "Plese select product name");
                productNameComboBox.Focus();
            }
            else
            {
                errorProvider2.Clear();
            }
        }

        private void typeOfProductComboBox_Leave(object sender, EventArgs e)
        {
            if (typeOfProductComboBox.SelectedItem == null)
            {
                errorProvider1.SetError(this.typeOfProductComboBox, "Please select type of product");
                typeOfProductComboBox.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void pieceTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                totalAmountTextBox.Text =
                    (Convert.ToInt32(pieceTextBox.Text) * Convert.ToInt32(rateTextBox.Text)).ToString();

            }
            catch (Exception)
            {
                //ignored
            }
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

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                BuyEmbroideryOrnaOrThreePiece buytThreePiece = new BuyEmbroideryOrnaOrThreePiece();
                buytThreePiece.DateTime = System.DateTime.Now;
                var productId = db.Products.FirstOrDefault(model => (string)productNameComboBox.SelectedItem == model.ProductName);
                if (productId != null) buytThreePiece.ProductId = productId.ProductId;
                buytThreePiece.Piece = Convert.ToInt32(pieceTextBox.Text);
                buytThreePiece.TotalAmount = Convert.ToInt32(totalAmountTextBox.Text);

                db.BuyEmbroideryOrnaOrThreePieces.Add(buytThreePiece);
                int a = db.SaveChanges();

                if (a > 0)
                {
                    MessageBox.Show(@"Buy embroidery orna record save successfully.", @"Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                }
                else
                {
                    MessageBox.Show(@"Buy embroidery orna record save failed.", @"Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show(@"Some information is missing please check again!", @"Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
