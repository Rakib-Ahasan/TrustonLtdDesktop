using System;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Linq;
using System.Windows.Forms;

namespace TrustonLtd
{
    public partial class WorkerLIstForm : Form
    {
        TrustonEntities db = new TrustonEntities();
        public WorkerLIstForm()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private class DataBindingProjection
        {
            public int WorkerId { get; set; }
            public string WorkerName { get; set; }
            public string Address { get; set; }
            public string Contact { get; set; }
            public string ReferenceName { get; set; }
            public string ReferenceContact { get; set; }
            public int TotalDistribute { get; set; }
            public int TotalCollection { get; set; }
            public int TotalDeposit { get; set; }
            public int TotalPayment { get; set; }
            public int TotalPayable { get; set; }
        }

        private void WorkerLIstForm_Load(object sender, EventArgs e)
        {

            var worker = from w in db.Workers
                         join d in db.Distributions on w.WorkerId equals d.WorkerId
                         join c in db.Collections on d.WorkerId equals c.WorkerId
                         join wp in db.WorkerPayments on w.WorkerId equals wp.WorkerId

                         group w by new { w.WorkerId } into y
                         from worker1 in db.Workers.DefaultIfEmpty().ToList()
                         select new DataBindingProjection
                         {
                             WorkerId = worker1.WorkerId,
                             WorkerName = worker1.WorkerName,
                             Address = worker1.Address,
                             Contact = worker1.Contact,
                             ReferenceName = worker1.ReferenceName,
                             ReferenceContact = worker1.RefereceContact,

                             TotalDistribute = worker1.Distributions.Sum(m => (int?)m.Piece) ?? 0,
                             TotalCollection = worker1.Collections.Sum(m => (int?)m.Piece) ?? 0,
                             TotalDeposit = worker1.Collections.Sum(m => (int?)m.PayableDeposit) ?? 0,
                             TotalPayment = worker1.WorkerPayments.Sum(m => (int?)m.Payment) ?? 0,
                             TotalPayable = ((worker1.Collections.Sum(m => (int?)m.PayableDeposit) ?? 0) - (worker1.WorkerPayments.Sum(m => (int?)m.Payment) ?? 0))
                         };
            workerDataGridView.DataSource = worker.ToList();
        }
    }
}


