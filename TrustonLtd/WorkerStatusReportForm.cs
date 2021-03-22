using System;
using System.Linq;
using System.Windows.Forms;

namespace TrustonLtd
{
    public partial class WorkerStatusReportForm : Form
    {
        TrustonEntities db = new TrustonEntities();
        public WorkerStatusReportForm(string workerName, string address, string contact, string refName, string refContact)
        {
            InitializeComponent();

            workerNameTextBox.Text = workerName;
            addressTextBox.Text = address;
            contactTextBox.Text = contact;
            refNameTextBox.Text = refName;
            refContactTextBox.Text = refContact;
        }

        private void BackButton_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }
        //Methods
        private class DataBindingProjection1
        {
            public DateTime Date { get; set; }
            public string ProductName { get; set; }
            public int DistributedPiece { get; set; }
        }
        private class DataBindingProjection2
        {
            public DateTime Date { get; set; }
            public string ProductName { get; set; }
            public int CollectedPiece { get; set; }
            public int Deposit { get; set; }
            public int ReturnPiece { get; set; }
        }
        private class DataBindingProjection3
        {
            public DateTime Date { get; set; }
            public int Payment { get; set; }
        }

        private void distributionDetailsButton_Click(object sender, EventArgs e)
        {
            try
            {
                var worker1 = from w in db.Workers.Where(m => m.WorkerName == workerNameTextBox.Text)
                              join d in db.Distributions on w.WorkerId equals d.WorkerId
                              join p in db.Products on d.ProductId equals p.ProductId
                              select new DataBindingProjection1
                              {
                                  Date = d.DateTime,
                                  ProductName = d.Product.ProductName,
                                  DistributedPiece = d.Piece,
                              };
                dataGridView1.DataSource = worker1.Distinct().ToList();
            }
            catch (Exception)
            {
                //ignored
            }
        }

        private void collectionDetailsButton_Click(object sender, EventArgs e)
        {
            var worker1 = from w in db.Workers.Where(m => m.WorkerName == workerNameTextBox.Text)

                          join c in db.Collections on w.WorkerId equals c.WorkerId
                          join p in db.Products on c.ProductId equals p.ProductId
                          orderby c.DateTime descending


                          select new DataBindingProjection2
                          {
                              Date = c.DateTime,
                              ProductName = c.Product.ProductName,
                              CollectedPiece = c.Piece,
                              Deposit = c.PayableDeposit,
                              ReturnPiece = c.Return
                          };
            dataGridView1.DataSource = worker1.Distinct().ToList();
        }

        private void paymentDetailsButton_Click(object sender, EventArgs e)
        {
            var worker1 = from w in db.Workers.Where(m => m.WorkerName == workerNameTextBox.Text)

                          join wp in db.WorkerPayments on w.WorkerId equals wp.WorkerId
                          orderby wp.DateTime descending
                          select new DataBindingProjection3
                          {
                              Date = wp.DateTime,

                              Payment = wp.Payment,
                          };
            dataGridView1.DataSource = worker1.Distinct().ToList();
        }
    }
}
