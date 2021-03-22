using System;
using System.Linq;
using System.Windows.Forms;

namespace TrustonLtd
{
    public partial class TotalStockInReportForm : Form
    {
        TrustonEntities db = new TrustonEntities();
        public TotalStockInReportForm()
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
            public string TypeOfProduct { get; set; }
            public string ProductName { get; set; }
            public int Piece { get; set; }
            public int Rate { get; set; }
        }
        //Methods
        private void LoadData()
        {
            var product = from s in db.StockIns
                          join p in db.Products on s.ProductId equals p.ProductId
                          select new DataBindingProjection()
                          {
                              Date = s.Date,
                              TypeOfProduct = s.Product.TypeOfProduct,
                              ProductName = s.Product.ProductName,
                              Piece = s.Piece,
                              Rate = s.Product.RateOfAmount
                          };
            dataGridView1.DataSource = product.ToList();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            var product = from s in db.StockIns.Where(s => db.StockIns.Any(ss => s.Date >= fromDateTime.Value && s.Date <= toDateTime.Value))
                          join p in db.Products on s.ProductId equals p.ProductId
                          select new DataBindingProjection()
                          {
                              Date = s.Date,
                              TypeOfProduct = s.Product.TypeOfProduct,
                              ProductName = s.Product.ProductName,
                              Piece = s.Piece,
                              Rate = s.Product.RateOfAmount
                          };
            dataGridView1.DataSource = product.ToList();
        }
    }
}
