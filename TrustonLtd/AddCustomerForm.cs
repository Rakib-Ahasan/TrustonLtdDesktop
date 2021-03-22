using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TrustonLtd.Models;

namespace TrustonLtd
{
    public partial class AddCustomerForm : Form
    {
        TrustonEntities db = new TrustonEntities();
        public AddCustomerForm()
        {
            InitializeComponent();
        }

        //TextBox Leave Events
        private void shopNameTextBox_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(shopNameTextBox.Text))
            {
                errorProvider1.SetError(this.shopNameTextBox, "Please give shop name!");
                shopNameTextBox.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }
        private void addressTextBox_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(addressTextBox.Text))
            {
                errorProvider2.SetError(this.addressTextBox, "Please give address!");
                addressTextBox.Focus();
            }
            else
            {
                errorProvider2.Clear();
            }
        }

        private void contactTextBox_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(contactTextBox.Text))
            {
                errorProvider3.SetError(this.contactTextBox, "Please give phone valid number!");
                contactTextBox.Focus();
            }
            else if (contactTextBox.Text.Length == 11 || contactTextBox.Text.Length == 12)
            {
                errorProvider3.Clear();
            }
            else
            {
                errorProvider3.SetError(this.contactTextBox, "Your phone number must be 11 or 12 digit only!");
                contactTextBox.Focus();
            }
        }
        private void refNameTextBox_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(refNameTextBox.Text))
            {
                errorProvider4.SetError(this.refNameTextBox, "Please give reference name!");
                refNameTextBox.Focus();
            }
            else
            {
                errorProvider4.Clear();
            }
        }
        private void refContactTextBox_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(refContactTextBox.Text))
            {
                errorProvider5.SetError(this.refContactTextBox, "Please give reference phone valid number!");
                //refContactTextBox.Focus();
            }
            else if (refContactTextBox.Text.Length == 11 || refContactTextBox.Text.Length == 12)
            {
                errorProvider5.Clear();
            }
            else
            {
                errorProvider5.SetError(this.refContactTextBox, "Your phone number must be 11 or 12 digit only!");
                //refContactTextBox.Focus();
            }
        }

        //TextBox Enter Events
        private void shopNameTextBox_Enter(object sender, EventArgs e)
        {
            if (shopNameTextBox.Text == @"Enter Full Name")
            {
                shopNameTextBox.Text = null;
                shopNameTextBox.ForeColor = Color.LightSeaGreen;
            }
        }
        private void addressTextBox_Enter(object sender, EventArgs e)
        {
            if (addressTextBox.Text == @"Enter Address")
            {
                addressTextBox.Text = null;
                addressTextBox.ForeColor = Color.LightSeaGreen;
            }
        }

        private void contactTextBox_Enter(object sender, EventArgs e)
        {
            if (contactTextBox.Text == @"Enter Valid Phone No")
            {
                contactTextBox.Text = null;
                contactTextBox.ForeColor = Color.LightSeaGreen;
            }
        }
        private void refNameTextBox_Enter(object sender, EventArgs e)
        {
            if (refNameTextBox.Text == @"Enter Ref Name")
            {
                refNameTextBox.Text = null;
                refNameTextBox.ForeColor = Color.LightSeaGreen;
            }
        }
        private void refContactTextBox_Enter(object sender, EventArgs e)
        {
            if (refContactTextBox.Text == @"Enter Ref Phone No")
            {
                refContactTextBox.Text = null;
                refContactTextBox.ForeColor = Color.LightSeaGreen;
            }
        }


        //TextBox Key Press Events
        private void shopNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsLetter(ch) || char.IsDigit(ch))
            {
                e.Handled = false;
            }
            else if (ch == 32)
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
        private void contactTextBox_KeyPress(object sender, KeyPressEventArgs e)
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
        private void refNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsLetter(ch) || char.IsDigit(ch))
            {
                e.Handled = false;
            }
            else if (ch == 32)
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
        private void refContactTextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void SaveButton_Click(object sender, EventArgs e)
        {

            var exitsInstance = (from row in db.Customers
                                 where row.ShopName == contactTextBox.Text
                                 select row).ToList();

            if (exitsInstance.Count() != 0)
            {
                MessageBox.Show(@"Customer name already exist please try another name!", @"Warning", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    //Create a object for store current data
                    Customer customer = new Customer();
                    customer.ShopName = shopNameTextBox.Text;
                    customer.Address = addressTextBox.Text;
                    customer.Contact = contactTextBox.Text;
                    customer.ReferenceName = refNameTextBox.Text;
                    customer.RefereceContact = refContactTextBox.Text;

                    //Now save the data in dbContext Class
                    db.Customers.Add(customer);
                    int a = db.SaveChanges();

                    if (a > 0)
                    {
                        MessageBox.Show(@"Customers record save successfully.", @"Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear();
                    }
                    else
                    {
                        MessageBox.Show(@"Customers record save failed.", @"Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show(@"Some information is missing please check again!", @"Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        //Methods
        private void Clear()
        {
            shopNameTextBox.Text = @"Enter Full Name";
            addressTextBox.Text = @"Enter Address";
            contactTextBox.Text = @"Enter Valid Phone No";
            refNameTextBox.Text = @"Enter Ref Name";
            refContactTextBox.Text = @"Enter Ref Phone No";
            shopNameTextBox.Focus();
        }
    }
}
