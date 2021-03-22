using System;
using System.Linq;
using System.Windows.Forms;

namespace TrustonLtd
{
    public partial class TotalBuyPrideOrYearnReportForm : Form
    {
        TrustonEntities db = new TrustonEntities();
        public TotalBuyPrideOrYearnReportForm()
        {
            InitializeComponent();
            LoadData();
        }
        private class DataBindingProjection
        {
            public DateTime Date { get; set; }
            public string ProductName { get; set; }
            public int Piece { get; set; }
            public int Rate { get; set; }
            public int TotalAmount { get; set; }
        }
        private void LoadData()
        {
            var buyPrideOrYearn = from t in db.BuyPrideOrYearns

                                  select new DataBindingProjection()
                                  {
                                      Date = t.Date,
                                      ProductName = t.TypeOfProduct,
                                      Piece = t.Piece,
                                      Rate = t.Rate,
                                      TotalAmount = t.TotalAmount
                                  };
            dataGridView1.DataSource = buyPrideOrYearn.ToList();
        }
        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            var buyPrideOrYearn = from t in db.BuyPrideOrYearns.Where(s => db.Costs.Any(ss => s.Date >= fromDateTime.Value && s.Date <= toDateTime.Value))
                                  select new DataBindingProjection()
                                  {

                                      Date = t.Date,
                                      ProductName = t.TypeOfProduct,
                                      Piece = t.Piece,
                                      Rate = t.Rate,
                                      TotalAmount = t.TotalAmount

                                  };
            dataGridView1.DataSource = buyPrideOrYearn.ToList();
        }
    }
}
