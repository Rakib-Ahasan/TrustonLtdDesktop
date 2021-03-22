using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TrustonLtd.Models;

namespace TrustonLtd
{
    public partial class AddProductForm : Form
    {
        TrustonEntities db = new TrustonEntities();
        public AddProductForm()
        {
            InitializeComponent();
        }


        //TextBox Leave Events
        private void rateOfAmountTextBox_Leave(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(rateOfAmountTextBox.Text))
            {
                errorProvider3.SetError(this.rateOfAmountTextBox, "Please give rate of amount !");
                rateOfAmountTextBox.Focus();
            }
            else
            {
                errorProvider3.Clear();
            }
        }
        private void productNameTextBox_Leave(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(productNameTextBox.Text))
            {
                errorProvider2.SetError(this.productNameTextBox, "Please enter product name!");
                productNameTextBox.Focus();
            }
            else
            {
                errorProvider2.Clear();
            }
        }

        private void typeOfProductComboBox_Leave_1(object sender, EventArgs e)
        {
            if (typeOfProductComboBox.SelectedItem == null || (string)typeOfProductComboBox.SelectedItem == @"---Select Item---")
            {
                typeOfProductComboBox.SelectedItem = @"---Select Item---";
                errorProvider1.SetError(this.typeOfProductComboBox, "Please select an item for type of product!");
                typeOfProductComboBox.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }


        //TextBox Enter Events
        private void rateOfAmountTextBox_Enter(object sender, EventArgs e)
        {
            if (rateOfAmountTextBox.Text == @"Enter Rate of Amount (taka)")
            {
                rateOfAmountTextBox.Text = null;
                rateOfAmountTextBox.ForeColor = Color.LightSeaGreen;
            }
        }

        private void productNameTextBox_Enter(object sender, EventArgs e)
        {
            if (productNameTextBox.Text == @"Enter Product Name")
            {
                productNameTextBox.Text = null;
                productNameTextBox.ForeColor = Color.LightSeaGreen;
            }
        }


        //TextBox Key Press Events
        private void rateOfAmountTextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        //Button operations
        private void SaveButton_Click(object sender, EventArgs e)
        {

            var exitsInstance = (from row in db.Products
                where row.ProductName == productNameTextBox.Text
                select row).ToList();

            if (exitsInstance.Count() != 0)
            {
                MessageBox.Show(@"Product name already exist please try another name!", @"Warning", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
                try
                {


                    //Create a object for store current data
                    Product product = new Product();
                    if (typeOfProductComboBox.SelectedIndex != -1)
                    {
                        product.TypeOfProduct = typeOfProductComboBox.SelectedItem.ToString();

                    }
                    product.ProductName = productNameTextBox.Text;
                    product.RateOfAmount = Convert.ToInt32(rateOfAmountTextBox.Text);

                    //Now save the data in dbContext Class
                    db.Products.Add(product);
                    int a = db.SaveChanges();

                    if (a > 0)
                    {
                        MessageBox.Show(@"Products record save successfully.", @"Success", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        Clear();
                    }
                    else
                    {
                        MessageBox.Show(@"Products record save failed.", @"Failed", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show(@"Some information is missing please check again!", @"Error!", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                }
            }
        }
        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            Clear();
        }


        //Methods
        private void Clear()
        {

            typeOfProductComboBox.SelectedItem = @"---Select Item---";
            productNameTextBox.Text = @"Enter Product Name";
            rateOfAmountTextBox.Text = @"Enter Rate of Amount (taka)";
            typeOfProductComboBox.Focus();
        }
    }
}
