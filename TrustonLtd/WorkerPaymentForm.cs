using System;
using System.Linq;
using System.Windows.Forms;
using TrustonLtd.Models;

namespace TrustonLtd
{
    public partial class WorkerPaymentForm : Form
    {
        TrustonEntities db = new TrustonEntities();

        public WorkerPaymentForm()
        {
            InitializeComponent();
            LoadData();
        }

        //Buttons operations

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                WorkerPayment workerPayment = new WorkerPayment();
                var worker = db.Workers.FirstOrDefault(model => model.WorkerName == (string)workerNameComboBox.SelectedItem);
                if (worker != null) workerPayment.WorkerId = worker.WorkerId;


                workerPayment.PayableAmount = Convert.ToInt32(payableAmountTextBox.Text);
                workerPayment.DateTime = DateTime.Now;
                workerPayment.Payment = Convert.ToInt32(paymentTextBox.Text);
                workerPayment.RepayableAmount = Convert.ToInt32(repayableTextBox.Text);

                //Now save the data in dbContext Class
                db.WorkerPayments.Add(workerPayment);
                int a = db.SaveChanges();

                if (a > 0)
                {
                    MessageBox.Show(@"Worker payment record save successfully.", @"Success", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    Clear();
                    workerNameComboBox.Focus();
                }
                else
                {
                    MessageBox.Show(@"Worker payment record save failed.", @"Failed", MessageBoxButtons.OK,
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
            var data = db.Workers.ToList();
            workerNameComboBox.Items.Add("---Select Worker---");
            foreach (var item in data)
            {
                workerNameComboBox.Items.Add(item.WorkerName);
            }

        }

        private void Clear()
        {
            workerNameComboBox.SelectedItem = null;
            addressTextBox.Clear();
            contactTextBox.Clear();
            referenceNameTextBox.Clear();
            refContactTextBox.Clear();
            payableAmountTextBox.Clear();
            paymentTextBox.Clear();
            confirmPaymentTextBox.Clear();
            repayableTextBox.Clear();
            workerNameComboBox.Focus();
        }

        //TextBox leave events
        private void workerNameComboBox_Leave(object sender, EventArgs e)
        {
            if (workerNameComboBox.SelectedItem == null)
            {
                errorProvider1.SetError(this.workerNameComboBox, "Please select an item!");
                workerNameComboBox.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void paymentTextBox_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(paymentTextBox.Text))
            {
                errorProvider2.SetError(this.paymentTextBox, "Please enter payment amount!");
                paymentTextBox.Focus();
            }
            else
            {
                errorProvider2.Clear();
            }
        }

        private void confirmPaymentTextBox_Leave(object sender, EventArgs e)
        {

            if (confirmPaymentTextBox.Text != paymentTextBox.Text)
            {
                errorProvider3.SetError(this.confirmPaymentTextBox, "Payment amount not match!");
                confirmPaymentTextBox.Focus();
            }
            else
            {
                errorProvider3.Clear();
            }
        }

        //TextBox keypress events
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
                    var payableDepositFromCollection =
                        (db.Collections.Where(m => m.Worker.WorkerName == (string)workerNameComboBox.SelectedItem)
                             .Sum(m => (int?)m.PayableDeposit) ?? 0).ToString();
                    var totalPaymentFromWorkerPayment = (db.WorkerPayments.Where(m => m.Worker.WorkerName == (string)workerNameComboBox.SelectedItem)
                                                            .Sum(m => (int?)m.Payment) ?? 0).ToString();
                    payableAmountTextBox.Text = (Convert.ToInt32(payableDepositFromCollection) - Convert.ToInt32(totalPaymentFromWorkerPayment)).ToString();
                }
            }
        }

        //TextBox text changed events
        private void confirmPaymentTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(confirmPaymentTextBox.Text))
            {

            }
            else
            {
                repayableTextBox.Text =
                    (Convert.ToInt32(payableAmountTextBox.Text) - Convert.ToInt32(confirmPaymentTextBox.Text)).ToString();

            }
        }
    }
}
