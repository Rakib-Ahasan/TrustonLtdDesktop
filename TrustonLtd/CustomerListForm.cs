using System;
using System.Linq;
using System.Windows.Forms;

namespace TrustonLtd
{
    public partial class CustomerListForm : Form
    {
        TrustonEntities db = new TrustonEntities();
        public CustomerListForm()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private class DataBindingProjection
        {
            public int CustomerId { get; set; }
            public string CustomerName { get; set; }
            public string Address { get; set; }
            public string Contact { get; set; }
            public string ReferenceName { get; set; }
            public string ReferenceContact { get; set; }
            public int TotalSaleOfPiece { get; set; }
            public int TotalReturn { get; set; }
            public int TotalDue { get; set; }

        }

        private void CustomerListForm_Load(object sender, EventArgs e)
        {

            var customer = from c in db.Customers
                           join s in db.Sales on c.CustomerId equals s.CustomerId
                           join cp in db.CustomerPayments on c.CustomerId equals cp.CustomerId
                           group c by new { c.CustomerId }
                into y
                           from customer1 in db.Customers.DefaultIfEmpty().ToList()
                           select new DataBindingProjection
                           {
                               CustomerId = customer1.CustomerId,
                               CustomerName = customer1.ShopName,
                               Address = customer1.Address,
                               Contact = customer1.Contact,
                               ReferenceName = customer1.ReferenceName,
                               ReferenceContact = customer1.RefereceContact,

                               TotalSaleOfPiece = customer1.Sales.Sum(m => (int?)m.Piece) ?? 0,
                               TotalReturn = customer1.Sales.Sum(m => (int?)m.ReturnPiece) ?? 0,

                               TotalDue = ((customer1.Sales.Sum(m => (int?)m.NetTotalBill) ?? 0) -
                                           ((customer1.Sales.Sum(m => (int?)m.Pay) ?? 0) +
                                            (customer1.Sales.Sum(m => (int?)m.LessPrice) ?? 0) +
                                            (customer1.Sales.Sum(m => (int?)m.TotalReturnPrice) ?? 0) +
                                            (customer1.CustomerPayments.Sum(m => (int?)m.Payment) ?? 0)))

                           };

            customerDataGridView.DataSource = customer.Distinct().ToList();
        }
    }
}
