using System;
using System.Windows.Forms;
using TrustonLtd.Models;

namespace TrustonLtd
{
    public partial class BuyPrideForm : Form
    {
        TrustonEntities db = new TrustonEntities();
        public BuyPrideForm()
        {
            InitializeComponent();
        }

        //Buttons operations
        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Create a object for store current data
                BuyPrideOrYearn buyPride = new BuyPrideOrYearn();
                buyPride.Date = System.DateTime.Now;
                buyPride.TypeOfProduct = typeOfProductTextBox.Text;
                buyPride.Piece = Convert.ToInt32(pieceTextBox.Text);
                buyPride.Rate = Convert.ToInt32(rateTextBox.Text);
                buyPride.TotalAmount = Convert.ToInt32(totalAmountTextBox.Text);


                //Now save the data in dbContext Class
                db.BuyPrideOrYearns.Add(buyPride);
                int a = db.SaveChanges();

                if (a > 0)
                {
                    MessageBox.Show(@"Buy pride record save successfully.", @"Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                    pieceTextBox.Focus();
                }
                else
                {
                    MessageBox.Show(@"Buy pride record save failed.", @"Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show(@"Some information is missing please check again!", @"Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ResetButton_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Hide();
        }


        //Methods
        private void Clear()
        {
            pieceTextBox.Clear();
            rateTextBox.Clear();
            totalAmountTextBox.Clear();
            pieceTextBox.Focus();
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

        private void rateTextBox_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(rateTextBox.Text) && string.IsNullOrEmpty(pieceTextBox.Text))
            {
                errorProvider1.SetError(this.pieceTextBox, "Please enter piece first!");
                pieceTextBox.Focus();
            }
            else if(String.IsNullOrEmpty(rateTextBox.Text) && !string.IsNullOrEmpty(pieceTextBox.Text))
            {
                errorProvider2.SetError(this.rateTextBox, "Please enter rate !");
                rateTextBox.Focus();
            }
            else
            {
                errorProvider2.Clear();
            }
        }

        private void rateTextBox_TextChanged(object sender, EventArgs e)
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
    }
}
