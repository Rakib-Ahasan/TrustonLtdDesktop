using System;
using System.Linq;
using System.Windows.Forms;
using TrustonLtd.Models;

namespace TrustonLtd
{
    public partial class CollectionForm : Form
    {
        TrustonEntities db = new TrustonEntities();

        public CollectionForm()
        {
            InitializeComponent();
            LoadData();
        }

        //Buttons operations
        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                Collection collection = new Collection();
                collection.DateTime = DateTime.Now;
                var worker = db.Workers.FirstOrDefault(model => model.WorkerName == (string)workerNameComboBox.SelectedItem);
                if (worker != null) collection.WorkerId = worker.WorkerId;
                collection.TotalDistributed = Convert.ToInt32(totalDistributedTextBox.Text);

                var productId = db.Products.FirstOrDefault(model => (string)productNameComboBox.SelectedItem == model.ProductName);
                if (productId != null) collection.ProductId = productId.ProductId;
                int distribute = Convert.ToInt32(distributedTextBox.Text);
                if (distribute > 0)
                {
                    collection.Piece = Convert.ToInt32(collectionPieceTextBox.Text);
                    collection.Return = Convert.ToInt32(returnTextBox.Text);
                    collection.Remaining = Convert.ToInt32(remainingTextBox.Text);
                    collection.TotalCollected = db.Collections.Select(m => m.Worker.WorkerName == (string)workerNameComboBox.SelectedItem).Any()
                        ? db.Collections.Sum(m => m.Piece + m.Return) : 0;
                    collection.PayableDeposit = (Convert.ToInt32(rateTextBox.Text) * Convert.ToInt32(collectionPieceTextBox.Text));

                    //Now save the data in dbContext Class
                    db.Collections.Add(collection);
                }
                else
                {
                    MessageBox.Show(@"You have not distributed product for collection Thank You!", @"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                int a = db.SaveChanges();

                if (a > 0)
                {
                    MessageBox.Show(@"Collection record save successfully.", @"Success", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    Clear();
                    workerNameComboBox.Focus();
                }
                else
                {
                    MessageBox.Show(@"Collection record save failed.", @"Failed", MessageBoxButtons.OK,
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

        private void pieceOfAmountTextBox_Leave(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(distributedTextBox.Text))
            {
                errorProvider4.SetError(this.distributedTextBox, "Please give piece of amount!");
                distributedTextBox.Focus();
            }
            else
            {
                errorProvider4.Clear();
            }
        }

        //TextBox Keypress events
        private void collectionPieceTextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void returnTextBox_KeyPress(object sender, KeyPressEventArgs e)
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
        private void workerNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (workerNameComboBox.SelectedItem == null ||
                (string)workerNameComboBox.SelectedItem == @"---Select Worker---")
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
                    totalDistributedTextBox.Text = (totalDistribute - (totalCollect + totalReturn)).ToString();

                    typeOfProductComboBox.DataSource = db.Distributions
                    .Where(m => m.Worker.WorkerName == (string)workerNameComboBox.SelectedItem)
                    .Select(m => m.Product.TypeOfProduct).Distinct()
                    .ToList();

                    productNameComboBox.DataSource = db.Distributions
                        .Where(m => m.Product.TypeOfProduct == (string)typeOfProductComboBox.SelectedItem)
                        .Select(m => m.Product.ProductName).Distinct()
                        .ToList();
                    if (productNameComboBox.SelectedItem == null)
                    {
                        rateTextBox.Clear();
                        distributedTextBox.Clear();
                    }
                }
            }
        }

        private void typeOfProductComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (typeOfProductComboBox.SelectedItem == null ||
                (string)typeOfProductComboBox.SelectedItem == "---Select Type of Product---")
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

        private void productNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            distributedTextBox.Clear();
            rateTextBox.Clear();
            remainingTextBox.Clear();
            if (productNameComboBox.SelectedItem != null)
            {
                var product = db.Distributions.Where(model =>
                    model.Product.ProductName == productNameComboBox.SelectedItem.ToString());

                var distributed = 0;
                if (productNameComboBox.SelectedIndex == -1)
                {
                    remainingTextBox.Text = 0.ToString();
                }
                else
                {
                    //Calculation For Distributed
                    var totalPieceFromDistribution = db.Distributions
                                     .Where(m => m.Worker.WorkerName == (string)workerNameComboBox.SelectedItem && m.Product.ProductName == (string)productNameComboBox.SelectedItem)
                                     .Sum(m => (int?)m.Piece) ?? 0;
                    var totalCollectedPieceFromCollection = db.Collections
                                                               .Where(m => m.Worker.WorkerName == (string)workerNameComboBox.SelectedItem && m.Product.ProductName == (string)productNameComboBox.SelectedItem)
                                                               .Sum(m => (int?)m.Piece) ?? 0;
                    var totalReturnFromCollection = db.Collections
                                                       .Where(m => m.Worker.WorkerName == (string)workerNameComboBox.SelectedItem && m.Product.ProductName == (string)productNameComboBox.SelectedItem)
                                                       .Sum(m => (int?)m.Return) ?? 0;

                    distributed = totalPieceFromDistribution - (totalCollectedPieceFromCollection + totalReturnFromCollection);
                }
                foreach (var item in product)
                {
                    rateTextBox.Text = item.Product.RateOfAmount.ToString();
                    distributedTextBox.Text = distributed.ToString();
                }
            }
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
            distributedTextBox.Clear();
            rateTextBox.Clear();
            workerNameComboBox.Focus();
            rateTextBox.Clear();
            collectionPieceTextBox.Clear();
            returnTextBox.Clear();
            remainingTextBox.Clear();
            totalDistributedTextBox.Clear();
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

            //Loading distributed through worker id.
            if (workerNameComboBox.SelectedItem != null)
            {
                var workerId = db.Workers.FirstOrDefault(x => x.WorkerName == (string)workerNameComboBox.SelectedItem);

                var distributed = db.Distributions.Where(model => workerId.WorkerId == model.WorkerId)
                                      .Sum(m => (int?)m.Piece) ?? 0;

                totalDistributedTextBox.Text = distributed.ToString();
            }
        }

        //TextBox TextChanged events
        private void collectionPieceTextBox_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(distributedTextBox.Text))
            {
                distributedTextBox.Text = 0.ToString();
            }
            else if (string.IsNullOrEmpty(collectionPieceTextBox.Text))
            {
                collectionPieceTextBox.Text = 0.ToString();
            }
            else if (string.IsNullOrEmpty(returnTextBox.Text))
            {
                returnTextBox.Text = 0.ToString();
            }
            else
            {
                int collectionOfPiece = Convert.ToInt32(collectionPieceTextBox.Text);
                int distributed = Convert.ToInt32(distributedTextBox.Text);
                int returnPiece = Convert.ToInt32(returnTextBox.Text);

                remainingTextBox.Text = (distributed - (collectionOfPiece + returnPiece)).ToString();
            }
        }

        private void returnTextBox_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(distributedTextBox.Text))
            {

            }
            else if (string.IsNullOrEmpty(collectionPieceTextBox.Text))
            {

            }
            else if (string.IsNullOrEmpty(returnTextBox.Text))
            {

            }
            else
            {
                var collectionOfPiece = Convert.ToInt32(collectionPieceTextBox.Text);
                var distributed = Convert.ToInt32(distributedTextBox.Text);
                var returnPiece = Convert.ToInt32(returnTextBox.Text);

                remainingTextBox.Text = (distributed - (collectionOfPiece + returnPiece)).ToString();
            }
        }
    }
}
