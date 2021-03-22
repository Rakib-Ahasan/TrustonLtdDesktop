using System;
using System.Linq;
using System.Windows.Forms;
using TrustonLtd.Models;

namespace TrustonLtd
{
    public partial class SalesForm : Form
    {
        TrustonEntities db = new TrustonEntities();

        public SalesForm()
        {
            InitializeComponent();
            LoadData();
        }

        //Buttons operations 
        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                Sale sale = new Sale();

                if (customerNameComboBox.SelectedItem != null && typeOfProductComboBox.SelectedItem != null && returnProductNameComboBox.SelectedItem != null)
                {
                    var customer = db.Customers.FirstOrDefault(model => model.ShopName == (string)customerNameComboBox.SelectedItem);
                    if (customer != null) sale.CustomerId = customer.CustomerId;

                    sale.PreviousDue = Convert.ToInt32(previousDueTextBox.Text);
                    sale.SalesBy = saleByTextBox.Text;
                    var productId = db.Products.FirstOrDefault(model =>
                            (string)productNameComboBox.SelectedItem == model.ProductName);
                    if (productId != null) sale.ProductId = productId.ProductId;

                    sale.Piece = Convert.ToInt32(pieceTextBox.Text);
                    sale.Rate = Convert.ToInt32(rateTextBox.Text);
                    sale.NetTotalBill = Convert.ToInt32(netTotalBillTextBox.Text);


                    var returnProductId =
                        db.Products.FirstOrDefault(m => m.ProductName == (string)returnProductNameComboBox.SelectedItem);



                    if (returnProductId != null) sale.ReturnProductId = Convert.ToInt32(returnProductId.ProductId);
                    sale.ReturnRate = Convert.ToInt32(rateReturnTextBox.Text);
                    sale.ReturnPiece = Convert.ToInt32(pieceReturnTextBox.Text);


                    sale.TotalReturnPrice = Convert.ToInt32(totalReturnPrice.Text);
                    sale.TotalBill = Convert.ToInt32(totalBillTextBox.Text);
                    sale.LessPrice = Convert.ToInt32(lessPriceTextBox.Text);
                    sale.Pay = Convert.ToInt32(payTextBox.Text);
                    sale.Due = Convert.ToInt32(dueTextBox.Text);
                    sale.DateTime = dateTimePicker.Value.Date;
                }
                else if (typeOfProductComboBox.SelectedItem != null && returnProductNameComboBox.SelectedItem == null)
                {
                    var customer = db.Customers.FirstOrDefault(model => model.ShopName == (string)customerNameComboBox.SelectedItem);
                    if (customer != null) sale.CustomerId = customer.CustomerId;

                    sale.PreviousDue = Convert.ToInt32(previousDueTextBox.Text);
                    sale.SalesBy = saleByTextBox.Text;

                    var productId = db.Products.FirstOrDefault(model =>
                        (string)productNameComboBox.SelectedItem == model.ProductName);
                    if (productId != null) sale.ProductId = productId.ProductId;

                    sale.Piece = Convert.ToInt32(pieceTextBox.Text);
                    sale.Rate = Convert.ToInt32(rateTextBox.Text);
                    sale.NetTotalBill = Convert.ToInt32(netTotalBillTextBox.Text);

                    sale.ReturnProductId = 0;
                    sale.ReturnRate = 0;
                    sale.ReturnPiece = 0;
                    sale.TotalReturnPrice = 0;
                    sale.TotalBill = Convert.ToInt32(totalBillTextBox.Text);
                    sale.LessPrice = Convert.ToInt32(lessPriceTextBox.Text);
                    sale.Pay = Convert.ToInt32(payTextBox.Text);
                    sale.Due = Convert.ToInt32(dueTextBox.Text);
                    sale.DateTime = dateTimePicker.Value.Date;
                }
                else if (typeOfProductComboBox.SelectedItem == null && returnProductNameComboBox.SelectedItem != null)
                {
                    var customer = db.Customers.FirstOrDefault(model => model.ShopName == (string)customerNameComboBox.SelectedItem);
                    if (customer != null) sale.CustomerId = customer.CustomerId;

                    sale.PreviousDue = Convert.ToInt32(previousDueTextBox.Text);
                    sale.SalesBy = saleByTextBox.Text;

                    var returnProductId =
                        db.Products.FirstOrDefault(m => m.ProductName == (string)returnProductNameComboBox.SelectedItem);


                    if (returnProductId != null)
                    {
                        sale.ProductId = returnProductId.ProductId;
                        sale.Piece = 0;
                        sale.Rate = 0;
                        sale.NetTotalBill = 0;
                        sale.ReturnProductId = Convert.ToInt32(returnProductId.ProductId);
                    }


                    sale.ReturnRate = Convert.ToInt32(rateReturnTextBox.Text);
                    sale.ReturnPiece = Convert.ToInt32(pieceReturnTextBox.Text);
                    sale.TotalReturnPrice = Convert.ToInt32(totalReturnPrice.Text);

                    sale.TotalBill = Convert.ToInt32(totalBillTextBox.Text);
                    sale.LessPrice = Convert.ToInt32(lessPriceTextBox.Text);
                    sale.Pay = Convert.ToInt32(payTextBox.Text);
                    sale.Due = Convert.ToInt32(dueTextBox.Text);
                    sale.DateTime = dateTimePicker.Value.Date;

                }

