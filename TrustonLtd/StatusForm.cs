using System;
using System.Windows.Forms;

namespace TrustonLtd
{
    public partial class StatusForm : Form
    {
        public StatusForm(Panel containerPanel)
        {
           _containerPanel = containerPanel;
            InitializeComponent();
        }
        private readonly Panel _containerPanel;

        private Form _activeForm;

        //Methods

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

        private void BusinessStatusTile_Click(object sender, EventArgs e)
        {
            OpenChildForm(new BusinessStatusForm(_containerPanel));
        }

        private void workerStatusTile_Click(object sender, EventArgs e)
        {
            OpenChildForm(new WorkerStatusForm(_containerPanel));
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new RemainderForm());
        }

        private void customerStatusTile_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CustomerStatusForm(_containerPanel));
        }

        private void workerListTile_Click(object sender, EventArgs e)
        {
            OpenChildForm(new WorkerLIstForm());
        }

        private void customerListTile_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CustomerListForm());
        }

        private void stockStatusTile_Click(object sender, EventArgs e)
        {
            OpenChildForm(new StockStatusForm());
        }
    }
}
