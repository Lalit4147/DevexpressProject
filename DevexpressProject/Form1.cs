using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace DevexpressProject
{
    public partial class Form1 : XtraForm1
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Orders obj = ordersBindingSource.Current as Orders;
            if (obj != null)
            {
                using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["localhost_Northwind_Connection"].ConnectionString))
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();
                    string query = "select d.OrderId, p.ProductName, d.Quantity, d.Discount, d.UnitPrice" + " from dbo.[Order Details] d inner join Products p on p.ProductID = d.ProductID" + $" where d.OrderID = '{obj.OrderID}'";
                    List<OrderDetail> list = db.Query<OrderDetail>(query, commandType: CommandType.Text).ToList();
                    using (PrntForm frm = new PrntForm())
                    {
                        frm.PrintInvoice(obj, list);
                        frm.ShowDialog();
                    }

                }
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["localhost_Northwind_Connection"].ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                string query = "select o.OrderID, c.CustomerID, c.ContactName, c.Address, c.PostalCode, c.City, c.Phone, o.OrderDate " +
                                " from Orders o inner join Customers c on o.CustomerID = c.CustomerID" +
                                $" where o.OrderDate between convert(varchar(25),'{dtFromDate.EditValue}',103) and convert(varchar(25),'{dtTodate.EditValue}',103)";
                ordersBindingSource.DataSource = db.Query<Orders>(query, commandType: CommandType.Text);
            }
        }

        private void gridControl1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
