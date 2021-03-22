using System;
using System.Windows.Forms;
using TrustonLtd.Models;

namespace TrustonLtd
{
    public partial class CostForm : Form
    {
        TrustonEntities db = new TrustonEntities();
        public CostForm()
        {
            InitializeComponent();
        }

        //Buttons Operations
        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                Cost cost = new Cost();
                cost.Date = System.DateTime.Now;
                cost.CostBy = costByTextBox.Text;
                cost.TypeOfCost = typeOfCostTextBox.Text;
                cost.CostAmount = Convert.ToInt32(CostAmountTextBox.Text);

                //Now save the data in dbContext Class
                db.Costs.Add(cost);
                int a = db.SaveChanges();
                if (a > 0)
                {
                    MessageBox.Show(@"Cost record save successfully.", @"Success", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    Clear();
                    costByTextBox.Focus();
                }
                else
                {
                    MessageBox.Show(@"Cost record save failed.", @"Failed", MessageBoxButtons.OK,
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


        //Methods
        private void Clear()
        {
            costByTextBox.Clear();
            typeOfCostTextBox.Clear();
            CostAmountTextBox.Clear();
            costByTextBox.Focus();
        }
        private void typeOfCostTextBox_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(typeOfCostTextBox.Text))
            {
                errorProvider2.SetError(this.typeOfCostTextBox, "Please enter cost type!");
                typeOfCostTextBox.Focus();
            }
            else
            {
                errorProvider2.Clear();
            }
        }

        private void typeOfCostTextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void CostAmountTextBox_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(CostAmountTextBox.Text))
            {
                errorProvider1.SetError(this.CostAmountTextBox,"Please enter cost amount!");
                CostAmountTextBox.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void CostAmountTextBox_KeyPress(object sender, KeyPressEventArgs e)
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
        private void costByTextBox_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(costByTextBox.Text))
            {
                errorProvider3.SetError(this.costByTextBox, "Please enter cost by name!");
                costByTextBox.Focus();
            }
            else
            {
                errorProvider3.Clear();
            }
        }

        private void costByTextBox_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
