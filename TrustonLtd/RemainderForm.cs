using System;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace TrustonLtd
{
    public partial class RemainderForm : Form
    {
        TrustonEntities db = new TrustonEntities();
        public RemainderForm()
        {
            InitializeComponent();
        }

        private class DataBindingProjection
        {
            public DateTime DistributionDate { get; set; }
            public string WorkersName { get; set; }
            public string Address { get; set; }
            public string Contact { get; set; }
            public string ProductName { get; set; }
            public int DistributedPiece { get; set; }
            public string HowManyDays { get; set; }
        }
        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void RemainderForm_Load(object sender, EventArgs e)
        {
            var worker = from w in db.Workers
                         join d in db.Distributions on w.WorkerId equals d.WorkerId
                         join p in db.Products on d.ProductId equals p.ProductId
                         orderby d.DateTime
                         select new DataBindingProjection
                         {
                             DistributionDate = d.DateTime,
                             WorkersName = d.Worker.WorkerName,
                             Address = d.Worker.Address,
                             Contact = d.Worker.Contact,
                             ProductName = d.Product.ProductName,
                             DistributedPiece =
                                 (db.Distributions
                                      .Where(m => m.Worker.WorkerId == w.WorkerId &&
                                                  m.Product.ProductId == p.ProductId).Sum(m => (int?)m.Piece) ?? 0
                                  ) - (db.Collections
                                            .Where(m => m.Worker.WorkerId == w.WorkerId &&
                                                        m.Product.ProductId == p.ProductId)
                                            .Sum(m => (int?)m.Piece + (int?)m.Return) ?? 0),
                             HowManyDays = DbFunctions.DiffDays(d.DateTime, DateTime.Now).Value + " days ago."
                         };

            dataGridView1.DataSource = worker.Where(w => w.DistributedPiece > 0).ToList();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Cells[3].Style.ForeColor = Color.Green;
                row.Cells[6].Style.ForeColor = Color.Red;
            }
        }
    }
}
