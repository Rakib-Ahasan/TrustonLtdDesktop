using System;
using System.Drawing;
using System.Windows.Forms;

namespace TrustonLtd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CustomDesign();
        }

        private void CustomDesign()
        {
            homePanel.Visible = false;
        }


        private void ShowPanel(Panel panel)
        {
            if (panel.Visible == false)
            {
                panel.Visible = true;
            }
            else
            {
                panel.Visible = false;
            }
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            ShowPanel(homePanel);

        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            ShowPanel(registrationPanel);
        }

        private void addWorker_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AddWorkerForm());
            //HideSubPanel();
        }

        private void addCustomer_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AddCustomerForm());
            //HideSubPanel();
        }

        private void stockInfoButton_Click(object sender, EventArgs e)
        {
            registrationPanel.Hide();
            OpenChildForm(new StockInForm());
        }

        private void statusButton_Click(object sender, EventArgs e)
        {
            registrationPanel.Hide();
            OpenChildForm(new StatusForm(ContainerPanel));
        }

        private void distributionButton_Click(object sender, EventArgs e)
        {
            homePanel.Visible = false;
            OpenChildForm(new DistributionForm());
        }

        private void collectionButton_Click(object sender, EventArgs e)
        {
            homePanel.Visible = false;
            OpenChildForm(new CollectionForm());
        }

        private void paymentButton_Click(object sender, EventArgs e)
        {
            homePanel.Visible = false;
            OpenChildForm(new PaymentMainForm(ContainerPanel));

        }

        private void salesButton_Click(object sender, EventArgs e)
        {
            homePanel.Visible = false;
            OpenChildForm(new SalesForm());

        }

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

            // childForm.Visible = true;
            childForm.BringToFront();
            childForm.Show();
        }
        //private System.Windows.Forms.Panel ContainerPanel;

        //private Form activeForm = null;

        //private void OpenChildForm(Form childForm)
        //{
        //    if (activeForm != null)
        //        activeForm.Close();
        //    activeForm = childForm;
        //    activeForm.TopLevel = false;
        //    activeForm.FormBorderStyle = FormBorderStyle.None;
        //    childForm.Dock = DockStyle.Fill;
        //    ContainerPanel.Controls.Add(childForm);
        //    ContainerPanel.Tag = childForm;

        //    //childForm.Visible = true;
        //    childForm.BringToFront();
        //    childForm.Show();
        //}

        private void stockInButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new StockInForm());
        }
        private void coastButton_Click(object sender, EventArgs e)
        {
            homePanel.Visible = false;
            OpenChildForm(new CostForm());
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            labelhr.Text = DateTime.Now.ToString("hh:mm tt");
            labelsec.Text = DateTime.Now.ToString("ss");
            labeldate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            labelday.Text = DateTime.Now.ToString("dddd");
            labelsec.Location = new Point(labelhr.Location.X + labelhr.Width - 5, labelsec.Location.Y);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void BuyButton_Click(object sender, EventArgs e)
        {
            homePanel.Visible = false;
            OpenChildForm(new BuyForm(ContainerPanel));
        }

        private void addProduct_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AddProductForm());
        }
    }
}
