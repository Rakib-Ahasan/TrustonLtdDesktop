using System;
using System.Linq;
using System.Windows.Forms;

namespace TrustonLtd
{
    public partial class CustomerStatusForm : Form
    {
        private TrustonEntities db = new TrustonEntities();
        public CustomerStatusForm(Panel containerPanel)
        {
            ContainerPanel = containerPanel;
            InitializeComponent();
            LoadData();
        }


        //Methods
        private void LoadData()
        {
            var data = db.Customers.ToList();
            customerNameComboBox.Items.Add("---Select Customer Name---");
            foreach (var item in data)
            {
                customerNameComboBox.Items.Add(item.ShopName);
            }
        }

        private void Clear()
        {
            customerNameComboBox.Items.Clear();
            customerNameTextBox.Clear();
            contactTextBox.Clear();
            addressTextBox.Clear();
            referenceNameTextBox.Clear();
            refContactTextBox.Clear();
            totalDueTextBox.Clear();
            customerNameComboBox.Focus();
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

        private void okButton_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            Clear();
            LoadData();
        }

        private void ViewReportButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                OpenChildForm(new CustomerStatusReportForm(customerNameComboBox.Text, addressTextBox.Text, contactTextBox.Text, referenceNameTextBox.Text, refContactTextBox.Text, Convert.ToInt32(totalDueTextBox.Text)));

            }
            catch (Exception)
            {
                //ignore
            }
        }

        private void customerNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (customerNameComboBox.SelectedItem == null || (string)customerNameComboBox.SelectedItem == @"---Select Worker---")
            {

            }
            else
            {
                var data = db.Customers.Where(model =>
                    model.ShopName == customerNameComboBox.SelectedItem.ToString());
                foreach (var item in data)
                {
                    customerNameTextBox.Text = item.ShopName;
                    addressTextBox.Text = item.Address;
                    contactTextBox.Text = item.Contact;
                    referenceNameTextBox.Text = item.ReferenceName;
                    refContactTextBox.Text = item.RefereceContact;

                    int totalPaymentFromCustomerPayment = (db.CustomerPayments.Where(m => m.Customer.ShopName == (string)customerNameComboBox.SelectedItem).Sum(m => (int?)m.Payment) ?? 0);
                    int totalLessPriceFromSale = (db.Sales.Where(m => m.Customer.ShopName == (string)customerNameComboBox.SelectedItem).Sum(m => (int?)m.LessPrice) ?? 0);
                    int totalReturnPriceFromSale = (db.Sales.Where(m => m.Customer.ShopName == (string)customerNameComboBox.SelectedItem).Sum(m => (int?)m.TotalReturnPrice) ?? 0);
                    int totalNetBillFromSale = (db.Sales.Where(m => m.Customer.ShopName == (string)customerNameComboBox.SelectedItem).Sum(m => (int?)m.NetTotalBill) ?? 0);
                    int totalPayFromSale = (db.Sales.Where(m => m.Customer.ShopName == (string)customerNameComboBox.SelectedItem).Sum(m => (int?)m.Pay) ?? 0);

                    totalDueTextBox.Text = (totalNetBillFromSale - (totalPaymentFromCustomerPayment + totalLessPriceFromSale + totalPayFromSale + totalReturnPriceFromSale)).ToString();
                }
            }
        }

        private void customerNameComboBox_Leave(object sender, EventArgs e)
        {
            if (customerNameComboBox.SelectedItem == null)
            {
                errorProvider1.SetError(this.customerNameComboBox, "Please select an item");
                customerNameComboBox.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            var exitsInstance = (from row in db.Customers
                                 where row.ShopName == contactTextBox.Text
                                 select row).ToList();

            if (exitsInstance.Count() != 0)
            {
                MessageBox.Show(@"Worker name already exist please try another name!", @"Warning", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    var customer = db.Customers.FirstOrDefault(m => m.ShopName == (string)customerNameComboBox.SelectedItem);
                    if (customer != null)
                    {
                        customer.ShopName = customerNameTextBox.Text;
                        customer.Address = addressTextBox.Text;
                        customer.Contact = contactTextBox.Text;
                        customer.ReferenceName = referenceNameTextBox.Text;
                        customer.RefereceContact = refContactTextBox.Text;
                    }


                    int a = db.SaveChanges();
                    Clear();

                    if (0 < a)
                    {
                        MessageBox.Show(@"Customer record Update successfully.", @"Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear();
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show(@"Customer record Update failed.", @"Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        LoadData();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show(@"Some information is missing please check again!", @"Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }
    }
}
