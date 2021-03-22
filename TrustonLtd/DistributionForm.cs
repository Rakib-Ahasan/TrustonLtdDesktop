using System;
using System.Linq;
using System.Windows.Forms;
using TrustonLtd.Models;

namespace TrustonLtd
{
    public partial class DistributionForm : Form
    {
        TrustonEntities db = new TrustonEntities();

        public DistributionForm()
        {
            InitializeComponent();
            LoadData();
        }

        //Buttons operations
        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                Distribution distribution = new Distribution();
                distribution.DateTime = DateTime.Now;
                var worker =
                    db.Workers.FirstOrDefault(model => model.WorkerName == (string)workerNameComboBox.SelectedItem);
                if (worker != null) distribution.WorkerId = worker.WorkerId;

                distribution.Distributed = Convert.ToInt32(distributedTextBox.Text);

                var productId = db.Products.FirstOrDefault(model =>
                    (string)productNameComboBox.SelectedItem == model.ProductName);

                if (productId != null) distribution.ProductId = productId.ProductId;

                int remain = Convert.ToInt32(remainingTextBox.Text);
                if (remain >= 0)
                {
                    distribution.Remaining = Convert.ToInt32(remainingTextBox.Text);
                    distribution.Piece = Convert.ToInt32(pieceOfAmountTextBox.Text);
                    distribution.TotalDistributed = Convert.ToInt32(totalDistributedTextBox.Text);

                    //Now save the data in dbContext Class
                    db.Distributions.Add(distribution);
                }
                else
                {
                    MessageBox.Show(@"Not enough product for distribution please select another or try later Thank You!", @"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                int a = db.SaveChanges();

                if (a > 0)
                {
                    MessageBox.Show(@"Distribution record save successfully.", @"Success", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    Clear();
                    workerNameComboBox.Focus();
                }
                else
                {
                    MessageBox.Show(@"Distribution record save failed.", @"Failed", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                MessageBox.Show(@"Some information is missing please check again!", @"Error!", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            Clear();
        }


        //Methods

        private void Clear()
        {
            workerNameComboBox.SelectedItem = "---Select Worker---";
            typeOfProductComboBox.SelectedItem = "---Select Type of Product---";
            productNameComboBox.SelectedItem = "---Select Product Name---";
            addressTextBox.Clear();
            referenceNameTextBox.Clear();
            contactTextBox.Clear();
            refContactTextBox.Clear();
            pieceOfAmountTextBox.Clear();
            rateTextBox.Clear();
            workerNameComboBox.Focus();
            remainingTextBox.Clear();
            distributedTextBox.Text = 0.ToString();
            totalDistributedTextBox.Text = 0.ToString();
        }

        private void LoadData()
        {
            //1nd approach
            var data = db.Workers.ToList();
            workerNameComboBox.Items.Add("---Select Worker---");
            foreach (var item in data)
            {
                workerNameComboBox.Items.Add(item.WorkerName);
            }

            //2nd approach

            //workerNameComboBox.Items.Add("---Select Worker Name---");

            //workerNameComboBox.DataSource = db.Workers.Select(m => m.WorkerName).ToList();
            //Loading distributed through worker id.
            if (workerNameComboBox.SelectedItem != null)
            {
                var workerId = db.Workers.FirstOrDefault(x => x.WorkerName == (string)workerNameComboBox.SelectedItem);

                var distributed = db.Distributions.Where(model => workerId.WorkerId == model.WorkerId)
                                      .Sum(m => (int?)m.Piece) ?? 0;
                distributedTextBox.Text = distributed.ToString();
                totalDistributedTextBox.Text = distributed.ToString();
            }


            typeOfProductComboBox.DataSource = db.StockIns.Select(m => m.Product.TypeOfProduct).Distinct().ToList();
        }


        //TextBox Key Press Events
        private void pieceOfAmountTextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


        //TextBox leave events
        private void workerNameComboBox_Leave(object sender, EventArgs e)
        {
            if (workerNameComboBox.SelectedItem == null ||
                (string)workerNameComboBox.SelectedItem == @"---Select Worker---")
            {
                errorProvider1.SetError(this.workerNameComboBox, "Please select an item");
                workerNameComboBox.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void typeOfProductComboBox_Leave_1(object sender, EventArgs e)
        {
            if (typeOfProductComboBox.SelectedItem == null ||
                (string)typeOfProductComboBox.SelectedItem == "---Select Type of Product---")
            {
                productNameComboBox.SelectedItem = "---Select Product Name---";
                errorProvider2.SetError(this.typeOfProductComboBox, "Please select type of product");
                typeOfProductComboBox.Focus();
            }
            else
            {
                errorProvider2.Clear();
            }
        }

        private void productNameComboBox_Leave(object sender, EventArgs e)
        {
            if (productNameComboBox.SelectedItem == null ||
                (string)productNameComboBox.SelectedItem == "---Select Product Name---")
            {
                errorProvider3.SetError(this.productNameComboBox, "Please select product name");
                productNameComboBox.Focus();
            }
            else
            {
                errorProvider3.Clear();
            }
        }

        private void pieceOfAmountTextBox_Leave(object sender, EventArgs e)
        {
            if ((string)workerNameComboBox.SelectedItem == @"---Select Worker---" ||
                string.IsNullOrEmpty(workerNameComboBox.Text))
            {
                workerNameComboBox.Focus();
            }
            else if (String.IsNullOrEmpty(pieceOfAmountTextBox.Text))
            {
                errorProvider4.SetError(this.pieceOfAmountTextBox, "Please enter piece amount");
                pieceOfAmountTextBox.Focus();
            }
            else
            {
                errorProvider4.Clear();
            }
        }

        //Selected_Index_Changed Events
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
            try
            {
                rateTextBox.Clear();
                remainingTextBox.Clear();
                if (productNameComboBox.SelectedItem != null)
                {
                    var product = db.StockIns.Where(model =>
                        model.Product.ProductName == productNameComboBox.SelectedItem.ToString());

                    int remaining = 0;
                    if (productNameComboBox.SelectedIndex == -1)
                    {
                        remainingTextBox.Text = 0.ToString();
                    }
                    else
                    {
                        //var totalDistributed = db.Distributions.Select(m => m.Product.ProductName == (string)productNameComboBox.SelectedItem).Any()? db.Distributions.Sum(m => m.Piece): 0;
                        var totalDistributed = db.Distributions.Where(m => m.Product.ProductName == (string)productNameComboBox.SelectedItem).Sum(m => (int?)m.Piece) ?? 0;

                        var totalStock = db.StockIns.Where(m => m.Product.ProductName == (string)productNameComboBox.SelectedItem).Sum(m => (int?)m.Piece) ?? 0;
                        //var totalStock = db.StockIns.Where(m => m.Product.ProductName == (string)productNameComboBox.SelectedItem).Any() ? db.StockIns.Sum(m => m.Piece): 0;

                        var totalReturnCollection = db.Collections.Where(m => m.Product.ProductName == (string) productNameComboBox.SelectedItem).Sum(m => (int?) m.Return) ?? 0;
                        remaining = (totalStock - totalDistributed) + totalReturnCollection;
                    }

                    foreach (var item in product)
                    {
                        rateTextBox.Text = item.Product.RateOfAmount.ToString();
                        remainingTextBox.Text = remaining.ToString();
                    }
                }
            }
            catch (Exception)
            {
                //ignored
            }
        }
        private void workerNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (workerNameComboBox.SelectedItem == null || (string)workerNameComboBox.SelectedItem == @"---Select Worker---")
            {
                Clear();
            }
            else
            {
                var data = db.Workers.Where(model =>
                    model.WorkerName == workerNameComboBox.SelectedItem.ToString());
                foreach (var item in data)
                {
                    addressTextBox.Text = item.Address;
                    contactTextBox.Text = item.Contact;
                    referenceNameTextBox.Text = item.ReferenceName;
                    refContactTextBox.Text = item.RefereceContact;
                    int totalCollect = db.Collections
                                           .Where(m => m.Worker.WorkerName == (string)workerNameComboBox.SelectedItem).Sum(m => (int?)m.Piece) ?? 0;
                    int totalReturn = db.Collections
                                          .Where(m => m.Worker.WorkerName == (string)workerNameComboBox.SelectedItem).Sum(m => (int?)m.Return) ?? 0;
                    int totalDistribute = db.Distributions
                                              .Where(m => m.Worker.WorkerName == (string)workerNameComboBox.SelectedItem).Sum(m => (int?)m.Piece) ?? 0;
                    distributedTextBox.Text = (totalDistribute - (totalCollect + totalReturn)).ToString();
                }
            }
        }


        //TextBox TextChanged Events
        private void pieceOfAmountTextBox_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(pieceOfAmountTextBox.Text))
            {

            }
            else
            {
                int piece = Convert.ToInt32(pieceOfAmountTextBox.Text);
                int distributed = Convert.ToInt32(distributedTextBox.Text);
                int totalDistributed = distributed + piece;
                totalDistributedTextBox.Text = totalDistributed.ToString();
            }
        }
    }

}

