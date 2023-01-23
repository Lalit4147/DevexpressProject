using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
namespace DevexpressProject
{
    public partial class PrntForm : DevExpress.XtraEditors.XtraForm
    {
        public PrntForm()
        {
            InitializeComponent();
        }
        public void PrintInvoice(Orders order, List<OrderDetail> data)
        {
            XtraReport2 report = new XtraReport2();
            foreach(DevExpress.XtraReports.Parameters.Parameter p in report.Parameters)
                p.Visible = false;
            report.InitData(order.OrderID.ToString(), order.OrderDate, order.ContactName, order.Address, order.PostalCode, order.City, order.Phone, data);
            documentViewer1.DocumentSource = report;
            report.CreateDocument();
                
        }
    }
}