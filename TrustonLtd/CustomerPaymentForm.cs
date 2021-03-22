using System;
using System.Linq;
using System.Windows.Forms;
using TrustonLtd.Models;

namespace TrustonLtd
{
    public partial class CustomerPaymentForm : Form
    {
        TrustonEntities db = new TrustonEntities();
        public CustomerPaymentForm()
        {
            InitializeComponent();
            LoadData();
        }

        //Buttons operations
        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                CustomerPayment customerPayment = new CustomerPayment();
                var customer = db.Customers.FirstOrDefault(model => model.ShopName == (string)customerNameComboBox.SelectedItem);
                if (customer != null) customerPayment.CustomerId = customer.CustomerId;


                customerPayment.TotalPreviousDue = Convert.ToInt32(previousDueTextBox.Text);
                customerPayment.DateTime = DateTime.Now;
                customerPayment.Payment = Convert.ToInt32(paymentTextBox.Text);
                customerPayment.Due = Convert.ToInt32(dueTextBox.Text);

                //Now save the data in dbContext Class
                db.CustomerPayments.Add(customerPayment);
                int a = db.SaveChanges();

                if (a > 0)
                {
                    MessageBox.Show(@"Customer payment record save successfully.", @"Success", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    Clear();
                    customerNameComboBox.Focus();
                }
                else
                {
                    MessageBox.Show(@"Customer payment record save failed.", @"Failed", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                MessageBox.Show(@"Some information is missing please check again!", @"Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            Clear();
        }
        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        //method

        private void LoadData()
        {
            //1nd approach
            var data = db.Customers.ToList();
            customerNameComboBox.Items.Add("---Select Customer---");
            foreach (var item in data)
            {
                customerNameComboBox.Items.Add(item.ShopName);
            }

            //Loading distributed through worker id.
            if (customerNameComboBox.SelectedItem != null)
            {
                var customerId = db.Customers.FirstOrDefault(x => x.ShopName == (string)customerNameComboBox.SelectedItem);

                var previousDue = db.Sales.Where(model => customerId.CustomerId == model.CustomerId)
                                        .Sum(m => (int?)m.Due) ?? 0;

                previousDueTextBox.Text = previousDue.ToString();
            }
        }

        private void Clear()
        {
            customerNameComboBox.SelectedItem = null;
            addressTextBox.Clear();
            contactTextBox.Clear();
            referenceNameTextBox.Clear();
            refContactTextBox.Clear();
            previousDueTextBox.Clear();
            paymentTextBox.Clear();
            confirmPaymentTextBox.Clear();
            dueTextBox.Clear();
            customerNameComboBox.Focus();
        }

        private void paymentTextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void paymentTextBox_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(paymentTextBox.Text))
            {
                errorProvider1.SetError(this.paymentTextBox, "Please enter payment amount!");
                paymentTextBox.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void confirmPaymentTextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void confirmPaymentTextBox_Leave(object sender, EventArgs e)
        {

            if (confirmPaymentTextBox.Text != paymentTextBox.Text)
            {
                errorProvider2.SetError(this.confirmPaymentTextBox, "Payment amount not match!");
                confirmPaymentTextBox.Focus();
            }
            else
            {
                errorProvider2.Clear();
            }

        }

        private void confirmPaymentTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(confirmPaymentTextBox.Text))
            {

            }
            else
            {
                dueTextBox.Text =
                    (Convert.ToInt32(previousDueTextBox.Text) - Convert.ToInt32(confirmPaymentTextBox.Text)).ToString();
            }
        }

        private void customerNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (customerNameComboBox.SelectedItem == null ||
                (string)customerNameComboBox.SelectedItem == @"---Select Customer---")
            {
                Clear();
            }
            else
            {
                var data = db.Customers.Where(model =>
                    model.ShopName == customerNameComboBox.SelectedItem.ToString());
                foreach (var item in data)
                {
                    addressTextBox.Text = item.Address;
                    contactTextBox.Text = item.Contact;
                    referenceNameTextBox.Text = item.ReferenceName;
                    refContactTextBox.Text = item.RefereceContact;

                    int totalPaymentFromCustomerPayment = (db.CustomerPayments.Where(m => m.Customer.ShopName == (string)customerNameComboBox.SelectedItem).Sum(m => (int?)m.Payment) ?? 0);
                    int totalLessPriceFromSale = (db.Sales.Where(m => m.Customer.ShopName == (string)customerNameComboBox.SelectedItem).Sum(m => (int?)m.LessPrice) ?? 0);
                    int totalReturnPriceFromSale = (db.Sales.Where(m => m.Customer.ShopName == (string)customerNameComboBox.SelectedItem).Sum(m => (int?)m.TotalReturnPrice) ?? 0);
                    int totalNetBillFromSale = (db.Sales.Where(m => m.Customer.ShopName == (string)customerNameComboBox.SelectedItem).Sum(m => (int?)m.NetTotalBill) ?? 0);
                    int totalPayFromSale = (db.Sales.Where(m => m.Customer.ShopName == (string)customerNameComboBox.SelectedItem).Sum(m => (int?)m.Pay) ?? 0);
                    previousDueTextBox.Text = (totalNetBillFromSale - (totalPaymentFromCustomerPayment + totalLessPriceFromSale + totalPayFromSale + totalReturnPriceFromSale)).ToString();
                }
            }
        }
    }
}