                //Now save the data in dbContext Class
                db.Sales.Add(sale);
                int a = db.SaveChanges();

                if (a > 0)
                {
                    MessageBox.Show(@"Sales record save successfully.", @"Success", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    Clear();
                    customerNameComboBox.Focus();
                }
                else
                {
                    MessageBox.Show(@"Sales record save failed.", @"Failed", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                MessageBox.Show(@"Some information is missing please check again!", @"Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void ResetButton_Click_1(object sender, EventArgs e)
        {
            Clear();
        }
        //Methods
        private void Clear()
        {
            customerNameComboBox.SelectedItem = null;
            typeOfProductComboBox.SelectedItem = null;
            productNameComboBox.SelectedItem = null;
            contactTextBox.Clear();
            addressTextBox.Clear();
            referenceNameTextBox.Clear();
            refContactTextBox.Clear();
            previousDueTextBox.Clear();
            pieceTextBox.Clear();
            rateTextBox.Clear();
            netTotalBillTextBox.Clear();
            saleByTextBox.Clear();
            lessPriceTextBox.Clear();
            payTextBox.Clear();
            confirnTextBox.Clear();
            returnProductNameComboBox.SelectedItem = null;
            pieceReturnTextBox.Clear();
            rateReturnTextBox.Clear();
            totalReturnPrice.Clear();
            totalBillTextBox.Clear();
            dueTextBox.Clear();
            customerNameComboBox.Focus();
        }

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

            }

            typeOfProductComboBox.Items.Add("--Select Product Type---");
            var typeOfProduct = db.Products.Select(m => m.TypeOfProduct).Distinct().ToList();
            foreach (var item in typeOfProduct)
            {
                typeOfProductComboBox.Items.Add(item);
            }
        }

        //TextBox leave events
        private void pieceTextBox_Leave(object sender, EventArgs e)
        {
            if (pieceTextBox.Text == null && typeOfProductComboBox.SelectedItem != null)
            {
                errorProvider5.SetError(this.pieceTextBox, "Please enter piece amount!");
                pieceTextBox.Focus();
            }
            else
            {
                errorProvider5.Clear();
                typeOfProductComboBox.Focus();
            }
        }
        private void rateTextBox_Leave(object sender, EventArgs e)
        {
            if (rateTextBox.Text == null && pieceTextBox.Text != null)
            {
                errorProvider6.SetError(this.rateTextBox, "Please enter rate amount!");
                rateTextBox.Focus();
            }
            else
            {
                errorProvider6.Clear();
                pieceTextBox.Focus();
            }
        }
        private void saleByTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(saleByTextBox.Text))
            {
                errorProvider2.SetError(this.saleByTextBox, "Please enter sale by!");
                saleByTextBox.Focus();
            }
            else
            {
                errorProvider2.Clear();
            }
        }
        private void pieceReturnTextBox_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(pieceReturnTextBox.Text) && returnProductNameComboBox.SelectedItem != null)
            {
                errorProvider5.SetError(this.pieceReturnTextBox, "Please enter return piece!");
                pieceReturnTextBox.Focus();
            }
            else
            {
                errorProvider5.Clear();
            }
        }

        private void lessPriceTextBox_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(lessPriceTextBox.Text))
            {
                errorProvider7.SetError(this.lessPriceTextBox, "Please enter less price!");
                lessPriceTextBox.Focus();
            }
            else
            {
                errorProvider7.Clear();
            }
        }

        private void payTextBox_Leave_1(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(payTextBox.Text))
            {
                errorProvider8.SetError(this.payTextBox, "Please enter payable amount!");
                payTextBox.Focus();
            }
            else
            {
                errorProvider8.Clear();
            }
        }
        private void confirnTextBox_Leave(object sender, EventArgs e)
        {
            if (customerNameComboBox.SelectedItem == null && confirnTextBox.Text == null)
            {
                errorProvider1.SetError(this.customerNameComboBox, "Please select customer first!");
                customerNameComboBox.Focus();
            }
            else if (customerNameComboBox.SelectedItem != null && confirnTextBox.Text == null)
            {
                errorProvider9.SetError(this.confirnTextBox, "Please enter confirm amount!");
                confirnTextBox.Focus();
            }
            else if (payTextBox.Text != confirnTextBox.Text)
            {
                errorProvider9.SetError(this.confirnTextBox, "Confirm amount not match with pay amount!");
                confirnTextBox.Focus();
            }
            else
            {
                errorProvider9.Clear();
            }
        }

        private void customerNameComboBox_Leave(object sender, EventArgs e)
        {
            if ((string)customerNameComboBox.SelectedItem == "---Select Customer---" || customerNameComboBox.SelectedItem == null)
            {
                errorProvider1.SetError(this.customerNameComboBox, "Please select customer name first!");
                customerNameComboBox.Focus();

            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void typeOfProductComboBox_Leave(object sender, EventArgs e)
        {
            if ((typeOfProductComboBox.Text == @"---Select Product Type---" || typeOfProductComboBox.SelectedItem == null) && customerNameComboBox.SelectedItem != null)
            {
                errorProvider3.SetError(this.typeOfProductComboBox, "Please select product type!");
                typeOfProductComboBox.Focus();
            }
            else
            {
                errorProvider3.Clear();
                customerNameComboBox.Focus();
            }
        }

        //TextBox keypress events
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

        private void rateTextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void pieceReturnTextBox_KeyPress(object sender, KeyPressEventArgs e)
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
        private void lessPriceTextBox_KeyPress(object sender, KeyPressEventArgs e)
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
        private void PayTextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void confirnTextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        //TextBox SelectedIndexChanged events
        private void customerNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(customerNameComboBox.Text))
            {
                Clear();
            }
            else
            {

                var data = db.Customers.Where(model =>
                    model.ShopName == (string)customerNameComboBox.SelectedItem).ToList();

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

                returnProductNameComboBox.Items.Clear();
                var returnProductName = db.Sales.Where(m =>
                    m.Customer.ShopName == (string)customerNameComboBox.SelectedItem).Select(m => m.Product.ProductName).Distinct().ToList();
                returnProductNameComboBox.Items.Add("---Select Product Name---");

                foreach (var item in returnProductName)
                {
                    returnProductNameComboBox.Items.Add(item);
                }

            }
        }

        private void typeOfProductComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (typeOfProductComboBox.SelectedItem == null ||
                (string)typeOfProductComboBox.SelectedItem == "---Select Product Type---")
            {
                typeOfProductComboBox.Focus();
            }
            else
            {
                productNameComboBox.DataSource = db.Distributions
                    .Where(m => m.Product.TypeOfProduct == (string)typeOfProductComboBox.SelectedItem)
                    .Select(m => m.Product.ProductName).Distinct()
                    .ToList();
            }
        }
        private void returnProductNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if ((string)returnProductNameComboBox.SelectedItem == "Select Product Name---")
                {
                    rateReturnTextBox.Text = 0.ToString();
                }
                else
                {
                    rateReturnTextBox.Text = db.Sales.Where(m =>
                        m.Product.ProductName == (string)returnProductNameComboBox.SelectedItem &&
                        m.Customer.ShopName == (string)customerNameComboBox.SelectedItem).Max(m => m.Rate).ToString();
                }
            }
            catch (Exception)
            {
                //ignored
            }
        }


        //TextBox TextChanged events

        private void rateTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {

                if (typeOfProductComboBox.SelectedItem != null && returnProductNameComboBox.SelectedItem != null)
                {
                    int rate = Convert.ToInt32(rateTextBox.Text);
                    int piece = Convert.ToInt32(pieceTextBox.Text);
                    int returnRate = Convert.ToInt32(rateReturnTextBox.Text);
                    int returnPiece = Convert.ToInt32(pieceReturnTextBox.Text);
                    int previousDue = Convert.ToInt32(previousDueTextBox.Text);

                    int netTotal = rate * piece;
                    netTotalBillTextBox.Text = netTotal.ToString();

                    int returnTotalPrice = returnPiece * returnRate;
                    totalReturnPrice.Text = returnTotalPrice.ToString();

                    int totalBill = (previousDue + netTotal) - returnTotalPrice;

                    totalBillTextBox.Text = totalBill.ToString();
                }
                else if (typeOfProductComboBox.SelectedItem != null && returnProductNameComboBox.SelectedItem == null)
                {
                    int rate = Convert.ToInt32(rateTextBox.Text);
                    int piece = Convert.ToInt32(pieceTextBox.Text);
                    int previousDue = Convert.ToInt32(previousDueTextBox.Text);

                    int netTotal = rate * piece;
                    netTotalBillTextBox.Text = netTotal.ToString();

                    int totalBill = (previousDue + netTotal);

                    totalBillTextBox.Text = totalBill.ToString();
                }
                else if (typeOfProductComboBox.SelectedItem == null && returnProductNameComboBox.SelectedItem != null)
                {
                    int returnRate = Convert.ToInt32(rateReturnTextBox.Text);
                    int returnPiece = Convert.ToInt32(pieceReturnTextBox.Text);
                    int previousDue = Convert.ToInt32(previousDueTextBox.Text);

                    int returnTotalPrice = returnPiece * returnRate;
                    totalReturnPrice.Text = returnTotalPrice.ToString();

                    int totalBill = previousDue - returnTotalPrice;

                    totalBillTextBox.Text = totalBill.ToString();
                }
            }
            catch (Exception)
            {
                // ignored
            }
        }

        private void pieceReturnTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (typeOfProductComboBox.SelectedItem != null && returnProductNameComboBox.SelectedItem != null)
                {
                    int rate = Convert.ToInt32(rateTextBox.Text);
                    int piece = Convert.ToInt32(pieceTextBox.Text);
                    int returnRate = Convert.ToInt32(rateReturnTextBox.Text);
                    int returnPiece = Convert.ToInt32(pieceReturnTextBox.Text);
                    int previousDue = Convert.ToInt32(previousDueTextBox.Text);

                    int netTotal = rate * piece;
                    netTotalBillTextBox.Text = netTotal.ToString();

                    int returnTotalPrice = returnPiece * returnRate;
                    totalReturnPrice.Text = returnTotalPrice.ToString();

                    int totalBill = (previousDue + netTotal) - returnTotalPrice;

                    totalBillTextBox.Text = totalBill.ToString();
                }
                else if (typeOfProductComboBox.SelectedItem != null && returnProductNameComboBox.SelectedItem == null)
                {
                    int rate = Convert.ToInt32(rateTextBox.Text);
                    int piece = Convert.ToInt32(pieceTextBox.Text);
                    int previousDue = Convert.ToInt32(previousDueTextBox.Text);

                    int netTotal = rate * piece;
                    netTotalBillTextBox.Text = netTotal.ToString();

                    int totalBill = (previousDue + netTotal);

                    totalBillTextBox.Text = totalBill.ToString();
                }
                else if (typeOfProductComboBox.SelectedItem == null && returnProductNameComboBox.SelectedItem != null)
                {
                    int returnRate = Convert.ToInt32(rateReturnTextBox.Text);
                    int returnPiece = Convert.ToInt32(pieceReturnTextBox.Text);
                    int previousDue = Convert.ToInt32(previousDueTextBox.Text);

                    int returnTotalPrice = returnPiece * returnRate;
                    totalReturnPrice.Text = returnTotalPrice.ToString();

                    int totalBill = previousDue - returnTotalPrice;

                    totalBillTextBox.Text = totalBill.ToString();
                }
            }
            catch (Exception)
            {
                // ignored
            }
        }

        private void confirnTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //int due = Convert.ToInt32(dueTextBox.Text);
                if (confirnTextBox.Text == null)
                {

                }
                else
                {
                    dueTextBox.Text = (Convert.ToInt32(totalBillTextBox.Text) - (Convert.ToInt32(lessPriceTextBox.Text) +
                                                                                 Convert.ToInt32(confirnTextBox.Text))).ToString();
                }
            }
            catch (Exception)
            {
                // ignored
            }
        }

        private void confirnTextBox_Enter(object sender, EventArgs e)
        {
            if (payTextBox.Text != confirnTextBox.Text)
            {

                errorProvider9.SetError(this.confirnTextBox, "Confirm amount not match with pay amount!");
                confirnTextBox.Focus();
            }
            else
            {
                errorProvider9.Clear();
            }
        }
    }
}
