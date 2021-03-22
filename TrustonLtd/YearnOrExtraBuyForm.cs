using System;
using System.Windows.Forms;
using TrustonLtd.Models;

namespace TrustonLtd
{
    public partial class YearnOrExtraBuyForm : Form
    {
        TrustonEntities db = new TrustonEntities();
        public YearnOrExtraBuyForm()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Create a object for store current data
                BuyPrideOrYearn buyYearn = new BuyPrideOrYearn();
                buyYearn.Date = DateTime.Now;
                buyYearn.TypeOfProduct = typeOfProductTextBox.Text;
                buyYearn.Piece = Convert.ToInt32(pieceTextBox.Text);
                buyYearn.Rate = Convert.ToInt32(rateTextBox.Text);
                buyYearn.TotalAmount = Convert.ToInt32(totalAmountTextBox.Text);


                //Now save the data in dbContext Class
                db.BuyPrideOrYearns.Add(buyYearn);
                int a = db.SaveChanges();

                if (a > 0)
                {
                    MessageBox.Show(@"Buy yearn record save successfully.", @"Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                    pieceTextBox.Focus();
                }
                else
                {
                    MessageBox.Show(@"Buy yearn record save failed.", @"Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show(@"Some information is missing please check again!", @"Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            Clear();
        }

        //Methods
        private void Clear()
        {
            pieceTextBox.Clear();
            rateTextBox.Clear();
            totalAmountTextBox.Clear();
            pieceTextBox.Focus();
        }

        private void pieceTextBox_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(pieceTextBox.Text))
            {
                errorProvider1.SetError(this.pieceTextBox, "Please enter  piece of number!");
                pieceTextBox.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void rateTextBox_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(rateTextBox.Text))
            {
                errorProvider2.SetError(this.rateTextBox, "Please enter rate amount!");
                rateTextBox.Focus();
            }
            else
            {
                errorProvider2.Clear();
            }
        }

        private void totalAmountTextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void totalAmountTextBox_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(totalAmountTextBox.Text) && string.IsNullOrEmpty(pieceTextBox.Text))
            {
                errorProvider1.SetError(this.pieceTextBox, "Please enter  piece first!");
                pieceTextBox.Focus();
            }
            else if (string.IsNullOrEmpty(totalAmountTextBox.Text) && !string.IsNullOrEmpty(pieceTextBox.Text))
            {
                errorProvider3.SetError(this.totalAmountTextBox, "Please enter total amount!");
                totalAmountTextBox.Focus();
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
    }
}
