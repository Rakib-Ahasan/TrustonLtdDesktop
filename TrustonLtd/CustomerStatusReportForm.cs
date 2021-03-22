using System;
using System.Linq;
using System.Windows.Forms;

namespace TrustonLtd
{
    public partial class CustomerStatusReportForm : Form
    {
        TrustonEntities db = new TrustonEntities();
        public CustomerStatusReportForm(string customerName, string address, string contact, string refName, string refContact, int due)
        {
            InitializeComponent();
            customerNameTextBox.Text = customerName;
            addressTextBox.Text = address;
            contactNameTextBox.Text = contact;
            refNameTextBox.Text = refName;
            refContactTextBox.Text = refContact;
            totalDueTextBox.Text = due.ToString();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private class DataBindingProjection1
        {
            public DateTime Date { get; set; }
            public int PreviousDue { get; set; }
            public string SalesBy { get; set; }
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
        private class DataBindingProjection2
        {
            public DateTime Date { get; set; }
            public int Payment { get; set; }
        }
        private void SalesDetailsButton_Click(object sender, EventArgs e)
        {
            var customer = from c in db.Customers.Where(m => m.ShopName == customerNameTextBox.Text)
                           join s in db.Sales on c.ShopName equals s.Customer.ShopName
                           join p in db.Products on s.Product.ProductId equals p.ProductId
                           orderby s.DateTime descending

                           select new DataBindingProjection1
                           {
                               Date = s.DateTime,
                               PreviousDue = s.PreviousDue,
                               SalesBy = s.SalesBy,
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
            dataGridView1.DataSource = customer.ToList();
        }

        private void paymentDetailsButton_Click(object sender, EventArgs e)
        {
            var customer = from c in db.Customers.Where(m => m.ShopName == customerNameTextBox.Text)
                           join cp in db.CustomerPayments on c.ShopName equals cp.Customer.ShopName
                           orderby cp.DateTime descending

                           select new DataBindingProjection2
                           {
                               Date = cp.DateTime,
                               Payment = cp.Payment,
                           };
            dataGridView1.DataSource = customer.ToList();
        }
    }
}
