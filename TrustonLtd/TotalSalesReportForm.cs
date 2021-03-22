using System;
using System.Linq;
using System.Windows.Forms;

namespace TrustonLtd
{
    public partial class TotalSalesReportForm : Form
    {
        TrustonEntities db = new TrustonEntities();
        public TotalSalesReportForm()
        {
            InitializeComponent();
            searchByNameComboBox.DataSource = db.Sales.Select(m => m.SalesBy).Distinct().ToList();
        }

        private class DataBindingProjection
        {
            public DateTime Date { get; set; }
            public int PreviousDue { get; set; }
            public string ProductName { get; set; }
            public int Piece { get; set; }
            public int Rate { get; set; }
            public int NetTotalBill { get; set; }
            public string ReturnProductName { get; set; }
            public int ReturnRate { get; set; }
            public int ReturnPiece { get; set; }
            public int ReturnTotalBill { get; set; }
            public int TotalBill { get; set; }
            public int LessPrice { get; set; }
            public int Payment { get; set; }
            public int Due { get; set; }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            var salesReport = from c in db.Sales.Where(s => db.Sales.Any(ss => s.DateTime >= fromDataTime.Value && s.DateTime <= toDateTime.Value) && s.SalesBy == (string)searchByNameComboBox.SelectedItem)
                              join s in db.Sales on c.Customer.ShopName equals s.Customer.ShopName
                              join p in db.Products on s.Product.ProductId equals p.ProductId
                              select new DataBindingProjection
                              {
                                  Date = s.DateTime,
                                  PreviousDue = s.PreviousDue,
                                  ProductName = s.Product.ProductName,
                                  Rate = s.Rate,
                                  Piece = s.Piece,
                                  NetTotalBill = s.NetTotalBill,
                                  ReturnProductName = s.Product.ProductName,
                                  ReturnPiece = s.ReturnPiece,
                                  ReturnRate = s.Rate,
                                  ReturnTotalBill = s.TotalReturnPrice,
                                  TotalBill = s.TotalBill,
                                  LessPrice = s.LessPrice,
                                  Payment = s.Pay,
                                  Due = s.Due
                              };
            dataGridView1.DataSource = salesReport.ToList();
        }
    }
}
