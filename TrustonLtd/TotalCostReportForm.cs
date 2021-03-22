using System;
using System.Linq;
using System.Windows.Forms;

namespace TrustonLtd
{
    public partial class TotalCostReportForm : Form
    {
        TrustonEntities db = new TrustonEntities();
        public TotalCostReportForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private class DataBindingProjection
        {
            public DateTime Date { get; set; }
            public string TypeOfCost { get; set; }
            public int CostAmount { get; set; }
        }
        //Methods
        private void LoadData()
        {
            var cost = from c in db.Costs.OrderByDescending(m => m.Date)
                       select new DataBindingProjection()
                       {
                           Date = c.Date,
                           TypeOfCost = c.TypeOfCost,
                           CostAmount = c.CostAmount
                       };
            dataGridView1.DataSource = cost.ToList();

        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            var cost = from tc in db.Costs.Where(s => db.Costs.Any(ss => s.Date >= fromDateTime.Value && s.Date <= toDateTime.Value))
                       select new DataBindingProjection()
                       {
                           Date = tc.Date,
                           TypeOfCost = tc.TypeOfCost,
                           CostAmount = tc.CostAmount,

                       };
            dataGridView1.DataSource = cost.ToList();

            int totalCost = db.Costs.Where(s => db.Costs.Any(ss => s.Date >= fromDateTime.Value && s.Date <= toDateTime.Value)).Sum(m => (int?)m.CostAmount) ?? 0;
            totalCostLable.Text = totalCost.ToString();
        }
    }
}
