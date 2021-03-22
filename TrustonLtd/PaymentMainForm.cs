using System;
using System.Windows.Forms;

namespace TrustonLtd
{
    public partial class PaymentMainForm : Form
    {
        public PaymentMainForm(Panel containerPanel)
        {
            ContainerPanel = containerPanel;
            InitializeComponent();
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
        private void workerPaymentTile_Click(object sender, EventArgs e)
        {
            OpenChildForm(new WorkerPaymentForm());

        }
        private void customerPaymentTile_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CustomerPaymentForm());
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

