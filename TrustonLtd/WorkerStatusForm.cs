using System;
using System.Linq;
using System.Windows.Forms;

namespace TrustonLtd
{
    public partial class WorkerStatusForm : Form
    {
        TrustonEntities db = new TrustonEntities();
        public WorkerStatusForm(Panel containerPanel)
        {
            _containerPanel = containerPanel;
            InitializeComponent();
            LoadData();
        }

        //Methods
        private void LoadData()
        {
            var data = db.Workers.ToList();
            workerNameComboBox.Items.Add("---Select Worker Name---");
            foreach (var item in data)
            {
                workerNameComboBox.Items.Add(item.WorkerName);
            }
        }

        private void Clear()
        {
            workerNameComboBox.Items.Clear();
            workerNameTextBox.Clear();
            contactTextBox.Clear();
            addressTextBox.Clear();
            referenceNameTextBox.Clear();
            refContactTextBox.Clear();
            totalDistributedTextBox.Clear();
            totalCollectedTextBox.Clear();
            totalPayableTextBox.Clear();
            workerNameComboBox.Focus();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            Clear();
            LoadData();
        }

        private void workerNameComboBox_Leave(object sender, EventArgs e)
        {
            if (workerNameComboBox.SelectedItem == null)
            {
                errorProvider1.SetError(this.workerNameComboBox, "Please select an item");
                workerNameComboBox.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void ViewReportButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new WorkerStatusReportForm(workerNameComboBox.Text, addressTextBox.Text, contactTextBox.Text, referenceNameTextBox.Text, refContactTextBox.Text));
        }
        private readonly Panel _containerPanel;

        private Form _activeForm;

        private void OpenChildForm(Form childForm)
        {
            _activeForm?.Close();
            _activeForm = childForm;
            _activeForm.TopLevel = false;
            _activeForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            _containerPanel.Controls.Add(childForm);
            _containerPanel.Tag = childForm;

            //childForm.Visible = true;
            childForm.BringToFront();
            childForm.Show();
        }

        private void workerNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (workerNameComboBox.SelectedItem == null || (string)workerNameComboBox.SelectedItem == @"---Select Worker---")
            {

            }
            else
            {
                var data = db.Workers.Where(model =>
                    model.WorkerName == workerNameComboBox.SelectedItem.ToString());
                foreach (var item in data)
                {
                    workerNameTextBox.Text = item.WorkerName;
                    addressTextBox.Text = item.Address;
                    contactTextBox.Text = item.Contact;
                    referenceNameTextBox.Text = item.ReferenceName;
                    refContactTextBox.Text = item.RefereceContact;
                    totalDistributedTextBox.Text =
                        (db.Distributions.Where(m => m.Worker.WorkerName == (string)workerNameComboBox.SelectedItem)
                             .Sum(m => (int?)m.Piece) ?? 0).ToString();
                    totalCollectedTextBox.Text =
                        (db.Collections.Where(m => m.Worker.WorkerName == (string)workerNameComboBox.SelectedItem)
                             .Sum(m => (int?)m.Piece) ?? 0).ToString();

                    var payableDepositFromCollection =
                        (db.Collections.Where(m => m.Worker.WorkerName == (string)workerNameComboBox.SelectedItem)
                             .Sum(m => (int?)m.PayableDeposit) ?? 0).ToString();
                    var totalPaymentFromWorkerPayment = (db.WorkerPayments.Where(m => m.Worker.WorkerName == (string)workerNameComboBox.SelectedItem)
                                                             .Sum(m => (int?)m.Payment) ?? 0).ToString();
                    totalPayableTextBox.Text = (Convert.ToInt32(payableDepositFromCollection) - Convert.ToInt32(totalPaymentFromWorkerPayment)).ToString();
                }
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            var exitsInstance = (from row in db.Workers
                                 where row.WorkerName == workerNameTextBox.Text
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
                    var worker = db.Workers.FirstOrDefault(m => m.WorkerName == (string)workerNameComboBox.SelectedItem);
                    if (worker != null)
                    {
                        worker.WorkerName = workerNameTextBox.Text;
                        worker.Address = addressTextBox.Text;
                        worker.Contact = contactTextBox.Text;
                        worker.ReferenceName = referenceNameTextBox.Text;
                        worker.RefereceContact = refContactTextBox.Text;
                    }


                    int a = db.SaveChanges();
                    Clear();

                    if (0 < a)
                    {
                        MessageBox.Show(@"Worker record Update successfully.", @"Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear();
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show(@"Worker record Update failed.", @"Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
