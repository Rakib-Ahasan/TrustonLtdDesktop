using System;
using System.Linq;
using System.Windows.Forms;

namespace TrustonLtd
{
    public partial class TotalBuyEmbroideryOrnaOrThreePieceReportForm : Form
    {
        TrustonEntities db = new TrustonEntities();
        public TotalBuyEmbroideryOrnaOrThreePieceReportForm(DateTime dateFrom, DateTime dateTo, string typeOfProduct, string pName, int totalAmount)
        {
            InitializeComponent();
            fromDateTime.Value = dateFrom;
            toDateTime.Value = dateTo;
            typeOfProductTextBox.Text = typeOfProduct;
            productNameTextBox.Text = pName;
            totalAmountTextBox.Text = totalAmount.ToString();
            LoadData();
        }

        private class DataBindingProjection3
        {
            public DateTime Date { get; set; }
            public string TypeOfProduct { get; set; }
            public string ProductName { get; set; }
            public int Piece { get; set; }
            public int Rate { get; set; }
            public int TotalAmount { get; set; }
        }
        private void LoadData()
        {
            var data = from d in db.BuyEmbroideryOrnaOrThreePieces.Where(s => db.BuyEmbroideryOrnaOrThreePieces.Any(ss => s.DateTime >= fromDateTime.Value && s.DateTime <= toDateTime.Value))
                       join p in db.Products on d.ProductId equals p.ProductId
                       select new DataBindingProjection3()
                       {
                           Date = d.DateTime,
                           TypeOfProduct = d.Product.TypeOfProduct,
                           ProductName = d.Product.ProductName,
                           Piece = d.Piece,
                           Rate = d.Product.RateOfAmount,
                           TotalAmount = d.TotalAmount
                       };
            dataGridView1.DataSource = data.ToList();

        }
        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
